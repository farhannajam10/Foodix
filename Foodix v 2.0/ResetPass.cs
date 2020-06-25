using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodix_v_2._0
{
    public partial class ResetPass : Form
    {
        string randomcode;
        public static string to;
        public ResetPass()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                   }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage m = new MailMessage();
            to = (textBox1.Text).ToString();
            from = "foodix10@gmail.com";
            pass = "Foodix123";
            messagebody = "your reset code is " + randomcode;
            m.To.Add(to);
            m.From = new MailAddress(from);
            m.Body = messagebody;
            m.Subject = "Password Reseting Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(m);
                MessageBox.Show("Code Send Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomcode == (textBox2.Text).ToString())
            {
                to = textBox1.Text;
                newPass np = new newPass();
                this.Hide();
                np.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            if (textBox1.Text == " ")
            {
                textBox1.Text = "Enter Email ID";
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
            if (textBox2.Text == " ")
            {
                textBox2.Text = "Enter Code";
            }
        }
    }
}
