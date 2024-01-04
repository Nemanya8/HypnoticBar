using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HypnoticBar
{
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MaturskiRad.accdb;Persist Security Info=False;";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand load = new OleDbCommand();
                load.Connection = connection;
                string query = "select * from Artikal";
                load.CommandText = query;
                OleDbDataReader loadreader = load.ExecuteReader();
                while (loadreader.Read())
                {
                    lbArtikli.Items.Add(loadreader["Naziv"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska " + ex);
            }
        }

        private void Ucitavanje()
        {
            try
            {
                lbArtikli.Items.Clear();
                connection.Open();
                OleDbCommand ucitaj = new OleDbCommand();
                ucitaj.Connection = connection;
                string query = "select * from Artikal";
                ucitaj.CommandText = query;
                OleDbDataReader ucitajreader = ucitaj.ExecuteReader();
                while (ucitajreader.Read())
                {
                    lbArtikli.Items.Add(ucitajreader["Naziv"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska " + ex);
            }
        }

        private void lbArtikli_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand prikaz = new OleDbCommand();
                prikaz.Connection = connection;
                string query = "select * from Artikal where Naziv='" + lbArtikli.Text + "'";
                prikaz.CommandText = query;
                OleDbDataReader prikazreader = prikaz.ExecuteReader();
                while (prikazreader.Read())
                {
                    tbnaziv.Text = prikazreader["Naziv"].ToString();
                    tbcena.Text = prikazreader["Cena"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska " + ex);
            }
        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbnaziv.Text == "")
                {
                    MessageBox.Show("Popunite polja");
                }
                else
                {
                    connection.Open();
                    OleDbCommand dodaj = new OleDbCommand();
                    dodaj.Connection = connection;
                    dodaj.CommandText = "insert into Artikal (Naziv,Cena) values('" + tbnaziv.Text + "'," + tbcena.Text + ")";
                    dodaj.ExecuteNonQuery();
                    MessageBox.Show("Uspeh");
                    connection.Close();
                    Ucitavanje();
                    tbcena.Clear();
                    tbnaziv.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska" + ex);
            }
        }

        private void Btnobrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbnaziv.Text == "")
                {
                    MessageBox.Show("Popunite polja");
                }
                else
                {
                    connection.Open();
                    OleDbCommand obrisi = new OleDbCommand();
                    obrisi.Connection = connection;
                    string query = "delete from Artikal where Naziv='" + tbnaziv.Text + "'";
                    obrisi.CommandText = query;
                    obrisi.ExecuteNonQuery();
                    MessageBox.Show("Uspeh");
                    connection.Close();
                    Ucitavanje();
                    tbcena.Clear();
                    tbnaziv.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska " + ex);
            }
        }
    }

}
