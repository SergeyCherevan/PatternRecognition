using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PatternRecognition.RecognitionOptionsNamespace;
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







        private void findFigures_Click(object sender, EventArgs e)
        {
            try
            {
                CheckPicture();
            }
            catch (ApplicationException)
            {
                return;
            }


            ConfigureInterfaceBeforeThreadedComputing();


            RecognitionOptions ro;

            try
            {
                ro = ConfigureRecognitionOptionsBeforeComputing();
            }
            catch (ApplicationException)
            {
                return;
            }


            Task taskOfPatternRecognition = ThreadedCompute(ro);


            ShowResult(taskOfPatternRecognition);
        }







        private void CheckPicture()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Изображение не выбрано", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw new ApplicationException("Image is not selected");
            }
        }

        private void ConfigureInterfaceBeforeThreadedComputing()
        {
            progressBar1.Maximum = pictureBox1.Image.Height
                                        * pictureBox1.Image.Width;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            timer1.Start();
        }

        private RecognitionOptions ConfigureRecognitionOptionsBeforeComputing()
        {
            RecognitionOptions ro = null;

            if (checkBoxBicolor.Checked)
            {
                ro = new OptionsOfBicolorRecognition();
            }

            if (checkBoxSharpBorders.Checked)
            {
                ro = new OptionsOfRecognitionWithSharpBorder();
            }

            if (checkBoxRgbCoord.Checked)
            {
                ro = new OptionsOfRecognitionWithRgbCoord() { MaxLen = trackBarMaxLen.Value };
            }

            if (checkBoxRgbChannels.Checked)
            {
                ro = new OptionsOfRecognitionWithRgbChannels() { 
                    MaxDifR = trackBarR.Value,
                    MaxDifG = trackBarG.Value,
                    MaxDifB = trackBarB.Value,

                    MinCountOfChannels = trackBarRgbChannels.Value,
                };
            }

            if (checkBoxHsv.Checked)
            {
                ro = new OptionsOfRecognitionWithHsv()
                {
                    MaxDifH = (decimal)trackBarH.Value / 100,
                    MaxDifS = (decimal)trackBarS.Value / 100,
                    MaxDifV = (decimal)trackBarV.Value / 100,

                    MinCountOfChannels = trackBarHsvChannels.Value,
                };
            }

            if (ro != null)
            {
                ro.NoiseSuppression = checkBoxNoiseSuppression.Checked;

                return ro;
            } 

            MessageBox.Show("Не выбраны параметры распознавания фигур", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            throw new ApplicationException("Recognition options are not selected");
        }

        private Task ThreadedCompute(RecognitionOptions ro)
        {
            Task task = new Task(() => {

                Mprc = new ManagerOfPatternRecognComputation { ImageIn = pictureBox1.Image, RO = ro };

                Mprc.Computate();

                pictureBox2.Image = Mprc.ImageOut;
            });

            task.Start();

            return task;
        }

        private void ShowResult(Task task)
        {
            task.ContinueWith(t => {
                progressBar1.Visible = false;

                MessageBox.Show($"Количество фигур на изображении не считая фон: {Mprc.PatternRecognResult.figureList.Count - 1} \n\n" +
                    $"Размеры изображения: {Mprc.ImageOut.Width}x{Mprc.ImageOut.Height} \n\n" +
                    $"Время работы алгоритма: {Math.Round(Mprc.TimeOfWork.TotalSeconds, 2)} секунд",
                    "Распознавание фигур на изображении");
            });
        }








        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Mprc?.PatternRecognResult?.locker != null)
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
                checkBoxRgbCoord.Checked = false;
                checkBoxRgbChannels.Checked = false;
                checkBoxHsv.Checked = false;
            }

            labelRgbCoordTitle.Enabled ^= true;
            labelRgbChannelTitle.Enabled ^= true;
            labelHsvTitle.Enabled ^= true;

            checkBoxRgbCoord.Enabled ^= true;
            checkBoxRgbChannels.Enabled ^= true;
            checkBoxHsv.Enabled ^= true;
        }

        private void checkBoxRgbPythagoras_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRgbCoord.Checked)
            {
                checkBoxRgbChannels.Checked = false;
                checkBoxHsv.Checked = false;
            }

            labelMaxLenTrack.Enabled ^= true;

            trackBarMaxLen.Enabled ^= true;
        }

        private void checkBoxRgbChannels_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRgbChannels.Checked)
            {
                checkBoxRgbCoord.Checked = false;
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
                checkBoxRgbCoord.Checked = false;
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
            labelMaxLenTrack.Text = "Пороговое значение расстояния: " + myTB.Value.ToString();
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
