namespace Тестовое_приложение_по_поиску_файлов__в_репозитории
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.search = new System.Windows.Forms.Button();
            this.textBoxPathString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.formatBackSpace = new System.Windows.Forms.Button();
            this.pathBackSpace = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBoxFileExtension = new System.Windows.Forms.TextBox();
            this.fileExtensionBackSpace = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxCounter = new System.Windows.Forms.TextBox();
            this.textBoxActualDirectory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(682, 10);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(97, 57);
            this.search.TabIndex = 0;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBoxPathString
            // 
            this.textBoxPathString.Location = new System.Drawing.Point(127, 12);
            this.textBoxPathString.Name = "textBoxPathString";
            this.textBoxPathString.Size = new System.Drawing.Size(496, 20);
            this.textBoxPathString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "       Начальная директория поиска";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Путь к файлу";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(127, 47);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(155, 20);
            this.textBoxFileName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя файла";
            // 
            // formatBackSpace
            // 
            this.formatBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.formatBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.formatBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("formatBackSpace.Image")));
            this.formatBackSpace.Location = new System.Drawing.Point(300, 40);
            this.formatBackSpace.Name = "formatBackSpace";
            this.formatBackSpace.Size = new System.Drawing.Size(47, 37);
            this.formatBackSpace.TabIndex = 9;
            this.formatBackSpace.UseVisualStyleBackColor = false;
            this.formatBackSpace.Click += new System.EventHandler(this.FormatBackSpace_Click);
            // 
            // pathBackSpace
            // 
            this.pathBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.pathBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pathBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pathBackSpace.FlatAppearance.BorderSize = 0;
            this.pathBackSpace.ForeColor = System.Drawing.Color.DarkMagenta;
            this.pathBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("pathBackSpace.Image")));
            this.pathBackSpace.Location = new System.Drawing.Point(629, 3);
            this.pathBackSpace.Name = "pathBackSpace";
            this.pathBackSpace.Size = new System.Drawing.Size(47, 37);
            this.pathBackSpace.TabIndex = 10;
            this.pathBackSpace.UseVisualStyleBackColor = false;
            this.pathBackSpace.Click += new System.EventHandler(this.PathBackSpace_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(127, 85);
            this.treeView1.MaximumSize = new System.Drawing.Size(496, 227);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(496, 227);
            this.treeView1.TabIndex = 12;
            // 
            // textBoxFileExtension
            // 
            this.textBoxFileExtension.Location = new System.Drawing.Point(468, 47);
            this.textBoxFileExtension.Name = "textBoxFileExtension";
            this.textBoxFileExtension.Size = new System.Drawing.Size(155, 20);
            this.textBoxFileExtension.TabIndex = 13;
            // 
            // fileExtensionBackSpace
            // 
            this.fileExtensionBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.fileExtensionBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fileExtensionBackSpace.FlatAppearance.BorderSize = 0;
            this.fileExtensionBackSpace.ForeColor = System.Drawing.Color.DarkMagenta;
            this.fileExtensionBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("fileExtensionBackSpace.Image")));
            this.fileExtensionBackSpace.Location = new System.Drawing.Point(629, 42);
            this.fileExtensionBackSpace.Name = "fileExtensionBackSpace";
            this.fileExtensionBackSpace.Size = new System.Drawing.Size(47, 37);
            this.fileExtensionBackSpace.TabIndex = 14;
            this.fileExtensionBackSpace.UseVisualStyleBackColor = false;
            this.fileExtensionBackSpace.Click += new System.EventHandler(this.FileExtensionBackSpace_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(353, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Расширение файла";
            // 
            // TextBoxTime
            // 
            this.TextBoxTime.Location = new System.Drawing.Point(629, 170);
            this.TextBoxTime.Name = "TextBoxTime";
            this.TextBoxTime.Size = new System.Drawing.Size(155, 20);
            this.TextBoxTime.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(641, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Затраченное время:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(641, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Количество подходящих файлов ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // TextBoxCounter
            // 
            this.TextBoxCounter.Location = new System.Drawing.Point(629, 231);
            this.TextBoxCounter.Name = "TextBoxCounter";
            this.TextBoxCounter.Size = new System.Drawing.Size(155, 20);
            this.TextBoxCounter.TabIndex = 19;
            // 
            // textBoxActualDirectory
            // 
            this.textBoxActualDirectory.Location = new System.Drawing.Point(127, 334);
            this.textBoxActualDirectory.Name = "textBoxActualDirectory";
            this.textBoxActualDirectory.Size = new System.Drawing.Size(496, 20);
            this.textBoxActualDirectory.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(9, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "      Актуальная директория поиска";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-27, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-11, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(682, 85);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(97, 57);
            this.stop.TabIndex = 24;
            this.stop.Text = "Стоп";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(791, 366);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxActualDirectory);
            this.Controls.Add(this.TextBoxCounter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileExtensionBackSpace);
            this.Controls.Add(this.textBoxFileExtension);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pathBackSpace);
            this.Controls.Add(this.formatBackSpace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPathString);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(807, 405);
            this.MinimumSize = new System.Drawing.Size(807, 405);
            this.Name = "Form1";
            this.Text = "Найти файл";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBoxPathString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button formatBackSpace;
        private System.Windows.Forms.Button pathBackSpace;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBoxFileExtension;
        private System.Windows.Forms.Button fileExtensionBackSpace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxCounter;
        private System.Windows.Forms.TextBox textBoxActualDirectory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button stop;
    }
}