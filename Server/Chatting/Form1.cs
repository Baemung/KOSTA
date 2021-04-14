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

namespace Chatting
{
    public partial class KOSTA_TALK : Form
    {
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string sec, string key, string defstr, StringBuilder sb, int size, string path);

        [DllImport("kernel32")]
        static extern int WritePrivateProfileString(string sec, string key, string str, string path);

        public KOSTA_TALK()
        {
            InitializeComponent();
        }

        delegate void CB(string str);

        //Client
        string init_IP = "127.0.0.1";
        int init_Port = 9001;
        Socket sock = null;
        Thread threadClient = null;
        string clientName = "Anonymous";

        //Server
        Thread threadServer = null;
        Thread threadRead = null;
        TcpListener listener = null;
        TcpClient tcp = null;

        private void AddText(string str)
        {
            if (tbServer.InvokeRequired)
            {
                 CB cb = new CB(AddText);
                Invoke(cb, new object[] { str });
            }
            else
            {
                tbServer.AppendText(str);
            }
        }
        void ClientProcess()
        {
            //while (true)
            {
                int n = sock.Available;
                if (n > 0 && sock.Connected)
                {
                    byte[] bArr = new byte[n];
                    sock.Receive(bArr);
                    AddText(Encoding.Default.GetString(bArr));
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (threadServer == null)
            {
                threadServer = new Thread(ServerProcess);
                threadServer.Start();
                threadRead = new Thread(ReadProcess);
                sbMessage.Text = "Thread Start";
            }
            else if (listener == null)
            {
                listener = new TcpListener(int.Parse(tbSPort.Text));
                listener.Start();
            }
            else
            {
                threadServer.Suspend();
                threadServer.Resume();
                sbMessage.Text = "Thread Resume";
            }
            //timer.Enabled = true;
        }

        void ReadProcess()
        {
            if (tcp != null)
            {
                NetworkStream ns = tcp.GetStream();
                byte[] bArr = new byte[50];
                while (true)
                {
                    while (ns.DataAvailable)
                    {
                        int n = ns.Read(bArr, 0, 50);
                        AddText(Encoding.Default.GetString(bArr, 0, n) + "\r\n");
                    }
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "") clientName = tbName.Text;
            try
            {
                if (sock == null)
                {
                    sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }

                else
                {
                    if (threadClient != null)
                    {
                        threadClient.Abort();
                        threadClient = null;
                    }
                    sock.Close();
                    sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
                sock.Connect(tbIP.Text, int.Parse(tbCPort.Text));

                if (threadClient == null)
                {
                    threadClient = new Thread(ClientProcess);
                    threadClient.Start();
                }

                if (sock.Connected == true)
                {
                    if (tbClient.Text != "")
                    {
                        sock.Send(Encoding.Default.GetBytes($"[{clientName}] {tbClient.Text}"));
                        if (tbServer.Text != "") tbServer.Text += "\r\n";
                    }
                    tbClient.Clear();
                }
            }
            catch (Exception e1)
            {
                sbMessage.Text = "Connection Error!";
            }
        }

        private void KOSTA_TALK_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (threadServer != null) threadServer.Abort();
            if (threadClient != null) threadClient.Abort();
            if (threadRead != null) threadRead.Abort();
            if (sock != null) sock.Close();
        }

        private void KOSTA_TALK_FormLoad(object sender, EventArgs e)
        {
            tbIP.Text = init_IP;
            tbCPort.Text = $"{init_Port}";
        }

        private void ServerProcess()
        {
            while (true)
            {
                if (listener == null)
                {
                    listener = new TcpListener(Dns.Resolve("localhost").AddressList[0], int.Parse(tbSPort.Text));
                    listener.Start(); 
                    sbMessage.Text = "Threading Start..";
                }

                if (listener.Pending())
                {
                    sbMessage.Text = "Thread is Running..";
                    TcpClient tcp = listener.AcceptTcpClient(); 
                    NetworkStream ns = tcp.GetStream();

                    while (ns.DataAvailable)
                    {
                        byte[] bArr = new byte[200];
                        int n = ns.Read(bArr, 0, 200);
                        AddText(Encoding.Default.GetString(bArr, 0, n));
                    }
                }
                Thread.Sleep(10);
            }
        }

    }
}
