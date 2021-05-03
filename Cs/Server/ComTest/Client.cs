using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComTest
{
    public partial class Client : Form
    {

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string sec, string key, string defstr, StringBuilder sb, int size, string path);

        [DllImport("kernel32")]
        static extern int WritePrivateProfileString(string sec, string key, string str, string path);

        public Client()
        {
            InitializeComponent();
        }

        string init_IP = "127.0.0.1";
        int init_Port = 9001;

        private void btnSend_Click(object sender, EventArgs e) // 통신 메시지 단위 1024 바이트
        {
            // 1. 소켓 생성 : 주소 없음
            // 2. 소켓 오픈 : 커넥션 오픈 - 주소부여
            // 3. 메시지 전송 : 텍스트 외에 이미지나 동영상도 가능. 단 양측이 서로 약속된 규약에 의해서 ==> 프로토콜 제정


            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(tbIP.Text, int.Parse(tbIPPort.Text));
            //string str = tbClient.Text;
            //byte[] bArr = Encoding.Default.GetBytes(str); // char[] = string
            //sock.Send(bArr);
            int ret = sock.Send(Encoding.Default.GetBytes(tbClient.Text));
            if(ret > 0) sbMessage.Text = $"{ret} byte(s) send success";
        }

        private void Client_Load(object sender, EventArgs e)
        {
            int x1, y1, x2, y2;
            StringBuilder sb512 = new StringBuilder(512);
            GetPrivateProfileString("Comm", "IP", "127.0.0.1", sb512, 512, @"ComClient.ini"); init_IP = sb512.ToString();
            GetPrivateProfileString("Comm", "Port", "9001", sb512, 512, @"ComClient.ini"); init_Port = int.Parse(sb512.ToString());
            GetPrivateProfileString("Form", "LocX", $"0", sb512, 512, @"ComClient.ini"); x1 = int.Parse(sb512.ToString());
            GetPrivateProfileString("Form", "LocY", $"0", sb512, 512, @"ComClient.ini"); y1 = int.Parse(sb512.ToString());
            GetPrivateProfileString("Form", "SizeX", $"500", sb512, 512, @"ComClient.ini"); x2 = int.Parse(sb512.ToString());
            GetPrivateProfileString("Form", "SizeX", $"500", sb512, 512, @"ComClient.ini"); y2 = int.Parse(sb512.ToString());
            Location = new Point(x1, y1);
            Size = new Size(x2, y2);
            tbIP.Text = init_IP;
            tbIPPort.Text = $"{init_Port}";
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            WritePrivateProfileString("Comm", "IP", tbIP.Text, @"ComClient.ini");
            WritePrivateProfileString("Comm", "Port", tbIPPort.Text, @"ComClient.ini");
            WritePrivateProfileString("Form", "LocX", $"{Location.X}", @"ComClient.ini");
            WritePrivateProfileString("Form", "LocY", $"{Location.Y}", @"ComClient.ini");
            WritePrivateProfileString("Form", "SizeX", $"{Size.Width}", @"ComClient.ini");
            WritePrivateProfileString("Form", "SizeY", $"{Size.Height}", @"ComClient.ini");
        }
    }
}
