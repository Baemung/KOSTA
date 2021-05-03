using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTest
{
    public partial class Server : Form
    {
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string sec, string key, string defstr, StringBuilder sb, int size, string path);

        [DllImport("kernel32")]
        static extern int WritePrivateProfileString(string sec, string key, string str, string path);

        public Server()
        {
            InitializeComponent();
        }

        delegate void cdAddText(string str);

        private void AddText(string str)
        {
            if (tbServer.InvokeRequired)
            {
                cdAddText at = new cdAddText(AddText);
                object[] oArr = { str };
                Invoke(at, oArr);
            }
            else
            {
                tbServer.Text = str;
            }
        }

        Thread thread = null;
        TcpListener listener = null;
        string MainMSG = "";
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (thread == null)
            {
                thread = new Thread(ServerProcess);
                thread.Start();
                timer.Start();
                sbMessage.Text = "Thread Start";
            }

            else
            {
                thread.Suspend();
                thread.Resume();
                sbMessage.Text = "Thread Resume";
            }
            timer.Enabled = true;
            //ServerProcess();
        }

        private void ServerProcess()
        {
            while (true)
            {
                // 1. 무한 수신 대기
                // 2. 기존 이벤트 처리
                // 3. 외부 접속 요청 수신시 해당 요청 처리


                if(listener == null)
                {
                    listener = new TcpListener(Dns.Resolve("localhost").AddressList[0], int.Parse(tbPort.Text));
                    listener.Start(); // Listener는 start가 되면 stop명령까지 계속 수행 
                    sbMessage.Text = "Threading Start..";
                }

                if (listener.Pending())
                {
                    sbMessage.Text = "Thread is Running..";
                    TcpClient tcp = listener.AcceptTcpClient(); // Tcp Type Socket : 블로킹 모드
                    NetworkStream ns = tcp.GetStream();

                    while (ns.DataAvailable)
                    {
                        byte[] bArr = new byte[200];
                        int n = ns.Read(bArr, 0, 200);
                        //tbServer.Text += Encoding.Default.GetString(bArr, 0, n); //Cross-Thread Error
                        AddText(Encoding.Default.GetString(bArr, 0, n));
                    }
                    //listener.Stop();
                }
                Thread.Sleep(100);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tbServer.Text = MainMSG;
            MainMSG = "";
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(thread != null) thread.Abort();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thread.Suspend(); // thread.Resume();
            if (thread.IsAlive) sbMessage.Text = "Thread Suspended";
            else sbMessage.Text = "Thread Not Alive";
        }

        private void Server_Load(object sender, EventArgs e)
        {
            int x1, y1, x2, y2;

            iniFile ini = new iniFile(@"ComServer.ini");
            x1 = int.Parse(ini.GetString("Form", "LocX", "0"));
            y1 = int.Parse(ini.GetString("Form", "LocY", "0"));
            x2 = int.Parse(ini.GetString("Form", "SizeX", "500"));
            y2 = int.Parse(ini.GetString("Form", "SizeY", "500"));

            Location = new Point(x1, y1);
            Size = new Size(x2, y2);
        }
    }
}
