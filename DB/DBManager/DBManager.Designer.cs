
namespace DBManager
{
    partial class DBManager
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.slDBOpenStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.slSQLReturn = new System.Windows.Forms.ToolStripStatusLabel();
            this.ddTableList = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileMigration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileOpendb = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAddcol = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAddrow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExecSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExecSelsql = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExecEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.SQLInput = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slDBOpenStatus,
            this.slSQLReturn,
            this.ddTableList});
            this.statusStrip.Location = new System.Drawing.Point(0, 393);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(582, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // slDBOpenStatus
            // 
            this.slDBOpenStatus.Name = "slDBOpenStatus";
            this.slDBOpenStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // slSQLReturn
            // 
            this.slSQLReturn.Name = "slSQLReturn";
            this.slSQLReturn.Size = new System.Drawing.Size(0, 17);
            this.slSQLReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ddTableList
            // 
            this.ddTableList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddTableList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddTableList.Name = "ddTableList";
            this.ddTableList.Size = new System.Drawing.Size(70, 20);
            this.ddTableList.Text = "Table List";
            this.ddTableList.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ddTableList_DropDownItemClicked);
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuExec,
            this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(4, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(353, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileMigration,
            this.toolStripMenuItem1,
            this.mnuFileSaveas,
            this.toolStripMenuItem2,
            this.mnuFileOpendb,
            this.mnuFileClose,
            this.mnuFileUpdate,
            this.toolStripMenuItem4,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Enabled = false;
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(221, 22);
            this.mnuFileNew.Text = "New";
            // 
            // mnuFileMigration
            // 
            this.mnuFileMigration.Name = "mnuFileMigration";
            this.mnuFileMigration.Size = new System.Drawing.Size(221, 22);
            this.mnuFileMigration.Text = "Migration (CSV)";
            this.mnuFileMigration.Click += new System.EventHandler(this.mnuFileMigration_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(218, 6);
            // 
            // mnuFileSaveas
            // 
            this.mnuFileSaveas.Enabled = false;
            this.mnuFileSaveas.Name = "mnuFileSaveas";
            this.mnuFileSaveas.Size = new System.Drawing.Size(221, 22);
            this.mnuFileSaveas.Text = "Savs as...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(218, 6);
            // 
            // mnuFileOpendb
            // 
            this.mnuFileOpendb.Name = "mnuFileOpendb";
            this.mnuFileOpendb.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpendb.Size = new System.Drawing.Size(221, 22);
            this.mnuFileOpendb.Text = "Open Database File";
            this.mnuFileOpendb.Click += new System.EventHandler(this.mnuFileOpendb_Click);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFileClose.Size = new System.Drawing.Size(221, 22);
            this.mnuFileClose.Text = "Close Database";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // mnuFileUpdate
            // 
            this.mnuFileUpdate.Name = "mnuFileUpdate";
            this.mnuFileUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuFileUpdate.Size = new System.Drawing.Size(221, 22);
            this.mnuFileUpdate.Text = "Update Database";
            this.mnuFileUpdate.Click += new System.EventHandler(this.mnuFileUpdate_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(218, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Enabled = false;
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(221, 22);
            this.mnuFileExit.Text = "Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditAddcol,
            this.mnuEditAddrow,
            this.mnuEditNew});
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
            // mnuEditNew
            // 
            this.mnuEditNew.Name = "mnuEditNew";
            this.mnuEditNew.Size = new System.Drawing.Size(180, 22);
            this.mnuEditNew.Text = "Add New Table";
            this.mnuEditNew.Click += new System.EventHandler(this.mnuEditNew_Click);
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
            this.mnuExecSQL,
            this.mnuExecSelsql,
            this.mnuExecEnter,
            this.toolStripMenuItem3});
            this.mnuExec.Name = "mnuExec";
            this.mnuExec.Size = new System.Drawing.Size(60, 20);
            this.mnuExec.Text = "Execute";
            // 
            // mnuExecSQL
            // 
            this.mnuExecSQL.Name = "mnuExecSQL";
            this.mnuExecSQL.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuExecSQL.Size = new System.Drawing.Size(210, 22);
            this.mnuExecSQL.Text = "Execute SQL";
            this.mnuExecSQL.Click += new System.EventHandler(this.mnuExecSql_Click);
            // 
            // mnuExecSelsql
            // 
            this.mnuExecSelsql.Name = "mnuExecSelsql";
            this.mnuExecSelsql.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuExecSelsql.Size = new System.Drawing.Size(210, 22);
            this.mnuExecSelsql.Text = "Execute Selected SQL";
            this.mnuExecSelsql.Click += new System.EventHandler(this.mnuExecSelsql_Click);
            // 
            // mnuExecEnter
            // 
            this.mnuExecEnter.Name = "mnuExecEnter";
            this.mnuExecEnter.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.mnuExecEnter.Size = new System.Drawing.Size(210, 22);
            this.mnuExecEnter.Text = "Execute For [Enter]";
            this.mnuExecEnter.Click += new System.EventHandler(this.mnuExecEnter_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(207, 6);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, -1);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGrid.RowTemplate.Height = 23;
            this.DataGrid.Size = new System.Drawing.Size(558, 267);
            this.DataGrid.TabIndex = 2;
            this.DataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGrid_CellBeginEdit);
            // 
            // SQLInput
            // 
            this.SQLInput.AcceptsReturn = true;
            this.SQLInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLInput.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLInput.Location = new System.Drawing.Point(12, 2);
            this.SQLInput.Multiline = true;
            this.SQLInput.Name = "SQLInput";
            this.SQLInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SQLInput.Size = new System.Drawing.Size(558, 87);
            this.SQLInput.TabIndex = 3;
            this.SQLInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SQLInput_KeyDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.ValidateNames = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SQLInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(582, 363);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 4;
            // 
            // DBManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 415);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DBManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Manager";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.TextBox SQLInput;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileMigration;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveas;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpendb;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripStatusLabel slDBOpenStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel slSQLReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuFileUpdate;
        private System.Windows.Forms.ToolStripDropDownButton ddTableList;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAddcol;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAddrow;
        private System.Windows.Forms.ToolStripMenuItem mnuExec;
        private System.Windows.Forms.ToolStripMenuItem mnuExecSQL;
        private System.Windows.Forms.ToolStripMenuItem mnuExecSelsql;
        private System.Windows.Forms.ToolStripMenuItem mnuExecEnter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuEditNew;
    }
}

