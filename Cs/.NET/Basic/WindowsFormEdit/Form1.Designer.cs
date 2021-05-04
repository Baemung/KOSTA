
namespace WindowsFormEdit
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.munFile = new System.Windows.Forms.ToolStripMenuItem();
            this.munFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.munEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPrev = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditNext = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slFind = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(864, 24);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip1";
            // 
            // munFile
            // 
            this.munFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveas});
            this.munFile.Name = "munFile";
            this.munFile.Size = new System.Drawing.Size(51, 20);
            this.munFile.Text = "File(&F)";
            // 
            // munFileNew
            // 
            this.munFileNew.Name = "munFileNew";
            this.munFileNew.Size = new System.Drawing.Size(136, 22);
            this.munFileNew.Text = "New(&N)";
            this.munFileNew.Click += new System.EventHandler(this.munFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(136, 22);
            this.mnuFileOpen.Text = "Open(&O)";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(136, 22);
            this.mnuFileSave.Text = "Save(&S)";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveas
            // 
            this.mnuFileSaveas.Name = "mnuFileSaveas";
            this.mnuFileSaveas.Size = new System.Drawing.Size(136, 22);
            this.mnuFileSaveas.Text = "Save as..(&A)";
            this.mnuFileSaveas.Click += new System.EventHandler(this.mnuFileSaveas_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munEditFind,
            this.mnuEditPrev,
            this.mnuEditNext,
            this.mnuEditReplace});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.ShortcutKeyDisplayString = "[Ctrl + F]";
            this.mnuEdit.Size = new System.Drawing.Size(53, 20);
            this.mnuEdit.Text = "Edit(&E)";
            // 
            // munEditFind
            // 
            this.munEditFind.Name = "munEditFind";
            this.munEditFind.ShortcutKeyDisplayString = "";
            this.munEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.munEditFind.Size = new System.Drawing.Size(180, 22);
            this.munEditFind.Text = "Find(&F)";
            this.munEditFind.ToolTipText = "현재의 문서에서 특정한 문자열을 찾습니다.";
            this.munEditFind.Click += new System.EventHandler(this.munEditFind_Click);
            // 
            // mnuEditPrev
            // 
            this.mnuEditPrev.Name = "mnuEditPrev";
            this.mnuEditPrev.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuEditPrev.Size = new System.Drawing.Size(180, 22);
            this.mnuEditPrev.Text = "Prev(&P)";
            this.mnuEditPrev.Click += new System.EventHandler(this.mnuEditPrev_Click);
            // 
            // mnuEditNext
            // 
            this.mnuEditNext.Name = "mnuEditNext";
            this.mnuEditNext.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuEditNext.Size = new System.Drawing.Size(180, 22);
            this.mnuEditNext.Text = "Next(&N)";
            this.mnuEditNext.Click += new System.EventHandler(this.mnuEditNext_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewFont});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(61, 20);
            this.mnuView.Text = "View(&V)";
            // 
            // mnuViewFont
            // 
            this.mnuViewFont.Name = "mnuViewFont";
            this.mnuViewFont.Size = new System.Drawing.Size(112, 22);
            this.mnuViewFont.Text = "Font(&F)";
            this.mnuViewFont.Click += new System.EventHandler(this.mnuViewFont_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(61, 20);
            this.mnuHelp.Text = "Help(&H)";
            // 
            // tbMemo
            // 
            this.tbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMemo.Font = new System.Drawing.Font("한컴 윤고딕 230", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbMemo.Location = new System.Drawing.Point(0, 27);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMemo.Size = new System.Drawing.Size(864, 466);
            this.tbMemo.TabIndex = 4;
            this.tbMemo.WordWrap = false;
            this.tbMemo.TextChanged += new System.EventHandler(this.tbMemo_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl1,
            this.sl2,
            this.sl3,
            this.slFind});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sl1
            // 
            this.sl1.Name = "sl1";
            this.sl1.Size = new System.Drawing.Size(0, 17);
            // 
            // sl2
            // 
            this.sl2.Name = "sl2";
            this.sl2.Size = new System.Drawing.Size(0, 17);
            // 
            // sl3
            // 
            this.sl3.Name = "sl3";
            this.sl3.Size = new System.Drawing.Size(0, 17);
            // 
            // slFind
            // 
            this.slFind.Name = "slFind";
            this.slFind.Size = new System.Drawing.Size(0, 17);
            // 
            // mnuEditReplace
            // 
            this.mnuEditReplace.Name = "mnuEditReplace";
            this.mnuEditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuEditReplace.Size = new System.Drawing.Size(180, 22);
            this.mnuEditReplace.Text = "Replace(&R)";
            this.mnuEditReplace.Click += new System.EventHandler(this.mnuEditReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem munFile;
        private System.Windows.Forms.ToolStripMenuItem munFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveas;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuViewFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sl1;
        private System.Windows.Forms.ToolStripStatusLabel sl2;
        private System.Windows.Forms.ToolStripStatusLabel sl3;
        private System.Windows.Forms.ToolStripMenuItem munEditFind;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPrev;
        private System.Windows.Forms.ToolStripMenuItem mnuEditNext;
        private System.Windows.Forms.ToolStripStatusLabel slFind;
        private System.Windows.Forms.ToolStripMenuItem mnuEditReplace;
    }
}

