using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbdullahHassanAbdo_Lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = this.Width + 100;
            this.Height = this.Height + 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnPlayer.Top -= 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnPlayer.Top += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnPlayer.Left -= 5;
            //btnPlayer.Location = new Point(btnPlayer.Left - 5, btnPlayer.Top);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnPlayer.Left += 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnPlayer.Width += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnPlayer.Width -= 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPlayer.Height += 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnPlayer.Height -= 5;
        }
    }
}
