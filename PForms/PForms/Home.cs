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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            loadTable();
        }

        void loadTable()
        {
            string conString = "Data Source=(local);Initial Catalog=Mprojekt;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand("select Ime as 'Ime i prezime', Ulazak as 'Vrijeme ulaska', Izlazak as 'Vrijeme izlaska', Temperatura from zaposlenici", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbDataSet = new DataTable();
                sda.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dataGridView1.DataSource = bSource;
                sda.Update(dbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prijava prijava = new Prijava();
            prijava.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
