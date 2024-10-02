using System;
using System.Windows.Forms;
using System.Threading;

namespace AbdullahHassanAbdo_Lab5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Thread threadgo;
        bool btnClose = true;
        private void button3_Click(object sender, EventArgs e)
        {
            threadgo = new Thread(go);
            threadgo.Start();
           
        }

       
        void go()
        {
            int i = 0;
            btnClose = true;
            do
            {
                for (i = 0; i < this.Width; i++)
                {
                    Invoke((Action)(() =>
                    {
                        button8.Left += 10;
                    }));

                    if (button8.Left > this.Width - 200)
                    {
                        break;
                    }
                    Thread.Sleep(100);

                }

                for (i = 0; i < button8.Left + 50; i++)
                {
                    Invoke((Action)(() =>
                    {
                        button8.Left -= 10;
                    }));

                    if (button8.Left > this.Width - 200)
                    {
                        break;
                    }
                    Thread.Sleep(100);

                }
            } while(btnClose);
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           btnClose = true;
            do
            {
                int i = 0;
                int first = button4.Top;
                for ( i = button4.Top; i < this.Height - button4.Height - 50; i++)
                {
                    if (button4.Top > this.Height - button4.Height - 50)
                    {
                        break;
                    }
                    button4.Top += 10;
                    Thread.Sleep(100);
                    Application.DoEvents();
                    
                }

                //while (button4.Top) { }

                for (i = 0; i < this.Height - button4.Height - 50 ; i++)
                {
                    if (button4.Top ==first)
                    {
                        break;
                    }
                    button4.Top -= 10;
                    Thread.Sleep(100);
                    Application.DoEvents();
                    
                }
            } while(btnClose);
          

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadgo != null)
            {
                threadgo.Abort();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnClose = false;
        }
    }
}
