using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int l=0;
        private void button1_Click(object sender, EventArgs e)
        {
            int n =int.Parse(button1.Text);
            n += 1;
            button1.Text = n.ToString();
            if (n % 2 == 0)
            {
                l++;
                textBox1.Text = l.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(button2.Text);
            n += 1;
            button2.Text = n.ToString();
            if (n % 2 == 0)
            {
                l++;
                textBox1.Text = l.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(button3.Text);
            n += 1;
            button3.Text = n.ToString();
            if (n % 2 == 0)
            {
                l++;
                textBox1.Text = l.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = int.Parse(button6.Text);
            n += 1;
            button6.Text = n.ToString();
            if (n % 2 == 0)
            {
                l++;
                textBox1.Text = l.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = int.Parse(button5.Text);
            n += 1;
            button5.Text = n.ToString();
            if (n % 2 == 0)
            {
                l++;
                textBox1.Text = l.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(button4.Text);
            n += 1;
            button4.Text = n.ToString();
            if (n % 2 == 0)
            {
                l++;
                textBox1.Text = l.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n = int.Parse(button9.Text);
            n += 1;
            button9.Text = n.ToString();
            if (n % 2 == 0)
            {
                l++;
                textBox1.Text = l.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = int.Parse(button8.Text);
            n += 1;
            button8.Text = n.ToString();
            if (n % 2 == 0)
            {
                l++;
                textBox1.Text = l.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n = int.Parse(button7.Text);
            n += 1;
            button7.Text = n.ToString();
            if (n % 2 == 0)
            {
                l++;
                textBox1.Text = l.ToString();
            }
        }
    }
}
