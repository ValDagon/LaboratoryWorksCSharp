using System;
using System.Windows.Forms;

namespace LaboratoryWork6
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[15];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 15; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            int min = Mas[0];
            for (int i = 0; i < Mas.Length; i++)
            {
                if (min > Mas[i])
                {
                    min = Mas[i];
                }
            }

            int index_min = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i] == min)
                {
                    index_min = i;
                }
            }

            int temp = Mas[0];
            Mas[index_min] = temp;
            Mas[0] = min;

            for (int i = 0; i < Mas.Length; i++)
            {
                textBox2.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
            }

        }
    }

}
