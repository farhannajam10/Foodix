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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("delete from customer where cell='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("enter cell number");
            }
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
