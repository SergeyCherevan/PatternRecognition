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
            this.labelRgbCoordTitle = new System.Windows.Forms.Label();
            this.labelMaxLenTrack = new System.Windows.Forms.Label();
            this.trackBarMaxLen = new System.Windows.Forms.TrackBar();
            this.labelRgbChannelTitle = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.labelG = new System.Windows.Forms.Label();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.labelB = new System.Windows.Forms.Label();
            this.trackBarRgbChannels = new System.Windows.Forms.TrackBar();
            this.labelRgbChannelTrack = new System.Windows.Forms.Label();
            this.checkBoxRgbCoord = new System.Windows.Forms.CheckBox();
            this.checkBoxRgbChannels = new System.Windows.Forms.CheckBox();
            this.checkBoxHsv = new System.Windows.Forms.CheckBox();
            this.labelHsvTrack = new System.Windows.Forms.Label();
            this.trackBarHsvChannels = new System.Windows.Forms.TrackBar();
            this.trackBarV = new System.Windows.Forms.TrackBar();
            this.labelV = new System.Windows.Forms.Label();
            this.trackBarS = new System.Windows.Forms.TrackBar();
            this.labelS = new System.Windows.Forms.Label();
            this.trackBarH = new System.Windows.Forms.TrackBar();
            this.labelH = new System.Windows.Forms.Label();
            this.labelHsvTitle = new System.Windows.Forms.Label();
            this.buttonFindFigures = new System.Windows.Forms.Button();
            this.labelBicolor = new System.Windows.Forms.Label();
            this.labelSharpBorders = new System.Windows.Forms.Label();
            this.labelSmoothBorders = new System.Windows.Forms.Label();
            this.checkBoxSmoothBorders = new System.Windows.Forms.CheckBox();
            this.checkBoxSharpBorders = new System.Windows.Forms.CheckBox();
            this.checkBoxBicolor = new System.Windows.Forms.CheckBox();
            this.checkBoxNoiseSuppression = new System.Windows.Forms.CheckBox();
            this.labelNoiseSuppression = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRgbChannels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHsvChannels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1836, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(81, 24);
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
            // labelRgbCoordTitle
            // 
            this.labelRgbCoordTitle.AutoSize = true;
            this.labelRgbCoordTitle.Enabled = false;
            this.labelRgbCoordTitle.Location = new System.Drawing.Point(1255, 229);
            this.labelRgbCoordTitle.Name = "labelRgbCoordTitle";
            this.labelRgbCoordTitle.Size = new System.Drawing.Size(497, 17);
            this.labelRgbCoordTitle.TabIndex = 11;
            this.labelRgbCoordTitle.Text = "Определение схожести цветов по расстоянию между координатами RGB:";
            // 
            // labelMaxLenTrack
            // 
            this.labelMaxLenTrack.AutoSize = true;
            this.labelMaxLenTrack.Enabled = false;
            this.labelMaxLenTrack.Location = new System.Drawing.Point(1255, 259);
            this.labelMaxLenTrack.Name = "labelMaxLenTrack";
            this.labelMaxLenTrack.Size = new System.Drawing.Size(242, 17);
            this.labelMaxLenTrack.TabIndex = 12;
            this.labelMaxLenTrack.Text = "Пороговое значение расстояния: 0";
            // 
            // trackBarMaxLen
            // 
            this.trackBarMaxLen.Enabled = false;
            this.trackBarMaxLen.LargeChange = 1;
            this.trackBarMaxLen.Location = new System.Drawing.Point(1514, 251);
            this.trackBarMaxLen.Maximum = 441;
            this.trackBarMaxLen.Name = "trackBarMaxLen";
            this.trackBarMaxLen.Size = new System.Drawing.Size(309, 56);
            this.trackBarMaxLen.TabIndex = 13;
            this.trackBarMaxLen.Scroll += new System.EventHandler(this.trackBarMaxLen_Scroll);
            // 
            // labelRgbChannelTitle
            // 
            this.labelRgbChannelTitle.AutoSize = true;
            this.labelRgbChannelTitle.Enabled = false;
            this.labelRgbChannelTitle.Location = new System.Drawing.Point(1255, 310);
            this.labelRgbChannelTitle.Name = "labelRgbChannelTitle";
            this.labelRgbChannelTitle.Size = new System.Drawing.Size(461, 17);
            this.labelRgbChannelTitle.TabIndex = 14;
            this.labelRgbChannelTitle.Text = "Определение схожести цветов по разнице отдельных каналов RGB:";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Enabled = false;
            this.labelR.Location = new System.Drawing.Point(1255, 346);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(226, 17);
            this.labelR.TabIndex = 15;
            this.labelR.Text = "Пороговое значение канала R: 0";
            // 
            // trackBarR
            // 
            this.trackBarR.Enabled = false;
            this.trackBarR.LargeChange = 1;
            this.trackBarR.Location = new System.Drawing.Point(1514, 342);
            this.trackBarR.Maximum = 254;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(309, 56);
            this.trackBarR.TabIndex = 16;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.Enabled = false;
            this.trackBarG.LargeChange = 1;
            this.trackBarG.Location = new System.Drawing.Point(1514, 377);
            this.trackBarG.Maximum = 254;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(309, 56);
            this.trackBarG.TabIndex = 18;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Enabled = false;
            this.labelG.Location = new System.Drawing.Point(1255, 381);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(227, 17);
            this.labelG.TabIndex = 17;
            this.labelG.Text = "Пороговое значение канала G: 0";
            // 
            // trackBarB
            // 
            this.trackBarB.Enabled = false;
            this.trackBarB.LargeChange = 1;
            this.trackBarB.Location = new System.Drawing.Point(1514, 412);
            this.trackBarB.Maximum = 254;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(309, 56);
            this.trackBarB.TabIndex = 20;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Enabled = false;
            this.labelB.Location = new System.Drawing.Point(1255, 415);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(225, 17);
            this.labelB.TabIndex = 19;
            this.labelB.Text = "Пороговое значение канала B: 0";
            // 
            // trackBarRgbChannels
            // 
            this.trackBarRgbChannels.Enabled = false;
            this.trackBarRgbChannels.LargeChange = 1;
            this.trackBarRgbChannels.Location = new System.Drawing.Point(1719, 451);
            this.trackBarRgbChannels.Maximum = 3;
            this.trackBarRgbChannels.Minimum = 1;
            this.trackBarRgbChannels.Name = "trackBarRgbChannels";
            this.trackBarRgbChannels.Size = new System.Drawing.Size(104, 56);
            this.trackBarRgbChannels.TabIndex = 21;
            this.trackBarRgbChannels.Value = 1;
            this.trackBarRgbChannels.Scroll += new System.EventHandler(this.trackBarRgbChannels_Scroll);
            // 
            // labelRgbChannelTrack
            // 
            this.labelRgbChannelTrack.AutoSize = true;
            this.labelRgbChannelTrack.Enabled = false;
            this.labelRgbChannelTrack.Location = new System.Drawing.Point(1255, 451);
            this.labelRgbChannelTrack.Name = "labelRgbChannelTrack";
            this.labelRgbChannelTrack.Size = new System.Drawing.Size(369, 17);
            this.labelRgbChannelTrack.TabIndex = 22;
            this.labelRgbChannelTrack.Text = "Минимальное количество каналлов с превышением: 1";
            // 
            // checkBoxRgbCoord
            // 
            this.checkBoxRgbCoord.AutoSize = true;
            this.checkBoxRgbCoord.Enabled = false;
            this.checkBoxRgbCoord.Location = new System.Drawing.Point(1768, 229);
            this.checkBoxRgbCoord.Name = "checkBoxRgbCoord";
            this.checkBoxRgbCoord.Size = new System.Drawing.Size(18, 17);
            this.checkBoxRgbCoord.TabIndex = 23;
            this.checkBoxRgbCoord.UseVisualStyleBackColor = true;
            this.checkBoxRgbCoord.CheckedChanged += new System.EventHandler(this.checkBoxRgbPythagoras_CheckedChanged);
            // 
            // checkBoxRgbChannels
            // 
            this.checkBoxRgbChannels.AutoSize = true;
            this.checkBoxRgbChannels.Enabled = false;
            this.checkBoxRgbChannels.Location = new System.Drawing.Point(1768, 310);
            this.checkBoxRgbChannels.Name = "checkBoxRgbChannels";
            this.checkBoxRgbChannels.Size = new System.Drawing.Size(18, 17);
            this.checkBoxRgbChannels.TabIndex = 24;
            this.checkBoxRgbChannels.UseVisualStyleBackColor = true;
            this.checkBoxRgbChannels.CheckedChanged += new System.EventHandler(this.checkBoxRgbChannels_CheckedChanged);
            // 
            // checkBoxHsv
            // 
            this.checkBoxHsv.AutoSize = true;
            this.checkBoxHsv.Enabled = false;
            this.checkBoxHsv.Location = new System.Drawing.Point(1768, 500);
            this.checkBoxHsv.Name = "checkBoxHsv";
            this.checkBoxHsv.Size = new System.Drawing.Size(18, 17);
            this.checkBoxHsv.TabIndex = 34;
            this.checkBoxHsv.UseVisualStyleBackColor = true;
            this.checkBoxHsv.CheckedChanged += new System.EventHandler(this.checkBoxHsv_CheckedChanged);
            // 
            // labelHsvTrack
            // 
            this.labelHsvTrack.AutoSize = true;
            this.labelHsvTrack.Enabled = false;
            this.labelHsvTrack.Location = new System.Drawing.Point(1255, 641);
            this.labelHsvTrack.Name = "labelHsvTrack";
            this.labelHsvTrack.Size = new System.Drawing.Size(369, 17);
            this.labelHsvTrack.TabIndex = 33;
            this.labelHsvTrack.Text = "Минимальное количество каналлов с превышением: 1";
            // 
            // trackBarHsvChannels
            // 
            this.trackBarHsvChannels.Enabled = false;
            this.trackBarHsvChannels.LargeChange = 1;
            this.trackBarHsvChannels.Location = new System.Drawing.Point(1719, 641);
            this.trackBarHsvChannels.Maximum = 3;
            this.trackBarHsvChannels.Minimum = 1;
            this.trackBarHsvChannels.Name = "trackBarHsvChannels";
            this.trackBarHsvChannels.Size = new System.Drawing.Size(104, 56);
            this.trackBarHsvChannels.TabIndex = 32;
            this.trackBarHsvChannels.Value = 1;
            // 
            // trackBarV
            // 
            this.trackBarV.Enabled = false;
            this.trackBarV.LargeChange = 1;
            this.trackBarV.Location = new System.Drawing.Point(1514, 602);
            this.trackBarV.Maximum = 99;
            this.trackBarV.Name = "trackBarV";
            this.trackBarV.Size = new System.Drawing.Size(309, 56);
            this.trackBarV.TabIndex = 31;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Enabled = false;
            this.labelV.Location = new System.Drawing.Point(1255, 605);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(225, 17);
            this.labelV.TabIndex = 30;
            this.labelV.Text = "Пороговое значение канала V: 0";
            // 
            // trackBarS
            // 
            this.trackBarS.Enabled = false;
            this.trackBarS.LargeChange = 1;
            this.trackBarS.Location = new System.Drawing.Point(1514, 567);
            this.trackBarS.Maximum = 99;
            this.trackBarS.Name = "trackBarS";
            this.trackBarS.Size = new System.Drawing.Size(309, 56);
            this.trackBarS.TabIndex = 29;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Enabled = false;
            this.labelS.Location = new System.Drawing.Point(1255, 571);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(225, 17);
            this.labelS.TabIndex = 28;
            this.labelS.Text = "Пороговое значение канала S: 0";
            // 
            // trackBarH
            // 
            this.trackBarH.Enabled = false;
            this.trackBarH.LargeChange = 1;
            this.trackBarH.Location = new System.Drawing.Point(1514, 532);
            this.trackBarH.Maximum = 99;
            this.trackBarH.Name = "trackBarH";
            this.trackBarH.Size = new System.Drawing.Size(309, 56);
            this.trackBarH.TabIndex = 27;
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Enabled = false;
            this.labelH.Location = new System.Drawing.Point(1255, 536);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(226, 17);
            this.labelH.TabIndex = 26;
            this.labelH.Text = "Пороговое значение канала H: 0";
            // 
            // labelHsvTitle
            // 
            this.labelHsvTitle.AutoSize = true;
            this.labelHsvTitle.Enabled = false;
            this.labelHsvTitle.Location = new System.Drawing.Point(1255, 500);
            this.labelHsvTitle.Name = "labelHsvTitle";
            this.labelHsvTitle.Size = new System.Drawing.Size(459, 17);
            this.labelHsvTitle.TabIndex = 25;
            this.labelHsvTitle.Text = "Определение схожести цветов по разнице отдельных каналов HSV:";
            // 
            // buttonFindFigures
            // 
            this.buttonFindFigures.Location = new System.Drawing.Point(1258, 80);
            this.buttonFindFigures.Name = "buttonFindFigures";
            this.buttonFindFigures.Size = new System.Drawing.Size(121, 32);
            this.buttonFindFigures.TabIndex = 35;
            this.buttonFindFigures.Text = "Найти фигуры";
            this.buttonFindFigures.UseVisualStyleBackColor = true;
            this.buttonFindFigures.Click += new System.EventHandler(this.buttonFindFigures_Click);
            // 
            // labelBicolor
            // 
            this.labelBicolor.AutoSize = true;
            this.labelBicolor.Location = new System.Drawing.Point(1255, 124);
            this.labelBicolor.Name = "labelBicolor";
            this.labelBicolor.Size = new System.Drawing.Size(185, 17);
            this.labelBicolor.TabIndex = 36;
            this.labelBicolor.Text = "Двухцветное изображение";
            // 
            // labelSharpBorders
            // 
            this.labelSharpBorders.AutoSize = true;
            this.labelSharpBorders.Location = new System.Drawing.Point(1255, 155);
            this.labelSharpBorders.Name = "labelSharpBorders";
            this.labelSharpBorders.Size = new System.Drawing.Size(276, 17);
            this.labelSharpBorders.TabIndex = 37;
            this.labelSharpBorders.Text = "Изображение RGB с резкими границами";
            // 
            // labelSmoothBorders
            // 
            this.labelSmoothBorders.AutoSize = true;
            this.labelSmoothBorders.Location = new System.Drawing.Point(1255, 186);
            this.labelSmoothBorders.Name = "labelSmoothBorders";
            this.labelSmoothBorders.Size = new System.Drawing.Size(287, 17);
            this.labelSmoothBorders.TabIndex = 38;
            this.labelSmoothBorders.Text = "Изображение RGB с плавными границами";
            // 
            // checkBoxSmoothBorders
            // 
            this.checkBoxSmoothBorders.AutoSize = true;
            this.checkBoxSmoothBorders.Location = new System.Drawing.Point(1586, 187);
            this.checkBoxSmoothBorders.Name = "checkBoxSmoothBorders";
            this.checkBoxSmoothBorders.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSmoothBorders.TabIndex = 39;
            this.checkBoxSmoothBorders.UseVisualStyleBackColor = true;
            this.checkBoxSmoothBorders.CheckedChanged += new System.EventHandler(this.checkBoxSmoothBorders_CheckedChanged);
            // 
            // checkBoxSharpBorders
            // 
            this.checkBoxSharpBorders.AutoSize = true;
            this.checkBoxSharpBorders.Location = new System.Drawing.Point(1586, 155);
            this.checkBoxSharpBorders.Name = "checkBoxSharpBorders";
            this.checkBoxSharpBorders.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSharpBorders.TabIndex = 40;
            this.checkBoxSharpBorders.UseVisualStyleBackColor = true;
            this.checkBoxSharpBorders.CheckedChanged += new System.EventHandler(this.checkBoxSharpBorders_CheckedChanged);
            // 
            // checkBoxBicolor
            // 
            this.checkBoxBicolor.AutoSize = true;
            this.checkBoxBicolor.Location = new System.Drawing.Point(1586, 124);
            this.checkBoxBicolor.Name = "checkBoxBicolor";
            this.checkBoxBicolor.Size = new System.Drawing.Size(18, 17);
            this.checkBoxBicolor.TabIndex = 41;
            this.checkBoxBicolor.UseVisualStyleBackColor = true;
            this.checkBoxBicolor.CheckedChanged += new System.EventHandler(this.checkBoxBicolor_CheckedChanged);
            // 
            // checkBoxNoiseSuppression
            // 
            this.checkBoxNoiseSuppression.AutoSize = true;
            this.checkBoxNoiseSuppression.Location = new System.Drawing.Point(1586, 689);
            this.checkBoxNoiseSuppression.Name = "checkBoxNoiseSuppression";
            this.checkBoxNoiseSuppression.Size = new System.Drawing.Size(18, 17);
            this.checkBoxNoiseSuppression.TabIndex = 43;
            this.checkBoxNoiseSuppression.UseVisualStyleBackColor = true;
            // 
            // labelNoiseSuppression
            // 
            this.labelNoiseSuppression.AutoSize = true;
            this.labelNoiseSuppression.Location = new System.Drawing.Point(1255, 689);
            this.labelNoiseSuppression.Name = "labelNoiseSuppression";
            this.labelNoiseSuppression.Size = new System.Drawing.Size(122, 17);
            this.labelNoiseSuppression.TabIndex = 42;
            this.labelNoiseSuppression.Text = "Шумоподавление";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1693, 66);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 61);
            this.buttonSave.TabIndex = 44;
            this.buttonSave.Text = "Сохранить изображение";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 755);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxNoiseSuppression);
            this.Controls.Add(this.labelNoiseSuppression);
            this.Controls.Add(this.checkBoxBicolor);
            this.Controls.Add(this.checkBoxSharpBorders);
            this.Controls.Add(this.checkBoxSmoothBorders);
            this.Controls.Add(this.labelSmoothBorders);
            this.Controls.Add(this.labelSharpBorders);
            this.Controls.Add(this.labelBicolor);
            this.Controls.Add(this.buttonFindFigures);
            this.Controls.Add(this.checkBoxHsv);
            this.Controls.Add(this.labelHsvTrack);
            this.Controls.Add(this.trackBarHsvChannels);
            this.Controls.Add(this.trackBarV);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.trackBarS);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.trackBarH);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelHsvTitle);
            this.Controls.Add(this.checkBoxRgbChannels);
            this.Controls.Add(this.checkBoxRgbCoord);
            this.Controls.Add(this.labelRgbChannelTrack);
            this.Controls.Add(this.trackBarRgbChannels);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelRgbChannelTitle);
            this.Controls.Add(this.trackBarMaxLen);
            this.Controls.Add(this.labelMaxLenTrack);
            this.Controls.Add(this.labelRgbCoordTitle);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRgbChannels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHsvChannels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).EndInit();
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
        private System.Windows.Forms.Label labelRgbCoordTitle;
        private System.Windows.Forms.Label labelMaxLenTrack;
        private System.Windows.Forms.TrackBar trackBarMaxLen;
        private System.Windows.Forms.Label labelRgbChannelTitle;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TrackBar trackBarRgbChannels;
        private System.Windows.Forms.Label labelRgbChannelTrack;
        private System.Windows.Forms.CheckBox checkBoxRgbCoord;
        private System.Windows.Forms.CheckBox checkBoxRgbChannels;
        private System.Windows.Forms.CheckBox checkBoxHsv;
        private System.Windows.Forms.Label labelHsvTrack;
        private System.Windows.Forms.TrackBar trackBarHsvChannels;
        private System.Windows.Forms.TrackBar trackBarV;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.TrackBar trackBarS;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.TrackBar trackBarH;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelHsvTitle;
        private System.Windows.Forms.Button buttonFindFigures;
        private System.Windows.Forms.Label labelBicolor;
        private System.Windows.Forms.Label labelSharpBorders;
        private System.Windows.Forms.Label labelSmoothBorders;
        private System.Windows.Forms.CheckBox checkBoxSmoothBorders;
        private System.Windows.Forms.CheckBox checkBoxSharpBorders;
        private System.Windows.Forms.CheckBox checkBoxBicolor;
        private System.Windows.Forms.CheckBox checkBoxNoiseSuppression;
        private System.Windows.Forms.Label labelNoiseSuppression;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

