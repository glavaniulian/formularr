using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            con.Open();

            SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info", con);
            DataTable dt = new DataTable();
            table.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {



            searchbyid(textBox1.Text.Trim());
        }

        protected void searchbyid(string searchText)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduceti numele!");

            }
            else
            {



                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\formular\WindowsFormsApplication2\data_source.mdf;Integrated Security=True;Connect Timeout=30"))
                {


                    string sql = "SELECT * FROM info WHERE nume_prenume = '" + textBox1.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {

                        cmd.Parameters.AddWithValue("nume_prenume", textBox1.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        ad.Fill(dt);

                        if (dt.Rows.Count > 0)
                        { 
                            dataGridView1.DataSource = dt;
                            
                        }
                        else
                        {
                            MessageBox.Show("Persoana nu a fost gasita!");
                        }
                    }
                }
            }





                }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\formular\WindowsFormsApplication2\data_source.mdf;Integrated Security=True;Connect Timeout=30");


        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info", con);
            DataTable dt = new DataTable();
            table.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
