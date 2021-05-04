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
        public Color color;
        public string color_Name;
        public int thickness;
        public int width;
        public int height;

        public FormSetting()
        {
            InitializeComponent();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            thickness =int.Parse(tbT.Text);
            width = int.Parse(tbW.Text);
            height = int.Parse(tbH.Text);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            DialogResult ret = dlg.ShowDialog();
            if (ret == DialogResult.Cancel) return;
            color = dlg.Color;
            color_Name = dlg.Color.Name;
            tbC.Text = dlg.Color.Name;
        }
    }
}
