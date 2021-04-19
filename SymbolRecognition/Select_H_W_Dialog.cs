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
    public partial class Select_H_W_Dialog : Form
    {
        public int H { get; private set; }
        public int W { get; private set; }

        public Select_H_W_Dialog()
        {
            InitializeComponent();
        }

        private void buttonTrainTheSystem_Click(object sender, EventArgs e)
        {
            H = (int)numericUpDownCountBlocksByH.Value;
            W = (int)numericUpDownCountBlocksByW.Value;

            this.DialogResult = DialogResult.OK;
        }

        private void FormDialog_FormClosing(object sender, EventArgs e)
        {
            H = (int)numericUpDownCountBlocksByH.Value;
            W = (int)numericUpDownCountBlocksByW.Value;
        }
    }
}
