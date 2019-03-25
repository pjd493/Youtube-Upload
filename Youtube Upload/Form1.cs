using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace Youtube_Upload
{

    public partial class Form1 : Form
    {
        public string privacy = "private";
        public string tag1 = "Unknown";
        public string tag2 = "Not Tagged";


        public File myvideo { get; set; }
        public Form1()
        {

            
            InitializeComponent();
            listBox1.Items.Add("1 -  Film & Animation");
            listBox1.Items.Add("2 - Autos & Vehicles");
            listBox1.Items.Add("10 - Music");
            listBox1.Items.Add("15 - Pets & Animals");
            listBox1.Items.Add("17 - Sports");
            listBox1.Items.Add("18 - Short Movies");
            listBox1.Items.Add("19 - Travel & Events");
            listBox1.Items.Add("20 - Gaming");
            listBox1.Items.Add("21 - Videoblogging");
            listBox1.Items.Add("22 - People & Blogs");
            listBox1.Items.Add("23 - Comedy");
            listBox1.Items.Add("24 - Entertainment");
            listBox1.Items.Add("25 - News & Politics");
            listBox1.Items.Add("26 - Howto & Style");
            listBox1.Items.Add("27 - Education");
            listBox1.Items.Add("28 - Science & Technology");
            listBox1.Items.Add("29 - Nonprofits & Activism");
            listBox1.Items.Add("30 - Movies");
            listBox1.Items.Add("31 - Anime/Animation");
            listBox1.Items.Add("32 - Action/Adventure");
            listBox1.Items.Add("33 - Classics");
            listBox1.Items.Add("34 - Comedy");
            listBox1.Items.Add("35 - Documentary");
            listBox1.Items.Add("36 - Drama");
            listBox1.Items.Add("37 - Family");
            listBox1.Items.Add("38 - Foreign");
            listBox1.Items.Add("39 - Horror");
            listBox1.Items.Add("40 - Sci-Fi/Fantasy");
            listBox1.Items.Add("41 - Thriller");
            listBox1.Items.Add("42 - Shorts");
            listBox1.Items.Add("43 - Shows");
            listBox1.Items.Add("44 - Trailers");
            
            

        }






        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog()
            {
            Filter = "Mp4 Files Only (*.mp4)|*.mp4",
            Title = "Open Mp4 file"
        };
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                FileNameText.Text = fdlg.FileName;
                
            }
        }
        public void PrivacyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (PrivacyRadio.Checked == true)
            { 
            string privacy = "public";
            }
            else
            {
                string privacy = "private";
            }
        }

        public void Upload_Click(object sender, EventArgs e)
        {
           
            string Id = Regex.Match(listBox1.SelectedItem.ToString(), @"\d+").Value;
            File myvideo = new File(VideoTitleText.Text, DescriptionText.Text, tag1, tag2, Id, privacy, FileNameText.Text);
            UploadVideo googlecode = new UploadVideo(myvideo);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryLabel.Text = listBox1.SelectedItem.ToString();
        }

        private void AddTag_Click(object sender, EventArgs e)
        {
            tag1 = tagBox1.Text;
            tag2 = tagBox2.Text;

        }
    }
}
