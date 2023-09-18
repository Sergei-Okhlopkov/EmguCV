namespace EmguCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.choosePhotoBtn = new System.Windows.Forms.Button();
            this.findPoseBtn = new System.Windows.Forms.Button();
            this.picChoose = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.photo = new System.Windows.Forms.TabPage();
            this.video = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cameraCMB = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startBtn = new System.Windows.Forms.ToolStripButton();
            this.pauseBtn = new System.Windows.Forms.ToolStripButton();
            this.stopBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RecognitionBtn = new System.Windows.Forms.ToolStripButton();
            this.originalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.savePictureBtn = new System.Windows.Forms.Button();
            this.videoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.photo.SuspendLayout();
            this.video.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // choosePhotoBtn
            // 
            this.choosePhotoBtn.Location = new System.Drawing.Point(150, 15);
            this.choosePhotoBtn.Name = "choosePhotoBtn";
            this.choosePhotoBtn.Size = new System.Drawing.Size(163, 63);
            this.choosePhotoBtn.TabIndex = 0;
            this.choosePhotoBtn.Text = "Выбрать фото";
            this.choosePhotoBtn.UseVisualStyleBackColor = true;
            this.choosePhotoBtn.Click += new System.EventHandler(this.ChooseClick);
            // 
            // findPoseBtn
            // 
            this.findPoseBtn.Location = new System.Drawing.Point(452, 15);
            this.findPoseBtn.Name = "findPoseBtn";
            this.findPoseBtn.Size = new System.Drawing.Size(163, 63);
            this.findPoseBtn.TabIndex = 1;
            this.findPoseBtn.Text = "Найти позу";
            this.findPoseBtn.UseVisualStyleBackColor = true;
            this.findPoseBtn.Click += new System.EventHandler(this.FindPoseClick);
            // 
            // picChoose
            // 
            this.picChoose.Location = new System.Drawing.Point(3, 60);
            this.picChoose.Name = "picChoose";
            this.picChoose.Size = new System.Drawing.Size(505, 400);
            this.picChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChoose.TabIndex = 2;
            this.picChoose.TabStop = false;
            // 
            // picShow
            // 
            this.picShow.Location = new System.Drawing.Point(514, 60);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(532, 400);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 3;
            this.picShow.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.savePictureBtn);
            this.panel1.Controls.Add(this.choosePhotoBtn);
            this.panel1.Controls.Add(this.findPoseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 89);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.originalLabel);
            this.panel2.Controls.Add(this.picChoose);
            this.panel2.Controls.Add(this.picShow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 555);
            this.panel2.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.photo);
            this.tabControl.Controls.Add(this.video);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1065, 590);
            this.tabControl.TabIndex = 7;
            // 
            // photo
            // 
            this.photo.Controls.Add(this.panel1);
            this.photo.Controls.Add(this.panel2);
            this.photo.Location = new System.Drawing.Point(4, 25);
            this.photo.Name = "photo";
            this.photo.Padding = new System.Windows.Forms.Padding(3);
            this.photo.Size = new System.Drawing.Size(1057, 561);
            this.photo.TabIndex = 0;
            this.photo.Text = "Фото";
            this.photo.UseVisualStyleBackColor = true;
            // 
            // video
            // 
            this.video.Controls.Add(this.videoBox);
            this.video.Controls.Add(this.toolStrip1);
            this.video.Location = new System.Drawing.Point(4, 25);
            this.video.Name = "video";
            this.video.Padding = new System.Windows.Forms.Padding(3);
            this.video.Size = new System.Drawing.Size(1057, 561);
            this.video.TabIndex = 1;
            this.video.Text = "Видео";
            this.video.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cameraCMB,
            this.toolStripSeparator1,
            this.startBtn,
            this.pauseBtn,
            this.stopBtn,
            this.toolStripSeparator2,
            this.RecognitionBtn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1051, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 25);
            this.toolStripLabel1.Text = "Камера:";
            // 
            // cameraCMB
            // 
            this.cameraCMB.Name = "cameraCMB";
            this.cameraCMB.Size = new System.Drawing.Size(121, 28);
            this.cameraCMB.SelectedIndexChanged += new System.EventHandler(this.cameraCMB_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // startBtn
            // 
            this.startBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startBtn.Image = ((System.Drawing.Image)(resources.GetObject("startBtn.Image")));
            this.startBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(51, 25);
            this.startBtn.Text = "Старт";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pauseBtn.Image = ((System.Drawing.Image)(resources.GetObject("pauseBtn.Image")));
            this.pauseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(54, 25);
            this.pauseBtn.Text = "Пауза";
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(46, 25);
            this.stopBtn.Text = "Стоп";
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // RecognitionBtn
            // 
            this.RecognitionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RecognitionBtn.Image = ((System.Drawing.Image)(resources.GetObject("RecognitionBtn.Image")));
            this.RecognitionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RecognitionBtn.Name = "RecognitionBtn";
            this.RecognitionBtn.Size = new System.Drawing.Size(120, 25);
            this.RecognitionBtn.Text = "Распознавание";
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalLabel.Location = new System.Drawing.Point(95, 32);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(299, 25);
            this.originalLabel.TabIndex = 4;
            this.originalLabel.Text = "Оригинальное изображение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(700, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "С положением тела";
            // 
            // savePictureBtn
            // 
            this.savePictureBtn.Location = new System.Drawing.Point(740, 15);
            this.savePictureBtn.Name = "savePictureBtn";
            this.savePictureBtn.Size = new System.Drawing.Size(163, 63);
            this.savePictureBtn.TabIndex = 2;
            this.savePictureBtn.Text = "Сохранить";
            this.savePictureBtn.UseVisualStyleBackColor = true;
            this.savePictureBtn.Click += new System.EventHandler(this.SaveRecognizedPosePhoto);
            // 
            // videoBox
            // 
            this.videoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoBox.Location = new System.Drawing.Point(3, 31);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(1051, 527);
            this.videoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoBox.TabIndex = 1;
            this.videoBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 620);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EmguCV App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.photo.ResumeLayout(false);
            this.video.ResumeLayout(false);
            this.video.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choosePhotoBtn;
        private System.Windows.Forms.Button findPoseBtn;
        private System.Windows.Forms.PictureBox picChoose;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage photo;
        private System.Windows.Forms.TabPage video;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cameraCMB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton startBtn;
        private System.Windows.Forms.ToolStripButton pauseBtn;
        private System.Windows.Forms.ToolStripButton stopBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton RecognitionBtn;
        private System.Windows.Forms.Button savePictureBtn;
        private System.Windows.Forms.PictureBox videoBox;
    }
}

