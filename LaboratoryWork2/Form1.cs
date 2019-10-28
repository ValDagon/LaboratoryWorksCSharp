using System;
using System.Windows.Forms;

namespace LaboratoryWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            var x = 0.4 * Math.Pow(10, 4);
            XTextBox.Text = x.ToString();


            var y = -0.875;
            YTextBox.Text = y.ToString();

            var z = -0.475 * Math.Pow(10, -3);
            ZTextBox.Text = z.ToString();

            var w = (Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), (1 + 2 * Math.Pow(Math.Sin(y), 2)))) * (1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4);
            w = Math.Round(w, 4);
            WTextBox.Text = w.ToString();

            ResultTextBox.Text = "X: " + x + Environment.NewLine + "Y: " + y + Environment.NewLine + "Z: " + z + Environment.NewLine + "W:" + w.ToString();

        }
    }
}
