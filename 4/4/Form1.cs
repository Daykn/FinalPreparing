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
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gb = Graphics.FromImage(bmp);
            br = new SolidBrush(Color.Purple);
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            gb.FillEllipse(br, e.X,e.Y, 20, 20);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gb.FillEllipse(br, e.X-10, e.Y-10, 20, 20);
            pictureBox1.Image = bmp;
        }
    }
}
