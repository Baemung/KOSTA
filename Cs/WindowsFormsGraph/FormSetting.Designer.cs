
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
            this.tbC = new System.Windows.Forms.ComboBox();
            this.btnOption = new System.Windows.Forms.Button();
            this.formPictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formPictureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbT
            // 
            this.tbT.Location = new System.Drawing.Point(122, 78);
            this.tbT.Name = "tbT";
            this.tbT.Size = new System.Drawing.Size(100, 21);
            this.tbT.TabIndex = 0;
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Location = new System.Drawing.Point(47, 83);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(64, 12);
            this.lbT.TabIndex = 1;
            this.lbT.Text = "Thickness";
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(122, 122);
            this.tbW.Name = "tbW";
            this.tbW.Size = new System.Drawing.Size(100, 21);
            this.tbW.TabIndex = 0;
            // 
            // lbW
            // 
            this.lbW.AutoSize = true;
            this.lbW.Location = new System.Drawing.Point(44, 128);
            this.lbW.Name = "lbW";
            this.lbW.Size = new System.Drawing.Size(72, 12);
            this.lbW.TabIndex = 1;
            this.lbW.Text = "Circle Width";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(122, 168);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(100, 21);
            this.tbH.TabIndex = 0;
            // 
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Location = new System.Drawing.Point(36, 173);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(77, 12);
            this.lbH.TabIndex = 1;
            this.lbH.Text = "Circle Height";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(60, 35);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(35, 12);
            this.lbC.TabIndex = 1;
            this.lbC.Text = "Color";
            // 
            // tbC
            // 
            this.tbC.FormattingEnabled = true;
            this.tbC.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Green",
            "Blue"});
            this.tbC.Location = new System.Drawing.Point(122, 31);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 20);
            this.tbC.TabIndex = 2;
            // 
            // btnOption
            // 
            this.btnOption.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOption.Location = new System.Drawing.Point(107, 215);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(75, 23);
            this.btnOption.TabIndex = 3;
            this.btnOption.Text = "확인";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // formPictureBindingSource
            // 
            this.formPictureBindingSource.DataSource = typeof(WindowsFormsGraph.FormPicture);
            // 
            // FormSetting
            // 
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.lbH);
            this.Controls.Add(this.lbW);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbT);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbW);
            this.Controls.Add(this.tbT);
            this.Name = "FormSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "설정";
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
        private System.Windows.Forms.ComboBox tbC;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.BindingSource formPictureBindingSource;
    }
}