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
        Select_H_W_Dialog select_H_W_Dialog = new Select_H_W_Dialog();

        ComputationOfSymbolRecognition csr = new ComputationOfSymbolRecognition();

        public Form1()
        {
            InitializeComponent();
        }

        private void openImageMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openImageDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = openImageDialog.FileName;
                pictureBox1.Image = Image.FromFile(path);
            }
            else
            {
                MessageBox.Show("Изображение не выбрано", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public ManagerOfPatternRecognComputation Mprc { get; private set; }

        Symbol symbol;

        private void SelectFolderWithTrainingSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = openFolderDialog.FileName.Replace(openFolderDialog.SafeFileName, "");

                select_H_W_Dialog.ShowDialog();

                csr.GetMapFromImagesBank(path, select_H_W_Dialog.H, select_H_W_Dialog.W);
            }
            else
            {
                MessageBox.Show("Папка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void trainTheSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
        }*/







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
                progressBar1.Visible = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Mprc?.PatternRecognResult?.locker != null)
                lock (Mprc.PatternRecognResult.locker)
                {
                    progressBar1.Value = Mprc.PatternRecognResult.locker.counter;


                    labelProgress.Visible = true;

                    int w = labelProgress.Width;

                    labelProgress.Text = progressBar1.Value + "/" + progressBar1.Maximum;

                    labelProgress.Location = new Point(labelProgress.Location.X - labelProgress.Width + w, labelProgress.Location.Y);
                }



            if (progressBar1.Value == progressBar1.Maximum)
                timer1.Stop();
        }
    }
}
