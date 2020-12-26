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

        DataTable dbDataSet;
        SqlConnection con;

        void loadTable()
        {
            string conString = "Data Source=(local);Initial Catalog=Mprojekt;Integrated Security=True";
            con = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand("select Ime, Ulazak as 'Vrijeme ulaska', Izlazak as 'Vrijeme izlaska', Temperatura, Datum from zaposlenici", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbDataSet = new DataTable();
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

        private void btnSearchIme_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dbDataSet);
            dv.RowFilter = string.Format("Ime LIKE '%{0}%'", comboBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Ime, Ulazak as 'Vrijeme ulaska', Izlazak as 'Vrijeme izlaska', Temperatura, Datum" +
                " FROM zaposlenici WHERE Datum between '" + dtpOdDatuma.Value.ToString() + "' and '" + dtpDoDatuma.Value.ToString() + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "TblData");

           dataGridView1.DataSource = ds.Tables["TblData"];
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Odjava odjava = new Odjava();
            odjava.Show();
        }
    }
}
