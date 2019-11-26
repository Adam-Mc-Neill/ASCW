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

namespace Maths_Quiz
{
    public partial class frmHighScores : Form
    {
        public frmHighScores()
        {
            InitializeComponent();
            ReadHighScores();
            Player.Score = 0;
            
        }
        string[] sortScores; //Arrays created to be used during the rest of the code
        string[] sortNames;
        string[] score;
        int[] highScore;
        string[] Names;

        private void ReadHighScores() //Creation of method to read highscores from the scores.txt file
        {
            if (File.Exists("scores.txt"))
            {
                try
                {
                    //Read data from scores file
                    score = File.ReadLines("scores.txt").ToArray();
                    highScore = new int[score.Length];
                    Names = new string[score.Length];

                    for (int i = 0; i < score.Length; i++)
                    {
                        string[] scoresDetails = score[i].Split('~');

                        //Add usernames and high scores to arrays
                        highScore[i] = Convert.ToInt32(scoresDetails[2]);
                        Names[i] = scoresDetails[0];
                    }
                    SortHighScores(highScore);
                }
                catch
                {
                    MessageBox.Show("Error reading scores encountered.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Error reading high scores.", "Error");
            }
        }

        private void SortHighScores(int[] highScore)
        {
            //Sort high scores in descending order and sort usernames to the equivalent positions in array
            for (int i = 0; i < highScore.Length; i++)
            {
                int temp = highScore[i];
                string temp2 = Names[i];
                int t = i - 1;

                while (t >= 0 && temp > highScore[t])
                {
                    highScore[t + 1] = highScore[t];
                    Names[t + 1] = Names[t];
                    t--;
                }
                highScore[t + 1] = temp;
                Names[t + 1] = temp2;
            }

            sortScores = new string[10];
            sortNames = new string[10];

            for (int j = 0; j < 5; j++)
            {
                //If less than 5 high scores, add blank space to remaining elements in sorted array
                if (j >= highScore.Length)
                {
                    sortScores[j] = "    ";
                    sortNames[j] = "    ";
                }
                else
                {
                    //Add sorted usernames and high scores to sorted arrays
                    sortScores[j] = Convert.ToString(highScore[j]);
                    sortNames[j] = Names[j];
                }

            }
            DisplayScores();
        }

        private void DisplayScores()
        {
            lblScore1.Text = "1. " + sortNames[0] + "     " + sortScores[0];
            lblScore2.Text = "2. " + sortNames[1] + "     " + sortScores[1];
            lblScore3.Text = "3. " + sortNames[2] + "     " + sortScores[2];
            lblScore4.Text = "4. " + sortNames[3] + "     " + sortScores[3];
            lblScore5.Text = "5. " + sortNames[4] + "     " + sortScores[4];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new frmMainMenu().Show();
        }

        private void tspHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the highscore table, it shows the top five scoring players! Did you make the list?");
        }

        private void tspExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tspMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            new frmMainMenu().Show();
        }

        private void tspLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            new frmLogIn().Show();
        }
    }
}

