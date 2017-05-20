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
        public Graphics g;
        public SolidBrush br;
        public Bitmap bmp;
        public Graphics gb;
        public float y, x=-12;
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
            if (d)
            {
                pictureBox1.Refresh();
                g.FillEllipse(br, x - 10, y - 10, 20, 20);
                y += 10;
            }
            if (y > pictureBox1.Height+10)
                d = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            d = true;
            x=e.X;
            y = e.Y;
            gb.FillEllipse(br, x-10, y-10, 20, 20);
            //pictureBox1.Image = bmp;
            timer1.Start();
        }
    }
}
