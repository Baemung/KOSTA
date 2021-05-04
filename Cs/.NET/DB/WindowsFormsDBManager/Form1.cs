using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDBManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string str = tbInput.Text;
            dbGrid.Columns.Add(str, str);
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            string[] str = tbValue.Text.Split(',');
            dbGrid.Rows.Add(str);
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog.ShowDialog();
            if (ret == DialogResult.Cancel) return; 

            string fname = openFileDialog.FileName;
            StreamReader sr = new StreamReader(fname);
            bool is_title = true;
            while (!sr.EndOfStream)
            {
                string buf = sr.ReadLine();
                string[] csvf = buf.Split(',');
                if(is_title)
                {
                    for (int i = 0; i < csvf.Length; i++)
                    {
                        dbGrid.Columns.Add(csvf[i], csvf[i]);
                    }
                    is_title = false;
                }
                else
                {
                    dbGrid.Rows.Add(csvf);
                }
            }
            sr.Close();
        }
    }
}
