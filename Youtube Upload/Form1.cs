using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Upload
{

    public partial class Form1 : Form
    {
        public File myvideo { get; set; }
        public Form1()
        {
            InitializeComponent();
        }






        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                FileNameText.Text = fdlg.FileName;
            }
        }

        public void Upload_Click(object sender, EventArgs e)
        {

            File myvideo = new File(VideoTitleText.Text, DescriptionText.Text, TagList.Text, , FileNameText.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
