using System;
using System.Windows.Forms;

//Player1 --> X
//Player2 --> O

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        //Make a variable to detect wich player's turn it is
        //In the first loop player variable will turn to false, so each time player is false 
        //it is the first player's turn. When it's true it's seconds.
        bool player = true;
        //Counter to print round number.
        int turns = 0;
        //Counter to print player victories number.
        int player1wins = 0;
        int player2wins = 0;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome, Player 1 you go first!");
        }

        //fucntion to check if there is a winner
        private void WinnerCheck()
        {
            //If winner is False we dont have a winner, If it's True we have one.
            bool winner = false;
            //Check rows:
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text)
                && (!button1.Enabled) && (!button2.Enabled) && (!button3.Enabled))
                winner = true;
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text)
                && (!button4.Enabled) && (!button5.Enabled) && (!button6.Enabled))
                winner = true;
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text)
                && (!button7.Enabled) && (!button8.Enabled) && (!button9.Enabled))
                winner = true;

            //Check columns:
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text)
                && (!button1.Enabled) && (!button4.Enabled) && (!button7.Enabled))
                winner = true;
            if ((button2.Text == button5.Text) && (button5.Text == button8.Text)
                && (!button2.Enabled) && (!button5.Enabled) && (!button8.Enabled))
                winner = true;
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text)
                && (!button3.Enabled) && (!button6.Enabled) && (!button9.Enabled))
                winner = true;

            //Check diagonally:
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text)
                && (!button1.Enabled) && (!button5.Enabled) && (!button9.Enabled))
                winner = true;
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text)
                && (!button3.Enabled) && (!button5.Enabled) && (!button7.Enabled))
                winner = true;

            //If winner is true it means we have a winner.
            if (winner)
            {
                //If player value is false it means Player 1 won if it's true Player 2 won
                String shoWinner = "";
                if (player)
                {
                    shoWinner = "Player 2";
                    player2wins += 1;
                }
                else
                {
                    shoWinner = "Player 1";
                    player1wins += 1;
                }
                MessageBox.Show(shoWinner + " is the Winner!\n  " + "It took " + turns + " moves.");
                label4.Text = player2wins.ToString();
                label3.Text = player1wins.ToString();
                //restart buttons for next round
                nextRound();
            }
        }

        //function to begin next round
        private void nextRound()
        {
            if (!button1.Enabled)
            {
                button1.Enabled = true;
                button1.Text = "";
            }
            if (!button2.Enabled)
            {
                button2.Enabled = true;
                button2.Text = "";

            }
            if (!button3.Enabled)
            {
                button3.Enabled = true;
                button3.Text = "";

            }
            if (!button4.Enabled)
            {
                button4.Enabled = true;
                button4.Text = "";

            }
            if (!button5.Enabled)
            {
                button5.Enabled = true;
                button5.Text = "";

            }
            if (!button6.Enabled)
            {
                button6.Enabled = true;
                button6.Text = "";

            }
            if (!button7.Enabled)
            {
                button7.Enabled = true;
                button7.Text = "";

            }
            if (!button8.Enabled)
            {
                button8.Enabled = true;
                button8.Text = "";

            }
            if (!button9.Enabled)
            {
                button9.Enabled = true;
                button9.Text = "";

            }
            turns = 0;
        }

        //function that runs everytime a button is pressed
        private void button_click(object sender, EventArgs e)
        {

            turns += 1;
            //I apply the same method to all buttons because the same thing must happen if any is clicked.
            Button buttonPressed = (Button)sender;
            if (player)
                buttonPressed.Text = "X";
            else
                buttonPressed.Text = "O";

            //Turn is over so player value must change.
            player = !player;

            //Disable the button when it's clicked so user can't interapt with it anymore.
            buttonPressed.Enabled = false;
            //After any button is pressed WinnerCheck Function will check for a winner.
            WinnerCheck();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player1wins = 0;
            player2wins = 0;
            label3.Text = player2wins.ToString();
            label4.Text = player1wins.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Version 1.0" + Environment.NewLine + "Created by George Pappas");

        }
    }
}
