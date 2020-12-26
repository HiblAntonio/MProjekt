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
    public partial class Odjava : Form
    {
        public Odjava()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=(local);Initial Catalog=Mprojekt;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlCommand updateCommand = new SqlCommand("Update zaposlenici SET Izlazak = '" + lblTime.Text + "' where Ime = '" + cbZaposlenik.Text + "' and Datum = '" + dtpDatum.Text + "'", con);

            updateCommand.ExecuteNonQuery();
            con.Close();

            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString("HH:mm:ss");
        }

        private void Odjava_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
