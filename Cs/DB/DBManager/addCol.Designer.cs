
namespace DBManager
{
    partial class addCol
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
            this.tbCN = new System.Windows.Forms.TextBox();
            this.lbCN = new System.Windows.Forms.Label();
            this.lbDT = new System.Windows.Forms.Label();
            this.btnAddcol = new System.Windows.Forms.Button();
            this.cbDT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCN
            // 
            this.tbCN.Location = new System.Drawing.Point(139, 36);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(163, 21);
            this.tbCN.TabIndex = 0;
            this.tbCN.TextChanged += new System.EventHandler(this.tbCN_TextChanged);
            // 
            // lbCN
            // 
            this.lbCN.AutoSize = true;
            this.lbCN.Location = new System.Drawing.Point(30, 39);
            this.lbCN.Name = "lbCN";
            this.lbCN.Size = new System.Drawing.Size(87, 12);
            this.lbCN.TabIndex = 1;
            this.lbCN.Text = "Column Name";
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Location = new System.Drawing.Point(48, 77);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(63, 12);
            this.lbDT.TabIndex = 1;
            this.lbDT.Text = "Data Type";
            // 
            // btnAddcol
            // 
            this.btnAddcol.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddcol.Enabled = false;
            this.btnAddcol.Location = new System.Drawing.Point(132, 118);
            this.btnAddcol.Name = "btnAddcol";
            this.btnAddcol.Size = new System.Drawing.Size(75, 23);
            this.btnAddcol.TabIndex = 2;
            this.btnAddcol.Text = "OK";
            this.btnAddcol.UseVisualStyleBackColor = true;
            this.btnAddcol.Click += new System.EventHandler(this.btnAddcol_Click);
            // 
            // cbDT
            // 
            this.cbDT.FormattingEnabled = true;
            this.cbDT.Items.AddRange(new object[] {
            "int",
            "varchar(20)"});
            this.cbDT.Location = new System.Drawing.Point(139, 75);
            this.cbDT.Name = "cbDT";
            this.cbDT.Size = new System.Drawing.Size(163, 20);
            this.cbDT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // addCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 167);
            this.Controls.Add(this.cbDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddcol);
            this.Controls.Add(this.lbDT);
            this.Controls.Add(this.lbCN);
            this.Controls.Add(this.tbCN);
            this.Name = "addCol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Column";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCN;
        private System.Windows.Forms.Label lbCN;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.Button btnAddcol;
        private System.Windows.Forms.ComboBox cbDT;
        private System.Windows.Forms.Label label1;
    }
}