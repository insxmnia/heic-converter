namespace HeicConverter
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            TopPanel = new Panel();
            Title = new Label();
            pictureBox1 = new PictureBox();
            MinimizeBtn = new Label();
            CloseBtn = new Label();
            Version = new Label();
            VersionLbl = new Label();
            ImagePath = new TextBox();
            SelectFile = new Label();
            ImgPathLbl = new Label();
            pictureBox2 = new PictureBox();
            ConvertOption = new ComboBox();
            button1 = new Button();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(28, 28, 28);
            TopPanel.Controls.Add(Title);
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Controls.Add(MinimizeBtn);
            TopPanel.Controls.Add(CloseBtn);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(316, 30);
            TopPanel.TabIndex = 1;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.ForeColor = Color.PaleGreen;
            Title.Location = new Point(43, 7);
            Title.Name = "Title";
            Title.Size = new Size(107, 17);
            Title.TabIndex = 2;
            Title.Text = "HEIC Converter";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.AutoSize = true;
            MinimizeBtn.BackColor = Color.Transparent;
            MinimizeBtn.Cursor = Cursors.Hand;
            MinimizeBtn.Location = new Point(270, 4);
            MinimizeBtn.Margin = new Padding(0);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(15, 17);
            MinimizeBtn.TabIndex = 3;
            MinimizeBtn.Text = "_";
            MinimizeBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.BackColor = Color.Transparent;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Location = new Point(290, 6);
            CloseBtn.Margin = new Padding(0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(16, 17);
            CloseBtn.TabIndex = 2;
            CloseBtn.Text = "X";
            CloseBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.ForeColor = Color.MintCream;
            Version.Location = new Point(71, 416);
            Version.Name = "Version";
            Version.Size = new Size(37, 17);
            Version.TabIndex = 4;
            Version.Text = "1.0.1";
            // 
            // VersionLbl
            // 
            VersionLbl.AutoSize = true;
            VersionLbl.ForeColor = Color.PaleGreen;
            VersionLbl.Location = new Point(12, 416);
            VersionLbl.Name = "VersionLbl";
            VersionLbl.Size = new Size(58, 17);
            VersionLbl.TabIndex = 3;
            VersionLbl.Text = "Version:";
            // 
            // ImagePath
            // 
            ImagePath.BackColor = Color.FromArgb(224, 224, 224);
            ImagePath.BorderStyle = BorderStyle.FixedSingle;
            ImagePath.ForeColor = SystemColors.GrayText;
            ImagePath.Location = new Point(12, 74);
            ImagePath.Name = "ImagePath";
            ImagePath.ReadOnly = true;
            ImagePath.Size = new Size(266, 23);
            ImagePath.TabIndex = 2;
            // 
            // SelectFile
            // 
            SelectFile.AutoSize = true;
            SelectFile.Cursor = Cursors.Hand;
            SelectFile.Location = new Point(284, 74);
            SelectFile.Name = "SelectFile";
            SelectFile.Size = new Size(20, 17);
            SelectFile.TabIndex = 3;
            SelectFile.Text = "...";
            // 
            // ImgPathLbl
            // 
            ImgPathLbl.AutoSize = true;
            ImgPathLbl.Location = new Point(12, 54);
            ImgPathLbl.Name = "ImgPathLbl";
            ImgPathLbl.Size = new Size(84, 17);
            ImgPathLbl.TabIndex = 4;
            ImgPathLbl.Text = "Image Path";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(292, 221);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // ConvertOption
            // 
            ConvertOption.BackColor = Color.White;
            ConvertOption.FlatStyle = FlatStyle.Flat;
            ConvertOption.ForeColor = SystemColors.GrayText;
            ConvertOption.FormattingEnabled = true;
            ConvertOption.Items.AddRange(new object[] { "JPEG", "PNG" });
            ConvertOption.Location = new Point(12, 330);
            ConvertOption.Name = "ConvertOption";
            ConvertOption.Size = new Size(161, 25);
            ConvertOption.TabIndex = 6;
            ConvertOption.Text = "Select Option";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 36, 36);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(179, 330);
            button1.Name = "button1";
            button1.Size = new Size(125, 25);
            button1.TabIndex = 7;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(316, 446);
            Controls.Add(Version);
            Controls.Add(VersionLbl);
            Controls.Add(button1);
            Controls.Add(ConvertOption);
            Controls.Add(pictureBox2);
            Controls.Add(ImgPathLbl);
            Controls.Add(SelectFile);
            Controls.Add(ImagePath);
            Controls.Add(TopPanel);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "HEIC Converter - Dashboard";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel TopPanel;
        private Label CloseBtn;
        private Label Version;
        private Label VersionLbl;
        private Label Title;
        private PictureBox pictureBox1;
        private Label MinimizeBtn;
        private TextBox ImagePath;
        private Label SelectFile;
        private Label ImgPathLbl;
        private PictureBox pictureBox2;
        private ComboBox ConvertOption;
        private Button button1;
    }
}
