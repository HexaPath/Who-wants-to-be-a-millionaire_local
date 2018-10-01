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


        public WhoWantsToBeAMillionaire_form2()
        {
            InitializeComponent();
            database_function();
        }

        //////////////////////////////////////////////////////////////////////////Functions///////////////////////////////////////////////////////////////////////////

        private void database_function() // vse kar se dogaja z databazami
        {
            
            connection.Open();                                                                                                              // odpre povezavo z podatkovno bazo
            using (SQLiteCommand command = new SQLiteCommand(connection))                                                                   //ustvari imput za command za connection
            {
                command.CommandText = "SELECT * FROM game WHERE (id = " + index + ");";                                                     // iz baze game bere vprašanje in odgovore glede na id
                SQLiteDataReader reader = command.ExecuteReader();                                                                          // definiranje bralnega dela kode
                while (reader.Read())                                                                                                       // ko bere
                {
                    q = reader.GetString(1);
                    a = reader.GetString(2);
                    b = reader.GetString(3);
                    c = reader.GetString(4);
                    d = reader.GetString(5);
                    right_answer = reader.GetInt32(6);
                }
            }
            connection.Close();
            btnansa.Text = a;
            btnansb.Text = b;
            btnansc.Text = c;
            btnansd.Text = d;
            btnq.Text = q;
            random_function();
        }

        private void right_function()
        {
            result++;
            //reset barv za gumbe
        /*    btnansa.BackColor = Color.DarkSlateGray;
            btnansb.BackColor = Color.DarkSlateGray;
            btnansc.BackColor = Color.DarkSlateGray;
            btnansd.BackColor = Color.DarkSlateGray;*/
        }

        private void wrong_function() // spremeni formo na endform
        {
            The_end mainform = new The_end();                                                                                                           // definiraj formo the end kot glavno formo
            this.Hide();                                                                                                                                // skrij to formo
            mainform.Show();                                                                                                                            // prikaži novo formo
        }

        private void prize_function () // pobarva gumb z nagrado
        {
            switch (result)                                                                                                                          
            {
                case 0:
                    btnreward1.BackColor = Color.YellowGreen;
                    /*btnreward1.BackColor = Color.Black;*/
                    btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
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
                    /*btnreward6.BackColor = Color.Black;*/
                    btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
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
                    /*btnreward11.BackColor = Color.Black;*/
                    btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
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
                    Win mainform = new Win();                                                                                                           // definiraj formo the end kot glavno formo
                    this.Hide();                                                                                                                        // skrij to formo
                    mainform.Show();                                                                                                                    // prikaži glavno formo
                    break;
            }
        }
        
        private void random_function() // randomizira index za vprašanje
        {
            index = new Random().Next(1, 53);
            repetability_function();
        }

        private void repetability_function() // ali se index ponovi ?
        {
            switch (n)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 12:
                case 13:
                case 14:
                    for (int m = 0; m == n; m++)
                    {
                        if (used[m] == index)
                        {
                            n--;
                            random_function();
                        }
                        else
                        {
                            database_function();
                        }
                    }
                    break;
            }
        }
        
        ///////////////////////////////////////////////////////////////////////////Variables///////////////////////////////////////////////////////////////////////////
        int index = 0;                                                          // indikator
        int[] used = new int[15];                                               // za preverjanje vleče iz podatkovne baze
        int n = 0;                                                              // za preverjanje tabele used
        string a = "";                                                          // "iz databasa neki a";
        string b = "";                                                          // "iz databasa neki b";
        string c = "";                                                          // "iz databasa neki c";
        string d = "";                                                          // "iz databasa neki d";
        string q = "";                                                          // "iz databasa nek question";
        int right_answer = 1;                                                   // za preverjanje vleče iz podatkovne baze in primerja
        int result = 0;                                                         // result vleče iz databaze
        SQLiteConnection connection = new SQLiteConnection("data source=Database.db");//definiranje povezave    
        //////////////////////////////////////////////////////////////////////////TO DO LIST//////////////////////////////////////////////////////////////////////////
        

        /////////////////////////////////////////////////////////////////////////BUTTONS AND STUFF///////////////////////////////////////////////////////////////////
        private void btnansa_Click(object sender, EventArgs e)
        {
            int right = 1;
            if(right == right_answer)
            {
                btnansa.BackColor = Color.Green;
                right_function();
            }
            else
            {
                btnansa.BackColor = Color.Red;
                wrong_function();
            }
        }

        private void btnansb_Click(object sender, EventArgs e)
        {
            int right = 2;
            if (right == right_answer)
            {
                btnansb.BackColor = Color.Green;
                right_function();
            }
            else
            {
                btnansb.BackColor = Color.Red;
                wrong_function();
            }
        }

        private void btnansc_Click(object sender, EventArgs e)
        {
            int right = 3;
            if (right == right_answer)
            {
                btnansc.BackColor = Color.Green;
                right_function();
            }
            else
            {
                btnansc.BackColor = Color.Red;
                wrong_function();
            }
        }

        private void btnansd_Click(object sender, EventArgs e)
        {
            int right = 4;
            if (right == right_answer)
            {
                btnansd.BackColor = Color.Green;
                right_function();
            }
            else
            {
                btnansd.BackColor = Color.Red;
                wrong_function();
            }
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            btn5050.Enabled = false;
        }

        private void btnaudi_Click(object sender, EventArgs e)
        {
            btnaudi.Enabled = false;
        }

        private void btnphone_Click(object sender, EventArgs e)
        {
            btnphone.Enabled = false;
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}

/*
btnansa.BackColor = Color.DarkSlateGray;
btnansb.BackColor = Color.DarkSlateGray;
btnansc.BackColor = Color.DarkSlateGray;
btnansd.BackColor = Color.DarkSlateGray;
Color.Green;
Color.Red;
System.Threading.Thread.Sleep(1000);
*/



