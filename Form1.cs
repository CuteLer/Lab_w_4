using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public double func(double x)
        {
            return 9 * Math.Pow(x, 4) + Math.Sin(57.2 + x);
        }

        double x1, x2, dx;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Text = "Работу выпонила студентка Михайловская В.А.";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text += Environment.NewLine;
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    throw new Exception("Введите все значения.");
                x1 = double.Parse(textBox1.Text.Replace('.', ','));
                x2 = double.Parse(textBox2.Text.Replace('.', ','));
                dx = double.Parse(textBox3.Text.Replace('.', ','));
                if (dx == 0)
                    throw new Exception("Неверный шаг.");
                if (x1 > x2)
                    for (double i = x1; i >= x2; i += dx)
                    {
                        textBox4.Text += "x = " + i + ";\ty = " + func(i) + Environment.NewLine;
                    }
                else
                    if (x1 < x2)
                        for (double i = x1; i <= x2; i += dx)
                        {
                            textBox4.Text += "x = " + i + ";\ty = " + func(i) + Environment.NewLine;
                        }
                    else
                        textBox4.Text += "x = " + x1 + ";\ty = " + func(x1) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
