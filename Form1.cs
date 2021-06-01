using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DarkNotepad
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();

            this.Text = "Untitled";
            textBoxSetup();

            if (args.Length > 0)
            {
                openFile(args[0]);
            }
        }

        private String fileName;
        private String filePath;
        private bool opened = false;
        private bool modified = false;

        private void textBoxSetup()
        {
            textBox1.Location = new Point(0, 31);
            textBox1.Size = new Size(this.Size.Width - 15, this.Size.Height - 78);
        }

        private void openFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                fileName = path.Split("\\").Last();
                textBox1.Text = reader.ReadToEnd();
                textBox1.Select(0, 0);
                reader.Close();
                this.Text = fileName;
                modified = false;
                opened = true;
            }
        }

        private void quickSaveFile()
        {
            if (opened == false)
            {
                saveFile();
                return;
            }

            using (StreamWriter writer = new StreamWriter(filePath + fileName, false, System.Text.Encoding.UTF8))
            {
                writer.WriteLine(textBox1.Text);
                this.Text = fileName;
                opened = true;
                modified = false;
                저장StoolStripMenuItem.Enabled = false;
                다른이름으로저장AtoolStripMenuItem.Enabled = false;
                writer.Close();
            }
        }

        private void saveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = @"C:\";
            if (filePath != null) { saveFileDialog.InitialDirectory = filePath; }
            saveFileDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = ".txt";
            if (fileName != null) { saveFileDialog.FileName = fileName; }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(textBox1.Text);
                    this.Text = saveFileDialog.FileName.Split("\\").Last();
                    fileName = this.Text;
                    opened = true;
                    modified = false;
                    저장StoolStripMenuItem.Enabled = false;
                    다른이름으로저장AtoolStripMenuItem.Enabled = false;
                    writer.Close();
                }
            }
        }

        private void 파일FcontextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            파일FtoolStripMenuItem.HideDropDown();

            if (e.ClickedItem == 새로만들기NtoolStripMenuItem)
            {

            }
            else if (e.ClickedItem == 새창WtoolStripMenuItem)
            {

            }
            else if (e.ClickedItem == 열기OtoolStripMenuItem)
            {
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;
                openFileDialog.FileName = null;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileName = openFileDialog.FileName.Split("\\").Last();
                        filePath = openFileDialog.FileName.Replace(fileName, "");
                        textBox1.Text = reader.ReadToEnd();
                        reader.Close();
                        fileStream.Close();
                        this.Text = fileName;
                        opened = true;
                        modified = false;
                        저장StoolStripMenuItem.Enabled = false;
                        다른이름으로저장AtoolStripMenuItem.Enabled = false;
                    }
                }
            }
            else if (e.ClickedItem == 저장StoolStripMenuItem)
            {
                quickSaveFile();
            }
            else if (e.ClickedItem == 다른이름으로저장AtoolStripMenuItem)
            {
                saveFile();
            }
            else if (e.ClickedItem == 끝내기XtoolStripMenuItem)
            {
                Application.Exit();
            }
        }

        private void 보기VcontextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            보기VtoolStripMenuItem.HideDropDown();

            if (e.ClickedItem == 상태표시줄StoolStripMenuItem)
            {

            }
            else if (e.ClickedItem == 배경색BtoolStripMenuItem)
            {
                backgroundColorDialog.ShowDialog();
                textBox1.BackColor = backgroundColorDialog.Color;
            }
            else if (e.ClickedItem == 글씨색FtoolStripMenuItem)
            {
                fontColorDialog.ShowDialog();
                textBox1.ForeColor = fontColorDialog.Color;
            }
            else if (e.ClickedItem == 초기화RtoolStripMenuItem)
            {
                textBox1.BackColor = Color.FromArgb(30, 30, 30);
                textBox1.ForeColor = Color.FromArgb(212, 212, 212);
            }
        }

        private void 서식OcontextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            서식OtoolStripMenuItem.HideDropDown();

            if (e.ClickedItem == 글꼴FtoolStripMenuItem)
            {
                fontDialog.ShowDialog();
                textBox1.Font = fontDialog.Font;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            textBoxSetup();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (modified == false)
            {
                this.Text = "*" + this.Text;
                modified = true;
                저장StoolStripMenuItem.Enabled = true;
                다른이름으로저장AtoolStripMenuItem.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modified == true)
            {
                DialogResult drg = MessageBox.Show("Save before exit?", "Notepad",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (drg == DialogResult.Yes) { saveFile(); }
                else if (drg == DialogResult.No) { }
                else { e.Cancel = true; }
            }
        }
    }
}
