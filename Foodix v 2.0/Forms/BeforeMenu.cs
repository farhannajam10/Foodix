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
    public partial class BeforeMenu : Form
    {
        public BeforeMenu()
        {
            InitializeComponent();
        }
        SqlConnection con;
        int check = 0;
        int pr = 0;
        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void BeforeMenu_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

            textBox1.Enabled = false;
            button1.Enabled = false;

            label5.Text = "Name     : " + customerData.name;
            label4.Text = "Email    : " + customerData.email;
            label7.Text = "CNIC     : " + customerData.cnic;
            label8.Text = "Cell     : " + customerData.cell;
            label3.Hide();
            label6.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
            con.Open();

            SqlCommand cqd = new SqlCommand("select * from customer where cell='" + textBox1.Text + "'", con);
            SqlDataReader reader = cqd.ExecuteReader();
            if (reader.Read())
            {


                label5.Text = "Name     : " + reader[0].ToString();
                label4.Text = "Email    : " + reader[2].ToString();
                label7.Text = "CNIC     : " + reader[3].ToString();
                label8.Text = "Cell     : " + reader[1].ToString();
                pr = Convert.ToInt32(reader[4].ToString());
                label3.Text = "Previous Products : " + pr;
                check = Convert.ToInt32(reader[5].ToString());
                label6.Text = "Previous amount    : " + check;

                customerData.name = label5.Text;
                customerData.cell = label8.Text;
                customerData.cnic = label7.Text;
                customerData.email = label4.Text;

                customerData.ucell = reader[1].ToString();



            }
            con.Close();

            if (check < -500)
            {
                MessageBox.Show("Please Clear remainig bill \n " + check);

                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            customerData.ch = "1";
            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

            label3.Show();
            label6.Show();

            label5.Text = "";
            label4.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            customerData.ch = "0";

            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;


            label5.Text = "Name     : " + customerData.name;
            label4.Text = "Email    : " + customerData.email;
            label7.Text = "CNIC     : " + customerData.cnic;
            label8.Text = "Cell     : " + customerData.cell;

            label3.Hide();
            label6.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MENU(), sender);
        }
    }
}
