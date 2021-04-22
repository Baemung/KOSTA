using jsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipManager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        delegate void cbAddText(string str);
        void AddText(string str)
        {
            if (tbMonitor.InvokeRequired)
            {
                cbAddText cb = new cbAddText(AddText);
                Invoke(cb, new object[] { str });
            }
            else tbMonitor.AppendText(str);
        }


        Socket sock = null; // Client - Server
        TcpListener listener = null;
        List<Socket> socks = new List<Socket>();
        Thread threadServer = null;
        Thread threadRead = null;

        void ServerProcess()
        {
            while (true)
            {
                if (listener.Pending())
                {
                    Socket sockT = listener.AcceptSocket();
                    socks.Add(sockT);
                }
                Thread.Sleep(100);
            }
        }

        void ReadProcess()
        {
            while (true)
            {
                for (int i = 0; i < socks.Count; i++)
                {
                    Socket lsock = socks[i];
                    if (! IsAlive(lsock)) continue;

                    if (lsock.Available > 0)
                    {
                        byte[] bArr = new byte[lsock.Available];
                        lsock.Receive(bArr);
                        ReadProc(lsock, bArr);
                    }
                }
                Thread.Sleep(100);
            }
        }

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anvo9\KOSTA\Emulator\EquipManager\EquipDatabase.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        void ReadProc(Socket sk, byte[] bArr)
        {
            string str = Encoding.Default.GetString(bArr);

            string sCode    = str.Substring(1, 5);  //String : 5
            string sModel   = str.Substring(6, 6);  //String : 6
            string sLine    = str.Substring(12, 5); //String : 5
            string sBat     = str.Substring(17, 5); //Float  : 5 _1.11
            string sState   = str.Substring(22, 1); //int    : 1
            string sCount   = str.Substring(23, 5); //int    : 5
            string sTemp    = str.Substring(28, 4); //int    : 4
            string sHum     = str.Substring(32, 4); //int    : 4
            string sWind    = str.Substring(36, 4); //int    : 4
            string sOz      = str.Substring(40, 4); //int    : 4
            string sAir     = str.Substring(44, 1); //int    : 1
            string sTotal   = str.Substring(45, 4); //int    : 4

            jslib.WriteLog($"{sCode} {sModel} {sLine} {sBat} {sState} {sCount} {sTemp} {sHum} {sWind} {sOz} {sAir} {sTotal}");
            AddText(sk.RemoteEndPoint.ToString() + "  >  "); // 127.0.0.1:12345 ==> 줄바꿈 없음.
            AddText($"{sCode} {sModel} {sLine} {sBat} {sState} {sCount} {sTemp} {sHum} {sWind} {sOz} {sAir} {sTotal}\r\n");

            string sql = $"insert into fStatus values ('{sCode}','{sModel}','{sLine}','{sBat}','{sState}','{sCount}','{sTemp}','{sHum}','{sWind}','{sOz}','{sAir}','{sTotal}',getdate())";
            RunSQL(sql);
         }

        void RunSQL(string SQL)
        {
            cmd.CommandText = SQL;
            cmd.ExecuteNonQuery();
        }

        bool IsAlive(Socket sk)
        {
            if (sk == null) return false;
            if (sk.Connected == false) return false;
            if (sk.Poll(1000, SelectMode.SelectRead) && sk.Available == 0) return false;

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

        private void mnuServerStart_Click(object sender, EventArgs e)
        {
            if (listener == null) listener = new TcpListener(int.Parse(tbServerPort.Text));
            else listener.Stop();
            listener.Start();

            if (threadServer != null) threadServer.Abort();
            else threadServer = new Thread(ServerProcess);
            threadServer.Start();

            if (threadRead != null) threadRead.Abort();
            else threadRead = new Thread(ReadProcess);
            threadRead.Start();
        }

        iniFile ini = new iniFile(@".\EquipManager.ini");
        private void Manager_Load(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;

            x1 = int.Parse(ini.GetString("Form", "LocationX", "600"));
            y1 = int.Parse(ini.GetString("Form", "LocationY", "300"));
            this.Location = new Point(x1, y1);

            x2 = int.Parse(ini.GetString("Form", "SizeX", "800"));
            y2 = int.Parse(ini.GetString("Form", "SizeY", "500"));
            this.Size = new Size(x2, y2);

            tabControl.SelectedIndex = int.Parse(ini.GetString("Form", "TabIndex", "1"));
            tbServerPort.Text = ini.GetString("Server", "Port", "9001");

            connString = ini.GetString("Database", "ConnectionString", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anvo9\KOSTA\Emulator\EquipManager\EquipDatabase.mdf;Integrated Security = True; Connect Timeout = 30");
            conn.ConnectionString = connString;
            conn.Open();
            cmd.Connection = conn;
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadServer != null) threadServer.Abort();
            if (threadRead != null) threadRead.Abort();

            ini.SetString("Server", "Port", tbServerPort.Text);
            ini.SetString("Form", "LocationX", $"{Location.X}");
            ini.SetString("Form", "LocationY", $"{Location.Y}");
            ini.SetString("Form", "SizeX", $"{Size.Width}");
            ini.SetString("Form", "SizeY", $"{Size.Height}");
            ini.SetString("Form", "TabIndex", $"{tabControl.SelectedIndex}");
            ini.SetString("Database", "ConnectionString", connString);
        }
    }
}
