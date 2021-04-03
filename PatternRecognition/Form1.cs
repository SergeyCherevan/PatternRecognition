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

        private void openFileMenuItem_Click(object sender, EventArgs e)
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

        private void findFiguresOnImage_Click(VariantOfPatternRecognition variant, string titleMessage)
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

        private void findFiguresOnBicolorImageButton_Click(object sender, EventArgs e)
        {
            findFiguresOnImage_Click(VariantOfPatternRecognition.White_Black, "Двухцветное изображение");
        }

        private void findFiguresOnMultycolorImageButton_Click(object sender, EventArgs e)
        {
            findFiguresOnImage_Click(VariantOfPatternRecognition.Multycolor, "Многоцветное изображение");
        }

        private void findFiguresOnMultycolorImageWithSmoothBorderButton_Click(object sender, EventArgs e)
        {
            findFiguresOnImage_Click(VariantOfPatternRecognition.MultycolorWithSmoothBorder, "Многоцветное изображение с плавными границами");
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

        private void checkBoxBicolor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBicolor.Checked)
            {
                checkBoxSharpBorders.Checked = false;
                checkBoxSmoothBorders.Checked = false;
            }
        }

        private void checkBoxSharpBorders_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSharpBorders.Checked)
            {
                checkBoxBicolor.Checked = false;
                checkBoxSmoothBorders.Checked = false;
            }
        }

        private void checkBoxSmoothBorders_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSmoothBorders.Checked)
            {
                checkBoxBicolor.Checked = false;
                checkBoxSharpBorders.Checked = false;
            }
            else
            {
                checkBoxRgbPythagoras.Checked = false;
                checkBoxRgbChannels.Checked = false;
                checkBoxHsv.Checked = false;
            }

            labelRgbTitle.Enabled ^= true;
            labelRgbChannelTitle.Enabled ^= true;
            labelHsvTitle.Enabled ^= true;

            checkBoxRgbPythagoras.Enabled ^= true;
            checkBoxRgbChannels.Enabled ^= true;
            checkBoxHsv.Enabled ^= true;
        }

        private void checkBoxRgbPythagoras_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRgbPythagoras.Checked)
            {
                checkBoxRgbChannels.Checked = false;
                checkBoxHsv.Checked = false;
            }

            labelRgbTrack.Enabled ^= true;

            trackBarMaxLen.Enabled ^= true;
        }

        private void checkBoxRgbChannels_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRgbChannels.Checked)
            {
                checkBoxRgbPythagoras.Checked = false;
                checkBoxHsv.Checked = false;
            }

            labelR.Enabled ^= true;
            labelG.Enabled ^= true;
            labelB.Enabled ^= true;
            labelRgbChannelTrack.Enabled ^= true;

            trackBarRgbChannels.Enabled ^= true;
            trackBarR.Enabled ^= true;
            trackBarG.Enabled ^= true;
            trackBarB.Enabled ^= true;
        }

        private void checkBoxHsv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHsv.Checked)
            {
                checkBoxRgbPythagoras.Checked = false;
                checkBoxRgbChannels.Checked = false;
            }

            labelH.Enabled ^= true;
            labelS.Enabled ^= true;
            labelV.Enabled ^= true;
            labelHsvTrack.Enabled ^= true;

            trackBarH.Enabled ^= true;
            trackBarS.Enabled ^= true;
            trackBarV.Enabled ^= true;
            trackBarHsvChannels.Enabled ^= true;
        }

        private void trackBarMaxLen_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTB;
            myTB = (System.Windows.Forms.TrackBar)sender;
            labelRgbTrack.Text = "Пороговое значение расстояния: " + myTB.Value.ToString();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTB;
            myTB = (System.Windows.Forms.TrackBar)sender;
            labelR.Text = "Пороговое значение канала R: " + myTB.Value.ToString();
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTB;
            myTB = (System.Windows.Forms.TrackBar)sender;
            labelG.Text = "Пороговое значение канала G: " + myTB.Value.ToString();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTB;
            myTB = (System.Windows.Forms.TrackBar)sender;
            labelB.Text = "Пороговое значение канала B: " + myTB.Value.ToString();
        }

        private void trackBarRgbChannels_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTB;
            myTB = (System.Windows.Forms.TrackBar)sender;
            labelRgbChannelTrack.Text = "Минимальное количество каналлов с превышением: " + myTB.Value.ToString();
        }
    }
}
