using System;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph.Graph obj = new Graph.Graph();
            float x = 0;
            if (!Single.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Строка содержит неправильное число", "Ошибка");
                return;
            }
            double y = obj.Task(Convert.ToDouble(textBox1.Text));
            if (y != double.NaN)
            {
                label2.Text = String.Format("y= {0:0.00}", Convert.ToDouble(y));
            }
            else { MessageBox.Show("X не принадлежит графику функции", "Ошибка");}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }
    }
}
