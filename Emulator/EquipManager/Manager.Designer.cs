
namespace EquipManager
{
    partial class Manager
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpEq = new System.Windows.Forms.TabPage();
            this.tpEnv = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tbMonitor = new System.Windows.Forms.TextBox();
            this.mnuServer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServerStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServerStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuServerExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lbServerTCPPort = new System.Windows.Forms.Label();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tpEnv.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpEq);
            this.tabControl.Controls.Add(this.tpEnv);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(569, 383);
            this.tabControl.TabIndex = 0;
            // 
            // tpEq
            // 
            this.tpEq.Location = new System.Drawing.Point(4, 22);
            this.tpEq.Name = "tpEq";
            this.tpEq.Padding = new System.Windows.Forms.Padding(3);
            this.tpEq.Size = new System.Drawing.Size(561, 357);
            this.tpEq.TabIndex = 0;
            this.tpEq.Text = "Equipment";
            this.tpEq.UseVisualStyleBackColor = true;
            // 
            // tpEnv
            // 
            this.tpEnv.BackColor = System.Drawing.Color.Gainsboro;
            this.tpEnv.Controls.Add(this.splitContainer);
            this.tpEnv.Location = new System.Drawing.Point(4, 22);
            this.tpEnv.Name = "tpEnv";
            this.tpEnv.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnv.Size = new System.Drawing.Size(561, 357);
            this.tpEnv.TabIndex = 1;
            this.tpEnv.Text = "Enviroment";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(569, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuServer});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tbServerPort);
            this.splitContainer.Panel1.Controls.Add(this.lbServerTCPPort);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tbMonitor);
            this.splitContainer.Size = new System.Drawing.Size(555, 351);
            this.splitContainer.SplitterDistance = 212;
            this.splitContainer.TabIndex = 0;
            // 
            // tbMonitor
            // 
            this.tbMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMonitor.Location = new System.Drawing.Point(3, 3);
            this.tbMonitor.Multiline = true;
            this.tbMonitor.Name = "tbMonitor";
            this.tbMonitor.Size = new System.Drawing.Size(336, 345);
            this.tbMonitor.TabIndex = 0;
            // 
            // mnuServer
            // 
            this.mnuServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuServerStart,
            this.mnuServerStop,
            this.toolStripMenuItem1,
            this.mnuServerExit});
            this.mnuServer.Name = "mnuServer";
            this.mnuServer.Size = new System.Drawing.Size(52, 20);
            this.mnuServer.Text = "Server";
            // 
            // mnuServerStart
            // 
            this.mnuServerStart.Name = "mnuServerStart";
            this.mnuServerStart.Size = new System.Drawing.Size(180, 22);
            this.mnuServerStart.Text = "Start";
            this.mnuServerStart.Click += new System.EventHandler(this.mnuServerStart_Click);
            // 
            // mnuServerStop
            // 
            this.mnuServerStop.Name = "mnuServerStop";
            this.mnuServerStop.Size = new System.Drawing.Size(180, 22);
            this.mnuServerStop.Text = "Stop";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuServerExit
            // 
            this.mnuServerExit.Name = "mnuServerExit";
            this.mnuServerExit.Size = new System.Drawing.Size(180, 22);
            this.mnuServerExit.Text = "Exit";
            // 
            // lbServerTCPPort
            // 
            this.lbServerTCPPort.AutoSize = true;
            this.lbServerTCPPort.Location = new System.Drawing.Point(16, 15);
            this.lbServerTCPPort.Name = "lbServerTCPPort";
            this.lbServerTCPPort.Size = new System.Drawing.Size(96, 12);
            this.lbServerTCPPort.TabIndex = 0;
            this.lbServerTCPPort.Text = "Server TCP Port";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(121, 10);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(74, 21);
            this.tbServerPort.TabIndex = 1;
            this.tbServerPort.Text = "9001";
            this.tbServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 435);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.Load += new System.EventHandler(this.Manager_Load);
            this.tabControl.ResumeLayout(false);
            this.tpEnv.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpEq;
        private System.Windows.Forms.TabPage tpEnv;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox tbMonitor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuServer;
        private System.Windows.Forms.ToolStripMenuItem mnuServerStart;
        private System.Windows.Forms.ToolStripMenuItem mnuServerStop;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuServerExit;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label lbServerTCPPort;
    }
}

