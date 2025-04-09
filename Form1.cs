using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        int num1=0;
        int num2;
        int num3=0;
        string op = "=";
        private void button10_Click(object sender, EventArgs e)
        {
            op = "+"; 
            if (textBox1.Text.Length > 0) 
            {      
                    num1 = Convert.ToInt32(textBox1.Text);
                    num2+= num1;
                    num1 = 0;
                   textBox1.Clear();
               
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op = "-";
            if (textBox1.Text.Length > 0)
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = num1-num2;
                num1 = 0;
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = "*";
            if (textBox1.Text != "")
            {
                
                num2= Convert.ToInt32(textBox1.Text);
                //num2=num2*num1;
                //num1 = 0;
                textBox1.Clear() ;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                num3 = Convert.ToInt32(textBox1.Text);
                if (op == "+")
                {
                    textBox1.Text = (num2+num3).ToString();
                    num2 = 0;
                    num3 = 0;
                }
               else if (op == "-")
                {
                    textBox1.Text = (num2-num3).ToString();
                    num2 = 0;
                    num3 = 0;
                }
                else if (op == "*")
                {
                    textBox1.Text = (num2 * num3).ToString();
                    num2 = 0;
                    num3 = 0;
                }
                else if (op == "/")
                {
                    if (num3 != 0)
                    {
                        textBox1.Text = (num2/num3).ToString();
                        num2 = 0;
                        num3 = 0;
                    }
                    else
                    {
                        string ms = "error";
                        textBox1.Text=ms;
                    }
                   
                }
                // textBox1.Clear();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
               num1=0; num2=0;num3 = 0;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op = "/";
            if (textBox1.Text != "")
                num1 = Convert.ToInt32(textBox1.Text);
            {
                if (num1 != 0)
                {

                    num2 /= num1;
                    num1 = 0;
                    textBox1.Clear();
                }
                else
                {
                    string ms = "error";
                    textBox1.Text=ms;
                }
            }
        }
    }
}
