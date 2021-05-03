
namespace WindowsFormsGraph
{
    partial class FormPicture
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
            this.components = new System.ComponentModel.Container();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.sl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munDrawLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.munDrawArc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuErase = new System.Windows.Forms.ToolStripMenuItem();
            this.munOption = new System.Windows.Forms.ToolStripMenuItem();
            this.CanvasDraw = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.statusBar.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl1,
            this.sl2,
            this.sl3});
            this.statusBar.Location = new System.Drawing.Point(0, 457);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(855, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
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
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그리기ToolStripMenuItem,
            this.mnuErase,
            this.munOption});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(139, 70);
            // 
            // 그리기ToolStripMenuItem
            // 
            this.그리기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munDrawLine,
            this.mnuDrawCircle,
            this.munDrawArc});
            this.그리기ToolStripMenuItem.Name = "그리기ToolStripMenuItem";
            this.그리기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.그리기ToolStripMenuItem.Text = "그리기";
            // 
            // munDrawLine
            // 
            this.munDrawLine.Name = "munDrawLine";
            this.munDrawLine.Size = new System.Drawing.Size(180, 22);
            this.munDrawLine.Text = "선 그리기";
            this.munDrawLine.Click += new System.EventHandler(this.mnuDrawLine_Click);
            // 
            // mnuDrawCircle
            // 
            this.mnuDrawCircle.Name = "mnuDrawCircle";
            this.mnuDrawCircle.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawCircle.Text = "원 그리기";
            this.mnuDrawCircle.Click += new System.EventHandler(this.mnuDrawCircle_Click);
            // 
            // munDrawArc
            // 
            this.munDrawArc.Enabled = false;
            this.munDrawArc.Name = "munDrawArc";
            this.munDrawArc.Size = new System.Drawing.Size(180, 22);
            this.munDrawArc.Text = "호 그리기";
            this.munDrawArc.Click += new System.EventHandler(this.mnuDrawArc_Click);
            // 
            // mnuErase
            // 
            this.mnuErase.Name = "mnuErase";
            this.mnuErase.Size = new System.Drawing.Size(180, 22);
            this.mnuErase.Text = "모두 지우기";
            this.mnuErase.Click += new System.EventHandler(this.mnuErase_Click);
            // 
            // munOption
            // 
            this.munOption.Name = "munOption";
            this.munOption.Size = new System.Drawing.Size(180, 22);
            this.munOption.Text = "설정";
            this.munOption.Click += new System.EventHandler(this.munOption_Click);
            // 
            // CanvasDraw
            // 
            this.CanvasDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasDraw.ContextMenuStrip = this.contextMenu;
            this.CanvasDraw.Location = new System.Drawing.Point(0, 1);
            this.CanvasDraw.Name = "CanvasDraw";
            this.CanvasDraw.Size = new System.Drawing.Size(855, 453);
            this.CanvasDraw.TabIndex = 3;
            this.CanvasDraw.TabStop = false;
            this.CanvasDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.CanvasDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasDraw_MouseMove);
            this.CanvasDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasDraw_MouseUp);
            this.CanvasDraw.Resize += new System.EventHandler(this.CanvasDraw_Resize);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // FormPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 479);
            this.Controls.Add(this.CanvasDraw);
            this.Controls.Add(this.statusBar);
            this.Name = "FormPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "그림판";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CanvasDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel sl1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.PictureBox CanvasDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuErase;
        private System.Windows.Forms.ToolStripMenuItem munOption;
        private System.Windows.Forms.ToolStripStatusLabel sl2;
        private System.Windows.Forms.ToolStripMenuItem 그리기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munDrawLine;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawCircle;
        private System.Windows.Forms.ToolStripMenuItem munDrawArc;
        private System.Windows.Forms.ToolStripStatusLabel sl3;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

