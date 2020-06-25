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
    public partial class Statics : Form
    {
        public Statics()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void Statics_Load(object sender, EventArgs e)
        {
            
            this.recordTableAdapter.Fill(this.foodixDataSet.record);
            con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from customer", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

           

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
