using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternRecognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int countOfClick = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;

            countOfClick++;
            if (countOfClick % 2 == 1)
            {
                LoadImageToPictureBox(box, "Image.jpg");
            }
            else
            {
                Image newImage = PatRecognComputation.Computate(box.Image);

                box.Image = newImage;
            }            
        }

        private void LoadImageToPictureBox(PictureBox box, string nameImageFile)
        {
            box.Image = Image.FromFile(nameImageFile);

            box.Width = box.Image.Width;
            box.Height = box.Image.Height;

            (box.Parent as Form1).Width = box.Width + 18;
            (box.Parent as Form1).Height = box.Height + 40;
        }
    }
}
