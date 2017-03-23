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



namespace Datenbanken
{
    public partial class Form1 : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand command;
        
        //testtdytdftgdc;
        //test
        //Auskommentiert
       


        public Form1()
        {
            InitializeComponent();
        }

        
        //Button Connection
        private void button1_Click(object sender, EventArgs e)
        {
              
                //OleDbConnectionStringBuilder strgbild = new OleDbConnectionStringBuilder();
                //strgbild.DataSource = "Bestellung.accdb";
                //strgbild.Provider = "Microsoft.ACE.OLEDB.12.0";
            
                con.ConnectionString = Properties.Settings.Default.DBConnection;
            try
            {
                con.Open();
            }
            catch (OleDbException f)
            {
                MessageBox.Show("Fehler bei der Verbindung");
            }
            
            
        }
        //Button SQL Command
        private void button2_Click(object sender, EventArgs e)
        {
            
            command = con.CreateCommand();
            command.CommandText = "Select * from tArtikel";
            command.CommandType = CommandType.Text;
            OleDbDataReader rd = command.ExecuteReader();

            while (rd.Read())
            {
                listBox1.Items.Add(rd["ArtikelNr"].ToString() + ":"+
                    rd["Bezeichnung"]);
            }
            rd.Close();

        }
        //Button auslesen
        private void button3_Click(object sender, EventArgs e)
        {

            command = con.CreateCommand();
            command.CommandText = "Select * from tArtikel";
            command.CommandType = CommandType.Text;
            OleDbDataReader rd = command.ExecuteReader();

            while (rd.Read())
            {
                listBox1.Items.Add(rd["ArtikelNr"].ToString() + ":" +
                    rd["Bezeichnung"]);
            }
            rd.Close();



        }
    }
}
