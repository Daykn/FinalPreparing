using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static int n;
        private void button1_Click(object sender, EventArgs e)
        {
            n = 2;
            if (n == 1)
            {
                button1.BackColor = Color.Yellow;
                n = 2;
            }
            if (n == 2)
            {
                button1.BackColor = Color.Blue;
                n = 3;
            }
            if (n == 3)
            {
                button1.BackColor = Color.Red;
                n = 1;
            }
        }
        
    }
}
