using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager
{
    public partial class addCol : Form
    {
        public string cName;
        public string cType;

        public addCol()
        {
            InitializeComponent();
        }

        private void btnAddcol_Click(object sender, EventArgs e)
        {
            cName = tbCN.Text;
            cType = cbDT.SelectedItem.ToString();
        }

        private void tbCN_TextChanged(object sender, EventArgs e)
        {
            if(tbCN.Text != "")
            {
                btnAddcol.Enabled = true;
            }
            else
            {
                btnAddcol.Enabled = false;
            }

        }
    }
}
