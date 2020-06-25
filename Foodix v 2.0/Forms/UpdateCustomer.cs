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

namespace Foodix_v_2._0.Forms
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;
        }
        SqlConnection con;

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
            con.Open();

            SqlCommand cnd = new SqlCommand("UPDATE customer SET name='" + textBox1.Text + "',cell='" + textBox2.Text + "',email='" + textBox3.Text + "',cnic='" + textBox4.Text + "',products='" + textBox5.Text + "',amount='" + textBox6.Text + "' WHERE cell='" + textBox2.Text + "'", con);
            cnd.ExecuteNonQuery();

            MessageBox.Show("success");


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {
                button2.Enabled = true;
                con = new SqlConnection("Data Source= FARHAN;Initial Catalog=foodix;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from customer where cell='" + textBox2.Text + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                    textBox5.Text = reader[4].ToString();
                    textBox6.Text = reader[5].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid cell number");
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("enter cell number");
            }
        }
    }
}
