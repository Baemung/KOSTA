using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManagerEx
{
    public partial class InputForm : Form
    {

        public string input;
        public InputForm(string args)
        {
            InitializeComponent();
            lbInput.Text = args;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            input = tbInput.Text;
        }
    }
}
