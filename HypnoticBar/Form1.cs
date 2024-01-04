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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MaturskiRad.accdb;Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Ucitavanje artikala u listbox  

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Artikal";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox2.Items.Add(reader["Naziv"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska " + ex);
            }
        }

        public void PromenaStola(int sto)
        {
            try
            {
                listBox1.Items.Clear();
                lbliznos.Text = "0";
                connection.Open();
                //prikaz stola i narucenih artikala na istom 

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Artikal.Naziv, Artikal.IDArtikla, Artikal.Cena, Narucuje.IDStola FROM Sto,Narucuje,Artikal where Sto.IDStola=Narucuje.IDStola AND ";
                query += "Narucuje.IDArtikla=Artikal.IDArtikla AND Narucuje.IDStola = " + Convert.ToString(sto) + " and Aktivan = true";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString());
                }

                int n = listBox1.Items.Count;
                int racun2 = 0;
                for (int i = 0; i < n; i++)
                {
                    //racunjane racuna od selektovanog stola 

                    OleDbCommand command3 = new OleDbCommand();
                    command3.Connection = connection;
                    string query3 = "select Artikal.Cena from Artikal where Artikal.Naziv = '" + listBox1.Items[i].ToString() + "'";
                    command3.CommandText = query3;
                    OleDbDataReader reader3 = command3.ExecuteReader();
                    while (reader3.Read())
                    {
                        racun2 = racun2 + Convert.ToInt32(reader3["Cena"]);
                    }
                    lbliznos.Text = racun2.ToString();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "1";
            PromenaStola(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "2";
            PromenaStola(2);
        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            if
              (lblbroj.Text != "")
            {
                try
                {
                    string pom = "";
                    string query, query2;
                    int racun = Convert.ToInt32(lbliznos.Text);
                    connection.Open();
                    string pice;
                    pice = listBox2.SelectedItem.ToString();
                    listBox1.Items.Add(pice);

                    //u Narucuje upisujemo idArtikla, aktivan stavljamo na true, idStola
                    query = "select IDArtikla from Artikal where Artikal.Naziv = '" + pice + "'";
                    //MessageBox.Show(query);
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        pom += "insert into Narucuje (IDArtikla,IDStola,aktivan) Values (" + reader["IDArtikla"].ToString() + ", ";
                        pom += lblbroj.Text + ",true)";

                    }
                    //MessageBox.Show(pom);
                    //izvrsiti upit pom
                    OleDbCommand command2 = new OleDbCommand();
                    command2.Connection = connection;
                    command2.CommandText = pom;
                    command2.ExecuteNonQuery();
                    command2.Dispose();
                    command.Dispose();

                    //cena
                    racun = 0;
                    query2 = "select Cena from Artikal,Narucuje where Artikal.IDArtikla=Narucuje.IDArtikla";
                    query2 += " and Narucuje.Aktivan = true and IDStola=" + lblbroj.Text;
                    //MessageBox.Show(query2);
                    OleDbCommand cena = new OleDbCommand();
                    cena.Connection = connection;
                    cena.CommandText = query2;
                    OleDbDataReader reader2 = cena.ExecuteReader();
                    while (reader2.Read())
                    {
                        racun = racun + Convert.ToInt32(reader2[0]);

                    }
                    lbliznos.Text = racun.ToString();
                    cena.Dispose();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska" + ex);
                }
            }
            else
            {
                MessageBox.Show("Izaberite sto!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "3";
            PromenaStola(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "4";
            PromenaStola(4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "5";
            PromenaStola(5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "6";
            PromenaStola(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "7";
            PromenaStola(7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "8";
            PromenaStola(8);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "9";
            PromenaStola(9);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "10";
            PromenaStola(10);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "11";
            PromenaStola(11);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "12";
            PromenaStola(12);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "13";
            PromenaStola(13);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "14";
            PromenaStola(14);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblbroj.Text = "15";
            PromenaStola(15);
        }

        private void btnpodesavanja_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnnaplati_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Narucuje SET Aktivan=false where IDStola=" + lblbroj.Text + " and ";
                query += " Aktivan = true  ";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString());
                }
                int placeno = 0, kusur;
                placeno = Convert.ToInt32(tbplaceno.Text);
                kusur = placeno - Convert.ToInt32(lbliznos.Text);
                if (kusur >= 0)
                {
                    MessageBox.Show("Kusur: " + kusur.ToString());
                    tbplaceno.Clear();
                    listBox1.Items.Clear();
                    lbliznos.Text = "0";
                }
                else
                {
                    MessageBox.Show("Nedovoljno novca");
                    tbplaceno.Clear();
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska " + ex);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Nemate artikl za brisanje!");
                }
                else
                {
                    if (listBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Izaberite artikal");
                    }
                    else
                    {
                        connection.Open();

                        //cena u labeli
                        int minus = 0;
                        int racun = Convert.ToInt32(lbliznos.Text);
                        string query2;
                        query2 = "select Cena from Artikal,Narucuje where Artikal.IDArtikla=Narucuje.IDArtikla";
                        query2 += " and Narucuje.Aktivan = true and Artikal.Naziv='" + listBox1.SelectedItem.ToString() + "' AND IDStola=" + lblbroj.Text;
                        //MessageBox.Show(query2);
                        OleDbCommand cena = new OleDbCommand();
                        cena.Connection = connection;
                        cena.CommandText = query2;
                        OleDbDataReader reader2 = cena.ExecuteReader();
                        while (reader2.Read())
                        {
                            minus = Convert.ToInt32(reader2[0]);
                        }
                        lbliznos.Text = (racun - minus).ToString();

                        //brisanje iz baze
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        //u pod upitu selektujemo idstola iz tabele Artikal
                        //top 1 - brisemo prvi artikal koji se zove kako je selektovan u listBoxu1
                        string query = "delete from (select top 1 * from Narucuje where Aktivan = true AND IDStola = (";
                        query += "select IDStola from Artikal where Naziv = '" + listBox1.SelectedItem.ToString() + "'))";
                        command.CommandText = query;
                        command.ExecuteNonQuery();


                        listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);

                        int n;
                        n = listBox1.Items.Count;
                        if (n == 0) {
                            lbliznos.Text = "0";
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska" + ex);
            }
        }
    }
}
