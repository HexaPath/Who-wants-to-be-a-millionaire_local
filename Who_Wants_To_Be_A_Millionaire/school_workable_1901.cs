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
    public partial class WhoWantsToBeAMillionaire_form2 : Form
    {
        private void nakljucno()
        {    /// randomizira naslednjo cifro
            indikator = new Random().Next(1, 53);
            baza();
        }
        private void baza()
        {
            connection.Open(); // odpre povezavo z podatkovno bazo
            using (SQLiteCommand command = new SQLiteCommand(connection)) //ustvari imput za command za connection
            {
                command.CommandText = "SELECT * FROM game WHERE (ID = " + indikator + ");"; // iz baze game bere vprašanje in odgovore glede na id
                SQLiteDataReader reader = command.ExecuteReader(); // definiranje bralnega dela kode
                while (reader.Read()) // ko bere
                {
                    /// spremeni text v spremenljivki 
                    question = reader.GetString(1);
                    answera = reader.GetString(2);
                    answerb = reader.GetString(3);
                    answerc = reader.GetString(4);
                    answerd = reader.GetString(5);
                    pravilendb = reader.GetInt32(6);
                }
            }
            connection.Close();
            /// spremeni text v gumbu v text prej določen
            btnansa.Text = answera;
            btnansb.Text = answerb;
            btnansc.Text = answerc;
            btnansd.Text = answerd;
            btnq.Text = question;
            /// nazaj na loop
            loop();
        }

        public WhoWantsToBeAMillionaire_form2()
        {
            InitializeComponent();
            nakljucno();
        }
        SQLiteConnection connection = new SQLiteConnection("data source=Database.db");//definiranje povezave
        int indikator = new Random().Next(1, 53); //definiranje random
        int rezultat = 0; // rezultat
        int[] uporabljena = new int[15]; //shranjuje vse indikatorje, da se ne ponovijo
        int pravilen = 0;
        int pravilendb = 0;
        string answera = ""; // "iz databasa neki a";
        string answerb = ""; // "iz databasa neki b";
        string answerc = ""; // "iz databasa neki c";
        string answerd = ""; // "iz databasa neki d";
        string question = ""; // "iz databasa nek question";
        
        /* TO DO LIST
                 - Obarvanje je pomaknjeno, pobarva naslenji odgovor namesto trenutnega
                 - leaderboard :
                                - ime
                                - točke
                                - datum in ura
                                - čas porabljen
                                - top 25
                 - ponovi igro
                 - igra :
                                - mogoče več levelov (marvel / dc / other stuff)
                                - težavnosti vprašanj
                                - 50 50
                                - voice of the audience
                                - call a friend (nevem točno kaj bi tu naredu. dam mu pravi odgovor mogoče ?)
                 */



        private void loop() // preveri če se je vprašanje že ponovilo
        {
            for (int n = 0; n < 15; n++) //število vprašanj
            {
                for (int m = 0; m == n; m++) // preveri vsa vprašanja
                {
                    if (uporabljena[m] == indikator) //preveri če se je vprašanje že ponovilo
                    {
                        n--;
                        nakljucno(); // nazaj na random 
                    }
                    else 
                    {

                    }
                }
            }
        }

        private void pravilno() // v primeru da je odgovor pravilen sproži funkcijo
        {
            switch (pravilendb)
            {
                case 0:
                    loop();
                    break;
                case 1:
                    btnansa.BackColor = Color.Green; 
                    btnansb.BackColor = Color.DarkSlateGray;
                    btnansc.BackColor = Color.DarkSlateGray;
                    btnansd.BackColor = Color.DarkSlateGray;
                    break;
                case 2:
                    btnansa.BackColor = Color.DarkSlateGray;
                    btnansb.BackColor = Color.Green; 
                    btnansc.BackColor = Color.DarkSlateGray;
                    btnansd.BackColor = Color.DarkSlateGray;
                    break;
                case 3:
                    btnansa.BackColor = Color.DarkSlateGray;
                    btnansb.BackColor = Color.DarkSlateGray;
                    btnansc.BackColor = Color.Green; 
                    btnansd.BackColor = Color.DarkSlateGray;
                    break;
                case 4:
                    btnansa.BackColor = Color.DarkSlateGray;
                    btnansb.BackColor = Color.DarkSlateGray;
                    btnansc.BackColor = Color.DarkSlateGray;
                    btnansd.BackColor = Color.Green; 
                    break;
                
            }
            rezultat++;
            System.Threading.Thread.Sleep(2000);
            // reset
            switch (rezultat) // pobarva gumb z nagrado
            {
                case 0:
                    btnreward1.BackColor = Color.YellowGreen;
                    /*btnreward1.BackColor = Color.Black;*/ btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 1:
                    btnreward2.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; /*btnreward2.BackColor = Color.Black;*/ btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 2:
                    btnreward3.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; /*btnreward3.BackColor = Color.Black;*/ btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 3:
                    btnreward4.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; /*btnreward4.BackColor = Color.Black;*/ btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 4:
                    btnreward5.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; /*btnreward5.BackColor = Color.Black;*/
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 5:
                    btnreward6.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    /*btnreward6.BackColor = Color.Black;*/ btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 6:
                    btnreward7.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; /*btnreward7.BackColor = Color.Black;*/ btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 7:
                    btnreward8.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; /*btnreward8.BackColor = Color.Black;*/ btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 8:
                    btnreward9.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; /*btnreward9.BackColor = Color.Black;*/ btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 9:
                    btnreward10.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; /*btnreward10.BackColor = Color.Black;*/
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 10:
                    btnreward11.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    /*btnreward11.BackColor = Color.Black;*/ btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 11:
                    btnreward12.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; /*btnreward12.BackColor = Color.Black;*/ btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 12:
                    btnreward13.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; /*btnreward13.BackColor = Color.Black;*/ btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 13:
                    btnreward14.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; /*btnreward14.BackColor = Color.Black;*/ btnreward15.BackColor = Color.Black;
                    break;
                case 14:
                    btnreward15.BackColor = Color.YellowGreen;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; /*btnreward15.BackColor = Color.Black;*/
                    break;
                case 15:
                    Win mainform = new Win(); // definiraj formo the end kot glavno formo
                    this.Hide(); // skrij to formo
                    mainform.Show(); // prikaži glavno formo
                    break;
            }
            //System.Threading.Thread.Sleep(1000);
            nakljucno();
        }

        private void nepravilno() // v primeru da je odgovor napačen sproži funkcijo
        {
            System.Threading.Thread.Sleep(2000);
            The_end mainform = new The_end(); // definiraj formo the end kot glavno formo
            this.Hide(); // skrij to formo
            mainform.Show(); // prikaži glavno formo
        }

        private void WhoWantsToBeAMillionaire_form2_Load(object sender, EventArgs e)
        {   

        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            btn5050.Enabled = false;
           // btn5050.Image = ;
        }

        private void btnaudi_Click(object sender, EventArgs e)
        {
            btnaudi.Enabled = false;
            //btn5050.Image = ;
        }

        private void btnphone_Click(object sender, EventArgs e)
        {
            btnphone.Enabled = false;
           // btn5050.Image = ;
        }

        private void btnansa_Click(object sender, EventArgs e)
        {
            pravilen = 1;
            if(pravilen == pravilendb)
            {
                btnansa.BackColor = Color.Green;
                /* btnansb.BackColor = Color.DarkSlateGray;
                btnansc.BackColor = Color.DarkSlateGray;
                btnansd.BackColor = Color.DarkSlateGray;
                System.Threading.Thread.Sleep(2000);
                btnansa.BackColor = Color.DarkSlateGray; */
                pravilno();
            }
            else
            {
                btnansa.BackColor = Color.Red;
                /* btnansb.BackColor = Color.DarkSlateGray;
                btnansc.BackColor = Color.DarkSlateGray;
                btnansd.BackColor = Color.DarkSlateGray;
                System.Threading.Thread.Sleep(2000);
                btnansa.BackColor = Color.DarkSlateGray; */
                nepravilno();
            }
        }

        private void btnansb_Click(object sender, EventArgs e)
        {
            pravilen = 2;
            if (pravilen == pravilendb)
            {
                btnansb.BackColor = Color.Green;
                /* btnansa.BackColor = Color.DarkSlateGray;
                btnansc.BackColor = Color.DarkSlateGray;
                btnansd.BackColor = Color.DarkSlateGray;
                System.Threading.Thread.Sleep(2000);
                btnansb.BackColor = Color.DarkSlateGray; */
                pravilno();
            }
            else
            {
                btnansb.BackColor = Color.Red;
                /* btnansa.BackColor = Color.DarkSlateGray;
                btnansc.BackColor = Color.DarkSlateGray;
                btnansd.BackColor = Color.DarkSlateGray;
                System.Threading.Thread.Sleep(2000);
                btnansb.BackColor = Color.DarkSlateGray; */
                nepravilno();
            }
        }

        private void btnansc_Click(object sender, EventArgs e)
        {
            pravilen = 3;
            if (pravilen == pravilendb)
            {
                btnansc.BackColor = Color.Green;
                /* btnansa.BackColor = Color.DarkSlateGray;
                btnansb.BackColor = Color.DarkSlateGray;
                btnansd.BackColor = Color.DarkSlateGray;
                System.Threading.Thread.Sleep(2000);
                btnansc.BackColor = Color.DarkSlateGray; */
                pravilno();
            }
            else
            {
                btnansc.BackColor = Color.Red;
                /* btnansb.BackColor = Color.DarkSlateGray;
                btnansa.BackColor = Color.DarkSlateGray;
                btnansd.BackColor = Color.DarkSlateGray;
                System.Threading.Thread.Sleep(2000);
                btnansc.BackColor = Color.DarkSlateGray; */
                nepravilno();
            }
        }

        private void btnansd_Click(object sender, EventArgs e)
        {
            pravilen = 4;
            if (pravilen == pravilendb)
            {
                btnansd.BackColor = Color.Green;
                /* btnansa.BackColor = Color.DarkSlateGray;
                btnansb.BackColor = Color.DarkSlateGray;
                btnansc.BackColor = Color.DarkSlateGray;
                System.Threading.Thread.Sleep(2000);
                btnansd.BackColor = Color.DarkSlateGray; */
                pravilno(); 
            }
            else
            {
                btnansd.BackColor = Color.Red;
                /* btnansb.BackColor = Color.DarkSlateGray;
                btnansc.BackColor = Color.DarkSlateGray;
                btnansa.BackColor = Color.DarkSlateGray;
                System.Threading.Thread.Sleep(2000);
                btnansd.BackColor = Color.DarkSlateGray; */
                nepravilno();
            }
        }
    }
}

