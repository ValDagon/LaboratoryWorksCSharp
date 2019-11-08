using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace SplitToRgbChannels {
    public partial class Form1 : Form {

        Bitmap[] rgb;

        public Form1() {
            InitializeComponent();
        }

        private void SourcePictureBox_MouseDoubleClick(object sender, MouseEventArgs e) 
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) 
            {
                ofd.Filter = "Изображения|*.jpeg;*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.Cancel) return;
                pictureBox1.Image = new Bitmap(ofd.FileName);
                rgb = GetRgbChannels(pictureBox1.Image);
            }
        }

        static Bitmap[] GetRgbChannels(Image source) 
        {
            Bitmap[] result = new Bitmap[3];
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix[] matrices = new ColorMatrix[3];

            for (int i = 0; i < matrices.Length; i++) 
            {
                float[][] elements =
                    {
                        new float[]{i == 0 ? 1 : 0, 0, 0, 0, 0},
                        new float[]{0, i == 1 ? 1 : 0, 0, 0, 0},
                        new float[]{0, 0, i == 2 ? 1 : 0, 0, 0},
                        new float[]{0, 0, 0, 1, 0},
                        new float[]{0, 0, 0, 0, 0}
                    };
                matrices[i] = new ColorMatrix(elements);
            }

            int w = source.Width, h = source.Height;

            for (int i = 0; i < result.Length; i++) 
            {
                result[i] = new Bitmap(source);
                imageAttributes.ClearColorMatrix();
                imageAttributes.SetColorMatrix(matrices[i], ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                using (Graphics g = Graphics.FromImage(result[i])) 
                {
                    g.DrawImage(result[i], new Rectangle(0, 0, w, h), 0, 0, w, h, GraphicsUnit.Pixel, imageAttributes);
                }
            }
            return result;
        }

        private void R_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = rgb[0];
        }

        private void G_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = rgb[1];
        }

        private void B_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = rgb[2];
        }
    }
}
