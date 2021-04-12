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
                if (n > 0)
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
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
