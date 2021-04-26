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

namespace ContourRecognition
{
    public partial class Form1 : Form
    {
        string[] filesOfCatalog = null;
        int numberOfFileInCatalog = 0;

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

                UploadImageToBox1();
            }
            else
            {
                MessageBox.Show("Папка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UploadImageToBox1()
        {
            string fileName = filesOfCatalog[numberOfFileInCatalog];

            pictureBox1.Image = Image.FromFile(fileName);
        }
    }
}
