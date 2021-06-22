
namespace DarkNotepad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일FtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일FcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.새로만들기NtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창WtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장StoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장AtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기XtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.실행취소UtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.찾기FtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바꾸기RtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.서식OtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식OcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.글꼴FtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.상태표시줄StoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배경색BtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글씨색FtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.초기화RtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.fontColorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.파일FcontextMenuStrip.SuspendLayout();
            this.편집EcontextMenuStrip.SuspendLayout();
            this.서식OcontextMenuStrip.SuspendLayout();
            this.보기VcontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FtoolStripMenuItem,
            this.편집EtoolStripMenuItem,
            this.서식OtoolStripMenuItem,
            this.보기VtoolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(633, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.UseWaitCursor = true;
            // 
            // 파일FtoolStripMenuItem
            // 
            this.파일FtoolStripMenuItem.DropDown = this.파일FcontextMenuStrip;
            this.파일FtoolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.파일FtoolStripMenuItem.Name = "파일FtoolStripMenuItem";
            this.파일FtoolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.파일FtoolStripMenuItem.Text = "파일(&F)";
            // 
            // 파일FcontextMenuStrip
            // 
            this.파일FcontextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.파일FcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NtoolStripMenuItem,
            this.새창WtoolStripMenuItem,
            this.열기OtoolStripMenuItem,
            this.저장StoolStripMenuItem,
            this.다른이름으로저장AtoolStripMenuItem,
            this.끝내기XtoolStripMenuItem});
            this.파일FcontextMenuStrip.Name = "contextMenuStrip1";
            this.파일FcontextMenuStrip.OwnerItem = this.파일FtoolStripMenuItem;
            this.파일FcontextMenuStrip.Size = new System.Drawing.Size(250, 172);
            this.파일FcontextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.파일FcontextMenuStrip_ItemClicked);
            // 
            // 새로만들기NtoolStripMenuItem
            // 
            this.새로만들기NtoolStripMenuItem.Name = "새로만들기NtoolStripMenuItem";
            this.새로만들기NtoolStripMenuItem.ShortcutKeyDisplayString = "";
            this.새로만들기NtoolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.새로만들기NtoolStripMenuItem.Text = "새로 만들기(&N)";
            // 
            // 새창WtoolStripMenuItem
            // 
            this.새창WtoolStripMenuItem.Name = "새창WtoolStripMenuItem";
            this.새창WtoolStripMenuItem.ShortcutKeyDisplayString = "";
            this.새창WtoolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.새창WtoolStripMenuItem.Text = "새 창(&W)";
            // 
            // 열기OtoolStripMenuItem
            // 
            this.열기OtoolStripMenuItem.Name = "열기OtoolStripMenuItem";
            this.열기OtoolStripMenuItem.ShortcutKeyDisplayString = "";
            this.열기OtoolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.열기OtoolStripMenuItem.Text = "열기(&O)";
            // 
            // 저장StoolStripMenuItem
            // 
            this.저장StoolStripMenuItem.Enabled = false;
            this.저장StoolStripMenuItem.Name = "저장StoolStripMenuItem";
            this.저장StoolStripMenuItem.ShortcutKeyDisplayString = "";
            this.저장StoolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.저장StoolStripMenuItem.Text = "저장(&S)";
            // 
            // 다른이름으로저장AtoolStripMenuItem
            // 
            this.다른이름으로저장AtoolStripMenuItem.Name = "다른이름으로저장AtoolStripMenuItem";
            this.다른이름으로저장AtoolStripMenuItem.ShortcutKeyDisplayString = "";
            this.다른이름으로저장AtoolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.다른이름으로저장AtoolStripMenuItem.Text = "다른 이름으로 저장(&A)";
            // 
            // 끝내기XtoolStripMenuItem
            // 
            this.끝내기XtoolStripMenuItem.Name = "끝내기XtoolStripMenuItem";
            this.끝내기XtoolStripMenuItem.ShortcutKeyDisplayString = "";
            this.끝내기XtoolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.끝내기XtoolStripMenuItem.Text = "끝내기(&X)";
            // 
            // 편집EtoolStripMenuItem
            // 
            this.편집EtoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.편집EtoolStripMenuItem.DropDown = this.편집EcontextMenuStrip;
            this.편집EtoolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.편집EtoolStripMenuItem.Name = "편집EtoolStripMenuItem";
            this.편집EtoolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.편집EtoolStripMenuItem.Text = "편집(&E)";
            // 
            // 편집EcontextMenuStrip
            // 
            this.편집EcontextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.편집EcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UtoolStripMenuItem,
            this.찾기FtoolStripMenuItem,
            this.바꾸기RtoolStripMenuItem1});
            this.편집EcontextMenuStrip.Name = "편집EcontextMenuStrip";
            this.편집EcontextMenuStrip.OwnerItem = this.편집EtoolStripMenuItem;
            this.편집EcontextMenuStrip.Size = new System.Drawing.Size(171, 88);
            this.편집EcontextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.편집EcontextMenuStrip_ItemClicked);
            // 
            // 실행취소UtoolStripMenuItem
            // 
            this.실행취소UtoolStripMenuItem.Enabled = false;
            this.실행취소UtoolStripMenuItem.Name = "실행취소UtoolStripMenuItem";
            this.실행취소UtoolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.실행취소UtoolStripMenuItem.Text = "실행취소(&U)";
            // 
            // 찾기FtoolStripMenuItem
            // 
            this.찾기FtoolStripMenuItem.Name = "찾기FtoolStripMenuItem";
            this.찾기FtoolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.찾기FtoolStripMenuItem.Text = "찾기(&F)";
            // 
            // 바꾸기RtoolStripMenuItem1
            // 
            this.바꾸기RtoolStripMenuItem1.Name = "바꾸기RtoolStripMenuItem1";
            this.바꾸기RtoolStripMenuItem1.Size = new System.Drawing.Size(170, 28);
            this.바꾸기RtoolStripMenuItem1.Text = "바꾸기(&R)";
            // 
            // 서식OtoolStripMenuItem
            // 
            this.서식OtoolStripMenuItem.DropDown = this.서식OcontextMenuStrip;
            this.서식OtoolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.서식OtoolStripMenuItem.Name = "서식OtoolStripMenuItem";
            this.서식OtoolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.서식OtoolStripMenuItem.Text = "서식(&O)";
            // 
            // 서식OcontextMenuStrip
            // 
            this.서식OcontextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.서식OcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴FtoolStripMenuItem});
            this.서식OcontextMenuStrip.Name = "서식OcontextMenuStrip";
            this.서식OcontextMenuStrip.OwnerItem = this.서식OtoolStripMenuItem;
            this.서식OcontextMenuStrip.Size = new System.Drawing.Size(133, 32);
            this.서식OcontextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.서식OcontextMenuStrip_ItemClicked);
            // 
            // 글꼴FtoolStripMenuItem
            // 
            this.글꼴FtoolStripMenuItem.Name = "글꼴FtoolStripMenuItem";
            this.글꼴FtoolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.글꼴FtoolStripMenuItem.Text = "글꼴(&F)";
            // 
            // 보기VtoolStripMenuItem
            // 
            this.보기VtoolStripMenuItem.DropDown = this.보기VcontextMenuStrip;
            this.보기VtoolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.보기VtoolStripMenuItem.Name = "보기VtoolStripMenuItem";
            this.보기VtoolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.보기VtoolStripMenuItem.Text = "보기(&V)";
            // 
            // 보기VcontextMenuStrip
            // 
            this.보기VcontextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.보기VcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상태표시줄StoolStripMenuItem,
            this.배경색BtoolStripMenuItem,
            this.글씨색FtoolStripMenuItem,
            this.초기화RtoolStripMenuItem});
            this.보기VcontextMenuStrip.Name = "보기VcontextMenuStrip";
            this.보기VcontextMenuStrip.OwnerItem = this.보기VtoolStripMenuItem;
            this.보기VcontextMenuStrip.Size = new System.Drawing.Size(191, 116);
            this.보기VcontextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.보기VcontextMenuStrip_ItemClicked);
            // 
            // 상태표시줄StoolStripMenuItem
            // 
            this.상태표시줄StoolStripMenuItem.Name = "상태표시줄StoolStripMenuItem";
            this.상태표시줄StoolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.상태표시줄StoolStripMenuItem.Text = "상태 표시줄(&S)";
            // 
            // 배경색BtoolStripMenuItem
            // 
            this.배경색BtoolStripMenuItem.Name = "배경색BtoolStripMenuItem";
            this.배경색BtoolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.배경색BtoolStripMenuItem.Text = "배경색(&B)";
            // 
            // 글씨색FtoolStripMenuItem
            // 
            this.글씨색FtoolStripMenuItem.Name = "글씨색FtoolStripMenuItem";
            this.글씨색FtoolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.글씨색FtoolStripMenuItem.Text = "글씨색(&F)";
            // 
            // 초기화RtoolStripMenuItem
            // 
            this.초기화RtoolStripMenuItem.Name = "초기화RtoolStripMenuItem";
            this.초기화RtoolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.초기화RtoolStripMenuItem.Text = "초기화(&R)";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.richTextBox1.Location = new System.Drawing.Point(41, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(542, 448);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseWaitCursor = true;
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.파일FcontextMenuStrip.ResumeLayout(false);
            this.편집EcontextMenuStrip.ResumeLayout(false);
            this.서식OcontextMenuStrip.ResumeLayout(false);
            this.보기VcontextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일FtoolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip 파일FcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EtoolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip 편집EcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창WtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장StoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장AtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식OtoolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip 서식OcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 글꼴FtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기VtoolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip 보기VcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄StoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배경색BtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글씨색FtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 찾기FtoolStripMenuItem;
        private System.Windows.Forms.ColorDialog backgroundColorDialog;
        private System.Windows.Forms.ColorDialog fontColorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem 초기화RtoolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 바꾸기RtoolStripMenuItem1;
    }
}

