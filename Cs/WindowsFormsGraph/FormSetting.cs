using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraph
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        public int thickness;
        public string color;
        public int width;
        public int height;

        private void btnOption_Click(object sender, EventArgs e)
        {
            thickness =int.Parse(tbT.Text);
            color = tbC.SelectedItem.ToString();
            width = int.Parse(tbW.Text);
            height = int.Parse(tbH.Text);
        }
    }
}
