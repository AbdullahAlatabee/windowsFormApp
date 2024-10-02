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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
                label3.ForeColor = Color.Red;
            else if (radioButton7.Checked)
                label3.ForeColor = Color.Yellow;
            else if (radioButton6.Checked)
                label3.ForeColor = Color.Green;
            else
                label3.ForeColor = Color.Black;

            if (radioButton1.Checked)
                label3.BackColor = Color.Red;
            else if (radioButton2.Checked)
                label3.BackColor = Color.Yellow;
            else if (radioButton3.Checked)
                label3.BackColor = Color.Green;
            else
                label3.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            // bool f=false;
            if (checkBox1.Checked)
                x += Convert.ToInt32(checkBox1.Text);
            if (checkBox2.Checked)
                x += Convert.ToInt32(checkBox2.Text);
            if (checkBox3.Checked)
                x += Convert.ToInt32(checkBox3.Text);
            if (checkBox4.Checked)
                x += Convert.ToInt32(checkBox4.Text);
            if (checkBox5.Checked)
                x += Convert.ToInt32(checkBox5.Text);

            textBox1.Text = x.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
