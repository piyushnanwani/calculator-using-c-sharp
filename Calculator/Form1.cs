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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        private void button00_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }
        private void button_equal_Click(object sender, EventArgs e)
        {
            int i = 0;
            string str = textBox1.Text;
            int len = str.Length;
            while(i!=len && !str[i].Equals("-")  )
            {
                Console.WriteLine(str[i]);
                Console.WriteLine("hey");
                i++;
            }
        }
        private void button_mult_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }
        private void button_sub_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }
        private void button_divide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }
        private void button_AC_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button_divide_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }




    }
}
