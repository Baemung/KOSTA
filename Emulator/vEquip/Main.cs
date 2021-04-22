using jsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vEquip
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        iniFile ini = new iniFile(@".\vEquip.ini");

        private void Main_Load(object sender, EventArgs e)
        {
            tbEqCode.Text  = ini.GetString("Equipment", "EqCode",  "00001");
            tbEqModel.Text = ini.GetString("Equipment", "EqModel", "000001");
            tbEqLine.Text  = ini.GetString("Equipment", "EqLine",  "00001");
            tbEqBat.Text   = ini.GetString("Equipment", "EqBat",   "00001");
            tbEqState.Text = ini.GetString("Equipment", "EqState", "0");
            tbEqCount.Text = ini.GetString("Equipment", "EqCount", "0");

            tbEnvTemp.Text  = ini.GetString("Enviroment", "EnvTemp",  "0000");
            tbEnvHum.Text   = ini.GetString("Enviroment", "EnvHum",   "0000");
            tbEnvWind.Text  = ini.GetString("Enviroment", "EnvWind",  "0000");
            tbEnvOz.Text    = ini.GetString("Enviroment", "EnvOz",    "0000");
            tbEnvAir.Text   = ini.GetString("Enviroment", "EnvAir",   "0");
            tbEnvTotal.Text = ini.GetString("Enviroment", "EnvTotal", "0000");

            dtStartDate.Value = new DateTime(long.Parse(ini.GetString("Operation", "StartDate", "0")));
            dtStopDate.Value = new DateTime(long.Parse(ini.GetString("Operation", "StopDate", "0")));
            dtStartTime.Value = new DateTime(long.Parse(ini.GetString("Operation", "StartTime", "0")));
            dtStopTime.Value = new DateTime(long.Parse(ini.GetString("Operation", "StopTime", "0")));
            tbInterval.Text = ini.GetString("Operation", "Interval", "2");

            int x1, x2, y1, y2;

            sblabel1.Text = ini.GetString("Server", "IP",   "127.0.0.1");
            sblabel2.Text = ini.GetString("Server", "Port", "9001");

            x1 = int.Parse(ini.GetString("Form", "LocationX", "600"));
            y1 = int.Parse(ini.GetString("Form", "LocationY", "300"));
            this.Location = new Point(x1, y1);

            x2 = int.Parse(ini.GetString("Form", "SizeX", "700"));
            y2 = int.Parse(ini.GetString("Form", "SizeY", "500"));
            this.Size = new Size(x2, y2);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadRead != null) threadRead.Abort(); 

            ini.SetString("Equipment", "EqCode",  tbEqCode.Text );
            ini.SetString("Equipment", "EqModel", tbEqModel.Text);
            ini.SetString("Equipment", "EqLine",  tbEqLine.Text );
            ini.SetString("Equipment", "EqBat",   tbEqBat.Text  );
            ini.SetString("Equipment", "EqState", tbEqState.Text);
            ini.SetString("Equipment", "EqCount", tbEqCount.Text);
                
            ini.SetString("Enviroment", "EnvTemp",  tbEnvTemp.Text );
            ini.SetString("Enviroment", "EnvHum",   tbEnvHum.Text  );
            ini.SetString("Enviroment", "EnvWind",  tbEnvWind.Text );
            ini.SetString("Enviroment", "EnvOz",    tbEnvOz.Text   );
            ini.SetString("Enviroment", "EnvAir",   tbEnvAir.Text  );
            ini.SetString("Enviroment", "EnvTotal", tbEnvTotal.Text);

            ini.SetString("Operation", "StartDate", dtStartDate.Value.Ticks.ToString());
            ini.SetString("Operation", "StopDate",  dtStopDate.Value.Ticks.ToString());
            ini.SetString("Operation", "StartTime", dtStartTime.Value.Ticks.ToString());
            ini.SetString("Operation", "StopTime", dtStopTime.Value.Ticks.ToString());
            ini.SetString("Operation", "Interval",  tbInterval.Text);

            ini.SetString("Server", "IP", sblabel1.Text);
            ini.SetString("Server", "Port", sblabel2.Text);
            ini.SetString("Form", "LocationX", $"{Location.X}");
            ini.SetString("Form", "LocationY", $"{Location.Y}");
            ini.SetString("Form", "SizeX", $"{Size.Width}");
            ini.SetString("Form", "SizeY", $"{Size.Height}");
        }

        Socket sock = null;
        Thread threadRead = null;

        delegate void cbAddText(string str);

        void AddText(string str)
        {
            if (tbMonitor.InvokeRequired)
            {
                cbAddText cb = new cbAddText(AddText);
                Invoke(cb, new object[] { str });
            }
            tbMonitor.AppendText(str);
        }

        bool IsAlive(Socket sk) // 소켓 sk가 유효한지 아닌지 판단
        {
            if (sk == null) return false;
            if (sk.Connected == false) return false;
            if(sk.Poll(1000, SelectMode.SelectRead) && sk.Available == 0) return false;

            try
            {
                sk.Send(new byte[1], 0, SocketFlags.OutOfBand);
                return true;
            }
            catch
            {
                return false;
            }
        }

        void ReadProcess()
        {
            Socket lsock = sock;
            while (true)
            {
                lsock = sock;
                if (IsAlive(lsock) && lsock.Available > 0)
                {
                    byte[] bArr = new byte[lsock.Available]; // 버퍼 확보
                    lsock.Receive(bArr);
                    tbMonitor.Text += Encoding.Default.GetString(bArr) + "\r\n";
                }
                Thread.Sleep(100);
            }   
        }

        bool CheckInTime()
        {
            DateTime dt = DateTime.Now;
            DateTime st = dtStartDate.Value.Date + dtStartTime.Value.TimeOfDay;
            DateTime et = dtStopDate.Value.Date + dtStopTime.Value.TimeOfDay;

            return dt > st && dt < et;
        }

        void SetRandomValue()
        {
            Random r = new Random();
            tbEnvTemp.Text = $"{r.Next(0, 99)}";
            tbEnvHum.Text = $"{r.Next(0, 99)}";
            tbEnvWind.Text = $"{r.Next(0, 99)}";
            tbEnvOz.Text = $"{r.Next(0, 99)}";
        }

        private void sblabel1_Click(object sender, EventArgs e)
        {
            string str = jslib.GetInput("IP Address");
            if (str != "") sblabel1.Text = str;
        }

        private void sblabel2_Click(object sender, EventArgs e)
        {
            string str = jslib.GetInput("Port");
            if (str != "") sblabel2.Text = str;
        }

        char STX = '\u0002';
        char ETX = '\u0003';

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            if (CheckInTime())
            {
                SetRandomValue();
                // Package 구성 : 패킷의 전후에 [02]STX [03]ETX 문자를 덧붙인다.
                string str = $"{STX}";
                str       += $"{tbEqCode.Text,5}{tbEqModel.Text, 6}{tbEqLine.Text, 5}{float.Parse(tbEqBat.Text), 5:F2}";
                str       += $"{tbEqState.Text,1}{int.Parse(tbEqCount.Text):D5}";
                str       += $"{int.Parse(tbEnvTemp.Text):D4}{int.Parse(tbEnvHum.Text):D4}{int.Parse(tbEnvWind.Text):D4}";
                str       += $"{int.Parse(tbEnvOz.Text):D4}{int.Parse(tbEnvAir.Text):D1}{int.Parse(tbEnvTotal.Text):D4}";
                str       += $"{ETX}";

                byte[] ba = Encoding.Default.GetBytes(str);
                if (IsAlive(sock))
                {
                    sock.Send(ba);
                    tbEqCount.Text = $"{int.Parse(tbEqCount.Text) + 1}";
                }
            } 
            timer.Start();
        }

        private void mnuFileStart_Click(object sender, EventArgs e) // 처음 수행 시
        {
            if (sock != null) sock.Close(); // Re-Start
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(sblabel1.Text, int.Parse(sblabel2.Text));

            if (threadRead != null) threadRead.Abort(); // Re-Start
            threadRead = new Thread(ReadProcess);
            threadRead.Start();

            try
            {
                timer.Interval = int.Parse(tbInterval.Text) * 1000; // sec to ms ; 주기적 인터럽트 생성
                timer.Start();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void mnuFileStop_Click(object sender, EventArgs e)
        {
            timer.Stop();

            if (sock != null) sock = null;
            if (threadRead != null) threadRead = null;
        }
    }
}
