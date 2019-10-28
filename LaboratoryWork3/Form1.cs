using System;
using System.Windows.Forms;

namespace LaboratoryWork3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultTextBox.Clear();
            // Получение исходных данных из TextBox
            double x = Convert.ToDouble(XTextBox.Text);
            double y = Convert.ToDouble(YTextBox.Text);
            double z = Convert.ToDouble(ZTextBox.Text);

            // Ввод исходных данных в окно результатов
            ResultTextBox.Text += "При X = " + XTextBox.Text + Environment.NewLine;
            ResultTextBox.Text += "При Y = " + YTextBox.Text + Environment.NewLine;
            ResultTextBox.Text += "При Z = " + ZTextBox.Text + Environment.NewLine;

            // Определение номера выбранной функции
            int RadioButtonValue = 0;
            if (radioButton1.Checked) RadioButtonValue = 0;
            else if (radioButton2.Checked) RadioButtonValue = 1;
            else if (radioButton3.Checked) RadioButtonValue = 2;

            // Вычисление U
            double u = 0;
            double Fx;
            switch (RadioButtonValue)
            {
                case 0:
                    Fx = Math.Sin(x);
                    if (x > y)
                    {
                        u = (Math.Pow((Fx - y), 3)) + Math.Atan(Fx);
                    }
                    else if (y > x)
                    {
                        u = Math.Pow((y - Fx), 3) + Math.Atan(Fx);
                    }
                    else if (y == x)
                    {
                        u = Math.Pow((y - Fx), 3) + 0.5;
                    }
                    ResultTextBox.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;

                case 1:
                    Fx = Math.Cos(x);
                    if (x > y)
                    {
                        u = (Math.Pow((Fx - y), 3)) + Math.Atan(Fx);
                    }
                    else if (y > x)
                    {
                        u = Math.Pow((y - Fx), 3) + Math.Atan(Fx);
                    }
                    else if (y == x)
                    {
                        u = Math.Pow((y - Fx), 3) + 0.5;
                    }
                    ResultTextBox.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;

                case 2:
                    Fx = Math.Exp(x);
                    if (x > y)
                    {
                        u = (Math.Pow((Fx - y), 3)) + Math.Atan(Fx);
                    }
                    else if (y > x)
                    {
                        u = Math.Pow((y - Fx), 3) + Math.Atan(Fx);
                    }
                    else if (y == x)
                    {
                        u = Math.Pow((y - Fx), 3) + 0.5;
                    }
                    ResultTextBox.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;
                default:
                    ResultTextBox.Text += "Решение не найдено" + Environment.NewLine;
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultTextBox.Clear();
        }
    }
}
