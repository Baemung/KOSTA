
namespace vEquip
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sblabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sblabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtStopDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEnvTotal1 = new System.Windows.Forms.Label();
            this.tbEnvOz = new System.Windows.Forms.TextBox();
            this.tbEnvOz1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEnvHum1 = new System.Windows.Forms.Label();
            this.tbEnvTemp = new System.Windows.Forms.TextBox();
            this.tbEnvTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEnvAir = new System.Windows.Forms.TextBox();
            this.tbEnvHum = new System.Windows.Forms.TextBox();
            this.tbEnvAir1 = new System.Windows.Forms.Label();
            this.tbEnvWind = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEqCount = new System.Windows.Forms.TextBox();
            this.tbEqState = new System.Windows.Forms.TextBox();
            this.tbEqBat = new System.Windows.Forms.TextBox();
            this.tbEqLine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEqModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEqCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMonitor = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtStopTime = new System.Windows.Forms.DateTimePicker();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuConfig,
            this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileStart,
            this.mnuFileStop,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileStart
            // 
            this.mnuFileStart.Name = "mnuFileStart";
            this.mnuFileStart.Size = new System.Drawing.Size(180, 22);
            this.mnuFileStart.Text = "Start";
            this.mnuFileStart.Click += new System.EventHandler(this.mnuFileStart_Click);
            // 
            // mnuFileStop
            // 
            this.mnuFileStop.Name = "mnuFileStop";
            this.mnuFileStop.Size = new System.Drawing.Size(180, 22);
            this.mnuFileStop.Text = "Stop";
            this.mnuFileStop.Click += new System.EventHandler(this.mnuFileStop_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(45, 20);
            this.mnuView.Text = "View";
            // 
            // mnuConfig
            // 
            this.mnuConfig.Name = "mnuConfig";
            this.mnuConfig.Size = new System.Drawing.Size(55, 20);
            this.mnuConfig.Text = "Config";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sblabel1,
            this.sblabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // sblabel1
            // 
            this.sblabel1.AutoSize = false;
            this.sblabel1.DoubleClickEnabled = true;
            this.sblabel1.Name = "sblabel1";
            this.sblabel1.Size = new System.Drawing.Size(120, 17);
            this.sblabel1.Text = "127.0.0.1";
            this.sblabel1.Click += new System.EventHandler(this.sblabel1_Click);
            // 
            // sblabel2
            // 
            this.sblabel2.AutoSize = false;
            this.sblabel2.DoubleClickEnabled = true;
            this.sblabel2.Name = "sblabel2";
            this.sblabel2.Size = new System.Drawing.Size(40, 17);
            this.sblabel2.Text = "9000";
            this.sblabel2.Click += new System.EventHandler(this.sblabel2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbMonitor);
            this.splitContainer1.Size = new System.Drawing.Size(684, 415);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtStopTime);
            this.groupBox3.Controls.Add(this.dtStartTime);
            this.groupBox3.Controls.Add(this.dtStopDate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dtStartDate);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbInterval);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(13, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 128);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "가동정보";
            // 
            // dtStopDate
            // 
            this.dtStopDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStopDate.Location = new System.Drawing.Point(79, 64);
            this.dtStopDate.Name = "dtStopDate";
            this.dtStopDate.Size = new System.Drawing.Size(91, 21);
            this.dtStopDate.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "종료시간";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(79, 35);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(91, 21);
            this.dtStartDate.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "시작시간";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(79, 93);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(79, 21);
            this.tbInterval.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(164, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "초";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "시간간격";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEnvTotal1);
            this.groupBox2.Controls.Add(this.tbEnvOz);
            this.groupBox2.Controls.Add(this.tbEnvOz1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbEnvHum1);
            this.groupBox2.Controls.Add(this.tbEnvTemp);
            this.groupBox2.Controls.Add(this.tbEnvTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbEnvAir);
            this.groupBox2.Controls.Add(this.tbEnvHum);
            this.groupBox2.Controls.Add(this.tbEnvAir1);
            this.groupBox2.Controls.Add(this.tbEnvWind);
            this.groupBox2.Location = new System.Drawing.Point(13, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "환경정보";
            // 
            // tbEnvTotal1
            // 
            this.tbEnvTotal1.AutoSize = true;
            this.tbEnvTotal1.Location = new System.Drawing.Point(250, 93);
            this.tbEnvTotal1.Name = "tbEnvTotal1";
            this.tbEnvTotal1.Size = new System.Drawing.Size(51, 12);
            this.tbEnvTotal1.TabIndex = 3;
            this.tbEnvTotal1.Text = "종합 [4]";
            // 
            // tbEnvOz
            // 
            this.tbEnvOz.Location = new System.Drawing.Point(165, 60);
            this.tbEnvOz.MaxLength = 4;
            this.tbEnvOz.Name = "tbEnvOz";
            this.tbEnvOz.Size = new System.Drawing.Size(76, 21);
            this.tbEnvOz.TabIndex = 2;
            // 
            // tbEnvOz1
            // 
            this.tbEnvOz1.AutoSize = true;
            this.tbEnvOz1.Location = new System.Drawing.Point(250, 66);
            this.tbEnvOz1.Name = "tbEnvOz1";
            this.tbEnvOz1.Size = new System.Drawing.Size(51, 12);
            this.tbEnvOz1.TabIndex = 3;
            this.tbEnvOz1.Text = "오존 [4]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "온도 [4]";
            // 
            // tbEnvHum1
            // 
            this.tbEnvHum1.AutoSize = true;
            this.tbEnvHum1.Location = new System.Drawing.Point(250, 39);
            this.tbEnvHum1.Name = "tbEnvHum1";
            this.tbEnvHum1.Size = new System.Drawing.Size(51, 12);
            this.tbEnvHum1.TabIndex = 3;
            this.tbEnvHum1.Text = "습도 [4]";
            // 
            // tbEnvTemp
            // 
            this.tbEnvTemp.Location = new System.Drawing.Point(80, 33);
            this.tbEnvTemp.MaxLength = 4;
            this.tbEnvTemp.Name = "tbEnvTemp";
            this.tbEnvTemp.Size = new System.Drawing.Size(79, 21);
            this.tbEnvTemp.TabIndex = 2;
            // 
            // tbEnvTotal
            // 
            this.tbEnvTotal.Location = new System.Drawing.Point(165, 87);
            this.tbEnvTotal.MaxLength = 4;
            this.tbEnvTotal.Name = "tbEnvTotal";
            this.tbEnvTotal.Size = new System.Drawing.Size(76, 21);
            this.tbEnvTotal.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "풍속 [4]";
            // 
            // tbEnvAir
            // 
            this.tbEnvAir.Location = new System.Drawing.Point(80, 87);
            this.tbEnvAir.MaxLength = 1;
            this.tbEnvAir.Name = "tbEnvAir";
            this.tbEnvAir.Size = new System.Drawing.Size(79, 21);
            this.tbEnvAir.TabIndex = 2;
            // 
            // tbEnvHum
            // 
            this.tbEnvHum.Location = new System.Drawing.Point(165, 33);
            this.tbEnvHum.MaxLength = 4;
            this.tbEnvHum.Name = "tbEnvHum";
            this.tbEnvHum.Size = new System.Drawing.Size(76, 21);
            this.tbEnvHum.TabIndex = 2;
            // 
            // tbEnvAir1
            // 
            this.tbEnvAir1.AutoSize = true;
            this.tbEnvAir1.Location = new System.Drawing.Point(23, 92);
            this.tbEnvAir1.Name = "tbEnvAir1";
            this.tbEnvAir1.Size = new System.Drawing.Size(51, 12);
            this.tbEnvAir1.TabIndex = 1;
            this.tbEnvAir1.Text = "대기 [1]";
            // 
            // tbEnvWind
            // 
            this.tbEnvWind.Location = new System.Drawing.Point(80, 60);
            this.tbEnvWind.MaxLength = 4;
            this.tbEnvWind.Name = "tbEnvWind";
            this.tbEnvWind.Size = new System.Drawing.Size(79, 21);
            this.tbEnvWind.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEqCount);
            this.groupBox1.Controls.Add(this.tbEqState);
            this.groupBox1.Controls.Add(this.tbEqBat);
            this.groupBox1.Controls.Add(this.tbEqLine);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbEqModel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbEqCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "장비상태정보";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "가동횟수 [5]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "BatteryV [5]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "장비모델 [6]";
            // 
            // tbEqCount
            // 
            this.tbEqCount.Location = new System.Drawing.Point(164, 90);
            this.tbEqCount.MaxLength = 5;
            this.tbEqCount.Name = "tbEqCount";
            this.tbEqCount.Size = new System.Drawing.Size(70, 21);
            this.tbEqCount.TabIndex = 2;
            // 
            // tbEqState
            // 
            this.tbEqState.Location = new System.Drawing.Point(89, 90);
            this.tbEqState.MaxLength = 1;
            this.tbEqState.Name = "tbEqState";
            this.tbEqState.Size = new System.Drawing.Size(70, 21);
            this.tbEqState.TabIndex = 2;
            // 
            // tbEqBat
            // 
            this.tbEqBat.Location = new System.Drawing.Point(164, 63);
            this.tbEqBat.MaxLength = 5;
            this.tbEqBat.Name = "tbEqBat";
            this.tbEqBat.Size = new System.Drawing.Size(70, 21);
            this.tbEqBat.TabIndex = 2;
            // 
            // tbEqLine
            // 
            this.tbEqLine.Location = new System.Drawing.Point(89, 63);
            this.tbEqLine.MaxLength = 5;
            this.tbEqLine.Name = "tbEqLine";
            this.tbEqLine.Size = new System.Drawing.Size(70, 21);
            this.tbEqLine.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "가동여부 [1]";
            // 
            // tbEqModel
            // 
            this.tbEqModel.Location = new System.Drawing.Point(164, 36);
            this.tbEqModel.MaxLength = 6;
            this.tbEqModel.Name = "tbEqModel";
            this.tbEqModel.Size = new System.Drawing.Size(70, 21);
            this.tbEqModel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Line No. [5]";
            // 
            // tbEqCode
            // 
            this.tbEqCode.Location = new System.Drawing.Point(89, 36);
            this.tbEqCode.MaxLength = 5;
            this.tbEqCode.Name = "tbEqCode";
            this.tbEqCode.Size = new System.Drawing.Size(70, 21);
            this.tbEqCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "장비코드 [5]";
            // 
            // tbMonitor
            // 
            this.tbMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMonitor.Location = new System.Drawing.Point(3, 3);
            this.tbMonitor.Multiline = true;
            this.tbMonitor.Name = "tbMonitor";
            this.tbMonitor.Size = new System.Drawing.Size(326, 409);
            this.tbMonitor.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dtStartTime
            // 
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtStartTime.Location = new System.Drawing.Point(176, 35);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.ShowUpDown = true;
            this.dtStartTime.Size = new System.Drawing.Size(125, 21);
            this.dtStartTime.TabIndex = 3;
            // 
            // dtStopTime
            // 
            this.dtStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtStopTime.Location = new System.Drawing.Point(176, 64);
            this.dtStopTime.Name = "dtStopTime";
            this.dtStopTime.ShowUpDown = true;
            this.dtStopTime.Size = new System.Drawing.Size(125, 21);
            this.dtStopTime.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel sblabel1;
        private System.Windows.Forms.ToolStripStatusLabel sblabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEqCount;
        private System.Windows.Forms.TextBox tbEqState;
        private System.Windows.Forms.TextBox tbEqBat;
        private System.Windows.Forms.TextBox tbEqLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEqModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEqCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMonitor;
        private System.Windows.Forms.Label tbEnvTotal1;
        private System.Windows.Forms.TextBox tbEnvOz;
        private System.Windows.Forms.Label tbEnvOz1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tbEnvHum1;
        private System.Windows.Forms.TextBox tbEnvTemp;
        private System.Windows.Forms.TextBox tbEnvTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEnvAir;
        private System.Windows.Forms.TextBox tbEnvHum;
        private System.Windows.Forms.Label tbEnvAir1;
        private System.Windows.Forms.TextBox tbEnvWind;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtStopDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuFileStart;
        private System.Windows.Forms.ToolStripMenuItem mnuFileStop;
        private System.Windows.Forms.ToolStripMenuItem mnuConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.DateTimePicker dtStopTime;
    }
}

