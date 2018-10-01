using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WhoWantsToBeAMillionaire_form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection("data source=Database.db");                                      // Define Conection

        public static string user = "";                                                                                     // Define empty public string
        string password = "";                                                                                               // Define empty string
        public static int form = 0;
        int nepravilnouporabniskoime = 0;                                                                                   // Variabe, responsible for username incorecy
        int uporabniskoimejeponovljeno = 0;                                                                                 // Variabe, responsible for username repeatability
        int connectionmejebe = 0;                                                                                           // For closing connection

        private void btnSin_Click(object sender, EventArgs e)                                                               // Singin function
        {
            user = textBoxUsername.Text;                                                                                    // Variable user change to textbox text 
            password = textBoxPassword.Text;                                                                                // Variable password change to textbox text 

            if (user == "" && password == "")                                                                               // Demo user  condition
            {
                user = "demo";
                WhoWantsToBeAMillionaire_form2 mainform = new WhoWantsToBeAMillionaire_form2();                             // Set Game form as main
                this.Hide();  
                mainform.Show();  
            }
            else                                                                                                            // database section
            {
                connection.Open();                                                                                          // Open database
                using (SQLiteCommand command = new SQLiteCommand(connection))                                               // Create imput for command  connection
                {
                    command.CommandText = "SELECT * FROM users;";                                       
                    SQLiteDataReader reader = command.ExecuteReader();                                                      // define reading part of code
                    while (reader.Read()) 
                    {
                        if (user == reader.GetString(1))                                                                    // In case of same name in DB
                        {
                            nepravilnouporabniskoime++;                                                                     // Add to variable, so it does not pass thoru as not repeated name
                            if (password == reader.GetString(2))                                                            // If user mathches with user's password 
                            {
                                newform();                                                                                  // Redirect to newform
                            }
                            else  
                            {
                                MessageBox.Show("Geslo je nepravilno! ");                                                   // sporočilo, da je geslo, ki je v passwordBox.text neujemljivo z geslom iz podatkovne baze
                            }
                        }
                    }
                    if (nepravilnouporabniskoime == 0)                                                                      // If username is 0 then it did not passed the check
                    {
                        MessageBox.Show("Uporabniško ime je neobstoječe!");                                                 // Username does not exist
                    }
                }
                connection.Close(); 
            }
        }

        private void btnSup_Click(object sender, EventArgs e)                                                               // Singup function
        {
            user = textBoxUsername.Text;                                                                            // nastavljanje spremenljivke user na vpisano vrednost stringa v textboxusername
            password = textBoxPassword.Text;                                                                        // nastavljanje spremenljivke password na vpisano vrednost stringa v textboxpassword
            uporabniskoimejeponovljeno = 0;                                                                         //nastavljanje spremenljike za ponovitev uporabniškega imena na 0 za simulacijo boolenana

            connection.Open();                                                                                      //odpiranje povezave z podatkobno bazo
            using (SQLiteCommand command = new SQLiteCommand(connection))                                           // ustvari imput za command za connection
            {
                command.CommandText = "SELECT * FROM users;";
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (user == reader.GetString(1))
                    {
                        MessageBox.Show("Uporabnik z tem imenom je že obstoječ. Izberi si novo ime");
                        uporabniskoimejeponovljeno++;
                    }
                }
                command.Dispose();
            }
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                if (uporabniskoimejeponovljeno == 0)
                {
                    command.CommandText = "INSERT INTO users (user, password) VALUES('" + user + "', '" + password + "');";
                    command.ExecuteNonQuery();
                    connectionmejebe = 1;
                }
            }
            connection.Close();
            if (connectionmejebe == 1) { newform(); }
        }

        private void btnext_Click(object sender, EventArgs e)                                                               // Exit function
        {
            Application.Exit();
        }

        private void textBoxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxUsername.Text = "";
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPassword.Text = "";
        }

        private void newform()                                                                                              // Redirect to main form
        {
            ChoseTopic mainform = new ChoseTopic();
            this.Hide();
            mainform.Show();
        }

        private void btnlead_Click(object sender, EventArgs e)                                                              // Redirect to leaderboard
        {
            Leaderboard mainform = new Leaderboard();                                                                                                           // definiraj formo the end kot glavno formo
            this.Hide();                                                                                                                                        // skrij to formo
            mainform.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
