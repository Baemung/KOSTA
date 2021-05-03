
namespace DBManager
{
    partial class input
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
            this.lbInput = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(37, 59);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(32, 12);
            this.lbInput.TabIndex = 0;
            this.lbInput.Text = "Input";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(99, 55);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(181, 21);
            this.tbInput.TabIndex = 1;
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 138);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "input";
            this.Load += new System.EventHandler(this.input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox tbInput;
    }
}