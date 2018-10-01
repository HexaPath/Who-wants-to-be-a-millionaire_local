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
        ///////////////////////////////////////////////////////////////BASIC FUNCTIONS///////////////////////////////////////////////////////////////////////////
        
        private void randomize_function()                                                   //Stvaritev naključne številke
        { 
            index = new Random().Next(1, randomlimit);
            if (result == 0)
            {
                    btnreward1.BackColor = Color.YellowGreen;
            }
            repeatability_check_function();
        }

        //////////////////////////////////////////////////////////////////

        private void database_function()                                                    //Vse funkcije v podatkovnih bazah za igro so tukej
        { 
            int i = 1;

            if (chosenone == 3)
            {
                SQL_command_topic_based = 
                    "SELECT " +
                    "   questions.content, " +
                    "   topics.name, questions.id " +
                    "FROM " +
                    "   questions, " +
                    "   topics " +
                    "WHERE (" +
                    "   (questions.topic = 1) " +
                    "   OR " +
                    "       (questions.topic = 2) " +
                    "   OR " +
                    "       (questions.topic = 3))" +
                    "   AND (topics.id = questions.topic) " +
                    "ORDER BY " +
                    "   (questions.id) " +
                    "LIMIT " +
                    "   " + index + "," +
                    "    1;";
            }
            else if (chosenone == 7)
            {
                SQL_command_topic_based = "" +
                    "SELECT " +
                    "   questions.content, " +
                    "   topics.name, " +
                    "   questions.id   " +
                    "FROM " +
                    "   questions, " +
                    "   topics " +
                    "WHERE (" +
                    "   (questions.topic = 1) " +
                    "   OR " +
                    "       (questions.topic = 2) " +
                    "   OR " +
                    "       (questions.topic = 3) " +
                    "   OR " +
                    "       (questions.topic = 4) " +
                    "   OR " +
                    "       (questions.topic = 5) " +
                    "   OR  " +
                    "       (questions.topic = 6) " +
                    "   OR " +
                    "       (questions.topic = 7) " +
                    "   OR  " +
                    "       (questions.topic = 8)) " +
                    "   AND " +
                    "       (topics.id = questions.topic) " +
                    "ORDER BY " +
                    "   (questions.id) " +
                    "LIMIT " +
                    "   " + index + ", " +
                    "1;";
            }
            else if (chosenone == 8 || chosenone == 9 || chosenone == 10 || chosenone == 17 || chosenone == 18 || chosenone == 19)
            {
                MessageBox.Show("This action was not acaunted for. Perhaps try again with choosing your topic ? DO NOT CHOSE FUKIN PLACEHOLDER. It Does Not Work.");
                ChoseTopic mainform = new ChoseTopic();
                this.Hide();
                mainform.Show();
            }
            else if (chosenone == 20)
            {
                SQL_command_topic_based = 
                    "SELECT " +
                    "   questions.content, " +
                    "   topics.name, " +
                    "   questions.id " +
                    "FROM " +
                    "   questions, " +
                    "   topics " +
                    "WHERE (" +
                    "   topics.id = questions.topic) " +
                    "ORDER BY " +
                    "   (questions.id) " +
                    "LIMIT " +
                    "   " + index + "," +
                    " 1;";
            }
            else
            {
                SQL_command_topic_based = 
                    "SELECT " +
                    "   questions.content, " +
                    "   topics.name, questions.id " +
                    "FROM " +
                    "   questions, " +
                    "   topics " +
                    "WHERE " +
                    "   (questions.topic = " + chosenone + " ) " +
                    "AND" +
                    "   (topics.id = questions.topic) " +
                    "ORDER BY " +
                    "   (questions.id) " +
                    "LIMIT " +
                    "   " + index + ", " +
                    "1 ; ";
            }

            connection.Open(); 
                            using (SQLiteCommand command = new SQLiteCommand(connection))
                                {
                                    command.CommandText = SQL_command_topic_based;
                                    SQLiteDataReader reader = command.ExecuteReader();
                                    reader.Read();
                                        btnq.Text = reader.GetString(0);
                                        qid = reader.GetInt32(2);
                                    reader.Close();
                                    command.Dispose();
                                }
                             
                            using (SQLiteCommand command = new SQLiteCommand(connection))                       
                                {   
                                    command.CommandText = 
                        "SELECT " +
                        "   content, " +
                        "   true " +
                        "FROM " +
                        "   answers " +
                        "WHERE " +
                        "   (q_id = " + qid + ") " +
                        "ORDER BY " +
                        "   RANDOM() " +
                        "LIMIT 4;";
                                    SQLiteDataReader reader = command.ExecuteReader();                              
                                    while(reader.Read())
                                    { 
                                        answertrue = reader.GetInt32(1);
                                    if (answertrue == 1)
                                    {
                                            answerDB = i;
                                    }
                                        switch(i) 
                                        {
                                            case 1: btnansa.Text = reader.GetString(0);
                                                break;
                                            case 2: btnansb.Text = reader.GetString(0);
                                                break;
                                            case 3: btnansc.Text = reader.GetString(0);
                                                break;
                                            case 4: btnansd.Text = reader.GetString(0);
                                                break;
                                        }  
                                        i++;

                                    }
                                    reader.Close();
                                    command.Dispose();
                                }
            connection.Close();
        }

        ////////////////////////////////////////////////////////////////////FORM///////////////////////////////////////////////////////////////////////////////

        public WhoWantsToBeAMillionaire_form2()
        {
            InitializeComponent();
            getuserid(); 
        }

        //////////////////////////////////////////////////////////////////VARIABLES/////////////////////////////////////////////////////////////////////////////

        SQLiteConnection connection = new SQLiteConnection("data source=Database.db");      //definiranje povezave
        int index = new Random().Next(1, 50);                                               //definiranje random
        int result = 0;                                                                     //rezultat
        int[] used = new int[15];                                                           //nov array za preverjanje ponovljivosti
        int answerDB = 0;                                                                   //preverjanje pravilnega odgovora
        public static int points = 0;
        public static int iduser = 0; 
        int form = Form1.form;
        string text = Form1.user;
        
        int fiftytrue = 0;
        int phonetrue = 0;
        int auditrue = 0;

        int chosenone = ChoseTopic.chosenone;
        string SQL_command_topic_based = ""; 
        int randomlimit = 0;
        int answertrue = 0;
        int qid = 0;
        
        /*/////////////////////////////////////////////////////////////////TO DO LIST//////////////////////////////////////////////////////////////////////////////
         

          ////////////////////////////////////////////////////////////OTHER FUNCTION/////////////////////////////////////////////////////////////////////////////// */

        private void repeatability_check_function()                                         // preveri če se je vprašanje že ponovilo
        {
            try
            {
            for (int i = 0; i < 15; i++)
            {
                if (used[i] == index)
                {
                    index++;
                        if (used[i] == index)
                        {
                            randomize_function();
                        }
                }
            }

                string testofused = "";
                for (int i = 0; i < 15; i++)
                {
                    testofused += " " +  Convert.ToString(used[i]);
                }
                 
            btnansa.BackColor = Color.DarkSlateGray;
            btnansb.BackColor = Color.DarkSlateGray;
            btnansc.BackColor = Color.DarkSlateGray;
            btnansd.BackColor = Color.DarkSlateGray; 
                btnaudi1.BackColor = Color.Black;
                btnaudi2.BackColor = Color.Black;
                btnaudi3.BackColor = Color.Black;
                btnaudi4.BackColor = Color.Black;

                if (result < 15)
                {
                    used[result] = index;
                }
            }
            catch { MessageBox.Show("neki je narobe. V cathchu sm"); }
            database_function();
        }
        
        //////////////////////////////////////////////////////////////////

        private void right()                                                                // v primeru da je odgovor pravilen sproži funkcijo
        {
            result++;
            btnansa.Enabled = true;
            btnansb.Enabled = true;
            btnansc.Enabled = true;
            btnansd.Enabled = true;
            switch (result)                                                                                                                           // pobarva gumb z nagrado
            {
                case 0:
                    btnreward1.BackColor = Color.YellowGreen; btnreward.Text = "0 $"; points = 0;
                    /*btnreward1.BackColor = Color.Black;*/
                    btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 1:
                    btnreward2.BackColor = Color.YellowGreen; btnreward.Text = btnreward1.Text; points = 100;
                    btnreward1.BackColor = Color.Black; /*btnreward2.BackColor = Color.Black;*/ btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 2:
                    btnreward3.BackColor = Color.YellowGreen; btnreward.Text = btnreward2.Text; points = 200;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; /*btnreward3.BackColor = Color.Black;*/ btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 3:
                    btnreward4.BackColor = Color.YellowGreen; btnreward.Text = btnreward3.Text; points = 300;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; /*btnreward4.BackColor = Color.Black;*/ btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 4:
                    btnreward5.BackColor = Color.YellowGreen; btnreward.Text = btnreward4.Text; points = 500;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; /*btnreward5.BackColor = Color.Black;*/
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 5:
                    btnreward6.BackColor = Color.YellowGreen; btnreward.Text = btnreward5.Text; points = 1000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    /*btnreward6.BackColor = Color.Black;*/
                    btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 6:
                    btnreward7.BackColor = Color.YellowGreen; btnreward.Text = btnreward6.Text; points = 2000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; /*btnreward7.BackColor = Color.Black;*/ btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 7:
                    btnreward8.BackColor = Color.YellowGreen; btnreward.Text = btnreward7.Text; points = 4000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; /*btnreward8.BackColor = Color.Black;*/ btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 8: 
                    btnreward9.BackColor = Color.YellowGreen; btnreward.Text = btnreward8.Text; points = 8000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; /*btnreward9.BackColor = Color.Black;*/ btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 9:
                    btnreward10.BackColor = Color.YellowGreen; btnreward.Text = btnreward9.Text; points = 16000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; /*btnreward10.BackColor = Color.Black;*/
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 10:
                    btnreward11.BackColor = Color.YellowGreen; btnreward.Text = btnreward10.Text; points = 32000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    /*btnreward11.BackColor = Color.Black;*/
                    btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 11:
                    btnreward12.BackColor = Color.YellowGreen; btnreward.Text = btnreward11.Text; points = 64000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; /*btnreward12.BackColor = Color.Black;*/ btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 12:
                    btnreward13.BackColor = Color.YellowGreen; btnreward.Text = btnreward12.Text; points = 125000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; /*btnreward13.BackColor = Color.Black;*/ btnreward14.BackColor = Color.Black; btnreward15.BackColor = Color.Black;
                    break;
                case 13:
                    btnreward14.BackColor = Color.YellowGreen; btnreward.Text = btnreward13.Text; points = 250000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; /*btnreward14.BackColor = Color.Black;*/ btnreward15.BackColor = Color.Black;
                    break;
                case 14:
                    btnreward15.BackColor = Color.YellowGreen; btnreward.Text = btnreward14.Text; points = 500000;
                    btnreward1.BackColor = Color.Black; btnreward2.BackColor = Color.Black; btnreward3.BackColor = Color.Black; btnreward4.BackColor = Color.Black; btnreward5.BackColor = Color.Black;
                    btnreward6.BackColor = Color.Black; btnreward7.BackColor = Color.Black; btnreward8.BackColor = Color.Black; btnreward9.BackColor = Color.Black; btnreward10.BackColor = Color.Black;
                    btnreward11.BackColor = Color.Black; btnreward12.BackColor = Color.Black; btnreward13.BackColor = Color.Black; btnreward14.BackColor = Color.Black; /*btnreward15.BackColor = Color.Black;*/
                    break;
                case 15:
                    points = 1000000;
                    form = 2;
                    The_end mainform = new The_end();                                                                                                   // definiraj formo the end kot glavno formo
                    this.Hide();                                                                                                                        // skrij to formo
                    mainform.Show();                                                                                                                    // prikaži glavno formo
                    break;
            }
            randomize_function();
        }
        
        //////////////////////////////////////////////////////////////////

        private void wrong()                                                                // v primeru da je odgovor napačen sproži funkcijo
        {
            form = 2; 
            The_end mainform = new The_end();                                                                                                           // definiraj formo the end kot glavno formo
            this.Hide();                                                                                                                                // skrij to formo
            mainform.Show();                                                                                                                            // prikaži glavno formo
        }

        //////////////////////////////////////////////////////////////////

        private void btnexit_Click_1(object sender, EventArgs e)                            // izhod iz programa
        {
            Application.Exit();
        }

        //////////////////////////////////////////////////////////////////

        private void delay_Tick(object sender, EventArgs e)                                 // zaenkrat še ni v uporabi... namenjeno za delay barve
        {
            delay.Enabled = false;
            right(); 
        }

        ////////////////////////////////////////////////////////////OPTIONAL BUTTONS for suny days//////////////////////////////////////////////////////////////

        private void btn5050_Click(object sender, EventArgs e)          // Fifty fifty
        {
            if (fiftytrue == 0)
            {
                btn5050.Image = WhoWantsToBeAMillionaire_form1.Properties.Resources._50_50_red;
                int fiftyfifty = new Random().Next(1, 5);
                fiftyfifty = new Random().Next(1, 5);
                
                btnansa.Enabled = false;
                btnansb.Enabled = false;
                btnansc.Enabled = false;
                btnansd.Enabled = false; 
                btnansa.BackColor = Color.Black;
                btnansb.BackColor = Color.Black;
                btnansc.BackColor = Color.Black;
                btnansd.BackColor = Color.Black;

                if (answerDB != fiftyfifty)
                {
                    switch (fiftyfifty)
                    {
                        case 1:
                            btnansa.Enabled = true;
                            btnansa.BackColor = Color.DarkSlateGray;
                            break;
                        case 2:
                            btnansb.Enabled = true;
                            btnansb.BackColor = Color.DarkSlateGray;
                            break;
                        case 3:
                            btnansc.Enabled = true;
                            btnansc.BackColor = Color.DarkSlateGray;
                            break;
                        case 4:
                            btnansd.Enabled = true;
                            btnansd.BackColor = Color.DarkSlateGray;
                            break;
                    }
                    switch (answerDB)
                    {
                        case 1:
                            btnansa.Enabled = true;
                            btnansa.BackColor = Color.DarkSlateGray;
                            break;
                        case 2:
                            btnansb.Enabled = true;
                            btnansb.BackColor = Color.DarkSlateGray;
                            break;
                        case 3:
                            btnansc.Enabled = true;
                            btnansc.BackColor = Color.DarkSlateGray;
                            break;
                        case 4:
                            btnansd.Enabled = true;
                            btnansd.BackColor = Color.DarkSlateGray;
                            break;
                    }
                }
                else if (answerDB < 4)
                {
                    fiftyfifty++;
                    switch (fiftyfifty)
                    {
                        case 1:
                            btnansa.Enabled = true;
                            btnansa.BackColor = Color.DarkSlateGray;
                            break;
                        case 2:
                            btnansb.Enabled = true;
                            btnansb.BackColor = Color.DarkSlateGray;
                            break;
                        case 3:
                            btnansc.Enabled = true;
                            btnansc.BackColor = Color.DarkSlateGray;
                            break;
                        case 4:
                            btnansd.Enabled = true;
                            btnansd.BackColor = Color.DarkSlateGray;
                            break;
                    }
                    switch (answerDB)
                    {
                        case 1:
                            btnansa.Enabled = true;
                            btnansa.BackColor = Color.DarkSlateGray;
                            break;
                        case 2:
                            btnansb.Enabled = true;
                            btnansb.BackColor = Color.DarkSlateGray;
                            break;
                        case 3:
                            btnansc.Enabled = true;
                            btnansc.BackColor = Color.DarkSlateGray;
                            break;
                        case 4:
                            btnansd.Enabled = true;
                            btnansd.BackColor = Color.DarkSlateGray;
                            break;
                    }
                }
                else if (answerDB == 4)
                {
                    fiftyfifty--;
                    switch (fiftyfifty)
                    {
                        case 1:
                            btnansa.Enabled = true;
                            btnansa.BackColor = Color.DarkSlateGray;
                            break;
                        case 2:
                            btnansb.Enabled = true;
                            btnansb.BackColor = Color.DarkSlateGray;
                            break;
                        case 3:
                            btnansc.Enabled = true;
                            btnansc.BackColor = Color.DarkSlateGray;
                            break;
                        case 4:
                            btnansd.Enabled = true;
                            btnansd.BackColor = Color.DarkSlateGray;
                            break;
                    }
                    switch (answerDB)
                    {
                        case 1:
                            btnansa.Enabled = true;
                            btnansa.BackColor = Color.DarkSlateGray;
                            break;
                        case 2:
                            btnansb.Enabled = true;
                            btnansb.BackColor = Color.DarkSlateGray;
                            break;
                        case 3:
                            btnansc.Enabled = true;
                            btnansc.BackColor = Color.DarkSlateGray;
                            break;
                        case 4:
                            btnansd.Enabled = true;
                            btnansd.BackColor = Color.DarkSlateGray;
                            break;
                    }
                }
            }
            fiftytrue++;
        }

        //////////////////////////////////////////////////////////////////

        private void btnaudi_Click(object sender, EventArgs e)          // Ask audience
        {
            if (auditrue == 0)
            {
                btnaudi.Image = WhoWantsToBeAMillionaire_form1.Properties.Resources.audience_red;
                int chanse = new Random().Next(1, 101);
                btnaudi1.BackColor = Color.White;
                btnaudi1.Text = " 50% ";
                btnaudi2.BackColor = Color.Orange;
                btnaudi2.Text = " 25% ";
                btnaudi3.BackColor = Color.PaleVioletRed;
                btnaudi3.Text = " 15%  ";
                btnaudi4.BackColor = Color.Yellow;
                btnaudi4.Text = " 10% ";
                if (chanse > 20)
                {
                    switch (answerDB)
                    {
                        case 1:
                            btnansa.BackColor = Color.White;
                            btnansb.BackColor = Color.Orange;
                            btnansc.BackColor = Color.PaleVioletRed;
                            btnansd.BackColor = Color.Yellow;
                            break;
                        case 2:
                            btnansa.BackColor = Color.Orange;
                            btnansb.BackColor = Color.White;
                            btnansc.BackColor = Color.PaleVioletRed;
                            btnansd.BackColor = Color.Yellow;
                            break;
                        case 3:
                            btnansa.BackColor = Color.PaleVioletRed;
                            btnansb.BackColor = Color.Orange;
                            btnansc.BackColor = Color.White;
                            btnansd.BackColor = Color.Yellow;
                            break;
                        case 4:
                            btnansa.BackColor = Color.Yellow;
                            btnansb.BackColor = Color.Orange;
                            btnansc.BackColor = Color.PaleVioletRed;
                            btnansd.BackColor = Color.White;
                            break;
                    }
                }
                else
                {
                    btnansa.BackColor = Color.Orange;
                    btnansb.BackColor = Color.White;
                    btnansc.BackColor = Color.PaleVioletRed;
                    btnansd.BackColor = Color.Yellow;
                }
                auditrue++;
            }
        }

        //////////////////////////////////////////////////////////////////

        private void btnphone_Click(object sender, EventArgs e)          // Phone a friend
        {
            if (phonetrue == 0)
            {
                btnphone.Image = WhoWantsToBeAMillionaire_form1.Properties.Resources.phone_friend_red;
                int phone = new Random().Next(1, 5);
                int chanse = new Random().Next(1,101);
                phonetrue++;
                if (chanse > 20)
                {
                    switch (answerDB)
                    {
                        case 1:
                            btnansa.BackColor = Color.Yellow;
                            break;
                        case 2:
                            btnansb.BackColor = Color.Yellow;
                            break;
                        case 3:
                            btnansc.BackColor = Color.Yellow;
                            break;
                        case 4:
                            btnansd.BackColor = Color.Yellow;
                            break;
                    }
                }
                else
                {
                    switch (phone)
                    {
                        case 1:
                            btnansa.BackColor = Color.Yellow;
                            break;
                        case 2:
                            btnansb.BackColor = Color.Yellow;
                            break;
                        case 3:
                            btnansc.BackColor = Color.Yellow;
                            break;
                        case 4:
                            btnansd.BackColor = Color.Yellow;
                            break;
                    }
                }
                
            } 
        }

        ////////////////////////////////////////////////////////////ANSWER BUTTONS/////////////////////////////////////////////////////////////////////////////

        private void btnansa_Click(object sender, EventArgs e)                              //Gumb za odgovor A)
        {
            
            if (answerDB == 1)
            {
                btnansa.BackColor = Color.Green;
                delay.Enabled = true; 
            }
            else
            {
                btnansa.BackColor = Color.Red;
                wrong();
            }
        }

        //////////////////////////////////////////////////////////////////

        private void btnansb_Click(object sender, EventArgs e)                              //Gumb za odgovor B)
        {
            
            if (answerDB == 2)
            {
                btnansb.BackColor = Color.Green;
                delay.Enabled = true; 
            }
            else
            {
                btnansb.BackColor = Color.Red;
                wrong();
            }
        }

        //////////////////////////////////////////////////////////////////

        private void btnansc_Click(object sender, EventArgs e)                              //Gumb za odgovor C)
        {
            
            if (answerDB == 3)
            {
                btnansc.BackColor = Color.Green;
                delay.Enabled = true; 
            }
            else
            {
                btnansc.BackColor = Color.Red;
                wrong();
            }
        }

        //////////////////////////////////////////////////////////////////

        private void btnansd_Click(object sender, EventArgs e)                              //Gumb za odgovor D)
        {
            if (answerDB == 4)
            {
                btnansd.BackColor = Color.Green;
                delay.Enabled = true; 
            }
            else
            {
                btnansd.BackColor = Color.Red;
                wrong();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void getuserid()
        {
            connection.Open();                                                      
            using (SQLiteCommand command = new SQLiteCommand(connection))                       
            {
                command.CommandText = "SELECT id FROM users WHERE (user = '" + text + "');";                // izpis id userja
                SQLiteDataReader reader = command.ExecuteReader();
                reader.Read();
                    iduser = reader.GetInt32(0);
                reader.Close();
                command.Dispose();
            } 

            using (SQLiteCommand command = new SQLiteCommand(connection))           
            {
                if (chosenone == 3) {command.CommandText = "SELECT COUNT(*) as 'counting' FROM questions WHERE((topic = 1) OR (topic = 2) OR (topic = 3));"; }          // izpis limita za random izvajanje
                else if (chosenone == 7)
                {
                    command.CommandText = "SELECT COUNT(*) as 'counting' FROM questions WHERE((topic = 1) OR (topic = 2) OR (topic = 4) OR (topic = 5) OR (topic = 6));";
                }
                else if (chosenone == 20)
                {
                    command.CommandText = "SELECT COUNT(*) as 'counting' FROM questions;";
                } 
                else {command.CommandText = "SELECT COUNT(*) as 'counting' FROM questions WHERE(topic = " + chosenone + ");"; }          // izpis limita za random izvajanje 
                SQLiteDataReader reader = command.ExecuteReader(); 
                reader.Read(); 
                    randomlimit = reader.GetInt32(0);
                reader.Close();
                command.Dispose();
            }
            connection.Close(); 
            randomize_function();
        }

        private void WhoWantsToBeAMillionaire_form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    } 
}