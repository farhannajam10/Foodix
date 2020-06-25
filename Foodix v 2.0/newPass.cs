using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodix_v_2._0
{
    public partial class newPass : Form
    {
        string username = ResetPass.to;
        public newPass()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                SqlConnection con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE forgotpassword SET password ='" + textBox2.Text + "'WHERE username='" + username + "' ", con);
                
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("password updated");
                con.Close();
            }
            else
            {
                MessageBox.Show("passwords dont match! enter same passwords");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPass rs = new ResetPass();
            rs.Show();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            if (textBox1.Text == " ")
            {
                textBox1.Text = "Enter New Password";
            }
            textBox1.PasswordChar = '*';

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
            if (textBox2.Text == " ")
            {
                textBox2.Text = "Confirm Password";
            }
            textBox2.PasswordChar = '*';
        }
    }
}
