using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Foodix_v_2._0.Forms
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }
        int total = 0;
        SqlConnection con;
        
        private void MENU_Load(object sender, EventArgs e)
        {


            tb9.Enabled = false;
            tb10.Enabled = false;
            tb1.Enabled = false;
            tb2.Enabled = false;
            tb3.Enabled = false;
            tb4.Enabled = false;
            tb5.Enabled = false;
            tb6.Enabled = false;
            tb7.Enabled = false;
            tb8.Enabled = false;
            tb11.Enabled = false;
            tb14.Enabled = false;
            tb13.Enabled = false;
            tb12.Enabled = false;
            tb17.Enabled = false;
            tb16.Enabled = false;
            tb15.Enabled = false;
            tb20.Enabled = false;
            tb19.Enabled = false;
            tb18.Enabled = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

          private void button1_Click_1(object sender, EventArgs e)
        {

        
            try
            {
                if (checkBox1.Checked == true)
                {
                    int p1 = int.Parse(tb1.Text);
                    total += 120 * p1;
                }
                if (checkBox2.Checked == true)
                {
                    int p2 = int.Parse(tb2.Text);
                    total += 100 * p2;
                }
                if (checkBox3.Checked == true)
                {
                    int p3 = int.Parse(tb3.Text);
                    total += 110 * p3;
                }
                if (checkBox4.Checked == true)
                {
                    int p4 = int.Parse(tb4.Text);
                    total += 170 * p4;
                }

                if (checkBox5.Checked == true)
                {
                    int p5 = int.Parse(tb5.Text);
                    total += 110 * p5;
                }
                if (checkBox6.Checked == true)
                {
                    int p6 = int.Parse(tb6.Text);
                    total += 120 * p6;
                }
                if (checkBox7.Checked == true)
                {
                    int p7 = int.Parse(tb7.Text);
                    total += 130 * p7;
                }
                if (checkBox8.Checked == true)
                {
                    int p8 = int.Parse(tb8.Text);
                    total += 180 * p8;
                }



                if (checkBox9.Checked == true)
                {
                    int p9 = int.Parse(tb9.Text);
                    total += 100 * p9;
                }
                if (checkBox10.Checked == true)
                {
                    int p10 = int.Parse(tb10.Text);
                    total += 110 * p10;
                }
                if (checkBox11.Checked == true)
                {
                    int p11 = int.Parse(tb11.Text);
                    total += 130 * p11;
                }



                if (checkBox12.Checked == true)
                {
                    int p12 = int.Parse(tb12.Text);
                    total += 250 * p12;
                }
                if (checkBox13.Checked == true)
                {
                    int p13 = int.Parse(tb13.Text);
                    total += 250 * p13;
                }
                if (checkBox14.Checked == true)
                {
                    int p14 = int.Parse(tb14.Text);
                    total += 400 * p14;
                }


                if (checkBox15.Checked == true)
                {
                    int p15 = int.Parse(tb15.Text);
                    total += 280 * p15;
                }
                if (checkBox16.Checked == true)
                {
                    int p16 = int.Parse(tb16.Text);
                    total += 430 * p16;
                }
                if (checkBox17.Checked == true)
                {
                    int p17 = int.Parse(tb17.Text);
                    total += 320 * p17;
                }


                if (checkBox18.Checked == true)
                {
                    int p18 = int.Parse(tb18.Text);
                    total += 65 * p18;
                }
                if (checkBox19.Checked == true)
                {
                    int p19 = int.Parse(tb19.Text);
                    total += 25 * p19;
                }
                if (checkBox20.Checked == true)
                {
                    int p20 = int.Parse(tb20.Text);
                    total += 30 * p20;
                }

                textBox21.Text = Convert.ToString(total);

                float to = float.Parse(textBox21.Text);
                float discount = to * 0.30f;
                textBox22.Text = Convert.ToString(discount);
                float final = to - discount;
                textBox23.Text = Convert.ToString(final);

                con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into record(customerName,Totalbill)values('" + customerData.name + "','" + textBox23.Text + "')", con);
                cmd.ExecuteNonQuery();

                con.Close();
               
            }
            catch
            {
                MessageBox.Show("Enter complete data");
            }

        }
          
            
          
        private void select_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            tb1.Enabled = true;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            tb2.Enabled = true;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            tb3.Enabled = true;
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            tb4.Enabled = true;
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            tb5.Enabled = true;
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            tb6.Enabled = true;
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            tb7.Enabled = true;
        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            tb8.Enabled = true;
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            tb9.Enabled = true;
        }

        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            tb10.Enabled = true;
        }

        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            tb11.Enabled = true;
        }

        private void checkBox12_CheckedChanged_1(object sender, EventArgs e)
        {
            tb12.Enabled = true;
        }

        private void checkBox13_CheckedChanged_1(object sender, EventArgs e)
        {
            tb13.Enabled = true;
        }

        private void checkBox14_CheckedChanged_1(object sender, EventArgs e)
        {
            tb14.Enabled = true;
        }

        private void checkBox15_CheckedChanged_1(object sender, EventArgs e)
        {
            tb15.Enabled = true;
        }

        private void checkBox16_CheckedChanged_1(object sender, EventArgs e)
        {
            tb16.Enabled = true;
        }

        private void checkBox17_CheckedChanged_1(object sender, EventArgs e)
        {
            tb17.Enabled = true;
        }

        private void checkBox18_CheckedChanged_1(object sender, EventArgs e)
        {
            tb18.Enabled = true;
        }

        private void checkBox19_CheckedChanged_1(object sender, EventArgs e)
        {
            tb19.Enabled = true;
        }

        private void checkBox20_CheckedChanged_1(object sender, EventArgs e)
        {
            tb20.Enabled = true;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            tb15.Enabled = true;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            tb16.Enabled = true;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            tb17.Enabled = true;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            tb18.Enabled = true;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            tb19.Enabled = true;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            tb20.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {   if (customerData.ch == "0")
            {
                Random r = new Random();
                int ran = r.Next(89099, 999999);
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("" + customerData.ucell + ".pdf", FileMode.Create));
                doc.Open();

                Paragraph a = new Paragraph("\n\n                                                          INVOICE");
                doc.Add(a);

                Paragraph p = new Paragraph("                                             **** Foodix **** \n\n");
                doc.Add(p);

                Paragraph p1 = new Paragraph("                  Date  :  " + DateTime.Now.ToString("MM/dd/yyyy") + "\n");
                doc.Add(p1);

                Paragraph p2 = new Paragraph("                  Time  :  " + DateTime.Now.ToString("HH:mm:ss") + "\n");
                doc.Add(p2);


                Paragraph p90 = new Paragraph("                  Invoice number  :  " + ran + "\n\n");
                doc.Add(p90);

                Paragraph p3 = new Paragraph("                  _____________________________________________  \n\n");
                doc.Add(p3);

                Paragraph p4 = new Paragraph("                  Customer Name  :  " + customerData.name + "\n");
                doc.Add(p4);

                Paragraph po = new Paragraph("                  Product Name  : Food items \n");
                doc.Add(po);


                Paragraph p7 = new Paragraph("                  Total amount  :  " + textBox23.Text + "\n\n");
                doc.Add(p7);

                Paragraph p8 = new Paragraph("                  _____________________________________________\n\n");
                doc.Add(p8);

                Paragraph p9 = new Paragraph("                  Thanks for purchase from us ");
                doc.Add(p9);

                Paragraph p10 = new Paragraph("                  Contact us : 03323464305 \n\n");
                doc.Add(p10);

                Paragraph pl = new Paragraph("                   copyright all rights reserved farhan ali and zubair ");
                doc.Add(pl);





                doc.Close();
                MessageBox.Show("success");




            }
            else if (customerData.ch == "1")
            {
                con = new SqlConnection("Data Source= FARHAN-PC\\SQLEXPRESS;Initial Catalog=foodix;Integrated Security=True");
                con.Open();
                MessageBox.Show(customerData.ucell);
                SqlCommand cnd = new SqlCommand("UPDATE customer SET products='1',amount='" + textBox23.Text + "' WHERE cell='" + customerData.ucell + "'", con);
                cnd.ExecuteNonQuery();

                MessageBox.Show("ok");


                con.Close();


                Random r = new Random();
                int ran = r.Next(89099, 999999);

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("" + customerData.ucell + ".pdf", FileMode.Create));
                doc.Open();

                Paragraph a = new Paragraph("\n\n                                                          INVOICE");
                doc.Add(a);

                Paragraph p = new Paragraph("                                             **** Foodix **** \n\n");
                doc.Add(p);

                Paragraph p1 = new Paragraph("                  Date  :  " + DateTime.Now.ToString("MM/dd/yyyy") + "\n");
                doc.Add(p1);

                Paragraph p2 = new Paragraph("                  Time  :  " + DateTime.Now.ToString("HH:mm:ss") + "\n");
                doc.Add(p2);


                Paragraph p90 = new Paragraph("                  Invoice number  :  " + ran + "\n\n");
                doc.Add(p90);

                Paragraph p3 = new Paragraph("                  _____________________________________________  \n\n");
                doc.Add(p3);

                Paragraph p4 = new Paragraph("                  Customer " + customerData.name + "\n");
                doc.Add(p4);

                Paragraph po = new Paragraph("                  Product Name  : Food items \n");
                doc.Add(po);


                Paragraph p7 = new Paragraph("                  Total amount  :  " + textBox23.Text + "\n\n");
                doc.Add(p7);

                Paragraph p8 = new Paragraph("                  _____________________________________________\n\n");
                doc.Add(p8);

                Paragraph p9 = new Paragraph("                  Thanks for purchase from us ");
                doc.Add(p9);

                Paragraph p10 = new Paragraph("                  Contact us : 03323464305 \n\n");
                doc.Add(p10);

                Paragraph pl = new Paragraph("                   copyright all rights reserved farhan ali and zubair ");
                doc.Add(pl);


                doc.Close();
                MessageBox.Show("success");
            }


        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        
     
    }

}
