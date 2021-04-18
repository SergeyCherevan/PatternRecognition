using PatternRecognition.RecognitionOptionsNamespace;
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

        Symbol symbol;







        private void recoginteSymbolToolStripMenuItem_Click(object sender, EventArgs e)
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


            RecognitionOptions ro = new OptionsOfBicolorRecognition();


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

        private Task ThreadedCompute(RecognitionOptions ro)
        {
            Task task = new Task(() => {

                Mprc = new ManagerOfPatternRecognComputation { ImageIn = pictureBox1.Image, RO = ro };

                Mprc.Computate();

                symbol = new Symbol((Figure<bool>)Mprc.PatternRecognResult.figureList.Last.Value);
            });

            task.Start();

            return task;
        }

        private void ShowResult(Task task)
        {
            task.ContinueWith(t => {
                // progressBar1.Visible = false;
                try
                {
                    double[,] areas = symbol.GetAreas();

                    MessageBox.Show($"{areas[0,0].ToString("0.####")}\t{areas[0,1].ToString("0.####")}\t{areas[0,2].ToString("0.####")}\n" +
                                    $"{areas[1,0].ToString("0.####")}\t{areas[1,1].ToString("0.####")}\t{areas[1,2].ToString("0.####")}\n" +
                                    $"{areas[2,0].ToString("0.####")}\t{areas[2,1].ToString("0.####")}\t{areas[2,2].ToString("0.####")}" ,
                        "Распознавание символа на изображении");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name);
                }
            });
        }
    }
}
