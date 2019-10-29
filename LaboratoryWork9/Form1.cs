using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaboratoryWork9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            p1 = new Pen(Color.Green, 3);
            p1.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            p2 = new Pen(Color.Red, 2);
            b1 = new SolidBrush(Color.White);
            p3 = new Pen(Color.Black, 2);

            this.Load += this.Form_Load;
            this.Paint += this.Form_Paint;
        }

        private Pen p1;
        private Pen p2;
        private Pen p3;
        private SolidBrush b1;

        public override Size MinimumSize
        {
            get
            {
                return new Size(1000, 480);
            }
            set
            {
                base.MinimumSize = value;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            //вызываем метод отрисовки снеговиков, аргументы - экземпляр класса Graphics и количество снеговиков
            Draw(e.Graphics, 10);
        }

        private void Draw(Graphics e, int count)
        {
            int diam;//диаметр
            Point location;//координаты валунов
            int distance = 75;//дистанция между снеговиками

            for (int j = 0; j < count; j++)//цикл орисовки снеговиков
            {
                diam = 50;
                location = new Point(this.ClientSize.Width - distance, this.ClientSize.Height);
                location.X += 5;//смещаем валун к середине
                location.Y -= diam;//ставим валун на другой

                e.FillEllipse(b1, location.X, location.Y, diam, diam);
                diam = 100;//уменьшаем диаметр валуна
                //отрисовка глаз, носа, рта и пуговиц
                e.DrawLine(p1, location.X + diam - 5, this.ClientSize.Height - 500, location.X + diam - 5, this.ClientSize.Height);
                e.DrawLine(p2, location.X + 5, location.Y - 100, location.X + diam + 7, location.Y - 100);
                e.DrawEllipse(p3, location.X + 15, location.Y + 5, 20, 20);
                distance += 100;//двигаем следующего снеговика
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
