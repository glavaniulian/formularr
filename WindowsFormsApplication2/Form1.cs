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
    public partial class FORM1 : Form
    {

        // schimbi toata linia dupa @ (sa pastrezi " "). Ca sa-ti fie mai usor, pui fisierul in d/c.. si schimbi doar g-ul ala. daca nu merge asa
        // dai la tools > connect to a database cauti in formular > WindowsFormsApplication2 > data_source.mdf iar dupa SERVER Explorer iti apare 
        // baza de date dai click dreapta pe data_source.mdf si propietati dupa copi toata linia de la Connection String si o schimbi cu lini de mai jos



        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\formular\WindowsFormsApplication2\data_source.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        

        public FORM1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C1.Text = ""; C2.Text = ""; C3.Text = ""; C4.Text = ""; C5.Text = ""; C6.Text = ""; C7.Text = ""; C8.Text = ""; C9.Text = ""; C10.Text = "";
            
            CB1.CheckState = CheckState.Unchecked; CB2.CheckState = CheckState.Unchecked; CB3.CheckState = CheckState.Unchecked;
            CB4.CheckState = CheckState.Unchecked; CB5.CheckState = CheckState.Unchecked; CB6.CheckState = CheckState.Unchecked;
            CB7.CheckState = CheckState.Unchecked; CB8.CheckState = CheckState.Unchecked; CB9.CheckState = CheckState.Unchecked;
            CB10.CheckState = CheckState.Unchecked; CB11.CheckState = CheckState.Unchecked; CB12.CheckState = CheckState.Unchecked;
            CB13.CheckState = CheckState.Unchecked; CB14.CheckState = CheckState.Unchecked; CB15.CheckState = CheckState.Unchecked;
            CB16.CheckState = CheckState.Unchecked; CB17.CheckState = CheckState.Unchecked;
            T1.Text = ""; T2.Text = ""; T3.Text = ""; T4.Text = ""; T5.Text = ""; T6.Text = ""; T7.Text = ""; T8.Text = ""; T9.Text = ""; T10.Text = "";
            T11.Text = ""; T12.Text = ""; T13.Text = ""; T14.Text = ""; T15.Text = ""; T16.Text = ""; T17.Text = ""; T18.Text = ""; T19.Text = ""; T20.Text = "";
            T21.Text = ""; T22.Text = ""; T23.Text = ""; T24.Text = ""; T25.Text = ""; T27.Text = ""; T28.Text = ""; T29.Text = ""; T26.Text = ""; T30.Text = "";
            T31.Text = ""; T32.Text = ""; T33.Text = ""; T34.Text = ""; T35.Text = ""; T36.Text = "";

        }




        private void C1_SelectedIndexChanged(object sender, EventArgs e)
        {

           


        }
        string diploma_org, adeverinta_ab, adeverinta_ab_leg, at_original, at_leg, cert_nastere_leg, cert_cas_leg, foto_3_4_da, foto_3_4_nu, adv_med_da, adv_med_nu, copie_ci_da, copie_ci_nu, foaie_matr_da, foaie_matr_nu, bon_taxa_da, bon_taxa_nu;

        private void CB13_CheckedChanged(object sender, EventArgs e)
        {
            copie_ci_nu = "NU";
        }

        private void CB14_CheckedChanged(object sender, EventArgs e)
        {
            foaie_matr_da = "DA";
        }

        private void CB15_CheckedChanged(object sender, EventArgs e)
        {
            foaie_matr_nu = "NU";
        }

        private void CB16_CheckedChanged(object sender, EventArgs e)
        {
           bon_taxa_da = "DA";
        }

        private void CB17_CheckedChanged(object sender, EventArgs e)
        {
            bon_taxa_nu = "NU";
        }

        private void CB12_CheckedChanged(object sender, EventArgs e)
        {
            copie_ci_da = "DA";
        }

        private void CB11_CheckedChanged(object sender, EventArgs e)
        {
            adv_med_nu = "NU";
        }

        private void CB10_CheckedChanged(object sender, EventArgs e)
        {
            adv_med_da = "DA";
        }

        private void CB9_CheckedChanged(object sender, EventArgs e)
        {
            foto_3_4_nu = "NU";
        }

        private void CB8_CheckedChanged(object sender, EventArgs e)
        {
            foto_3_4_da = "DA";
        }

        private void CB7_CheckedChanged(object sender, EventArgs e)
        {
            cert_cas_leg = "DA";
        }

        private void CB6_CheckedChanged(object sender, EventArgs e)
        {
            cert_nastere_leg = "DA";
        }

        private void CB5_CheckedChanged(object sender, EventArgs e)
        {
            at_leg = "DA";
        }

        private void CB4_CheckedChanged(object sender, EventArgs e)
        {
            at_original = "DA";
        }

        private void CB3_CheckedChanged(object sender, EventArgs e)
        {
            adeverinta_ab_leg = "DA";
        }


  

        private void B1_Click(object sender, EventArgs e)
        {


            cmd.Parameters.Clear();

            cn.Open();


            cmd.CommandText = "INSERT INTO info(fac,dom,spec,data,form_invat,nume_prenume,cod_legitimatie,localitate,judet,tara,strada,numar,bloc,scara,etaj,apartament,sector,cod_postal,data_n,loc_nastere,judet_n,tara_n,sexul,stare_civila,cetatenie,cetatenie_op,etnie,incadrare,cnp,serie,numar_cnp,eliberat_de_catre,data_eliberare,studii,unitate_invatamant,specializare,oras_studii,judet_studii,tara_studii,forma_invatamant,media,durata_studii,data_absolvirii,tipul_diploma,serie_diploma,numar_diploma,emis,data_emiterii,numarul_foii_matricole,diploma_original,adeverinta_absolvire_original,adeverinta_absolvire_copielegalizata,atestat_original,atestat_legalizat,certificat_nastere,certificat_casatorie,foto_3_4_da,foto_3_4_nu,adeverinta_med_da,adeverinta_med_nu,copie_buletin_da,copie_buletin_nu,foaie_matricola_da,foaie_matricola_nu,taxa_achitata_da,taxa_achitata_nu,introducere_date,semnatura) values('" + C1.Text + "','" + T1.Text + "','" + T2.Text + "','" + d5.Text + "','" + C2.Text + "','" + T3.Text + "','" + T4.Text + "','" + T5.Text + "','" + T6.Text + "','" + T7.Text + "','" + T8.Text + "','" + T9.Text + "','" + T10.Text + "','" + T11.Text + "','" + T12.Text + "','" + T13.Text + "','" + T14.Text + "','" + T15.Text + "','" + d1.Text + "','" + T16.Text + "','" + T17.Text + "','" + T18.Text + "','" + C3.Text + "','" + C4.Text + "','" + C5.Text + "','" + T19.Text + "','" + T20.Text + "','" + C6.Text + "','" + T21.Text + "','" + T22.Text + "','" + T23.Text + "','" + T24.Text + "','" + d2.Text + "','" + C7.Text + "','" + T25.Text + "','" + T26.Text + "','" + T27.Text + "','" + T28.Text + "','" + T29.Text + "','" + C8.Text + "','" + T30.Text + "','" + C9.Text + "','" + d3.Text + "','" + C10.Text + "','" + T31.Text + "','" + T32.Text + "','" + T33.Text + "','" + d4.Text + "','" + T34.Text + "','" + diploma_org + "','" + adeverinta_ab + "','" + adeverinta_ab_leg + "','" + at_original + "','" + "','" + at_leg + cert_nastere_leg + "','" + cert_cas_leg + "','" + foto_3_4_da + "','" + foto_3_4_nu + "','" + adv_med_da + "','" + adv_med_nu + "','" + copie_ci_da + "','" + copie_ci_nu + "','" + foaie_matr_da + "','" + foaie_matr_nu + "','" + bon_taxa_da + "','" + bon_taxa_nu + "','" + T35.Text + "','" + T36.Text + "')";
           

            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost introduse in baza de date !");
            cn.Close();
            
        }

        private void FORM1_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void T35_TextChanged(object sender, EventArgs e)
        {

        }

        private void B2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            

        }

        private void CB2_CheckedChanged(object sender, EventArgs e)
        {
            adeverinta_ab = "DA";
        }

        private void CB1_CheckedChanged(object sender, EventArgs e)
        {
            diploma_org = "DA";
        }
    }
}
