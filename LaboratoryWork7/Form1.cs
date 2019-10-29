using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork7
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
            dataGridView1.RowCount = 15; 
            dataGridView1.ColumnCount = 15; 
            int[,] a = new int[3, 4]; 
            int i, j;

            Random rand = new Random();
            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    a[i, j] = rand.Next(-100, 100);

            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);

            var sum = 0;
            for (i = 0; i < 3; i++)
            {
                sum += a[i, i];
            }
            a[2, 2] = sum;

            textBox1.Text = Convert.ToString(sum);

        }
    }
}
