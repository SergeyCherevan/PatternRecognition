
namespace PatternRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openCatalogStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFolderDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.numericUpDownMatrixBias = new System.Windows.Forms.NumericUpDown();
            this.labelMatrixBias = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            this.labelDistance = new System.Windows.Forms.Label();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.labelCoefficient = new System.Windows.Forms.Label();
            this.numericUpDownCoefficient = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixBias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoefficient)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCatalogStripMenuItem,
            this.backToolStripMenuItem,
            this.nextToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openCatalogStripMenuItem
            // 
            this.openCatalogStripMenuItem.Name = "openCatalogStripMenuItem";
            this.openCatalogStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.openCatalogStripMenuItem.Text = "Открыть";
            this.openCatalogStripMenuItem.Click += new System.EventHandler(this.openCatalogStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.backToolStripMenuItem.Text = "← Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.nextToolStripMenuItem.Text = "Next →";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // openFolderDialog
            // 
            this.openFolderDialog.CheckFileExists = false;
            this.openFolderDialog.FileName = "Имя файла будет проигнорировано";
            this.openFolderDialog.ReadOnlyChecked = true;
            this.openFolderDialog.ValidateNames = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(439, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(10, 482);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 400);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(439, 482);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(400, 400);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // numericUpDownMatrixBias
            // 
            this.numericUpDownMatrixBias.DecimalPlaces = 2;
            this.numericUpDownMatrixBias.Location = new System.Drawing.Point(530, 450);
            this.numericUpDownMatrixBias.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDownMatrixBias.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numericUpDownMatrixBias.Name = "numericUpDownMatrixBias";
            this.numericUpDownMatrixBias.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownMatrixBias.TabIndex = 58;
            this.numericUpDownMatrixBias.TabStop = false;
            this.numericUpDownMatrixBias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMatrixBias
            // 
            this.labelMatrixBias.AutoSize = true;
            this.labelMatrixBias.Location = new System.Drawing.Point(447, 452);
            this.labelMatrixBias.Name = "labelMatrixBias";
            this.labelMatrixBias.Size = new System.Drawing.Size(77, 17);
            this.labelMatrixBias.TabIndex = 59;
            this.labelMatrixBias.Text = "Смещение";
            // 
            // buttonReload
            // 
            this.buttonReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonReload.Location = new System.Drawing.Point(409, 447);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(30, 32);
            this.buttonReload.TabIndex = 60;
            this.buttonReload.Text = "↻";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(22, 895);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(86, 17);
            this.labelDistance.TabIndex = 62;
            this.labelDistance.Text = "Расстояние";
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.DecimalPlaces = 1;
            this.numericUpDownDistance.Location = new System.Drawing.Point(113, 893);
            this.numericUpDownDistance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownDistance.TabIndex = 61;
            this.numericUpDownDistance.TabStop = false;
            this.numericUpDownDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDistance.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelCoefficient
            // 
            this.labelCoefficient.AutoSize = true;
            this.labelCoefficient.Location = new System.Drawing.Point(447, 898);
            this.labelCoefficient.Name = "labelCoefficient";
            this.labelCoefficient.Size = new System.Drawing.Size(91, 17);
            this.labelCoefficient.TabIndex = 64;
            this.labelCoefficient.Text = "Коефициент";
            // 
            // numericUpDownCoefficient
            // 
            this.numericUpDownCoefficient.DecimalPlaces = 2;
            this.numericUpDownCoefficient.Location = new System.Drawing.Point(544, 895);
            this.numericUpDownCoefficient.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCoefficient.Name = "numericUpDownCoefficient";
            this.numericUpDownCoefficient.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownCoefficient.TabIndex = 63;
            this.numericUpDownCoefficient.TabStop = false;
            this.numericUpDownCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 957);
            this.Controls.Add(this.labelCoefficient);
            this.Controls.Add(this.numericUpDownCoefficient);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.numericUpDownDistance);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.labelMatrixBias);
            this.Controls.Add(this.numericUpDownMatrixBias);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixBias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoefficient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openCatalogStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFolderDialog;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.NumericUpDown numericUpDownMatrixBias;
        private System.Windows.Forms.Label labelMatrixBias;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.NumericUpDown numericUpDownDistance;
        private System.Windows.Forms.Label labelCoefficient;
        private System.Windows.Forms.NumericUpDown numericUpDownCoefficient;
    }
}

