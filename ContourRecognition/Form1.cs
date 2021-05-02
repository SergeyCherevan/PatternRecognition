using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PatternRecognition.RecognitionOptionsNamespace;

namespace PatternRecognition
{
    partial class Form1 : Form
    {
        string[] filesOfCatalog = null;
        int numberOfFileInCatalog = 0;

        TemplateComputationOfPatternRecognition<double> tcpr;
        MatrixRecognitionComputation mrc;
        ContourRecognitionComputation crc;
        ImpulseRecognitionComputation irc;

        public Form1()
        {
            InitializeComponent();

            numericUpDownMatrixBias.Increment = 0.05m;

            numericUpDownCoefficient.Increment = 0.05m;
            numericUpDownCoefficient.Minimum = 0.8m;
            numericUpDownCoefficient.Maximum = 1.2m;
            numericUpDownCoefficient.Value = 0.8m;
        }

        private void openCatalogStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = openFolderDialog.FileName.Replace(openFolderDialog.SafeFileName, "");

                filesOfCatalog = Directory.GetFiles(path, "*.jpg");

                OperateImage();
            }
            else
            {
                MessageBox.Show("Папка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (filesOfCatalog == null)
                return;

            switch (e.KeyCode)
            {
                case Keys.Right:
                    numberOfFileInCatalog = (numberOfFileInCatalog + 1) % filesOfCatalog.Length;

                    OperateImage();
                    break;

                case Keys.Left:
                    numberOfFileInCatalog = (numberOfFileInCatalog + filesOfCatalog.Length - 1) % filesOfCatalog.Length;

                    OperateImage();
                    break;

                case Keys.Enter:

                    OperateImage();
                    break;
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(null, new KeyEventArgs(Keys.Enter));
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(null, new KeyEventArgs(Keys.Left));
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(null, new KeyEventArgs(Keys.Right));
        }

        private void OperateImage()
        {
            if (filesOfCatalog == null)
                return;

            this.Cursor = Cursors.WaitCursor;

            UploadImageToBox1();

            RecognitionOptions ro = new OptionsOfBlackWhiteRecognition() { isContourRecognition = true };
            tcpr = new TemplateComputationOfPatternRecognition<double>(ro);
            tcpr.CreatePointsArrFromImage(pictureBox1.Image);

            UploadImageToBox2();

            UploadImageToBox3();

            UploadImageToBox4();

            this.Cursor = Cursors.Default;
        }

        private void UploadImageToBox1()
        {
            string fileName = filesOfCatalog[numberOfFileInCatalog];

            pictureBox1.Image = Image.FromFile(fileName);
        }

        private void UploadImageToBox2()
        {
            mrc = new MatrixRecognitionComputation(new double[3, 3]
            {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 },
            }, 1, 1);

            double[,] newPoints = mrc.Comp(tcpr.pointsM);

            pictureBox2.Image = mrc.GetImage(newPoints, (double)numericUpDownMatrixBias.Value);
        }

        private void UploadImageToBox3()
        {
            try
            {
                crc = new ContourRecognitionComputation((double)numericUpDownDistance.Value);

                bool[,] newPoints = crc.Comp(tcpr.pointsM);

                pictureBox3.Image = crc.GetImage(newPoints);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nВ стеке вызовов:\n" + ex.StackTrace, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UploadImageToBox4()
        {
            try
            {
                irc = new ImpulseRecognitionComputation((double)numericUpDownCoefficient.Value);

                bool[,] newPoints = irc.Comp(tcpr.pointsM);

                pictureBox4.Image = irc.GetImage(newPoints);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nВ стеке вызовов:\n" + ex.StackTrace, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
