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

        Thread threadServer = null;
        TcpListener listener = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (listener == null)
            {
                listener = new TcpListener(int.Parse(tbPort.Text));
            }
        }

        void ServerProcess()
        {
            TcpClient tcp = listener.AcceptTcpClient(); // blocking mode

            NetworkStream ns = tcp.GetStream();
            if (ns.DataAvailable)
            {
                byte[] bArr = new byte[ns.Length];
                ns.Read(bArr, 0, (int)ns.Length);
            }
        }
    }
}
