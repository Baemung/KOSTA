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
    public partial class FormPicture : Form
    {
        Graphics GDC;
        // Default Setting
        Color color = Color.Red;
        int thickness = 3;
        int width = 10;
        int height = 10;

        public FormPicture()
        {
            InitializeComponent();

            GDC = CanvasDraw.CreateGraphics(); //그래픽컨트롤을 받음
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen pp = new Pen(color, thickness); //default
                GDC.DrawEllipse(pp, e.X, e.Y, width, height); //default
            }
        }

        private void CanvasDraw_Resize(object sender, EventArgs e)
        {
            GDC = CanvasDraw.CreateGraphics();
        }

        private void mnuErase_Click(object sender, EventArgs e)
        {
            GDC.Clear(DefaultBackColor);
        }

        private void munOption_Click(object sender, EventArgs e)
        {
            FormSetting fs = new FormSetting();
            DialogResult ret = fs.ShowDialog();
            if (ret == DialogResult.Cancel) return;

            color = Color.FromName(fs.color);
            thickness = fs.thickness;
            width = fs.width;
            height = fs.height;
        }
    }
}
