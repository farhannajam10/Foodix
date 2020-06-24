using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodix_v_2._0.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 6)
            {
               imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
