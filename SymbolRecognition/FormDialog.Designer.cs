
namespace PatternRecognition
{
    partial class FormDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownCountBlocksByH = new System.Windows.Forms.NumericUpDown();
            this.labelCountBlocksByH = new System.Windows.Forms.Label();
            this.labelCountBlocksByW = new System.Windows.Forms.Label();
            this.numericUpDownCountBlocksByW = new System.Windows.Forms.NumericUpDown();
            this.buttonTrainTheSystem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBlocksByH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBlocksByW)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCountBlocksByH
            // 
            this.numericUpDownCountBlocksByH.Location = new System.Drawing.Point(265, 12);
            this.numericUpDownCountBlocksByH.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownCountBlocksByH.Name = "numericUpDownCountBlocksByH";
            this.numericUpDownCountBlocksByH.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownCountBlocksByH.TabIndex = 46;
            this.numericUpDownCountBlocksByH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCountBlocksByH.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelCountBlocksByH
            // 
            this.labelCountBlocksByH.AutoSize = true;
            this.labelCountBlocksByH.Location = new System.Drawing.Point(12, 14);
            this.labelCountBlocksByH.Name = "labelCountBlocksByH";
            this.labelCountBlocksByH.Size = new System.Drawing.Size(211, 17);
            this.labelCountBlocksByH.TabIndex = 47;
            this.labelCountBlocksByH.Text = "Количество блоков по высоте:";
            // 
            // labelCountBlocksByW
            // 
            this.labelCountBlocksByW.AutoSize = true;
            this.labelCountBlocksByW.Location = new System.Drawing.Point(12, 54);
            this.labelCountBlocksByW.Name = "labelCountBlocksByW";
            this.labelCountBlocksByW.Size = new System.Drawing.Size(215, 17);
            this.labelCountBlocksByW.TabIndex = 49;
            this.labelCountBlocksByW.Text = "Количество блоков по ширине:";
            // 
            // numericUpDownCountBlocksByW
            // 
            this.numericUpDownCountBlocksByW.Location = new System.Drawing.Point(265, 52);
            this.numericUpDownCountBlocksByW.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownCountBlocksByW.Name = "numericUpDownCountBlocksByW";
            this.numericUpDownCountBlocksByW.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownCountBlocksByW.TabIndex = 48;
            this.numericUpDownCountBlocksByW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCountBlocksByW.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonTrainTheSystem
            // 
            this.buttonTrainTheSystem.Location = new System.Drawing.Point(172, 98);
            this.buttonTrainTheSystem.Name = "buttonTrainTheSystem";
            this.buttonTrainTheSystem.Size = new System.Drawing.Size(153, 39);
            this.buttonTrainTheSystem.TabIndex = 50;
            this.buttonTrainTheSystem.Text = "Обучить систему";
            this.buttonTrainTheSystem.UseVisualStyleBackColor = true;
            this.buttonTrainTheSystem.Click += new System.EventHandler(this.buttonTrainTheSystem_Click);
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 149);
            this.Controls.Add(this.buttonTrainTheSystem);
            this.Controls.Add(this.labelCountBlocksByW);
            this.Controls.Add(this.numericUpDownCountBlocksByW);
            this.Controls.Add(this.labelCountBlocksByH);
            this.Controls.Add(this.numericUpDownCountBlocksByH);
            this.Name = "FormDialog";
            this.Text = "Параметры обучения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBlocksByH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBlocksByW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCountBlocksByH;
        private System.Windows.Forms.Label labelCountBlocksByH;
        private System.Windows.Forms.Label labelCountBlocksByW;
        private System.Windows.Forms.NumericUpDown numericUpDownCountBlocksByW;
        private System.Windows.Forms.Button buttonTrainTheSystem;
    }
}