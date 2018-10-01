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
    public partial class Leaderboard : Form
    {
        private void check()
        {
            connection.Open();                                                                  // odpre povezavo z podatkovno bazo
            using (SQLiteCommand command = new SQLiteCommand(connection))                       // ustvari imput za command za connection
            {
                command.CommandText = "SELECT users.user , leaderboard.points , leaderboard.date, topics.name FROM leaderboard INNER JOIN users ON leaderboard.id_user = users.id INNER JOIN topics ON leaderboard.id_topic = topics.id ORDER BY(points) DESC LIMIT (" + limit + ")  ;";         //   iz baze game bere vprašanje in odgovore glede na id
                SQLiteDataReader reader = command.ExecuteReader();                              // definiranje bralnega dela kode
                while (reader.Read()) { 
                        name = reader.GetString(0);                                             // GetString from DB and save it in string name 
                        points= Convert.ToString(reader.GetInt32(1));                           // Getint from DB, convert to string and save it in string points          
                        date = reader.GetString(2);                                             // GetString from DB and save it in string date
                        topic = reader.GetString(3);                                            // GetString from DB and save it in string topic
                    switch (read) // Long, long, long switch operation //Btn inserted text 
                    {
                        case 0:
                            btname1.Text = name;
                            btnpoints1.Text = points;
                            btndate1.Text = date;
                            btntopic1.Text = topic;
                            read++;
                            break;
                        case 1:
                            btname2.Text = name;
                            btnpoints2.Text = points;
                            btndate2.Text = date;
                            btntopic2.Text = topic;
                            read++;
                            break;
                        case 2:
                            btname3.Text = name;
                            btnpoints3.Text = points;
                            btndate3.Text = date;
                            btntopic3.Text = topic;
                            read++;
                            break;
                        case 3:
                            btname4.Text = name;
                            btnpoints4.Text = points;
                            btndate4.Text = date;
                            btntopic4.Text = topic;
                            read++;
                            break;
                        case 4:
                            btname5.Text = name;
                            btnpoints5.Text = points;
                            btndate5.Text = date;
                            btntopic5.Text = topic;
                            read++;
                            break;
                        case 5:
                            btname6.Text = name;
                            btnpoints6.Text = points;
                            btndate6.Text = date;
                            btntopic6.Text = topic;
                            read++;
                            break;
                        case 6:
                            btname7.Text = name;
                            btnpoints7.Text = points;
                            btndate7.Text = date;
                            btntopic7.Text = topic;
                            read++;
                            break;
                        case 7:
                            btname8.Text = name;
                            btnpoints8.Text = points;
                            btndate8.Text = date;
                            btntopic8.Text = topic;
                            read++;
                            break;
                        case 8:
                            btname9.Text = name;
                            btnpoints9.Text = points;
                            btndate9.Text = date;
                            btntopic9.Text = topic;
                            read++;
                            break;
                        case 9:
                            btname10.Text = name;
                            btnpoints10.Text = points;
                            btndate10.Text = date;
                            btntopic10.Text = topic;
                            read++;
                            break;
                        case 10:
                            read = 0;
                            break;
                    }
                }
            }
            connection.Close();
        }

        public Leaderboard()
        {
            InitializeComponent();
            check();                                                                            // Send to Check function
        }

        SQLiteConnection connection = new SQLiteConnection("data source=Database.db");          // Defining the connection                                      
        int limit = 10; 
        string name = "";
        string date = "";
        string points = "";
        string topic = "";
        int read = 0;
        int chosenone = ChoseTopic.chosenone; 
        int forma = Form1.form;

        private void btnnext_Click(object sender, EventArgs e)                                  // Extend the limit of SQL read
        {
            limit += 10;
            check();
        }

        private void btnback_Click(object sender, EventArgs e)                                  // Back to form that you came from
        {
            if (forma == 3)                                                                     // Return to form _ The_end                                                                                  
            {
                Form1.form = 4;
                The_end mainform = new The_end();                                                                                                           
                this.Hide();                                                                                                                                
                mainform.Show();
            }
            else if (forma == 0)                                                                // return to form  _ Vpis
            {
                Form1.form = 4;
                Form1 mainform = new Form1();
                this.Hide();
                mainform.Show();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)                                  // Exit the aplication
        {
            Application.Exit();
        }

        private void Leaderboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
