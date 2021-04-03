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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.findFiguresOnBicolorImageButton = new System.Windows.Forms.Button();
            this.findFiguresOnMultycolorImageButton = new System.Windows.Forms.Button();
            this.findFiguresOnMultycolorImageWithSmoothBorderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1840, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(81, 28);
            this.openFileMenuItem.Text = "Открыть";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(633, 80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 600);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 698);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1077, 31);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(1179, 703);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "0/100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Visible = false;
            // 
            // findFiguresOnBicolorImageButton
            // 
            this.findFiguresOnBicolorImageButton.Location = new System.Drawing.Point(1255, 80);
            this.findFiguresOnBicolorImageButton.Name = "findFiguresOnBicolorImageButton";
            this.findFiguresOnBicolorImageButton.Size = new System.Drawing.Size(225, 47);
            this.findFiguresOnBicolorImageButton.TabIndex = 8;
            this.findFiguresOnBicolorImageButton.Text = "Найти фигуры на двухцветном изображении";
            this.findFiguresOnBicolorImageButton.UseVisualStyleBackColor = true;
            this.findFiguresOnBicolorImageButton.Click += new System.EventHandler(this.findFiguresOnBicolorImageButton_Click);
            // 
            // findFiguresOnMultycolorImageButton
            // 
            this.findFiguresOnMultycolorImageButton.Location = new System.Drawing.Point(1255, 133);
            this.findFiguresOnMultycolorImageButton.Name = "findFiguresOnMultycolorImageButton";
            this.findFiguresOnMultycolorImageButton.Size = new System.Drawing.Size(225, 60);
            this.findFiguresOnMultycolorImageButton.TabIndex = 9;
            this.findFiguresOnMultycolorImageButton.Text = "Найти фигуры на изображении RGB с резкими границами";
            this.findFiguresOnMultycolorImageButton.UseVisualStyleBackColor = true;
            this.findFiguresOnMultycolorImageButton.Click += new System.EventHandler(this.findFiguresOnMultycolorImageButton_Click);
            // 
            // findFiguresOnMultycolorImageWithSmoothBorderButton
            // 
            this.findFiguresOnMultycolorImageWithSmoothBorderButton.Location = new System.Drawing.Point(1255, 203);
            this.findFiguresOnMultycolorImageWithSmoothBorderButton.Name = "findFiguresOnMultycolorImageWithSmoothBorderButton";
            this.findFiguresOnMultycolorImageWithSmoothBorderButton.Size = new System.Drawing.Size(225, 60);
            this.findFiguresOnMultycolorImageWithSmoothBorderButton.TabIndex = 10;
            this.findFiguresOnMultycolorImageWithSmoothBorderButton.Text = "Найти фигуры на изображении RGB с плавными границами";
            this.findFiguresOnMultycolorImageWithSmoothBorderButton.UseVisualStyleBackColor = true;
            this.findFiguresOnMultycolorImageWithSmoothBorderButton.Click += new System.EventHandler(this.findFiguresOnMultycolorImageWithSmoothBorderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1255, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Определение схожести цветов по расстоянию между координатами RGB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1255, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пороговое значение расстояния: 0";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(1503, 300);
            this.trackBar1.Maximum = 441;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(309, 56);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1255, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Определение схожести цветов по разнице отдельных каналов RGB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1255, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Пороговое значение канала R: 0";
            // 
            // trackBar2
            // 
            this.trackBar2.Enabled = false;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(1503, 391);
            this.trackBar2.Maximum = 254;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(309, 56);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Enabled = false;
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(1503, 426);
            this.trackBar3.Maximum = 254;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(309, 56);
            this.trackBar3.TabIndex = 18;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1255, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Пороговое значение канала G: 0";
            // 
            // trackBar4
            // 
            this.trackBar4.Enabled = false;
            this.trackBar4.LargeChange = 1;
            this.trackBar4.Location = new System.Drawing.Point(1503, 461);
            this.trackBar4.Maximum = 254;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(309, 56);
            this.trackBar4.TabIndex = 20;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1255, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Пороговое значение канала B: 0";
            // 
            // trackBar5
            // 
            this.trackBar5.Enabled = false;
            this.trackBar5.LargeChange = 1;
            this.trackBar5.Location = new System.Drawing.Point(1708, 500);
            this.trackBar5.Maximum = 3;
            this.trackBar5.Minimum = 1;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(104, 56);
            this.trackBar5.TabIndex = 21;
            this.trackBar5.Value = 1;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1255, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Минимальное количество каналлов с превышением: 1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1794, 279);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1794, 359);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1794, 549);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1255, 690);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(369, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Минимальное количество каналлов с превышением: 1";
            // 
            // trackBar6
            // 
            this.trackBar6.Enabled = false;
            this.trackBar6.LargeChange = 1;
            this.trackBar6.Location = new System.Drawing.Point(1708, 690);
            this.trackBar6.Maximum = 3;
            this.trackBar6.Minimum = 1;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(104, 56);
            this.trackBar6.TabIndex = 32;
            this.trackBar6.Value = 1;
            // 
            // trackBar7
            // 
            this.trackBar7.Enabled = false;
            this.trackBar7.LargeChange = 1;
            this.trackBar7.Location = new System.Drawing.Point(1503, 651);
            this.trackBar7.Maximum = 254;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(309, 56);
            this.trackBar7.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1255, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Пороговое значение канала V: 0";
            // 
            // trackBar8
            // 
            this.trackBar8.Enabled = false;
            this.trackBar8.LargeChange = 1;
            this.trackBar8.Location = new System.Drawing.Point(1503, 616);
            this.trackBar8.Maximum = 254;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(309, 56);
            this.trackBar8.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1255, 620);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Пороговое значение канала S: 0";
            // 
            // trackBar9
            // 
            this.trackBar9.Enabled = false;
            this.trackBar9.LargeChange = 1;
            this.trackBar9.Location = new System.Drawing.Point(1503, 581);
            this.trackBar9.Maximum = 254;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(309, 56);
            this.trackBar9.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1255, 585);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Пороговое значение канала H: 0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1255, 549);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(459, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Определение схожести цветов по разнице отдельных каналов HSV:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 755);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trackBar9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findFiguresOnMultycolorImageWithSmoothBorderButton);
            this.Controls.Add(this.findFiguresOnMultycolorImageButton);
            this.Controls.Add(this.findFiguresOnBicolorImageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Распознавание фигур на изображении";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findFiguresOnBicolorImageButton;
        private System.Windows.Forms.Button findFiguresOnMultycolorImageButton;
        private System.Windows.Forms.Button findFiguresOnMultycolorImageWithSmoothBorderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

