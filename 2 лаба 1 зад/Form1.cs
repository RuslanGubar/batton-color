using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_лаба_1_зад
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "щелчок на кнопке 1";
            textBox1.ForeColor = System.Drawing.Color.Red;
            button1.ForeColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "щелчок на кнопке 2";
            textBox1.ForeColor = System.Drawing.Color.Blue;
            button2.ForeColor = System.Drawing.Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "щелчок на кнопке 3";
            textBox1.ForeColor = System.Drawing.Color.Green;
            button3.ForeColor = System.Drawing.Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "щелчок на кнопке 4";
            textBox1.ForeColor = System.Drawing.Color.Magenta;
            button4.ForeColor = System.Drawing.Color.Magenta;
        }
    }
}
