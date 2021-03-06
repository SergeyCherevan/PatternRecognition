
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recoginteSymbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainTheSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectFolderWithTrainingSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeResultOfLearningToJsonFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFileWithKeyValuePairsSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelProgress = new System.Windows.Forms.Label();
            this.openFolderDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveJsonDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 695);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(485, 31);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 50;
            this.progressBar1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // recoginteSymbolToolStripMenuItem
            // 
            this.recoginteSymbolToolStripMenuItem.Name = "recoginteSymbolToolStripMenuItem";
            this.recoginteSymbolToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            this.recoginteSymbolToolStripMenuItem.Text = "Распознать символ";
            this.recoginteSymbolToolStripMenuItem.Click += new System.EventHandler(this.recoginteSymbolToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.trainTheSystemToolStripMenuItem,
            this.recoginteSymbolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(623, 26);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(81, 28);
            this.openFileMenuItem.Text = "Открыть";
            this.openFileMenuItem.Click += new System.EventHandler(this.openImageMenuItem_Click);
            // 
            // trainTheSystemToolStripMenuItem
            // 
            this.trainTheSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectFolderWithTrainingSampleToolStripMenuItem,
            this.writeResultOfLearningToJsonFileToolStripMenuItem,
            this.selectFileWithKeyValuePairsSetToolStripMenuItem});
            this.trainTheSystemToolStripMenuItem.Name = "trainTheSystemToolStripMenuItem";
            this.trainTheSystemToolStripMenuItem.Size = new System.Drawing.Size(140, 28);
            this.trainTheSystemToolStripMenuItem.Text = "Обучить систему";
            // 
            // SelectFolderWithTrainingSampleToolStripMenuItem
            // 
            this.SelectFolderWithTrainingSampleToolStripMenuItem.Name = "SelectFolderWithTrainingSampleToolStripMenuItem";
            this.SelectFolderWithTrainingSampleToolStripMenuItem.Size = new System.Drawing.Size(411, 26);
            this.SelectFolderWithTrainingSampleToolStripMenuItem.Text = "Выбрать папку с обучающей выборкой";
            this.SelectFolderWithTrainingSampleToolStripMenuItem.Click += new System.EventHandler(this.SelectFolderWithTrainingSampleToolStripMenuItem_Click);
            // 
            // writeResultOfLearningToJsonFileToolStripMenuItem
            // 
            this.writeResultOfLearningToJsonFileToolStripMenuItem.Name = "writeResultOfLearningToJsonFileToolStripMenuItem";
            this.writeResultOfLearningToJsonFileToolStripMenuItem.Size = new System.Drawing.Size(411, 26);
            this.writeResultOfLearningToJsonFileToolStripMenuItem.Text = "Записать результаты обучения в json-файл";
            this.writeResultOfLearningToJsonFileToolStripMenuItem.Click += new System.EventHandler(this.writeResultOfLearningToJsonFileToolStripMenuItem_Click);
            // 
            // selectFileWithKeyValuePairsSetToolStripMenuItem
            // 
            this.selectFileWithKeyValuePairsSetToolStripMenuItem.Name = "selectFileWithKeyValuePairsSetToolStripMenuItem";
            this.selectFileWithKeyValuePairsSetToolStripMenuItem.Size = new System.Drawing.Size(411, 26);
            this.selectFileWithKeyValuePairsSetToolStripMenuItem.Text = "Выбрать файл с набором пар ключ-значение";
            this.selectFileWithKeyValuePairsSetToolStripMenuItem.Click += new System.EventHandler(this.selectFileWithKeyValuePairsSetToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProgress.Location = new System.Drawing.Point(565, 700);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelProgress.Size = new System.Drawing.Size(50, 20);
            this.labelProgress.TabIndex = 51;
            this.labelProgress.Text = "0/100";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelProgress.Visible = false;
            // 
            // openFolderDialog
            // 
            this.openFolderDialog.CheckFileExists = false;
            this.openFolderDialog.FileName = "Имя файла будет проигнорировано";
            this.openFolderDialog.ReadOnlyChecked = true;
            this.openFolderDialog.ValidateNames = false;
            // 
            // saveJsonDialog
            // 
            this.saveJsonDialog.Filter = "JSON-file|*.json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 739);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Распознавание символа на изображении";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem recoginteSymbolToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ToolStripMenuItem trainTheSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectFolderWithTrainingSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFileWithKeyValuePairsSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeResultOfLearningToJsonFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFolderDialog;
        private System.Windows.Forms.SaveFileDialog saveJsonDialog;
    }
}

