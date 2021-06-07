using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DarkNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            reset();
            setup();
        }
        public Form1(string[] args) : this()
        {
            if (args.Length > 0)
            {
                quickOpenFile(args[0]);
            }
        }

        private String fileName;
        private String filePath;
        private String fileData;
        private bool opened;

        private void setup()
        {
            richTextBox1.Location = new Point(0, 31);
            richTextBox1.Dock = DockStyle.Top;

            richTextBox1.Width = this.Size.Width - 15;
            richTextBox1.Height = this.Size.Height - 78;
            label1.Width = this.Width;
            if (label1.Visible == true) { richTextBox1.Height -= label1.Height; }
        }

        private void reset()
        {
            this.Text = "Untitled";
            richTextBox1.Text = null;
            fileName = this.Text;
            filePath = null;
            fileData = "";
            opened = false;
        }

        private void quickOpenFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                fileName = path.Split("\\").Last();
                richTextBox1.Text = reader.ReadToEnd();
                richTextBox1.Select(0, 0);
                reader.Close();
                this.Text = fileName;
                opened = true;
                저장StoolStripMenuItem.Enabled = false;
                fileData = richTextBox1.Text;
            }
        }

        private bool openFile()
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
                    richTextBox1.Text = reader.ReadToEnd();
                    reader.Close();
                    fileStream.Close();
                    this.Text = fileName;
                    opened = true;
                    저장StoolStripMenuItem.Enabled = false;
                    fileData = richTextBox1.Text;
                    return true;
                }
            }
            return false;
        }

        private void quickSaveFile()
        {
            if (fileData == richTextBox1.Text) { return; }

            if (opened == false) { saveFile(); }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath + fileName, false, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(richTextBox1.Text);
                    this.Text = fileName;
                    opened = true;
                    저장StoolStripMenuItem.Enabled = false;
                    fileData = richTextBox1.Text;
                    writer.Close();
                }
            }
        }

        private bool saveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.FileName = ".txt";
            if (filePath != null)
            { 
                saveFileDialog.InitialDirectory = filePath;
                saveFileDialog.FileName = fileName;
            }
            saveFileDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(richTextBox1.Text);
                    this.Text = saveFileDialog.FileName.Split("\\").Last();
                    fileName = this.Text;
                    opened = true;
                    저장StoolStripMenuItem.Enabled = false;
                    fileData = richTextBox1.Text;
                    writer.Close();
                    return true;
                }
            }
            return false;
        }

        private void stateUpdate()
        {
            int index = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(index);
            Point pos = richTextBox1.GetPositionFromCharIndex(index);
            pos.X = 0;
            int col = index - richTextBox1.GetCharIndexFromPosition(pos);
            label1.Text = "line: " + line.ToString() + ", col: " + col.ToString();
        }

        private void 파일FcontextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            파일FtoolStripMenuItem.HideDropDown();

            if (e.ClickedItem == 새로만들기NtoolStripMenuItem)
            {
                DialogResult drg = MessageBox.Show("Save modification?", "Notepad",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (drg == DialogResult.Yes)
                {
                    if (saveFile() == true) { reset(); }
                }
                else if (drg == DialogResult.No) { reset(); }
                else { }
            }
            else if (e.ClickedItem == 새창WtoolStripMenuItem) { Process.Start("DarkNotepad.exe"); }
            else if (e.ClickedItem == 열기OtoolStripMenuItem)
            {
                if (fileData != richTextBox1.Text)
                { 
                    DialogResult drg = MessageBox.Show("Save before open?", "Notepad",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                    if (drg == DialogResult.Yes) { quickSaveFile(); }
                    else if (drg == DialogResult.No) { }
                    else { return; }
                }
                openFile();
            }
            else if (e.ClickedItem == 저장StoolStripMenuItem) { quickSaveFile(); }
            else if (e.ClickedItem == 다른이름으로저장AtoolStripMenuItem) { saveFile(); }
            else if (e.ClickedItem == 끝내기XtoolStripMenuItem) { Application.Exit(); }
        }

        private void 보기VcontextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            보기VtoolStripMenuItem.HideDropDown();

            if (e.ClickedItem == 상태표시줄StoolStripMenuItem)
            {
                if (label1.Visible == true)
                {
                    label1.Dock = DockStyle.None;
                    label1.Visible = false;
                    상태표시줄StoolStripMenuItem.Checked = false;
                }
                else
                {
                    label1.Dock = DockStyle.Bottom;
                    label1.Visible = true;
                    상태표시줄StoolStripMenuItem.Checked = true;
                }
                setup();
            }
            else if (e.ClickedItem == 배경색BtoolStripMenuItem)
            {
                if (backgroundColorDialog.ShowDialog() == DialogResult.OK) { richTextBox1.BackColor = backgroundColorDialog.Color; }
            }
            else if (e.ClickedItem == 글씨색FtoolStripMenuItem)
            {
                if (fontColorDialog.ShowDialog() == DialogResult.OK) { richTextBox1.ForeColor = fontColorDialog.Color; }
            }
            else if (e.ClickedItem == 초기화RtoolStripMenuItem)
            {
                richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox1.ForeColor = Color.FromArgb(212, 212, 212);
            }
        }

        private void 서식OcontextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            서식OtoolStripMenuItem.HideDropDown();

            if (e.ClickedItem == 글꼴FtoolStripMenuItem)
            {
                fontDialog.Font = richTextBox1.Font;
                if (fontDialog.ShowDialog() == DialogResult.OK) { richTextBox1.Font = fontDialog.Font;  }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            setup();
            stateUpdate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileData != richTextBox1.Text)
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

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) { quickSaveFile(); }
            else if (e.Control && e.KeyCode == Keys.W) { this.Close(); }
            else if (e.Control && e.KeyCode == Keys.O) { openFile(); }
            else if (e.Control && e.KeyCode == Keys.Oemplus) { richTextBox1.ZoomFactor *= (float)(1.1); }
            else if (e.Control && e.KeyCode == Keys.OemMinus) { richTextBox1.ZoomFactor *= (float)(0.9); }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                // To do
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (fileData != richTextBox1.Text)
            {
                this.Text = "*" + fileName;
                저장StoolStripMenuItem.Enabled = true;
            }
            else
            {
                this.Text = fileName;
                저장StoolStripMenuItem.Enabled = false;
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e) { stateUpdate(); }

    }
}
