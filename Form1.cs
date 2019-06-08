using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static_Image_Generator
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

        private void Button1_Click(object sender, EventArgs e)
        {
            int width = decimal.ToInt32(num_Width.Value);
            int height = decimal.ToInt32(num_Height.Value);

            Bitmap bmp = new Bitmap(width, height);
            Random rand = new Random();
            for (int y = 0; height > y; y++)
            {
                for (int x = 0; width > x; x++)
                {
                    int a = 255;
                    if (rand_alpha_check.Checked == true)
                    {
                        a = rand.Next(256);
                    }
                    int r = rand.Next(256);
                    int g = rand.Next(256);
                    int b = rand.Next(256);
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            picturebox_result.Image = bmp;
        }
        

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (picturebox_result.Image == null)
            {
                MessageBox.Show("Can't save, no image here!");
            } else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg;*.jpeg";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    picturebox_result.Image.Save(sfd.FileName);
                }
            }

        }

        private void Rand_alpha_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(picturebox_result.Image);
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawString(textBox1.Text, new Font("Tahoma",Convert.ToInt32(num_font_size.Value)), Brushes.Black, new RectangleF(0, 0, picturebox_result.Image.Width, picturebox_result.Image.Height));
            picturebox_result.Image = picturebox_result.Image;
        }

        private void Num_font_size_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
