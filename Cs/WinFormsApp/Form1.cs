using System; //include와 비슷하게 사용
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        bool status = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (status) {
                btn1.Text = "OFF";
            }
            else {
                btn1.Text = "ON";
            }
            status = !status;
        }

        private void btnfopen_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret == DialogResult.Cancel) return; //리턴값이 cancel(파일이 선택되지 않으면)이라면 종료.

            string fname = openFileDialog1.FileName; //File full path가 저장
            StreamReader sr = new StreamReader(fname);

            string buf = sr.ReadToEnd();
            sr.Close();
            tbMemo.Text = buf;
        }

        private void btnfsave_Click(object sender, EventArgs e)
        {
            DialogResult ret = saveFileDialog1.ShowDialog();
            if (ret == DialogResult.Cancel) return;

            string fname = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(fname);

            string buf = tbMemo.Text;
            sw.Write(buf);
            sw.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string src = tb1.Text;          //C++ CStirng
            string dest = src.ToUpper();    //CString str
            int len = src.Length;           
            tb2.Text = dest;
            tb3.Text = $"변환된 문자열은 {dest}이고 문자열의 길이는 {len}입니다.";     //보간 문자열
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            DialogResult ret = frm2.ShowDialog();
            if (ret == DialogResult.Cancel) return;
            tbf2.Text = $"cb1 : {frm2.cb1.Text}\r\ncb2 : {frm2.cb2.Text}\r\ncb3 : {frm2.cb3.Text}";
        }
    }
}