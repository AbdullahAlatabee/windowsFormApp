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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Location =  new Point(15, 85);
            this.Height = btnsumation.Height + 80;
            this.Width = btnMinus.Left + btnMinus.Width + 450;
        }

        private void btnCloseMinus_Click(object sender, EventArgs e)
        {
            Form5_Load(null, null);
        }

        private void txtMinus1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        int z = 1;

        


        private void EventsButtons(int x)
        {
            if (x == 1)
            {
                if ((txtMinus1.Text.Trim() != "") && (txtMinus2.Text.Trim() != ""))
                {
                    ResultMinus.Text = Convert.ToString(Convert.ToInt32(txtMinus1.Text) -
                                                        Convert.ToInt32(txtMinus2.Text)
                                                       );
                }
                else
                    MessageBox.Show("Plese Enter the Number");
            }
            else if (x == 2)
            {
                if ((txtMinus1.Text.Trim() != "") && (txtMinus2.Text.Trim() != ""))
                {
                    ResultMinus.Text = Convert.ToString(Convert.ToInt32(txtMinus1.Text) +
                                                        Convert.ToInt32(txtMinus2.Text)
                                                       );
                }
                else
                    MessageBox.Show("Plese Enter the Number");
            }
            else if (x == 3)
            {
                if ((txtMinus1.Text.Trim() != "") && (txtMinus2.Text.Trim() != ""))
                {
                    ResultMinus.Text = Convert.ToString(Convert.ToInt32(txtMinus1.Text) *
                                                        Convert.ToInt32(txtMinus2.Text)
                                                       );
                }
                else
                    MessageBox.Show("Plese Enter the Number");
            }
            else if (x == 4)
            {
                if ((txtMinus1.Text.Trim() != "") && (txtMinus2.Text.Trim() != ""))
                {
                    if (txtMinus2.Text != "0")
                    {
                        ResultMinus.Text = Convert.ToString(Convert.ToInt32(txtMinus1.Text) /
                                                        Convert.ToInt32(txtMinus2.Text)
                                                       );
                    }
                    else
                        MessageBox.Show("Error You can not Divide by 0 !");

                }
                else
                    MessageBox.Show("Plese Enter the Number");
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BackColor = Color.SlateBlue;
            label3.Text = "-";
            this.Height = panel1.Height * 2 - 100;
            z = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BackColor = Color.Pink;
            label3.Text = "+";
            this.Height = panel1.Height * 2 - 100;
            z = 2;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BackColor = Color.Turquoise;
            label3.Text = "*";
            this.Height = panel1.Height * 2 - 100;
            z = 3;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BackColor = Color.IndianRed;
            label3.Text = "/";
            this.Height = panel1.Height * 2 - 100;
            z = 4;
        }

        private void btnCalcMinus_Click(object sender, EventArgs e)
        {
            EventsButtons(z);
            z = 2;
        }
    }
}
