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
            this.TagList = new System.Windows.Forms.ListBox();
            this.AddTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(116, 511);
            this.SelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(100, 28);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // FileNameText
            // 
            this.FileNameText.AutoSize = true;
            this.FileNameText.Location = new System.Drawing.Point(224, 516);
            this.FileNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.Size = new System.Drawing.Size(111, 17);
            this.FileNameText.TabIndex = 1;
            this.FileNameText.Text = "No File Selected";
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(16, 511);
            this.Upload.Margin = new System.Windows.Forms.Padding(4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(92, 28);
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
            this.VideoTitleText.Size = new System.Drawing.Size(455, 56);
            this.VideoTitleText.TabIndex = 3;
            this.VideoTitleText.Text = "Enter Video Title Here";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(16, 74);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(455, 300);
            this.DescriptionText.TabIndex = 4;
            this.DescriptionText.Text = "Enter your video description ...";
            // 
            // TagList
            // 
            this.TagList.FormattingEnabled = true;
            this.TagList.ItemHeight = 16;
            this.TagList.Location = new System.Drawing.Point(477, 74);
            this.TagList.Name = "TagList";
            this.TagList.Size = new System.Drawing.Size(120, 292);
            this.TagList.TabIndex = 5;
            // 
            // AddTag
            // 
            this.AddTag.Location = new System.Drawing.Point(493, 372);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(75, 27);
            this.AddTag.TabIndex = 6;
            this.AddTag.Text = "Add Tag";
            this.AddTag.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 554);
            this.Controls.Add(this.AddTag);
            this.Controls.Add(this.TagList);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.VideoTitleText);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.FileNameText);
            this.Controls.Add(this.SelectFile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ListBox TagList;
        private System.Windows.Forms.Button AddTag;
    }
}

