using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LaboratoryWork8
{
    public partial class Form1 : Form
    {
        private readonly double y = -0.875;
        private readonly double z = -0.475 * Math.Pow(10, -3);

        private readonly double XMin = 0.4 * Math.Pow(10, 4);

        private readonly double XMax = 0.4 * Math.Pow(10, 4) + 100;

        private readonly double Step = 10;

        private double[] x;

        private double[] w;
        private Chart chart;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcFunction()
        {
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;

            x = new double[count];
            w = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = XMin + Step * i;
                w[i] = (Math.Pow(Math.Abs(Math.Cos(x[i]) - Math.Cos(y)), (1 + 2 * Math.Pow(Math.Sin(y), 2)))) 
                        * (1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4);
            }
        }

        private void CreateChart()
        {

            chart = new Chart
            {
                Parent = this
            };

            chart.SetBounds(0, 0, ClientSize.Width - 10,
                            ClientSize.Height - 10);

            ChartArea area = new ChartArea
            {
                Name = "myGraph"
            };

            area.AxisX.Minimum = XMin;
            area.AxisX.Maximum = XMax;

            area.AxisX.MajorGrid.Interval = Step;

            chart.ChartAreas.Add(area);

            Series series1 = new Series
            {
                ChartArea = "myGraph",

                ChartType = SeriesChartType.Spline,

                BorderWidth = 3,

                LegendText = "W(x)"
            };

            chart.Series.Add(series1);

            Legend legend = new Legend();
            chart.Legends.Add(legend);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateChart();

            CalcFunction();

            chart.Series[0].Points.DataBindXY(x, w);
        }
    }
}
