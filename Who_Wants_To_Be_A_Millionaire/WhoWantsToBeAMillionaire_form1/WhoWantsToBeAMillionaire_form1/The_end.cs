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
    public partial class The_end : Form
    {
        public The_end()
        {
            InitializeComponent();
            win_lose();                                                                     // Send to Win function
        }

        SQLiteConnection connection = new SQLiteConnection("data source=Database.db");      // definiranje povezave
        string labelimput = " ";                                                            // string define labelimput as blank
        string date = System.DateTime.Now.ToString("dd/MM/yyyy");                           // as string define date time year
        string text = Form1.user;                                                           // use global variable
        int userid = WhoWantsToBeAMillionaire_form2.iduser;                                 // use global variable
        int points = WhoWantsToBeAMillionaire_form2.points;                                 // use global variable                    
        int form = Form1.form;                                                              // use global variable
        int chosenone = ChoseTopic.chosenone;

        private void win_lose()                                                             // Win_Lose detarmine
        {
            if (points == 1000000)                                                          // if you have high score, write in label congradulation text
                {
                    labelimput = " Congradulation! " + text + " , You Won " + Convert.ToString(points) + "$ ";
                }
             else                                                                           // if you don't have high score, write in label you lost text
                {
                    labelimput = " You lost " + text + " , You Get " + Convert.ToString(points) + "$ ";
                }
            label3.Text = labelimput;                                                       // label text = label put up together
            Form1.form = 3;                                                                 // change global variable
            imput();
        }

        private void imput()                                                                // Function, where all imputing in leaderboard is done
        {
            if(form != 4)
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO leaderboard (id_user, points, date,id_topic) VALUES('" + userid + "', '" + points + "', '" + date + "', '" + chosenone + "');";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            } 
        }

        private void btnrepeat_Click(object sender, EventArgs e)
        {
            WhoWantsToBeAMillionaire_form2.points = 0;
            WhoWantsToBeAMillionaire_form2 mainform = new WhoWantsToBeAMillionaire_form2(); // establishing 2nd form as main
            this.Hide();  
            mainform.Show(); 
        }

        private void btnexit_Click(object sender, EventArgs e)                              // Close aplicaton
        {
            Application.Exit();
        }

        private void btnlead_Click(object sender, EventArgs e)                              // Redirect to leaderboard form
        {
            Leaderboard mainform = new Leaderboard();                                       // establishing leaderboard form as main                                                                                                   
            this.Hide();                                                                                                                                 
            mainform.Show();
        }

        private void btnchangeuser_Click(object sender, EventArgs e)
        {
            WhoWantsToBeAMillionaire_form2.points = 0;
            Form1 mainform = new Form1();                                                                                                                                          
            this.Hide();
            mainform.Show();
        }

        private void btnctpc_Click(object sender, EventArgs e)
        {
            WhoWantsToBeAMillionaire_form2.points = 0;
            ChoseTopic mainform = new ChoseTopic();
            this.Hide();
            mainform.Show();
        }

        private void The_end_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
