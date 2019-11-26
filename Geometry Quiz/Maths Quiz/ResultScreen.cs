using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_Quiz
{
    public partial class frmResultScreen : Form
    {
        public frmResultScreen()
        {
            InitializeComponent();
            CenterToScreen();
            lblThank.Text = "Thanks for playing, " + Player.Username + "!"; //Changes the label to include the players username
            lblScore.Text = "You Scored " + Player.Score + " Points!"; //Changes label to include the players Score
            
        }
        

        private void btnHighScores_Click(object sender, EventArgs e) //Executes savescore method and opens the Highscore table
        {
            Hide();
            Player.SaveScore();
            new frmHighScores().Show();
        }

        private void button3_Click(object sender, EventArgs e) //Executes savescore method and opens the Main Menu
        {
            Hide();
            Player.SaveScore();
            new frmMainMenu().Show();
        }

        private void button2_Click(object sender, EventArgs e)//Executes savescore method and closes the application
        {
            Hide();
            Player.SaveScore();
            Application.Exit();
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) //See: frmQuestion1 for menu strip and toolbar comments
        {
            Player.Score = 0;
            Hide();
            new frmQuestion1().Show();
        }

        private void tspLogOut_Click(object sender, EventArgs e)
        {
            Player.Score = 0;
            Hide();
            new frmLogIn().Show();
        }

        private void tspHighScores_Click(object sender, EventArgs e)
        {
            Player.Score = 0;
            Hide();
            new frmHighScores().Show();
        }

        private void tspMainMenu_Click(object sender, EventArgs e)
        {
            Player.Score = 0;
            Hide();
            new frmMainMenu().Show();
        }

        private void tspExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tspHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for playing my quiz! I hope it has aided in your revision and i wish you good luck in your examinations. The buttons will take you to the forms outlined in their names and will save your score. Check the HighScore Table to see if you made the cut!");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
