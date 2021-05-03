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

namespace ChatManager
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        delegate void cbAddText(string s);
        void AddText(string str)
        {
            cbAddText cb = new cbAddText(AddText);
            Invoke(cb, new object[] { str });
        }

        Thread threadClient = null;
        Socket sock = null;

        void ClientProcess()
        {
            while (true)
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

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            int size1 = 200;

            splitContainer.SplitterDistance = splitContainer.Size.Width - size1;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
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
                sock.Connect(tbIP.Text, int.Parse(tbPort.Text));
                sl1.Text = ((IPEndPoint)(sock.RemoteEndPoint)).Address.ToString();
                sl2.Text = ((IPEndPoint)(sock.RemoteEndPoint)).Port.ToString();

                if (threadClient == null)
                {
                    threadClient = new Thread(ClientProcess);
                    threadClient.Start();
                }
            }
            catch(Exception e1)
            {
                tbReceive.AppendText(e1.Message + "커넥션에 오류가 생겼습니다.\r\n");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(sock.Connected == true)
            {
                string str = tbSend.Text.Trim();
                string[] sArr = str.Split('\r');
                string sLast = sArr[sArr.Length - 1];
                sock.Send(Encoding.Default.GetBytes(sLast));
            }
        }
    }
}
