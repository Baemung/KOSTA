
namespace WindowsFormEdit
{
    partial class FormReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReplace1 = new System.Windows.Forms.Button();
            this.tbD = new System.Windows.Forms.TextBox();
            this.btnReplaceall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReplace1
            // 
            this.btnReplace1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReplace1.Location = new System.Drawing.Point(277, 19);
            this.btnReplace1.Name = "btnReplace1";
            this.btnReplace1.Size = new System.Drawing.Size(94, 25);
            this.btnReplace1.TabIndex = 4;
            this.btnReplace1.Text = "Replace One";
            this.btnReplace1.UseVisualStyleBackColor = true;
            this.btnReplace1.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(24, 21);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(240, 21);
            this.tbD.TabIndex = 3;
            // 
            // btnReplaceall
            // 
            this.btnReplaceall.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnReplaceall.Location = new System.Drawing.Point(377, 19);
            this.btnReplaceall.Name = "btnReplaceall";
            this.btnReplaceall.Size = new System.Drawing.Size(92, 25);
            this.btnReplaceall.TabIndex = 4;
            this.btnReplaceall.Text = "Replace All";
            this.btnReplaceall.UseVisualStyleBackColor = true;
            this.btnReplaceall.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // FormReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 61);
            this.Controls.Add(this.btnReplaceall);
            this.Controls.Add(this.btnReplace1);
            this.Controls.Add(this.tbD);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplace1;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Button btnReplaceall;
    }
}