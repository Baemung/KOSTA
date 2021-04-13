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

namespace ChatManager
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        delegate void CB(string str);

        void AddText(string str)
        {
            if (tbRecieve.InvokeRequired)
            {
                CB cb = new CB(AddText);
                Invoke(cb, new object[] { str });
            }
            else
            {
                //tbReciever.AppendText();
            }
        }

        string tempString = "";
        Thread threadServer = null;
        Thread threadRead = null;
        TcpListener listener = null;
        TcpClient tcp = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (listener == null)
            {
                listener = new TcpListener(int.Parse(tbPort.Text));
                listener.Start();
            }
            if (threadServer == null)
            {
                threadServer = new Thread(ServerProcess);
                threadServer.Start();
                threadRead = new Thread(ReadProcess);
            }
        }

        void ServerProcess()
        {
            while (true)
            {
                if(listener.Pending() == true)
                {
                    tcp = listener.AcceptTcpClient(); // blocking mode
                    AddText($"{tcp.Client.RemoteEndPoint.ToString()} 로부터 접속됨. \r\n");
                    threadRead.Start();
                }
                Thread.Sleep(100);
            }
        }

        void ReadProcess()
        {
            if(tcp != null)
            {
                NetworkStream ns = tcp.GetStream();
                byte[] bArr = new byte[50];
                while (true)
                {
                    while (ns.DataAvailable)
                    {
                        int n = ns.Read(bArr, 0, 50);
                        AddText(Encoding.Default.GetString(bArr, 0, n)+"\r\n");
                    }
                }
            }
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            strSend(tbSend.Text);
        }

        private void frmServer_Load(object sender, EventArgs e)
        {

        }

        private void tbSend_KeyUp(object sender, KeyEventArgs e)
        {
            int pos = tbSend.SelectionStart;
            if(e.KeyCode == Keys.Enter)
            {
                string[] sArr = tbSend.Text.Split('\n');
                string str = sArr[sArr.Length - 2] + "\n";
                strSend(str);

                strSend(tbSend.Text.Split('\n')[tbSend.GetLineFromCharIndex(tbSend.SelectionStart)-1]+"\n");
            }
        }

        private void strSend(string str)
        {
            if (tcp != null)
            {
                NetworkStream ns = tcp.GetStream();

                byte[] bArr = Encoding.Default.GetBytes(tbSend.Text);
                ns.Write(bArr, 0, bArr.Length);
            }
        }
    }
}
