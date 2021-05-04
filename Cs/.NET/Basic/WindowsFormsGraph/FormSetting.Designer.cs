
namespace WindowsFormsGraph
{
    partial class FormSetting
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbT = new System.Windows.Forms.TextBox();
            this.lbT = new System.Windows.Forms.Label();
            this.tbW = new System.Windows.Forms.TextBox();
            this.lbW = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TextBox();
            this.lbH = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.formPictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formPictureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbT
            // 
            this.tbT.Location = new System.Drawing.Point(122, 67);
            this.tbT.Name = "tbT";
            this.tbT.Size = new System.Drawing.Size(100, 21);
            this.tbT.TabIndex = 0;
            this.tbT.Text = "2";
            this.tbT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Location = new System.Drawing.Point(47, 70);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(64, 12);
            this.lbT.TabIndex = 1;
            this.lbT.Text = "Thickness";
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(100, 25);
            this.tbW.Name = "tbW";
            this.tbW.Size = new System.Drawing.Size(100, 21);
            this.tbW.TabIndex = 0;
            this.tbW.Text = "100";
            this.tbW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbW
            // 
            this.lbW.AutoSize = true;
            this.lbW.Location = new System.Drawing.Point(48, 31);
            this.lbW.Name = "lbW";
            this.lbW.Size = new System.Drawing.Size(35, 12);
            this.lbW.TabIndex = 1;
            this.lbW.Text = "Width";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(100, 59);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(100, 21);
            this.tbH.TabIndex = 0;
            this.tbH.Text = "100";
            this.tbH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Location = new System.Drawing.Point(43, 63);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(40, 12);
            this.lbH.TabIndex = 1;
            this.lbH.Text = "Height";
            this.lbH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(69, 30);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(35, 12);
            this.lbC.TabIndex = 1;
            this.lbC.Text = "Color";
            // 
            // btnOption
            // 
            this.btnOption.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOption.Location = new System.Drawing.Point(101, 223);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(75, 23);
            this.btnOption.TabIndex = 3;
            this.btnOption.Text = "확인";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(223, 25);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(24, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbW);
            this.groupBox1.Controls.Add(this.lbW);
            this.groupBox1.Controls.Add(this.lbH);
            this.groupBox1.Controls.Add(this.tbH);
            this.groupBox1.Location = new System.Drawing.Point(22, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circle Option";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(122, 26);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 21);
            this.tbC.TabIndex = 6;
            this.tbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formPictureBindingSource
            // 
            this.formPictureBindingSource.DataSource = typeof(WindowsFormsGraph.FormPicture);
            // 
            // FormSetting
            // 
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbT);
            this.Controls.Add(this.tbT);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "설정";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formPictureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox tbT;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.TextBox tbW;
        private System.Windows.Forms.Label lbW;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label lbH;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.BindingSource formPictureBindingSource;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbC;
    }
}