
namespace FileSearch
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.RegexTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InitFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.FileCountLabel = new System.Windows.Forms.Label();
            this.CurrentFolderLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProceedThreadButton = new System.Windows.Forms.Button();
            this.PauseThreadButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.OpenFolderButton);
            this.panel1.Controls.Add(this.RegexTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.InitFolderTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(729, 57);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(67, 27);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.FlatAppearance.BorderSize = 0;
            this.OpenFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolderButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFolderButton.Location = new System.Drawing.Point(741, 20);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(37, 27);
            this.OpenFolderButton.TabIndex = 4;
            this.OpenFolderButton.Text = ". . .";
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // RegexTextBox
            // 
            this.RegexTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegexTextBox.Location = new System.Drawing.Point(182, 57);
            this.RegexTextBox.Name = "RegexTextBox";
            this.RegexTextBox.Size = new System.Drawing.Size(383, 26);
            this.RegexTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Шаблон поиска:";
            // 
            // InitFolderTextBox
            // 
            this.InitFolderTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitFolderTextBox.Location = new System.Drawing.Point(182, 21);
            this.InitFolderTextBox.Name = "InitFolderTextBox";
            this.InitFolderTextBox.Size = new System.Drawing.Size(541, 26);
            this.InitFolderTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стартовая директория:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ElapsedTimeLabel);
            this.panel2.Controls.Add(this.FileCountLabel);
            this.panel2.Controls.Add(this.CurrentFolderLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ProceedThreadButton);
            this.panel2.Controls.Add(this.PauseThreadButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 380);
            this.panel2.TabIndex = 1;
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(476, 247);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(312, 19);
            this.ElapsedTimeLabel.TabIndex = 13;
            this.ElapsedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileCountLabel
            // 
            this.FileCountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileCountLabel.Location = new System.Drawing.Point(476, 179);
            this.FileCountLabel.Name = "FileCountLabel";
            this.FileCountLabel.Size = new System.Drawing.Size(312, 19);
            this.FileCountLabel.TabIndex = 12;
            this.FileCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentFolderLabel
            // 
            this.CurrentFolderLabel.AutoSize = true;
            this.CurrentFolderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentFolderLabel.Location = new System.Drawing.Point(476, 47);
            this.CurrentFolderLabel.MaximumSize = new System.Drawing.Size(312, 70);
            this.CurrentFolderLabel.Name = "CurrentFolderLabel";
            this.CurrentFolderLabel.Size = new System.Drawing.Size(0, 19);
            this.CurrentFolderLabel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(472, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Затрачено времени:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(472, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Найдено файлов:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(472, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Текущая директория:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProceedThreadButton
            // 
            this.ProceedThreadButton.FlatAppearance.BorderSize = 0;
            this.ProceedThreadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedThreadButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProceedThreadButton.Location = new System.Drawing.Point(670, 326);
            this.ProceedThreadButton.Name = "ProceedThreadButton";
            this.ProceedThreadButton.Size = new System.Drawing.Size(108, 27);
            this.ProceedThreadButton.TabIndex = 7;
            this.ProceedThreadButton.Text = "Продолжить";
            this.ProceedThreadButton.UseVisualStyleBackColor = true;
            this.ProceedThreadButton.Click += new System.EventHandler(this.ProceedThreadButton_Click);
            // 
            // PauseThreadButton
            // 
            this.PauseThreadButton.FlatAppearance.BorderSize = 0;
            this.PauseThreadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseThreadButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseThreadButton.Location = new System.Drawing.Point(497, 326);
            this.PauseThreadButton.Name = "PauseThreadButton";
            this.PauseThreadButton.Size = new System.Drawing.Size(108, 27);
            this.PauseThreadButton.TabIndex = 6;
            this.PauseThreadButton.Text = "Пауза";
            this.PauseThreadButton.UseVisualStyleBackColor = true;
            this.PauseThreadButton.Click += new System.EventHandler(this.PauseThreadButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icons8-file-20.png");
            this.imageList.Images.SetKeyName(1, "icons8-folder-20.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск файлов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button OpenFolderButton;
        private System.Windows.Forms.TextBox RegexTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InitFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ElapsedTimeLabel;
        private System.Windows.Forms.Label FileCountLabel;
        private System.Windows.Forms.Label CurrentFolderLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ProceedThreadButton;
        private System.Windows.Forms.Button PauseThreadButton;
        private System.Windows.Forms.ImageList imageList;
    }
}

