using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire_form1
{
    public partial class ChoseTopic : Form
    {
        public ChoseTopic()
        {
            InitializeComponent();
        }

        public static int chosenone = 0;

          

        private void Btnmovie_Click(object sender, EventArgs e)                         // 1 - 8   Outer button Movies 
        {
            Btnmovie.Visible = false;
            Btnsports.Visible = false;
            Btnmix_sports_movies.Visible = false;
            BtnLordOfTheRings.Enabled = false;
            BtnPlaceholderMovie1.Enabled = false;
            // show movie under-links
            BtnMarvel.Visible = true;
            BtnDC.Visible = true;
            BtnMarvelDC.Visible = true;
            BtnStarWars.Visible = true;
            BtnJurassicPark.Visible = true;
            BtnLordOfTheRings.Visible = true;
            BtnMixed.Visible = true;
            BtnPlaceholderMovie1.Visible = true;
            BtnBackTo3.Visible = true;
        }

        private void Btnsports_Click(object sender, EventArgs e)                        // 11 - 18 Outer button Sports
        {
            Btnmovie.Visible = false;
            Btnsports.Visible = false;
            Btnmix_sports_movies.Visible = false;
            // show sport under - links
            BtnFootbal.Visible = true;
            BtnBasketball.Visible = true;
            BtnAthletics.Visible = true;
            BtnOlympics.Visible = true;
            BtnWinterSports.Visible = true;
            BtnSportsMixed.Visible = true;
            BtnPlaceholderSports1.Visible = true;
            BtnPlaceholderSports2.Visible = true;
            BtnBackTo3.Visible = true;
        }

        private void Btnmix_sports_movies_Click(object sender, EventArgs e)             //   20    Outer button Mixed
        {
            Btnmovie.Visible = false;
            Btnsports.Visible = false;
            Btnmix_sports_movies.Visible = false;
            chosenone = 20;
            nextform();
        }
            
        private void BtnMarvel_Click(object sender, EventArgs e)                        // 1 Inner button Movie - Marvel
        {
            chosenone = 1;
            nextform();
        }

        private void BtnDC_Click(object sender, EventArgs e)                            // 2 Inner button Movie - DC
        {
            chosenone = 2;
            nextform();
        }
        
        private void BtnMarvelDC_Click(object sender, EventArgs e)                      // 3 Inner button Movie - Marvel / DC
        {
            chosenone = 3;
            nextform();
        }

        private void BtnStarWars_Click(object sender, EventArgs e)                      // 4 Inner button Movie - StarWars
        {
            chosenone = 4;
            nextform();
        }

        private void BtnJurassicPark_Click(object sender, EventArgs e)                  // 5 Inner button Movie - Jurassic Park
        {
            chosenone = 5;
            nextform();
        }
        
        private void BtnLordOfTheRings_Click(object sender, EventArgs e)                // 6 Inner button Movie - Lord Of The Rings
        {
            chosenone = 6;
            nextform();
        }

        private void BtnMixed_Click_1(object sender, EventArgs e)                       // 7 Inner button Movie - Mixed
        {
            chosenone = 7;
            nextform();
        }

        private void BtnPlaceholderMovie1_Click_1(object sender, EventArgs e)           // 
        {
            chosenone = 8;
            nextform();
        }

        private void BtnFootbal_Click(object sender, EventArgs e)                       // 11 Inner button Sports - Footbal
        {
            chosenone = 11;
            nextform();
        }

        private void BtnBasketball_Click(object sender, EventArgs e)                    // 12 Inner button Sports - Basketball
        {
            chosenone = 12;
            nextform();
        }

        private void BtnAthletics_Click(object sender, EventArgs e)                     // 13 Inner button Sports - Athletics
        {
            chosenone = 13;
            nextform();
        }

        private void BtnOlympics_Click(object sender, EventArgs e)                      // 14 Inner button Sports - Olympics
        {
            chosenone = 14;
            nextform();
        }

        private void BtnWinterSports_Click(object sender, EventArgs e)                  // 15 Inner button Sports - Winter Sports
        {
            chosenone = 15;
            nextform();
        }

        private void BtnSportsMixed_Click(object sender, EventArgs e)                   // 16 Inner button Sports - Mixed Sports
        {
            chosenone = 16;
            nextform();
        }

        private void BtnPlaceholderSports1_Click(object sender, EventArgs e)            // 
        {
            chosenone = 17;
            nextform();
        }

        private void BtnPlaceholderSports2_Click(object sender, EventArgs e)            // 
        {
            chosenone = 18;
            nextform();
        }



        private void BtnBackTo3_Click(object sender, EventArgs e)                       // Inner button BACK for all innerbuttons 
        {
            Btnmovie.Visible = true;
            Btnsports.Visible = true;
            Btnmix_sports_movies.Visible = true;
            BtnBackTo3.Visible = false;
                // hide movie section
            BtnMarvel.Visible = false;
            BtnDC.Visible = false;
            BtnMarvelDC.Visible = false;
            BtnStarWars.Visible = false;
            BtnJurassicPark.Visible = false;
            BtnLordOfTheRings.Visible = false;
            BtnMixed.Visible = false;
            BtnMixed.Visible = false;
            BtnPlaceholderMovie1.Visible = false;
                // hide sports section
            BtnFootbal.Visible = false;
            BtnBasketball.Visible = false;
            BtnAthletics.Visible = false;
            BtnOlympics.Visible = false;
            BtnWinterSports.Visible = false;
            BtnSportsMixed.Visible = false;
            BtnPlaceholderSports1.Visible = false;
            BtnPlaceholderSports2.Visible = false;
        }
         
        private void nextform()                                                         // New form
        { 
            //MessageBox.Show(Convert.ToString(chosenone));
            WhoWantsToBeAMillionaire_form2 mainform = new WhoWantsToBeAMillionaire_form2();                                                                                                   // definiraj formo the end kot glavno formo
            this.Hide();                                                                                                                        // skrij to formo
            mainform.Show();
        }

        private void ChoseTopic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
