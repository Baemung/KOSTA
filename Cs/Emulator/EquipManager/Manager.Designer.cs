
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpEq = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.gbEquipment = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tpEnv = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.lbServerTCPPort = new System.Windows.Forms.Label();
            this.tbMonitor = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuServer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServerStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServerStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuServerExit = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpEq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tpEnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(784, 509);
            this.tabControl.TabIndex = 0;
            // 
            // tpEq
            // 
            this.tpEq.Controls.Add(this.splitContainer1);
            this.tpEq.Location = new System.Drawing.Point(4, 22);
            this.tpEq.Name = "tpEq";
            this.tpEq.Padding = new System.Windows.Forms.Padding(3);
            this.tpEq.Size = new System.Drawing.Size(776, 483);
            this.tpEq.TabIndex = 0;
            this.tpEq.Text = "Equipment";
            this.tpEq.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbStatus);
            this.splitContainer1.Panel1.Controls.Add(this.gbEquipment);
            this.splitContainer1.Panel1.Controls.Add(this.btnRef);
            this.splitContainer1.Panel1.Controls.Add(this.btnRegister);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(770, 477);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.label16);
            this.gbStatus.Controls.Add(this.label14);
            this.gbStatus.Controls.Add(this.label12);
            this.gbStatus.Controls.Add(this.label10);
            this.gbStatus.Controls.Add(this.label8);
            this.gbStatus.Controls.Add(this.label15);
            this.gbStatus.Controls.Add(this.label13);
            this.gbStatus.Controls.Add(this.label11);
            this.gbStatus.Controls.Add(this.label9);
            this.gbStatus.Controls.Add(this.label7);
            this.gbStatus.Controls.Add(this.textBox15);
            this.gbStatus.Controls.Add(this.textBox11);
            this.gbStatus.Controls.Add(this.textBox14);
            this.gbStatus.Controls.Add(this.textBox10);
            this.gbStatus.Controls.Add(this.textBox13);
            this.gbStatus.Controls.Add(this.textBox12);
            this.gbStatus.Controls.Add(this.textBox5);
            this.gbStatus.Controls.Add(this.textBox4);
            this.gbStatus.Controls.Add(this.textBox6);
            this.gbStatus.Controls.Add(this.textBox7);
            this.gbStatus.Location = new System.Drawing.Point(20, 122);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(609, 121);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status Info";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(54, 76);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(67, 21);
            this.textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(54, 32);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(67, 21);
            this.textBox7.TabIndex = 1;
            // 
            // gbEquipment
            // 
            this.gbEquipment.Controls.Add(this.checkBox4);
            this.gbEquipment.Controls.Add(this.checkBox6);
            this.gbEquipment.Controls.Add(this.checkBox2);
            this.gbEquipment.Controls.Add(this.checkBox3);
            this.gbEquipment.Controls.Add(this.checkBox5);
            this.gbEquipment.Controls.Add(this.checkBox1);
            this.gbEquipment.Controls.Add(this.label6);
            this.gbEquipment.Controls.Add(this.label4);
            this.gbEquipment.Controls.Add(this.label5);
            this.gbEquipment.Controls.Add(this.label3);
            this.gbEquipment.Controls.Add(this.label2);
            this.gbEquipment.Controls.Add(this.label1);
            this.gbEquipment.Controls.Add(this.textBox3);
            this.gbEquipment.Controls.Add(this.textBox9);
            this.gbEquipment.Controls.Add(this.textBox2);
            this.gbEquipment.Controls.Add(this.textBox8);
            this.gbEquipment.Controls.Add(this.textBox1);
            this.gbEquipment.Controls.Add(this.tbCode);
            this.gbEquipment.Location = new System.Drawing.Point(20, 12);
            this.gbEquipment.Name = "gbEquipment";
            this.gbEquipment.Size = new System.Drawing.Size(609, 104);
            this.gbEquipment.TabIndex = 2;
            this.gbEquipment.TabStop = false;
            this.gbEquipment.Text = "Equipment Info";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(376, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 21);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 65);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(54, 29);
            this.tbCode.MaxLength = 5;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(67, 21);
            this.tbCode.TabIndex = 1;
            this.tbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(650, 161);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(100, 52);
            this.btnRef.TabIndex = 0;
            this.btnRef.Text = "장비 조회";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(650, 46);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 52);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "장비 등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(770, 222);
            this.dataGrid.TabIndex = 0;
            // 
            // tpEnv
            // 
            this.tpEnv.BackColor = System.Drawing.Color.Gainsboro;
            this.tpEnv.Controls.Add(this.splitContainer);
            this.tpEnv.Location = new System.Drawing.Point(4, 22);
            this.tpEnv.Name = "tpEnv";
            this.tpEnv.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnv.Size = new System.Drawing.Size(776, 483);
            this.tpEnv.TabIndex = 1;
            this.tpEnv.Text = "Enviroment";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.label18);
            this.splitContainer.Panel1.Controls.Add(this.label17);
            this.splitContainer.Panel1.Controls.Add(this.tbInterval);
            this.splitContainer.Panel1.Controls.Add(this.tbServerPort);
            this.splitContainer.Panel1.Controls.Add(this.lbServerTCPPort);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tbMonitor);
            this.splitContainer.Size = new System.Drawing.Size(770, 477);
            this.splitContainer.SplitterDistance = 294;
            this.splitContainer.TabIndex = 0;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(121, 10);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(100, 21);
            this.tbServerPort.TabIndex = 1;
            this.tbServerPort.Text = "9001";
            this.tbServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tbMonitor
            // 
            this.tbMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMonitor.Location = new System.Drawing.Point(3, 3);
            this.tbMonitor.Multiline = true;
            this.tbMonitor.Name = "tbMonitor";
            this.tbMonitor.Size = new System.Drawing.Size(469, 471);
            this.tbMonitor.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuServer});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
            this.mnuServerStart.Size = new System.Drawing.Size(99, 22);
            this.mnuServerStart.Text = "Start";
            this.mnuServerStart.Click += new System.EventHandler(this.mnuServerStart_Click);
            // 
            // mnuServerStop
            // 
            this.mnuServerStop.Name = "mnuServerStop";
            this.mnuServerStop.Size = new System.Drawing.Size(99, 22);
            this.mnuServerStop.Text = "Stop";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 6);
            // 
            // mnuServerExit
            // 
            this.mnuServerExit.Name = "mnuServerExit";
            this.mnuServerExit.Size = new System.Drawing.Size(99, 22);
            this.mnuServerExit.Text = "Exit";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(221, 65);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(134, 21);
            this.textBox8.TabIndex = 1;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(461, 65);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(117, 21);
            this.textBox9.TabIndex = 1;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Location1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Location2";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(169, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 21);
            this.textBox4.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(169, 76);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(67, 21);
            this.textBox10.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(293, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 21);
            this.textBox5.TabIndex = 1;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(293, 76);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(67, 21);
            this.textBox11.TabIndex = 1;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(416, 32);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(67, 21);
            this.textBox12.TabIndex = 1;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(534, 32);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(67, 21);
            this.textBox13.TabIndex = 1;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(416, 76);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(67, 21);
            this.textBox14.TabIndex = 1;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(534, 76);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(67, 21);
            this.textBox15.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Line";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Temp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "Hum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "State";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "Wind";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(371, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "Count";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ozon";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(492, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(503, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "Air";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(126, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(125, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(264, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(359, 68);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(581, 33);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(580, 71);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(121, 38);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(100, 21);
            this.tbInterval.TabIndex = 2;
            this.tbInterval.Text = "5";
            this.tbInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "Interval";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(226, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "초";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.tpEq.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbEquipment.ResumeLayout(false);
            this.gbEquipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tpEnv.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox gbEquipment;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbInterval;
    }
}

