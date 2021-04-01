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

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(path);
            }
            else
            {
                MessageBox.Show("Изображение не выбрано", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ManagerOfPatternRecognComputation Mprc { get; private set; }

        private void findFiguresOnImageMenuItem_Click(string colorPalette, string titleMessage)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Изображение не выбрано", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            progressBar1.Maximum = pictureBox1.Image.Height
                                        * pictureBox1.Image.Width;
            progressBar1.Value = 0;
            progressBar1.Visible = true;




            Task reactionByClickMenuItem = new Task( () => {

                Mprc = new ManagerOfPatternRecognComputation { ImageIn = pictureBox1.Image, ColorPalette = colorPalette };

                timer1.Start();

                Mprc.Computate();

                pictureBox2.Image = Mprc.ImageOut;
            });

            reactionByClickMenuItem.Start();




            reactionByClickMenuItem.ContinueWith(task => {
                progressBar1.Visible = false;

                timer1.Stop();

                MessageBox.Show($"Количество фигур на изображении не считая фон: {Mprc.PatternRecognResult.figureList.Count - 1} \n\n" +
                    $"Размеры изображения: {Mprc.ImageOut.Width}x{Mprc.ImageOut.Height} \n\n" +
                    $"Время работы алгоритма: {Math.Round(Mprc.TimeOfWork.TotalSeconds, 2)} seconds",
                    titleMessage);
            });
        }

        private void findFiguresOnBicolorImageMenuItem_Click(object sender, EventArgs e)
        {
            findFiguresOnImageMenuItem_Click("white/black", "Двухцветное изображение");
        }

        private void findFiguresOnMultycolorImageMenuItem_Click(object sender, EventArgs e)
        {
            findFiguresOnImageMenuItem_Click("multycolor", "Многоцветное изображение");
        }

        private void findFiguresOnMultycolorImageWithSmoothBorderMenuItem_Click(object sender, EventArgs e)
        {
            findFiguresOnImageMenuItem_Click("multycolor with smooth border", "Многоцветное изображение с плавными границами");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lock (Mprc.PatternRecognResult)
                progressBar1.Value = 1000;

            // MessageBox.Show("Hi");
        }
    }
}
