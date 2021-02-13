using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float A = 0;
        string op = "";
        private void button10_Click(object sender, EventArgs e)
        {
            A = Convert.ToSingle(textBox1.Text);
            label1.Text = A + "+";
            textBox1.Clear();
            op = "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            A = Convert.ToSingle(textBox1.Text);
            label1.Text = A + "-";
            textBox1.Clear();
            op = "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            A = Convert.ToSingle(textBox1.Text);
            label1.Text = A + "*";
            textBox1.Clear();
            op = "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            A = Convert.ToSingle(textBox1.Text);
            label1.Text = A + ":";
            textBox1.Clear();
            op = "4";
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

        private void button14_Click(object sender, EventArgs e)
        {
            if (op == "1")
            {
               textBox1.Text = (A + Convert.ToSingle(textBox1.Text)).ToString();
                label1.Text = "";
            }
            if (op == "2")
            {
                textBox1.Text = (A - Convert.ToSingle(textBox1.Text)).ToString();
                label1.Text = "";
            }
            if (op == "3")
            {
                textBox1.Text = (A * Convert.ToSingle(textBox1.Text)).ToString();
                label1.Text = "";
            }
            if (op == "4")
            {
                textBox1.Text = (A / Convert.ToSingle(textBox1.Text)).ToString();
                label1.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
           textBox1.Text = (Math.Sqrt(Convert.ToSingle(textBox1.Text))).ToString();
            label1.Text = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(delegate () { ColorCicle(5, 255); });
            thread.Start();
            void ColorCicle(int time, int alpha)
            {
                int red = 255;
                int green = 0;
                int blue = 0;
                for (; ; )
                {
                    //255;0;0
                    for (int g = 0; g < 255; g++)
                    {
                        green = g;
                        try { this.Invoke((MethodInvoker)delegate () { this.BackColor = Color.FromArgb(alpha, red, green, blue); }); } catch { }
                        
                        Thread.Sleep(time);
                    }
                    //255;255;0
                    for (int r = 255; r >= 0; r--)
                    {
                        red = r;
                        try { this.Invoke((MethodInvoker)delegate () { this.BackColor = Color.FromArgb(alpha, red, green, blue); }); } catch { }
                        Thread.Sleep(time);
                    }
                    //0;255;0
                    for (int b = 0; b < 255; b++)
                    {
                        blue = b;
                        try { this.Invoke((MethodInvoker)delegate () { this.BackColor = Color.FromArgb(alpha, red, green, blue); }); } catch { }
                        Thread.Sleep(time);
                    }
                    for (int g = 255; g >= 0; g--)
                    {
                        green = g;
                        try { this.Invoke((MethodInvoker)delegate () { this.BackColor = Color.FromArgb(alpha, red, green, blue); }); } catch { }
                        Thread.Sleep(time);
                    }
                    for (int b = 254; b >= 0; b--)
                    {
                        blue = b;
                        red++;
                        try { this.Invoke((MethodInvoker)delegate () { this.BackColor = Color.FromArgb(alpha, red, green, blue); }); } catch { }
                        Thread.Sleep(time);
                    }
                }
            }
        }
    }
}
