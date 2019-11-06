using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        const float PI = (float)Math.PI;
        readonly Timer tmr = new Timer() { Interval = 25 };
        readonly GraphicsPath sinusoid;
        int n;
        public Form1()
        {
            InitializeComponent()
                ;
            pictureBox1.Paint += pictureBox1_Paint;
            tmr.Tick += Tmr_Tick;
            sinusoid = new GraphicsPath();
            n = 0;
            CreateSinusoid(sinusoid, 10f * PI, pictureBox1.ClientSize);

            tmr.Start();
        }

        void Tmr_Tick(object sender, EventArgs e)
        {
            if (++n >= sinusoid.PointCount) n = 0;
            pictureBox1.Refresh();
        }

        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (sinusoid.PointCount == 0) return;
            PointF pt = sinusoid.PathPoints[n];
            e.Graphics.ScaleTransform(1, -1);
            e.Graphics.TranslateTransform(5, -pictureBox1.Height / 2);
            e.Graphics.DrawPath(Pens.Black, sinusoid);
            e.Graphics.FillEllipse(Brushes.Red, RectangleF.FromLTRB(pt.X - 15, pt.Y - 15, pt.X + 15, pt.Y + 15));
        }

        private void CreateSinusoid(GraphicsPath gp, float MaxX, Size size)
        {
            gp.Reset();
            PointF[] points = new PointF[1] { PointF.Empty };
            for (float i = 0; i <= MaxX; i += 0.1f)
            {
                points[points.GetUpperBound(0)] = new PointF(i, (float)Math.Sin(i));
                Array.Resize<PointF>(ref points, points.Length + 1);
            }
            Array.Resize<PointF>(ref points, points.Length - 1);
            gp.AddCurve(points);
            Matrix m = new Matrix();
            m.Scale(size.Width / MaxX, 0.5f * size.Height);
            gp.Transform(m);
        }
    }
}
