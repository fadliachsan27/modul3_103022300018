using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3
{
    public partial class Form1: Form
    {
        String number;
        string angka1;
        String hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "1";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "2";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "3";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "4";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "5";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "6";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "7";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "8";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "9";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "0";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //angka1 = textBox1.Text;
            //number = "";
            //Console.WriteLine(angka1);
            Console.WriteLine();
            hasil = number;
            number = "+";
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //hasil = textBox1.Text;
            //number = "";
            //Console.WriteLine(hasil);
            Console.WriteLine();
            int result = Int32.Parse(number) + Int32.Parse(hasil);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }
    }
}
