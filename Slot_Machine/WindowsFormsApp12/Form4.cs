using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form4 : Form
    {
        Random r = new Random();
        int bet;
        int sumlos=0;
        int sumwin=0;
        int pic1;
        int pic2;
        int pic3;
        int period=0;
        public Form4()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            period = period + 100;
            

            if (period <= 400)
            {
                pic1 = r.Next(4);
                pic2 = r.Next(4);
                pic3 = r.Next(4);
                if (pic1 == 0)
                {
                    pictureBox1.ImageLocation = "pear.jpg";
                }
                else if (pic1 == 1)
                {
                    pictureBox1.ImageLocation = "Apple.jpg";
                }
                else if (pic1 == 2)
                {
                    pictureBox1.ImageLocation = "fraoula.jpg";
                }
                else if (pic1 == 3)
                {
                    pictureBox1.ImageLocation = "Diamond.jpg";
                }
                if (pic2 == 0)
                {
                    pictureBox2.ImageLocation = "pear.jpg";
                }
                else if (pic2 == 1)
                {
                    pictureBox2.ImageLocation = "Apple.jpg";
                }
                else if (pic2 == 2)
                {
                    pictureBox2.ImageLocation = "fraoula.jpg";
                }
                else if (pic2 == 3)
                {
                    pictureBox2.ImageLocation = "Diamond.jpg";
                }
                if (pic3 == 0)
                {
                    pictureBox3.ImageLocation = "pear.jpg";
                }
                else if (pic3 == 1)
                {
                    pictureBox3.ImageLocation = "Apple.jpg";
                }
                else if (pic3 == 2)
                {
                    pictureBox3.ImageLocation = "fraoula.jpg";
                }
                else if (pic3 == 3)
                {
                    pictureBox3.ImageLocation = "Diamond.jpg";
                }  
            }
            else
            {
                period = 0;
                timer1.Enabled = false;
                check();
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pic1 = r.Next(4);
            pic2 = r.Next(4);
            pic3 = r.Next(4);
            bet = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text!=null)
            {
               
                sumwin = bet + sumwin;
                sumlos = sumlos - bet;
                

            }


            else
            {
                MessageBox.Show("Please enter your bet");
            }
                


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            label2.Text = Form1.User;
            pictureBox1.ImageLocation = "fraoula.jpg";
            pictureBox2.ImageLocation = "pear.jpg";
            pictureBox3.ImageLocation = "Apple.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(label1.Text);
            f2.Show();
            this.Hide();
        }
        private void check()
        {
            if (pic1==pic2 && pic2 == pic3)
            {
                MessageBox.Show("You are awesome");
                label6.Text = sumwin.ToString();
            }
            else
            {
                MessageBox.Show("Try your luck again");
                label7.Text = sumlos.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
