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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.Visible=panel2.Visible=panel3.Visible=panel4.Visible=false;
            panel1.Location = panel2.Location = panel3.Location = panel4.Location=new Point(15, 85);
            this.Height = btnSumation.Height + 80;
            this.Width = btnMinus.Left + btnMinus.Width + 350;

            // لقد قمنا بإستخدام فكرة التضعيف للأزرار

            //btnCloseDiv.Click += btnCloseMinus_Click;
            //btnClosePlus.Click += btnCloseMinus_Click;
            //btnCloseMulti.Click += btnCloseMinus_Click;

            // لقد قمنا بإستخدام فكرة التضعيف لصناديق النصوص

        }

        private void btnCloseMinus_Click(object sender, EventArgs e)
        {
            Form4_Load(null, null);
        }

        private void txtMinus1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            this.Height = panel3.Height * 2;
        }

       

        private void btnMinus_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            this.Height = panel1.Height * 2;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            this.Height = panel4.Height * 2;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            this.Height = panel2.Height * 2;
        }

        // This Function To do all events in one event
        private void EventsButtons(int x)
        {
            if(x == 1)
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
                if ((txtPlus1.Text.Trim() != "") && (txtPlus2.Text.Trim() != ""))
                {
                    ResultPlus.Text = Convert.ToString(Convert.ToInt32(txtPlus1.Text) +
                                                        Convert.ToInt32(txtPlus2.Text)
                                                       );
                }
                else
                    MessageBox.Show("Plese Enter the Number");
            }
            else if(x == 3)
            {
                if ((txtMult1.Text.Trim() != "") && (txtMult2.Text.Trim() != ""))
                {
                    ResultMult.Text = Convert.ToString(Convert.ToInt32(txtMult1.Text) *
                                                        Convert.ToInt32(txtMult2.Text)
                                                       );
                }
                else
                    MessageBox.Show("Plese Enter the Number");
            }
            else if (x == 4)
            {
                if ((txtDiv1.Text.Trim() != "") && (txtDiv1.Text.Trim() != ""))
                {
                    if (txtDiv2.Text != "0")
                    {
                        ResultDiv.Text = Convert.ToString(Convert.ToInt32(txtDiv1.Text) /
                                                        Convert.ToInt32(txtDiv2.Text)
                                                       );
                    }
                    else
                        MessageBox.Show("Error You can not Divide by 0 !");

                }
                else
                    MessageBox.Show("Plese Enter the Number");
            }
              
        }

        private void btnCalcMinus_Click(object sender, EventArgs e)
        {
            EventsButtons(1);
        }

        private void btnCalcuBlus_Click(object sender, EventArgs e)
        {
            EventsButtons(2);
        }

        private void btnCalcuMulti_Click(object sender, EventArgs e)
        {
            EventsButtons(3);
        }

        private void btnCalcuDiv_Click(object sender, EventArgs e)
        {
            EventsButtons(4);
        }
    }
}
