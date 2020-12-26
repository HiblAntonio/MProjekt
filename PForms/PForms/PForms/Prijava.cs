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

namespace PForms
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string zapIme = cbZaposlenik.Text;
            string zapUlazak = lblTime.Text;
            string zapTemperatura = nudTemperatura.Value.ToString();
            string zapDatum = dtpDatum.Text;

            string conString = "Data Source=(local);Initial Catalog=Mprojekt;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            if (zapIme == "")
            {
                MessageBox.Show("Odaberite ime zaposlenika");
            }
            else
            {
                con.Open();

                SqlCommand insertCommand = new SqlCommand("Insert into zaposlenici(Ime, Ulazak, Temperatura, Datum) " +
                "values(@zapIme, @zapUlazak, @zapTemperatura, @zapDatum);", con);

                insertCommand.Parameters.AddWithValue("@zapIme", zapIme);
                insertCommand.Parameters.AddWithValue("@zapUlazak", zapUlazak);
                insertCommand.Parameters.AddWithValue("@zapTemperatura", zapTemperatura);
                insertCommand.Parameters.AddWithValue("@zapDatum", zapDatum);

                insertCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Podatci su uspješno uneseni");
                this.Hide();
                Home home = new Home();
                home.Show();
            }
        }

        private void Prijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString("HH:mm:ss");
        }
    }
}
