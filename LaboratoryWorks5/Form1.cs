using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int count = 0;

            foreach (char c in listBox1.SelectedItem.ToString())
            {
                if (Char.IsDigit(c)) count += 1;

                label1.Text = "Количество символов в строке: " + count.ToString();
            }
        }
    }
}
