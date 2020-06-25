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
    public partial class RegCustomer : Form
    {
        public RegCustomer()
        {
            InitializeComponent();
        }

        SqlConnection con;
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
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                if (radioButton2.Checked == true)
                {
                    con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into customer(name,cell,email,cnic,products,amount)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','0','0')", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    OpenChildForm(new Forms.BeforeMenu(), sender);
                }
                if (radioButton1.Checked == true)
                {
                    customerData.name = textBox1.Text;
                    customerData.cell = textBox2.Text;
                    customerData.cnic = textBox3.Text;
                    customerData.email = textBox4.Text;
                    OpenChildForm(new Forms.BeforeMenu(), sender);
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }
    }
}
