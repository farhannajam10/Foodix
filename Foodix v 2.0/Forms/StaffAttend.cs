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
    public partial class StaffAttend : Form
    {
        public StaffAttend()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = "Absent";
            string j = "Absent";
            string a = "Absent";
            string mi = "Absent";
            string m = "Absent";

            if (checkBox1.Checked == true)
            {
                t = "Present";
            }
            if (checkBox4.Checked == true)
            {
                j = "Present";
            } if (checkBox6.Checked == true)
            {
                a = "Present";
            } if (checkBox8.Checked == true)
            {
                mi = "Present";
            } if (checkBox10.Checked == true)
            {
                m = "Present";
            }


            con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("insert into attend(Tom,John,Alex,Micheal,Mark,date)values('" + t + "','" + j + "','" + a + "','" + mi + "','" + m + "','" + DateTime.Now.ToString("dd MMMM yyyy") + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("success");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
            con.Open();

            SqlDataAdapter sdp = new SqlDataAdapter("select * from attend", con);
            DataTable dtt = new DataTable();
            sdp.Fill(dtt);
            dataGridView1.DataSource = dtt;
            con.Close();
        }
    }
}
