using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = num1 + num2;

            label5.Text = res.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = num1 - num2;

            label5.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = num1 * num2;

            label5.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = num1 / num2;

            label5.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
