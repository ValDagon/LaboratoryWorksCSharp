using System;
using System.Windows.Forms;

namespace LaboratoryWorks5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Количество цифр в строке: ";

            foreach (char c in listBox1.SelectedItem.ToString())
            {
                if (Char.IsDigit(c)) label1.Text +=  c.ToString();
            }
        }
    }
}
