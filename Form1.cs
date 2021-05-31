using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxSetup();
        }

        private String fileName;
        private String filePath;

        private void textBoxSetup()
        {
            textBox1.Location = new Point(0, 31);
            textBox1.Size = new Size(this.Size.Width-15, this.Size.Height-78);
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
                        fileStream.Close();
                    }
                }
            }
            else if (e.ClickedItem==저장StoolStripMenuItem || e.ClickedItem==다른이름으로저장AtoolStripMenuItem)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (filePath != null)
                {
                    saveFileDialog.InitialDirectory = filePath;
                }
                else
                {
                    saveFileDialog.InitialDirectory = @"C:\";
                }
                saveFileDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (e.ClickedItem == 저장StoolStripMenuItem)
                {
                    saveFileDialog.FileName = fileName;
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sr = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8);
                    if (sr != null)
                    {
                        // Code to write the stream goes here.
                        try
                        {
                            //File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                            sr.WriteLine(textBox1.Text);
                        }
                        catch
                        {
                            MessageBox.Show("cannot write");
                        }
                        finally
                        {
                            sr.Close();
                        }
                    }
                }
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

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
