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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
          
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            }

        private void Close_Click(object sender, EventArgs e)
        {
            
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void rectangleShape1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear() ;
            if (textBox1.Text == " ")
            {
                textBox1.Text = "Username";
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
            if (textBox2.Text == " ")
            {
                textBox2.Text = "Password";
            }
            textBox2.PasswordChar = '*'; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from forgotpassword where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                
                main m = new main();
                this.Hide();
                
                m.Show();
            }

            else
            {
                MessageBox.Show("Incorrect Username or Password");

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetPass rp = new ResetPass();
            rp.Show();
            this.Hide();

        }

        }
    }

