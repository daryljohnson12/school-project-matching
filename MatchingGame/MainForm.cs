using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MatchingGame

    
    
    
    
{
    public partial class Matching : Form
    {
        // Variables
        Random location = new Random(); // Puts Cards in Random locations
        List<Point> points = new List<Point>();
        bool again = false; // Asks you if you want to play again.
        PictureBox PendingImage1;// Stores first card in memory.
        PictureBox PendingImage2;// Stores second card in memory.
        StreamWriter outputFile;
        


        public Matching()
        {
            InitializeComponent();
        }

      
        private void Matching_Load(object sender, EventArgs e)
        {

            // Used to put the cards in Random locations
            foreach (PictureBox picture in cardsHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in cardsHolder.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            // Sets images for game.
            card1.Image = Properties.Resources.Ace_Clubs;
            dupCard1.Image = Properties.Resources.Ace_Clubs;
            card2.Image = Properties.Resources.Ace_Spades;
            dupCard2.Image = Properties.Resources.Ace_Spades;
            card3.Image = Properties.Resources.Jack_Clubs;
            dupCard3.Image = Properties.Resources.Jack_Clubs;
            card4.Image = Properties.Resources.Jack_Spades;
            dupCard4.Image = Properties.Resources.Jack_Spades;
            card5.Image = Properties.Resources.King_Clubs;
            dupCard5.Image = Properties.Resources.King_Clubs;
            card6.Image = Properties.Resources.King_Spades;
            dupCard6.Image = Properties.Resources.King_Spades;
            card7.Image = Properties.Resources.Queen_Clubs;
            dupCard7.Image = Properties.Resources.Queen_Clubs;
            card8.Image = Properties.Resources.Queen_Spades;
            dupCard8.Image = Properties.Resources.Queen_Spades;

           
        }
       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Timer used to set the time you can see the card before they flip over.
            timer1.Stop();
            foreach (PictureBox picture in cardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Backface_Blue;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Timer used to set the count down timer.
            int timer = Convert.ToInt32(timerLabel.Text);
            timer = timer - 1;
            timerLabel.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
            }
        }

        // Region for card info. 
        #region

        private void card1_Click(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            card1.Image = Properties.Resources.Ace_Clubs;
            if (PendingImage1 == null)
            {
                PendingImage1 = card1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card1.Enabled = false;
                    dupCard1.Enabled = false;
                    // Make a method used for score.
                    Score();
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void dupCard1_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            dupCard1.Image = Properties.Resources.Ace_Clubs;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupCard1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupCard1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card1.Enabled = false;
                    dupCard1.Enabled = false;
                    // Make a method used for score.
                    Score();
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void card2_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            card2.Image = Properties.Resources.Ace_Spades;
            if (PendingImage1 == null)
            {
                PendingImage1 = card2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card2.Enabled = false;
                    dupCard2.Enabled = false;
                    // Make a method used for score.
                    Score();
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void dupCard2_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            dupCard2.Image = Properties.Resources.Ace_Spades;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupCard2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupCard2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card2.Enabled = false;
                    dupCard2.Enabled = false;
                    // Make a method used for score.
                    Score();
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void card3_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            card3.Image = Properties.Resources.Jack_Clubs;
            if (PendingImage1 == null)
            {
                PendingImage1 = card3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card3.Enabled = false;
                    dupCard3.Enabled = false;
                    // Make a method used for score.
                    Score();
                   
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void dupCard3_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            dupCard3.Image = Properties.Resources.Jack_Clubs;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupCard3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupCard3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card3.Enabled = false;
                    dupCard3.Enabled = false;
                    // Make a method used for score.
                    Score();
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void card4_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            card4.Image = Properties.Resources.Jack_Spades;
            if (PendingImage1 == null)
            {
                PendingImage1 = card4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card4.Enabled = false;
                    dupCard4.Enabled = false;
                    // Make a method used for score.
                    Score();
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void dupCard4_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            dupCard4.Image = Properties.Resources.Jack_Spades;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupCard4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupCard4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card4.Enabled = false;
                    dupCard4.Enabled = false;
                    // Make a method used for score.
                    Score();
                    
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void card5_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            card5.Image = Properties.Resources.King_Clubs;
            if (PendingImage1 == null)
            {
                PendingImage1 = card5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card5.Enabled = false;
                    dupCard5.Enabled = false;
                    // Make a method used for score.
                    Score();
                    
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void dupCard5_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            dupCard5.Image = Properties.Resources.King_Clubs;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupCard5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupCard5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card5.Enabled = false;
                    dupCard5.Enabled = false;
                    // Make a method used for score.
                    Score();
                    
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void card6_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            card6.Image = Properties.Resources.King_Spades;
            if (PendingImage1 == null)
            {
                PendingImage1 = card6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card6.Enabled = false;
                    dupCard6.Enabled = false;
                    // Make a method used for score.
                    Score();
                    
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void dupCard6_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            dupCard6.Image = Properties.Resources.King_Spades;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupCard6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupCard6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card6.Enabled = false;
                    dupCard6.Enabled = false;
                    // Make a method used for score.
                    Score();
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void card7_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            card7.Image = Properties.Resources.Queen_Clubs;
            if (PendingImage1 == null)
            {
                PendingImage1 = card7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card7.Enabled = false;
                    dupCard7.Enabled = false;
                    // Make a method used for score.
                    Score();
                    
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void dupCard7_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            dupCard7.Image = Properties.Resources.Queen_Clubs;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupCard7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupCard7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card7.Enabled = false;
                    dupCard7.Enabled = false;
                    // Make a method used for score.
                    Score();
                    
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void card8_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            card8.Image = Properties.Resources.Queen_Spades;
            if (PendingImage1 == null)
            {
                PendingImage1 = card8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card8.Enabled = false;
                    dupCard8.Enabled = false;
                    // Make a method used for score.
                    Score();
                    
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        private void dupCard8_Click_1(object sender, EventArgs e)
        {
            // Used to see if the cards match.
            dupCard8.Image = Properties.Resources.Queen_Spades;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupCard8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupCard8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card8.Enabled = false;
                    dupCard8.Enabled = false;
                    // Make a method used for score.
                    Score();
                    
                }
                else
                {
                    // Used to keep time that the cards are flipped over.
                    timer3.Start();
                }
            }
        }

        #endregion
        
            
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            //Sets the timer for the time between card flips.
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.Backface_Blue;
            PendingImage2.Image = Properties.Resources.Backface_Blue;
            PendingImage1 = null;
            PendingImage2 = null;
        }

       

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            //Closes the game.
            this.Close();
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            // Input vaildation that makes sure that you enter in a name.
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name ");
            }
            else
            {
                // Resets the game if anything goes wrong.
                scoreCounter.Text = "0";
                timeLeft.Text = "35";
                timer1.Stop();
                timer4.Start();
                timer5.Start();
                foreach (PictureBox picture in cardsHolder.Controls)
                {
                    picture.Enabled = true;
                    picture.Cursor = Cursors.Hand;
                    picture.Image = Properties.Resources.Backface_Blue;
                }
            }
            
        }

       public void Score() // Method used to keep track of the score.
        {
            // Prints the score to the scoreCounter.
            scoreCounter.Text = Convert.ToString(Convert.ToInt32(scoreCounter.Text) + 10);
           
        }

        public void Message() // Method used for message and to send information to a file.
        {
            // Print your name and score and sends it to a file.
            MessageBox.Show(nameTextBox.Text + " your score is " + scoreCounter.Text);
            outputFile = File.AppendText("info.txt");
            outputFile.WriteLine(nameTextBox.Text + " " + scoreCounter.Text);
            outputFile.Close();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            // Timer used to count down the time you have left in the game.
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            // Timer used to count down timer4.
            int timer = Convert.ToInt32(timeLeft.Text);
            timer = timer - 1;
            timeLeft.Text = Convert.ToString(timer);
            int score = Convert.ToInt32(scoreCounter.Text);

            if (timer == 0 || score == 80)
            { 
                timer5.Stop();
                Message();               
                foreach (PictureBox picture in cardsHolder.Controls)
                {
                    picture.Enabled = false;
                    picture.Cursor = Cursors.Hand;
                    picture.Image = Properties.Resources.Backface_Blue;
                }
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Input vaildation that makes sure that you enter in a name.
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name ");
            }
            else
            {
                // Sets the vaiables before the game starts.
                timerLabel.Text = "5";
                timeLeft.Text = "35";
                scoreCounter.Text = "0";
                // Sets timer for game.
                timer4.Start();
                timer5.Start();
                timer2.Start();
                timer1.Start();
                Matching_Load(sender, e);

            }
           
        }
       
       
    }
}

        
    

