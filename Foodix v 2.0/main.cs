using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodix_v_2._0
{
    public partial class main : Form
    {
        private Form activeForm;
        public main()
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
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm( new Forms.RegCustomer(),sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm( new Forms.Statics(),sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm( new Forms.BeforeMenu(),sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm( new Forms.UpdateCustomer(),sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm( new Forms.DeleteCustomer(),sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm( new Forms.StaffAttend(),sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(), sender);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
