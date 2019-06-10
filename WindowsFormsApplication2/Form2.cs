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

    
        

        
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // schimbi toata linia dupa @ (sa pastrezi " ") ca sa-ti fie mai usor, pui fisierul in d/c.. si schimbi doar g-ul ala. daca nu merge asa
        // dai la tools > connect to a database cauti in formular > WindowsFormsApplication2 > data_source.mdf iar dupa SERVER Explorer iti apare 
        // baza de date dai click dreapta pe data_source.mdf si propietati dupa copi toata linia de la Connection String si o schimbi cu lini de mai jos
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\formular\WindowsFormsApplication2\data_source.mdf;Integrated Security=True;Connect Timeout=30");

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Selectati o cautare!", "Formular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox1.Text == "ID")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE ID LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (comboBox1.Text == "NUME SI PRENUME")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE NUME_PRENUME LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            else if (comboBox1.Text == "FACULTATE")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE fac LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "DOMENIUL")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE dom LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "SPECIALIZARE FACULTATE")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE spec LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "COD LEGITIMATIE")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE cod_legitimatie LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "FORMA DE INVATAMANT")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE form_invat LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "JUDETUL DE PROVENIENTA")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE judet LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "DATA INSCRIERE")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE data LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "GENUL")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE sexul LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "TARA DE PROVENNIENTA")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE TARA LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "STAREA CIVILA")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE stare_civila LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "CETATENIE")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE cetatenie LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "CANDIDAT CARE SE INCADREAZA")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT Id,nume_prenume,incadrare FROM info WHERE incadrare LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "CNP")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT Id,nume_prenume,cnp,serie,eliberat_de_catre,data_eliberare FROM info WHERE cnp LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "STUDII PREUNIVERSARE")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE studii LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "SPECIALIZARE PREUNIVERSITARA")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE specializare LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "UNITATE INVATAMANT")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE unitate_invatamant LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "ORAS ABSOLVIRE UNITATE")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE oras_studii LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "JUDET ABSOLVIRE UNITATE")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE judet_studii LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "TARA ABSOLVIRE UNITATE")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE tara_studii LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "FORMA DE INVATAMANT PREUNIVERSITAR")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE forma_invatamant LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "DATA ABSOLVIRI")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info WHERE data_absolvirii LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "TIPUL DE DIPLOMA")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT Id,nume_prenume,tipul_diploma,serie_diploma,numar_diploma,media,emis,data_emiterii,numarul_foii_matricole FROM info WHERE tipul_diploma LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "SERIE DIPLOMA")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT Id,nume_prenume,serie_diploma,tipul_diploma,numar_diploma,media,emis,data_emiterii,numarul_foii_matricole FROM info WHERE serie_diploma LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "NUMARUL DIPLOMEI")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT Id,nume_prenume,numar_diploma,tipul_diploma,serie_diploma,media,emis,data_emiterii,numarul_foii_matricole FROM info WHERE numar_diploma LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "DATA EMITERI DIPLOMEI")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT id,nume_prenume,data_emiterii,tipul_diploma,serie_diploma,media,numar_diploma,emis,numarul_foii_matricole FROM info WHERE data_emiterii LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "MEDIE DIPLOMA")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT Id,nume_prenume,media,data_emiterii,tipul_diploma,serie_diploma,numar_diploma,emis,numarul_foii_matricole FROM info WHERE media LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "ANEXELE URMATOARELOR ACTE (DA)")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT Id,id,nume_prenume,foto_3_4_da,adeverinta_med_da,copie_buletin_da,foaie_matricola_da,taxa_achitata_da FROM info WHERE foto_3_4_da LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "ANEXELE URMATOARELOR ACTE (NU)")
            {
                SqlDataAdapter table = new SqlDataAdapter("SELECT Id,nume_prenume,foto_3_4_nu,adeverinta_med_nu,copie_buletin_nu,foaie_matricola_nu,taxa_achitata_nu FROM info WHERE foto_3_4_nu LIKE '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                table.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
                return;
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";

            con.Open();
            SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM info ", con);
            DataTable dt = new DataTable();
            table.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
