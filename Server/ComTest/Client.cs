using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComTest
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e) // 통신 메시지 단위 1024 바이트
        {
            // 1. 소켓 생성 : 주소 없음
            // 2. 소켓 오픈 : 커넥션 오픈 - 주소부여
            // 3. 메시지 전송 : 텍스트 외에 이미지나 동영상도 가능. 단 양측이 서로 약속된 규약에 의해서 ==> 프로토콜 제정


            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(tbIP.Text, int.Parse(tbIPPort.Text));
            string str = tbClient.Text;
            byte[] bArr = Encoding.Default.GetBytes(str); // char[] = string
            sock.Send(bArr);
        }
    }
}
