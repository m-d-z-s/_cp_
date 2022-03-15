using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace кп_с_24._02
{
    
    public partial class Form1 : Form
    {
        int a, b, c, d;
        int [,] x;
        int[,] y;


        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            if (a == c && b == d)
            { 
                int[,] z = new int[a, b]; 
                for (int i = 0;i <a;i++)
                { 
                    for(int j = 0;j <b;j++)
                    {
                        z[i, j] = x[i, j] + y[i, j];
                        textBox7.Text += z[i, j] + " ";

                    }
                    textBox7.Text += "\r\n";

                }

            }
            else
            {
                MessageBox.Show("ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            if (b==c)
            {
                int[,] z = new int[a, d];
                for (int i = 0; i < a;i++)
                {
                    for (int j = 0; j < d;j++)
                    {
                        for (int k = 0; k < b;k++)
                        {
                            z[i, j] += x[i, k] * y[k, j]; 
т
                        }
                        textBox7.Text += z[i, j] + " ";
                    }
                    textBox7.Text += "\r\n";
                }
            }
            else
            {
                MessageBox.Show("ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            if (a == c && b == d)
            {
                int[,] z = new int[a, b];
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        z[i, j] = x[i, j] - y[i, j];
                        textBox7.Text += z[i, j] + " ";

                    }
                    textBox7.Text += "\r\n";

                }

            }
            else
            {
                MessageBox.Show("ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox7.Text = "";
                
                int[,] z = new int[b, a];
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        z[i, j] = x[j, i];
                        textBox7.Text += z[i, j] + " ";

                    }
                 textBox7.Text += "\r\n";

                }
            }
            else if (radioButton2.Checked == true)
            {
                textBox7.Text = "";

                int[,] z = new int[d, c];
                for (int i = 0; i < d; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        z[i, j] = y[j, i];
                        textBox7.Text += z[i, j] + " ";

                    }
                    textBox7.Text += "\r\n";

                }
            }
            else
            {
                MessageBox.Show("ошибка");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" || textBox6.Text != "" || textBox7.Text != "")
            {
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            a =  Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            d = Convert.ToInt32(textBox4.Text);
            x = new int[a, b];
            Random r = new Random();
            for (int i= 0; i < a; i++)
            {
                for (int j=0; j < b; j++)
                {
                    x[i,j] = r.Next(1,9);
                    textBox5.Text += x[i, j] + " " ;
                }
                textBox5.Text += "\r\n";

            }
            textBox6.Text = "";
            y = new int[c, d];
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    y[i, j] = r.Next(1, 9);
                    textBox6.Text += y[i, j] + " ";
                }
                textBox6.Text += "\r\n";

            }
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

        }
    }
}
