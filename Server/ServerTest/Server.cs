using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTest
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        Thread thread = null;
        TcpListener listener = null;
        //byte[] bArr = new byte[200];
        string MainMSG = "";
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (thread == null)
            {
                thread = new Thread(ServerProcess);
                sbMessage.Text = "Thread Start";
                thread.Start();
                timer.Start();
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

        private void AddText(string str)
        {
            MainMSG += str;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tbServer.Text = MainMSG;
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
    }
}
