namespace Youtube_Upload
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
            this.SelectFile = new System.Windows.Forms.Button();
            this.FileNameText = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.Button();
            this.VideoTitleText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.AddTag = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.PrivacyRadio = new System.Windows.Forms.RadioButton();
            this.tagBox2 = new System.Windows.Forms.TextBox();
            this.tagBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(318, 553);
            this.SelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(140, 47);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // FileNameText
            // 
            this.FileNameText.AutoSize = true;
            this.FileNameText.Location = new System.Drawing.Point(315, 523);
            this.FileNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.Size = new System.Drawing.Size(111, 17);
            this.FileNameText.TabIndex = 1;
            this.FileNameText.Text = "No File Selected";
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(171, 553);
            this.Upload.Margin = new System.Windows.Forms.Padding(4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(129, 47);
            this.Upload.TabIndex = 2;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // VideoTitleText
            // 
            this.VideoTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTitleText.Location = new System.Drawing.Point(12, 12);
            this.VideoTitleText.Name = "VideoTitleText";
            this.VideoTitleText.Size = new System.Drawing.Size(487, 56);
            this.VideoTitleText.TabIndex = 3;
            this.VideoTitleText.Text = "Enter Video Title Here";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(16, 74);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(465, 300);
            this.DescriptionText.TabIndex = 4;
            this.DescriptionText.Text = "Enter your video description ...";
            // 
            // AddTag
            // 
            this.AddTag.Location = new System.Drawing.Point(509, 130);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(93, 27);
            this.AddTag.TabIndex = 6;
            this.AddTag.Text = "Add Tags";
            this.AddTag.UseVisualStyleBackColor = true;
            this.AddTag.Click += new System.EventHandler(this.AddTag_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 402);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 84);
            this.listBox1.TabIndex = 7;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(12, 382);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(183, 17);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Please select one category.";
            // 
            // CategoryButton
            // 
            this.CategoryButton.Location = new System.Drawing.Point(65, 492);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(75, 23);
            this.CategoryButton.TabIndex = 9;
            this.CategoryButton.Text = "Enter";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // PrivacyRadio
            // 
            this.PrivacyRadio.AutoSize = true;
            this.PrivacyRadio.Location = new System.Drawing.Point(214, 477);
            this.PrivacyRadio.Name = "PrivacyRadio";
            this.PrivacyRadio.Size = new System.Drawing.Size(311, 21);
            this.PrivacyRadio.TabIndex = 10;
            this.PrivacyRadio.TabStop = true;
            this.PrivacyRadio.Text = "Select to make Video Public (Default Private)";
            this.PrivacyRadio.UseVisualStyleBackColor = true;
            this.PrivacyRadio.CheckedChanged += new System.EventHandler(this.PrivacyRadio_CheckedChanged);
            // 
            // tagBox2
            // 
            this.tagBox2.Location = new System.Drawing.Point(487, 102);
            this.tagBox2.Name = "tagBox2";
            this.tagBox2.Size = new System.Drawing.Size(135, 22);
            this.tagBox2.TabIndex = 11;
            this.tagBox2.Text = "Enter Tag 2";
            // 
            // tagBox1
            // 
            this.tagBox1.Location = new System.Drawing.Point(487, 74);
            this.tagBox1.Name = "tagBox1";
            this.tagBox1.Size = new System.Drawing.Size(135, 22);
            this.tagBox1.TabIndex = 12;
            this.tagBox1.Text = "Enter Tag 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 613);
            this.Controls.Add(this.tagBox1);
            this.Controls.Add(this.tagBox2);
            this.Controls.Add(this.PrivacyRadio);
            this.Controls.Add(this.CategoryButton);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddTag);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.VideoTitleText);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.FileNameText);
            this.Controls.Add(this.SelectFile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Youtube Video Upload";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label FileNameText;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.TextBox VideoTitleText;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Button AddTag;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.RadioButton PrivacyRadio;
        private System.Windows.Forms.TextBox tagBox2;
        private System.Windows.Forms.TextBox tagBox1;
    }
}

