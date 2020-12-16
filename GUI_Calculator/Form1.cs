using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double num1, num2, result;
        int choice;

        private void bac_Click(object sender, EventArgs e)
        {
            display.Clear();
            choice = 0;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 0;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 1;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 2;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 3;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 6;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 9;
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void badd_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Clear();
            display.Focus();
            choice = 1;
        }

        private void bmin_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Clear();
            display.Focus();
            choice = 2;
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Clear();
            display.Focus();
            choice = 3;
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Clear();
            display.Focus();
            choice = 4;
        }

        private void bsin_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Text = System.Convert.ToString("sin" + "(" + (display.Text) + ")");
            choice = 5;
        }

        private void bcos_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Text = System.Convert.ToString("cos" + "(" + (display.Text) + ")");
            choice = 6;
        }

        private void bpow_Click_1(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Clear();
            display.Focus();
            choice = 7;
        }

        private void bmod_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Clear();
            display.Focus();
            choice = 8;
        }

        private void blog_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Text = System.Convert.ToString("log" + "(" + (display.Text) + ")");
            choice = 9;
        }

        private void bsqrt_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            display.Text = System.Convert.ToString("sqrt" + "(" + (display.Text) + ")");
            choice = 10;
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void beq_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    num2 = double.Parse(display.Text);
                    result = num1 + num2;
                    display.Text = result.ToString();
                    break;
                case 2:
                    num2 = double.Parse(display.Text);
                    result = num1 - num2;
                    display.Text = result.ToString();
                    break;
                case 3:
                    num2 = double.Parse(display.Text);
                    result = num1 * num2;
                    display.Text = result.ToString();
                    break;
                case 4:
                    num2 = double.Parse(display.Text);
                    if (num2 == 0)
                    {
                        display.Text = "Cannot Divide by Zero";
                    }
                    else
                    {
                        result = (num1 / num2);
                        display.Text = result.ToString();
                        num1 = result;
                    }
                    break;
                case 5:
                    result = Math.Sin((num1));
                    display.Text = "sin(" + num1 + ")" + " = " + result.ToString();
                    break;
                case 6:
                    result = Math.Cos((num1));
                    display.Text = "cos(" + num1 + ")" + " = " + result.ToString();
                    break;
                case 7:
                    num2 = double.Parse(display.Text);
                    result = Math.Pow(num1, num2);
                    display.Text = "pow(" + num1 + "," + num2 + ")" + " = " + result.ToString();
                    break;
                case 8:
                    num2 = double.Parse(display.Text);
                    result = num1 % num2;
                    display.Text =  num1 + " mod " + num2 + " = " + result.ToString();
                    break;
                case 9:
                    result = Math.Log10(num1);
                    display.Text = "log(" + num1 + ")" + " = " + result.ToString();
                    break;
                case 10:
                    result = Math.Sqrt(num1);
                    display.Text = "sqrt(" + num1 + ")" + " = " + result.ToString();
                    break;

                default:
                    break;
            }
        }
    }
}