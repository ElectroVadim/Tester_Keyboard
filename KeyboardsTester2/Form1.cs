using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace KeyboardsTester2
{

    
    public partial class Form1 : Form
    {



        public Form1()
        {

            this.Activate();
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button11.Click += new System.EventHandler(this.button11_Click);
            this.button12.Click += new System.EventHandler(this.button12_Click);


        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G) 
            {
                button1.BackColor = Color.Gray;
            }
            
            

            if (e.KeyCode == Keys.F5)
            {
                //button2.PerformClick();

                button2.BackColor = Color.Gray;
            }
           

            if (e.KeyCode == Keys.F6)
            {
                //button3.PerformClick();

                button3.BackColor = Color.Gray;
            }
           

            if (e.KeyCode == Keys.F7)
            {
                //button4.PerformClick();

                button4.BackColor = Color.Gray;
            }
          
            if (e.KeyCode == Keys.F8)
            {
                //button5.PerformClick();

                button5.BackColor = Color.Gray;
            }
         
            

            if (e.KeyCode == Keys.F9)
            {
                //button6.PerformClick();
                button6.BackColor = Color.Gray;
            }
          

            if (e.KeyCode == Keys.F12)
            {
               // button7.PerformClick();
                 button7.BackColor = Color.Gray;
            }
         
            if (e.KeyCode == Keys.F11)
            {
               // button8.PerformClick();

                 button8.BackColor = Color.Gray;
            }
          


            if (e.KeyCode == Keys.Space)
            {
                //button9.PerformClick();
                button9.BackColor = Color.Gray;
            }
            

            if (e.KeyCode == Keys.F4)
            {
               // button10.PerformClick();

             button10.BackColor = Color.Gray;
            }
          


            if (e.KeyCode == Keys.F10)
            {
                //button11.PerformClick();

                button11.BackColor = Color.Gray;
            }
           

            if (e.KeyCode == Keys.F3)
            {
                //button12.PerformClick();

             button12.BackColor = Color.Gray;
            }
          

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.G) 
            {
                button1.BackColor = Color.Gold;
            }
            else
            {
                button1.BackColor = Color.Gray;
            }


            if (e.KeyCode == Keys.F5)
            {
                //button2.PerformClick();

                button2.BackColor = Color.Gold;
            }
            else
            {
                button2.BackColor = Color.Gray;
            }

            if (e.KeyCode == Keys.F6)
            {
                //button3.PerformClick();

                button3.BackColor = Color.Gold;
            }
            else
            {
                button3.BackColor = Color.Gray;
            }

            if (e.KeyCode == Keys.F7)
            {
                //button4.PerformClick();

                button4.BackColor = Color.Gold;
            }
            else
            {
                button4.BackColor = Color.Gray;
            }
            if (e.KeyCode == Keys.F8)
            {
                //button5.PerformClick();

                button5.BackColor = Color.Gold;
            }
            else
            {
                button5.BackColor = Color.Gray;
            }
            

            if (e.KeyCode == Keys.F9)
            {
                //button6.PerformClick();
                button6.BackColor = Color.Gold;
            }
            else
            {
                button6.BackColor = Color.Gray;
            }

            if (e.KeyCode == Keys.F12)
            {
               // button7.PerformClick();
                 button7.BackColor = Color.Gold;
            }
            else
            {
                button7.BackColor = Color.Gray;
            }

            if (e.KeyCode == Keys.F11)
            {
               // button8.PerformClick();

                 button8.BackColor = Color.Gold;
            }
            else
            {
                button8.BackColor = Color.Gray;
            }


            if (e.KeyCode == Keys.Space)
            {
                //button9.PerformClick();
                button9.BackColor = Color.Gold;
            }
            else
            {
                button9.BackColor = Color.Gray;
            }

            if (e.KeyCode == Keys.F4)
            {
               // button10.PerformClick();

             button10.BackColor = Color.Gold;
            }
            else
            {
                button10.BackColor = Color.Gray;
            }


            if (e.KeyCode == Keys.F10)
            {
                //button11.PerformClick();

                button11.BackColor = Color.Gold;
            }
            else
            {
                button11.BackColor = Color.Gray;
            }

            if (e.KeyCode == Keys.F3)
            {
                //button12.PerformClick();

             button12.BackColor = Color.Gold;
            }
            else
            {
                button12.BackColor = Color.Gray;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
           

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сработала F2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сработала F1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сработала F3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Сработала F4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сработала F5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сработала F8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сработала F9");
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сработала F10");


           
                //Thread.Sleep(200);

                //SendKeys.Send("{F10}");

                //button10.BackColor = Color.Gold;
           
                //this.Activate();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сработала F11");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сработала F12");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show("Сработала F7");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
