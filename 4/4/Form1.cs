using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public int r=0;
        public Graphics g;
        public SolidBrush br;
        public Bitmap bmp;
        public Graphics gb;
        public float y, x,x1,y1,x2,y2,x3,y3;
        public bool d = true;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gb = Graphics.FromImage(bmp);
            br = new SolidBrush(Color.Purple);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                pictureBox1.Refresh();
                g.FillEllipse(br, x - 10, y - 10, 20, 20);
                y += 10;
            if (y > pictureBox1.Height + 10)
                timer1.Stop();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            g.FillEllipse(br, x1 - 10, y1 - 10, 20, 20);
            y1 += 10;
            if (y1 > pictureBox1.Height + 5)
                timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            g.FillEllipse(br, x2 - 10, y2 - 10, 20, 20);
            y2 += 10;
            if (y2 > pictureBox1.Height + 5)
                timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            g.FillEllipse(br, x3 - 10, y3 - 10, 20, 20);
            y3 += 10;
            if (y3 > pictureBox1.Height + 5)
                timer4.Stop();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            r++;
            if (r == 5)
                r = 1;
            if (r == 1)
            {
                x = e.X;
                y = e.Y;
                gb.FillEllipse(br, x - 10, y - 10, 20, 20);
                timer1.Start();
            }
            if (r == 2)
            {
                x1 = e.X;
                y1 = e.Y;
                gb.FillEllipse(br, x1 - 10, y1 - 10, 20, 20);
                timer2.Start();
            }
            if (r == 3)
            {
                x2 = e.X;
                y2 = e.Y;
                gb.FillEllipse(br, x2 - 10, y2 - 10, 20, 20);
                timer3.Start();
            }
            if (r == 4)
            {
                x3 = e.X;
                y3 = e.Y;
                gb.FillEllipse(br, x3 - 10, y3 - 10, 20, 20);
                timer4.Start();
            }
        }
    }
}
