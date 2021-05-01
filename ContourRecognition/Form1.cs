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
    public partial class Form1 : Form
    {
        string[] filesOfCatalog = null;
        int numberOfFileInCatalog = 0;

        TemplateComputationOfPatternRecognition<double> tcpr;
        MatrixComputationOfImage mci;

        public Form1()
        {
            InitializeComponent();
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
            switch (e.KeyCode)
            {
                case Keys.Right:
                    numberOfFileInCatalog = (numberOfFileInCatalog + 1) % filesOfCatalog.Length;
                    break;

                case Keys.Left:
                    numberOfFileInCatalog = (numberOfFileInCatalog + filesOfCatalog.Length - 1) % filesOfCatalog.Length;
                    break;
            }

            OperateImage();
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
            UploadImageToBox1();

            UploadImageToBox2();

            UploadImageToBox3();
        }

        private void UploadImageToBox1()
        {
            string fileName = filesOfCatalog[numberOfFileInCatalog];

            pictureBox1.Image = Image.FromFile(fileName);
        }

        private void UploadImageToBox2()
        {
            RecognitionOptions ro = new OptionsOfBlackWhiteRecognition() { isContourRecognition = true, MaxLen = 250d };

            tcpr = new TemplateComputationOfPatternRecognition<double>(ro);

            mci = new MatrixComputationOfImage(new double[3, 3]
            {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 },
            }, 1, 1);

            tcpr.CreatePointsArrFromImage(pictureBox1.Image);

            tcpr.pointsM = mci.Comp(tcpr.pointsM);

            pictureBox2.Image = mci.GetImage(tcpr.pointsM);
        }

        private void UploadImageToBox3()
        {
            try
            {
                tcpr.CreatePixelsM();

                tcpr.GroupPixelsByFigures();

                tcpr.ClearFromNoise();

                pictureBox3.Image = tcpr.RecolorImage(new List<Color>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nВ стеке вызовов:\n" + ex.StackTrace, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
