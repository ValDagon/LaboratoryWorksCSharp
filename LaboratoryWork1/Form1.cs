using System;
using System.Windows.Forms;

namespace LaboratoryWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InvisibleButton_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

    }
}
