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
        Color color = Color.Black;
        int thickness = 1;
        int width = 10;
        int height = 10;

        public FormPicture()
        {
            InitializeComponent();

            GDC = CanvasDraw.CreateGraphics(); //그래픽컨트롤을 받음
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

        Point P1, P2;
        string dMode;
        int is_Draw_mode;
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            P1 = new Point(e.X, e.Y);
            if(dMode == "Draw Line") is_Draw_mode = 1;
            else if (dMode == "Draw Circle") is_Draw_mode = 2;
            else if (dMode == "Draw Arc")  is_Draw_mode = 3;

            if(is_Draw_mode == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Pen pp = new Pen(color, thickness); //default
                    GDC.DrawEllipse(pp, e.X - width / 2, e.Y - height / 2, width, height); //default
                }
            }          
        }

        private void CanvasDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_Draw_mode == 1)
            {
                Pen pp = new Pen(color, thickness);
                P2 = new Point(e.X, e.Y);
                GDC.DrawLine(pp, P1, P2);
                P1 = P2;
            }
            
            else if(is_Draw_mode == 3)
            {
                Pen pp = new Pen(color, thickness);
                GDC.DrawArc(pp, e.X, e.Y, width, height, 30, 60);
            }

            sl1.Text = $"( X : {e.X},  Y : {e.Y} )   ";
            sl2.Text = $"Mode : {dMode}   ";
            sl3.Text = $"Option : {color}  size : {thickness} pts   w : {width}  h : {height}";
        }

        private void CanvasDraw_MouseUp(object sender, MouseEventArgs e)
        {
            is_Draw_mode = 0;
        }

        private void mnuDrawLine_Click(object sender, EventArgs e)
        {
            dMode = "Draw Line";
        }

        private void mnuDrawCircle_Click(object sender, EventArgs e)
        {
            dMode = "Draw Circle";
        }

        private void mnuDrawArc_Click(object sender, EventArgs e)
        {
            dMode = "Draw Arc";
        }
    }
}
