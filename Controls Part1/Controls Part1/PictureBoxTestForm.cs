using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls_Part1
{
    public partial class PictureBoxTestForm : Form
    {
        private int imageNum = -1; // determines which image is displayed
        public PictureBoxTestForm()
        {
            InitializeComponent();
        }

        private void PictureBoxTestForm_Load(object sender, EventArgs e)
        {

        }

        private void displayNextImage_Click(object sender, EventArgs e)
        {
            imageNum = (imageNum + 1) % 3; // imageNum cycles from 0 to 2
            // retrieve image from resources and load into PictureBox
            imagePictureBox.Image = (Image) (Properties.Resources.ResourceManager.GetObject(string.Format("img{0}", imageNum )) ) ;
        }
    }
}
