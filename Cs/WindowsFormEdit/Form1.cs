using myLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEdit
{
    public partial class Form1 : Form
    {
        string Title = "제목 없음.txt";
        string pPath = string.Empty;
        bool txtChanged = false;
        string originText = string.Empty;

        public Form1()
        {
            InitializeComponent();
            Set_fontInfo();
            this.Text = "MyEditor - "+ Title;
        }

        private void munFileNew_Click(object sender, EventArgs e)
        {
            if (txtChanged)
            {
                DialogResult dr = MessageBox.Show("변경 내용을 저장 하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    DialogResult ret = saveFileDialog1.ShowDialog();
                    if (ret == DialogResult.Cancel) return;

                    string fPath = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(fPath);
                    sw.Write(tbMemo.Text);
                    sw.Close();
                }
                else if (dr == DialogResult.Cancel) return;
            }
            tbMemo.Text = string.Empty;
            this.Text = "MyEditor - " + "제목 없음.txt";
            slFind.Text = string.Empty;
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            if (txtChanged)
            {
                DialogResult dr = MessageBox.Show("변경 내용을 저장 하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    DialogResult ret1 = saveFileDialog1.ShowDialog();
                    if (ret1 == DialogResult.Cancel) return;

                    string fPath1 = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(fPath1);
                    sw.Write(tbMemo.Text);
                    sw.Close();
                }
                else if (dr == DialogResult.Cancel) return;
            }

            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret == DialogResult.Cancel) return; //C#에서 ShowDialog()은 C++의 DoModal과 완전히 동일한 메소드

            string fPath = openFileDialog1.FileName; //FullPath를 가져옴
            StreamReader sr = new StreamReader(fPath); //C에서는 FILE*, C++에서는 CFile
            tbMemo.Text = sr.ReadToEnd();
            sr.Close();

            int idx = myLib.Get_Count('\\', fPath);
            Title = myLib.Get_Token('\\', fPath, idx);
            this.Text = $"MyEditor - {Title}";
            txtChanged = false;
            slFind.Text = string.Empty;
        }

        //Save as..
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if (txtChanged)
            {
                if (Title == "제목 없음.txt")
                {
                    DialogResult dr = MessageBox.Show("\"제목 없음.txt\"로 저장 하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        pPath = Directory.GetCurrentDirectory() + @"..\..\..\";
                        StreamWriter sw1 = new StreamWriter(pPath + '\\' + Title);
                        sw1.Write(tbMemo.Text);
                        sw1.Close();
                    }
                    else if (dr == DialogResult.No)
                    {
                        DialogResult ret = saveFileDialog1.ShowDialog();
                        if (ret == DialogResult.Cancel) return;
                        string fPath = saveFileDialog1.FileName;
                        StreamWriter sw = new StreamWriter(fPath);
                        sw.Write(tbMemo.Text);
                        sw.Close();
                        int idx = myLib.Get_Count('\\', fPath);
                        Title = myLib.Get_Token('\\', fPath, idx);
                        this.Text = $"MyEditor - {Title}";
                    }
                    else return;
                }
                else
                {
                    pPath = Directory.GetCurrentDirectory() + @"..\..\..\";
                    StreamWriter sw = new StreamWriter(pPath + '\\' + Title);
                    sw.Write(tbMemo.Text);
                    sw.Close();
                }
                originText = tbMemo.Text;
                txtChanged = false;
            }
        }

        private void mnuFileSaveas_Click(object sender, EventArgs e)
        {
            DialogResult ret = saveFileDialog1.ShowDialog();
            if (ret == DialogResult.Cancel) return;
            string fPath = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(fPath);
            sw.Write(tbMemo.Text);
            sw.Close();

            int idx = myLib.Get_Count('\\', fPath);
            Title = myLib.Get_Token('\\', fPath, idx);
            this.Text = $"MyEditor - {Title}";
            originText = tbMemo.Text;
            txtChanged = false;
        }

        //1. File Open 후 메모창에 표시한 경우 - 확인만하고 아무것도 수정 X
        //2. New Menu 선택 후 문서 편집 - file명 지정 필요 O
        //3. 기존 문서 중 일부 수정 - file명 지정 필요 X
        private void tbMemo_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
            if (originText == tbMemo.Text) txtChanged = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtChanged)
            {
                DialogResult dr = MessageBox.Show("변경 내용을 저장 하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    DialogResult ret = saveFileDialog1.ShowDialog();
                    if (ret == DialogResult.Cancel) return;

                    string fPath = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(fPath);
                    sw.Write(tbMemo.Text);
                    sw.Close();
                    tbMemo.Text = string.Empty;
                }
                else if (dr == DialogResult.Cancel) e.Cancel = true;
            }
            else
            {
                DialogResult dr = MessageBox.Show("정말로 종료 하시겠습니까?", "메모장", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) e.Cancel = true;
            }
        }

        private void mnuViewFont_Click(object sender, EventArgs e)
        {
            DialogResult ret = fontDialog1.ShowDialog();
            if (ret == DialogResult.Cancel) return;
            
            Font fnt = fontDialog1.Font;
            tbMemo.Font = fnt;
            Set_fontInfo();
        }

        private void Set_fontInfo()
        {
            sl1.Text = $"Font Name : {tbMemo.Font.Name}   ";
            sl2.Text = $"Font Style : {tbMemo.Font.Style}   ";
            sl3.Text = $"Font Size : {tbMemo.Font.SizeInPoints}pt ";
        }

        string retStr;
        int pos;
        int cnt = 0;
        int idx;
        List<int> posList = new List<int>();

        private void munEditFind_Click(object sender, EventArgs e)
        {
            FormFind dlg = new FormFind();
            DialogResult ret = dlg.ShowDialog();
            if(ret == DialogResult.Cancel) return;

            retStr = dlg.fndStr; //찾을 문자열
            if (retStr == string.Empty) return;
            pos = tbMemo.Text.IndexOf(retStr);
            posList.Clear;
            posList.Add(pos);
            cnt = 1;
            idx = 0;
            while (pos != -1)
            {
                pos = tbMemo.Text.IndexOf(retStr, pos + 1); //tbMemo.Text : 타겟 문자열
                posList.Add(pos);
                cnt += 1;
            }
            slFind.Text = $"   찾은 문자열 갯수 : ( {idx + 1} / {cnt - 1} )";
            if (cnt == 1) //해당 문자열 없음.
            {
                MessageBox.Show("문자열을 찾을 수 없습니다.", "메모장", MessageBoxButtons.OK);
                return;
            }
            tbMemo.SelectionStart = (int)posList[idx];
            tbMemo.SelectionLength = retStr.Length;
            tbMemo.ScrollToCaret();
        }

        private void mnuEditPrev_Click(object sender, EventArgs e)
        { 
            if (idx == 0) //해당 문자열 없음.
            {
                MessageBox.Show("가장 첫번째 문자열 입니다.", "메모장");
                return;
            }
            idx -= 1;
            tbMemo.SelectionStart = (int)posList[idx];
            tbMemo.SelectionLength = retStr.Length;
            tbMemo.ScrollToCaret();
            slFind.Text = $"   찾은 문자열 갯수 : ( {idx + 1} / {cnt - 1} )";
        }

        private void mnuEditNext_Click(object sender, EventArgs e)
        {
            idx += 1;
            if (cnt == 0 || (int)posList[idx] == -1)
            {
                idx -= 1;
                MessageBox.Show("문자열을 찾을 수 없습니다.", "메모장", MessageBoxButtons.OK);
                return;
            }
            tbMemo.SelectionStart = (int)posList[idx];
            tbMemo.SelectionLength = retStr.Length;
            tbMemo.ScrollToCaret();
            slFind.Text = $"   찾은 문자열 갯수 : ( {idx+1} / {cnt-1} )";
        }

        private void mnuEditReplace_Click(object sender, EventArgs e)
        {
            FormReplace dlg = new FormReplace();
            DialogResult ret = dlg.ShowDialog();
            if (ret == DialogResult.Cancel) return;
            else if (cnt == 0)
            {
                MessageBox.Show("선택된 문자열이 없습니다.", "메모장", MessageBoxButtons.OK);
                return;
            }
            else if (ret == DialogResult.OK)
            {
                tbMemo.SelectionStart = (int)posList[idx];
                tbMemo.SelectionLength = retStr.Length;
                tbMemo.ScrollToCaret();
                tbMemo.SelectedText = dlg.strD;
                slFind.Text = string.Empty;
            }
            else if (ret == DialogResult.Yes)
            {
                tbMemo.Text = tbMemo.Text.Replace(retStr, dlg.strD);
                slFind.Text = string.Empty;
            }
        }
    }
}
