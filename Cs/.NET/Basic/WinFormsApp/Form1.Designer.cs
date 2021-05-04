
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.btnfileopen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnfilesave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFIle = new System.Windows.Forms.ToolStripMenuItem();
            this.munNew = new System.Windows.Forms.ToolStripMenuItem();
            this.munOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.munEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.munView = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCall = new System.Windows.Forms.Button();
            this.tbf2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("양재소슬체S", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(86, 291);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(183, 30);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "OFF";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tbMemo
            // 
            this.tbMemo.AcceptsReturn = true;
            this.tbMemo.AcceptsTab = true;
            this.tbMemo.Font = new System.Drawing.Font("한컴 윤체 L", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMemo.Location = new System.Drawing.Point(16, 22);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMemo.Size = new System.Drawing.Size(313, 260);
            this.tbMemo.TabIndex = 4;
            // 
            // btnfileopen
            // 
            this.btnfileopen.Font = new System.Drawing.Font("양재소슬체S", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnfileopen.Location = new System.Drawing.Point(86, 327);
            this.btnfileopen.Name = "btnfileopen";
            this.btnfileopen.Size = new System.Drawing.Size(183, 34);
            this.btnfileopen.TabIndex = 5;
            this.btnfileopen.Text = "FILE OPEN";
            this.btnfileopen.UseVisualStyleBackColor = true;
            this.btnfileopen.Click += new System.EventHandler(this.btnfopen_Click);
            // 
            // btnfilesave
            // 
            this.btnfilesave.Font = new System.Drawing.Font("양재소슬체S", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnfilesave.Location = new System.Drawing.Point(86, 367);
            this.btnfilesave.Name = "btnfilesave";
            this.btnfilesave.Size = new System.Drawing.Size(183, 31);
            this.btnfilesave.TabIndex = 6;
            this.btnfilesave.Text = "FILE SAVE";
            this.btnfilesave.UseVisualStyleBackColor = true;
            this.btnfilesave.Click += new System.EventHandler(this.btnfsave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFIle,
            this.munEdit,
            this.munView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFIle
            // 
            this.mnuFIle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munNew,
            this.munOpen,
            this.mnuSave});
            this.mnuFIle.Name = "mnuFIle";
            this.mnuFIle.Size = new System.Drawing.Size(37, 20);
            this.mnuFIle.Text = "File";
            // 
            // munNew
            // 
            this.munNew.Name = "munNew";
            this.munNew.Size = new System.Drawing.Size(120, 22);
            this.munNew.Text = "New";
            // 
            // munOpen
            // 
            this.munOpen.Name = "munOpen";
            this.munOpen.Size = new System.Drawing.Size(120, 22);
            this.munOpen.Text = "Open";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(120, 22);
            this.mnuSave.Text = "Save as..";
            // 
            // munEdit
            // 
            this.munEdit.Name = "munEdit";
            this.munEdit.Size = new System.Drawing.Size(39, 20);
            this.munEdit.Text = "Edit";
            // 
            // munView
            // 
            this.munView.Name = "munView";
            this.munView.Size = new System.Drawing.Size(45, 20);
            this.munView.Text = "View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(175, 44);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(160, 23);
            this.tb1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(175, 73);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(160, 23);
            this.tb2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Etc";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(175, 102);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(160, 23);
            this.tb3.TabIndex = 9;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(26, 68);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(95, 23);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "문자열 변환";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb2);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb3);
            this.groupBox1.Controls.Add(this.tb1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 164);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Controls.Add(this.btnfileopen);
            this.groupBox2.Controls.Add(this.tbMemo);
            this.groupBox2.Controls.Add(this.btnfilesave);
            this.groupBox2.Location = new System.Drawing.Point(443, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 407);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(146, 238);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(112, 47);
            this.btnCall.TabIndex = 13;
            this.btnCall.Text = "CallForm2";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // tbf2
            // 
            this.tbf2.Location = new System.Drawing.Point(12, 303);
            this.tbf2.Multiline = true;
            this.tbf2.Name = "tbf2";
            this.tbf2.ReadOnly = true;
            this.tbf2.Size = new System.Drawing.Size(395, 126);
            this.tbf2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbf2);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnfileopen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnfilesave;
        public System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFIle;
        private System.Windows.Forms.ToolStripMenuItem munNew;
        private System.Windows.Forms.ToolStripMenuItem munOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem munEdit;
        private System.Windows.Forms.ToolStripMenuItem munView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.TextBox tbf2;
    }
}

