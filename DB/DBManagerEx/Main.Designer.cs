
namespace DBManagerEx
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileOpendb = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClosedb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileCtable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileUtable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAddcol = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAddrow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditDropt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDropcol = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDelrow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditTname = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCname = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExecRun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExecEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tbSql = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.sl2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuExec,
            this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(774, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSaveas,
            this.toolStripMenuItem1,
            this.mnuFileOpendb,
            this.mnuFileClosedb,
            this.toolStripMenuItem2,
            this.mnuFileCtable,
            this.mnuFileUtable,
            this.toolStripMenuItem3,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "Open (Migration)";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSaveas
            // 
            this.mnuFileSaveas.Name = "mnuFileSaveas";
            this.mnuFileSaveas.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveas.Text = "Save as...";
            this.mnuFileSaveas.Click += new System.EventHandler(this.mnuFileSaveas_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFileOpendb
            // 
            this.mnuFileOpendb.Name = "mnuFileOpendb";
            this.mnuFileOpendb.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpendb.Text = "Open Database";
            this.mnuFileOpendb.Click += new System.EventHandler(this.mnuFileOpendb_Click);
            // 
            // mnuFileClosedb
            // 
            this.mnuFileClosedb.Name = "mnuFileClosedb";
            this.mnuFileClosedb.Size = new System.Drawing.Size(180, 22);
            this.mnuFileClosedb.Text = "Close Database";
            this.mnuFileClosedb.Click += new System.EventHandler(this.mnuFileClosedb_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFileCtable
            // 
            this.mnuFileCtable.Name = "mnuFileCtable";
            this.mnuFileCtable.Size = new System.Drawing.Size(180, 22);
            this.mnuFileCtable.Text = "Create Table";
            this.mnuFileCtable.Click += new System.EventHandler(this.mnuFileCtable_Click);
            // 
            // mnuFileUtable
            // 
            this.mnuFileUtable.Name = "mnuFileUtable";
            this.mnuFileUtable.Size = new System.Drawing.Size(180, 22);
            this.mnuFileUtable.Text = "Update Table";
            this.mnuFileUtable.Click += new System.EventHandler(this.mnuFileUtable_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditAddcol,
            this.mnuEditAddrow,
            this.toolStripMenuItem4,
            this.mnuEditDropt,
            this.mnuEditDropcol,
            this.mnuEditDelrow,
            this.toolStripMenuItem6,
            this.mnuEditTname,
            this.mnuEditCname});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuEditAddcol
            // 
            this.mnuEditAddcol.Name = "mnuEditAddcol";
            this.mnuEditAddcol.Size = new System.Drawing.Size(180, 22);
            this.mnuEditAddcol.Text = "Add Column";
            this.mnuEditAddcol.Click += new System.EventHandler(this.mnuEditAddcol_Click);
            // 
            // mnuEditAddrow
            // 
            this.mnuEditAddrow.Name = "mnuEditAddrow";
            this.mnuEditAddrow.Size = new System.Drawing.Size(180, 22);
            this.mnuEditAddrow.Text = "Add Row";
            this.mnuEditAddrow.Click += new System.EventHandler(this.mnuEditAddrow_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuEditDropt
            // 
            this.mnuEditDropt.Name = "mnuEditDropt";
            this.mnuEditDropt.Size = new System.Drawing.Size(180, 22);
            this.mnuEditDropt.Text = "Drop Table";
            this.mnuEditDropt.Click += new System.EventHandler(this.mnuEditDropt_Click);
            // 
            // mnuEditDropcol
            // 
            this.mnuEditDropcol.Name = "mnuEditDropcol";
            this.mnuEditDropcol.Size = new System.Drawing.Size(180, 22);
            this.mnuEditDropcol.Text = "Drop Column";
            this.mnuEditDropcol.Click += new System.EventHandler(this.mnuEditDropcol_Click);
            // 
            // mnuEditDelrow
            // 
            this.mnuEditDelrow.Name = "mnuEditDelrow";
            this.mnuEditDelrow.Size = new System.Drawing.Size(180, 22);
            this.mnuEditDelrow.Text = "Delete Row";
            this.mnuEditDelrow.Click += new System.EventHandler(this.mnuEditDelrow_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuEditTname
            // 
            this.mnuEditTname.Name = "mnuEditTname";
            this.mnuEditTname.Size = new System.Drawing.Size(180, 22);
            this.mnuEditTname.Text = "Edit Table Name";
            this.mnuEditTname.Click += new System.EventHandler(this.mnuEditTname_Click);
            // 
            // mnuEditCname
            // 
            this.mnuEditCname.Name = "mnuEditCname";
            this.mnuEditCname.Size = new System.Drawing.Size(180, 22);
            this.mnuEditCname.Text = "Edit Column Name";
            this.mnuEditCname.Click += new System.EventHandler(this.mnuEditCname_Click);
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(45, 20);
            this.mnuView.Text = "View";
            // 
            // mnuExec
            // 
            this.mnuExec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExecRun,
            this.toolStripMenuItem5,
            this.mnuExecEnter});
            this.mnuExec.Name = "mnuExec";
            this.mnuExec.Size = new System.Drawing.Size(60, 20);
            this.mnuExec.Text = "Execute";
            // 
            // mnuExecRun
            // 
            this.mnuExecRun.Name = "mnuExecRun";
            this.mnuExecRun.Size = new System.Drawing.Size(167, 22);
            this.mnuExecRun.Text = "Run SQL";
            this.mnuExecRun.Click += new System.EventHandler(this.mnuExecRun_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(164, 6);
            // 
            // mnuExecEnter
            // 
            this.mnuExecEnter.Checked = true;
            this.mnuExecEnter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuExecEnter.Name = "mnuExecEnter";
            this.mnuExecEnter.Size = new System.Drawing.Size(167, 22);
            this.mnuExecEnter.Text = "Excute for [Enter]";
            this.mnuExecEnter.Click += new System.EventHandler(this.mnuExecEnter_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl1,
            this.sl2,
            this.sl3});
            this.statusStrip.Location = new System.Drawing.Point(0, 423);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(774, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // sl1
            // 
            this.sl1.Name = "sl1";
            this.sl1.Size = new System.Drawing.Size(0, 17);
            // 
            // sl3
            // 
            this.sl3.Name = "sl3";
            this.sl3.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.ValidateNames = false;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tbSql);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGrid);
            this.splitContainer.Size = new System.Drawing.Size(774, 399);
            this.splitContainer.SplitterDistance = 108;
            this.splitContainer.TabIndex = 2;
            // 
            // tbSql
            // 
            this.tbSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSql.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSql.Location = new System.Drawing.Point(0, 0);
            this.tbSql.Multiline = true;
            this.tbSql.Name = "tbSql";
            this.tbSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSql.Size = new System.Drawing.Size(774, 108);
            this.tbSql.TabIndex = 0;
            this.tbSql.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(0, 1);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(774, 284);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGrid_CellBeginEdit);
            // 
            // sl2
            // 
            this.sl2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sl2.Image = ((System.Drawing.Image)(resources.GetObject("sl2.Image")));
            this.sl2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sl2.Name = "sl2";
            this.sl2.Size = new System.Drawing.Size(13, 20);
            this.sl2.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sl2_DropDownItemClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 445);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Manager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveas;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpendb;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClosedb;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileCtable;
        private System.Windows.Forms.ToolStripMenuItem mnuFileUtable;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAddcol;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAddrow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDropcol;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDelrow;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuExec;
        private System.Windows.Forms.ToolStripMenuItem mnuExecRun;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuExecEnter;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel sl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox tbSql;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolStripStatusLabel sl3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCname;
        private System.Windows.Forms.ToolStripMenuItem mnuEditTname;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDropt;
        private System.Windows.Forms.ToolStripDropDownButton sl2;
    }
}

