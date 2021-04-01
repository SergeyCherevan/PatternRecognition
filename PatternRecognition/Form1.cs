using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static PatternRecognition.ManagerOfPatternRecognComputation;

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

        private void findFiguresOnImageMenuItem_Click(VariantOfPatternRecognition variant, string titleMessage)
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

            timer1.Start();




            Task reactionByClickMenuItem = new Task( () => {

                Mprc = new ManagerOfPatternRecognComputation { ImageIn = pictureBox1.Image, Variant = variant };

                Mprc.Computate();

                pictureBox2.Image = Mprc.ImageOut;
            });

            reactionByClickMenuItem.Start();




            reactionByClickMenuItem.ContinueWith(task => {
                progressBar1.Visible = false;

                MessageBox.Show($"Количество фигур на изображении не считая фон: {Mprc.PatternRecognResult.figureList.Count - 1} \n\n" +
                    $"Размеры изображения: {Mprc.ImageOut.Width}x{Mprc.ImageOut.Height} \n\n" +
                    $"Время работы алгоритма: {Math.Round(Mprc.TimeOfWork.TotalSeconds, 2)} seconds",
                    titleMessage);
            });
        }

        private void findFiguresOnBicolorImageMenuItem_Click(object sender, EventArgs e)
        {
            findFiguresOnImageMenuItem_Click(VariantOfPatternRecognition.White_Black, "Двухцветное изображение");
        }

        private void findFiguresOnMultycolorImageMenuItem_Click(object sender, EventArgs e)
        {
            findFiguresOnImageMenuItem_Click(VariantOfPatternRecognition.Multycolor, "Многоцветное изображение");
        }

        private void findFiguresOnMultycolorImageWithSmoothBorderMenuItem_Click(object sender, EventArgs e)
        {
            findFiguresOnImageMenuItem_Click(VariantOfPatternRecognition.MultycolorWithSmoothBorder, "Многоцветное изображение с плавными границами");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Mprc.PatternRecognResult.locker != null)
                lock (Mprc.PatternRecognResult.locker)
                {
                    progressBar1.Value = Mprc.PatternRecognResult.locker.counter;


                    label1.Visible = true;

                    int w = label1.Width;

                    label1.Text = progressBar1.Value + "/" + progressBar1.Maximum;

                    label1.Location = new Point(label1.Location.X - label1.Width + w, label1.Location.Y);
                }
                    


            if (progressBar1.Value == progressBar1.Maximum)
                timer1.Stop();
        }
    }
}
