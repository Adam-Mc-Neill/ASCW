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
    public partial class frmQuestion2 : Form
    {
        public frmQuestion2()
        {
            InitializeComponent();
            CenterToScreen();
            lblScore.Text = "Score: " + Player.Score;
            lblUser.Text = "User:" + Player.Username;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOctagon.Text.ToLower() == "octagon" && txtHexagon.Text.ToLower() == "hexagon") //Converts inputted text to lower case and compares them with the answers
            {
                Player.Score += 200; //adds 200 to the score
                MessageBox.Show("Correct Answers, Well done"); //feedback
                Hide();
                new frmQuestion3().Show();
            }
            if (txtOctagon.Text.ToLower() == "octagon" && txtHexagon.Text.ToLower() != "hexagon") //Takes place if only one answer is right
            {
                Player.Score += 100;
                MessageBox.Show("1/2, Good Effort!");
                Hide();
                new frmQuestion3().Show();
            }
            if (txtOctagon.Text.ToLower() != "octagon" && txtHexagon.Text.ToLower() == "hexagon") //Takes place if only one answer is right
            {
                Player.Score += 100;
                MessageBox.Show("1/2, Good Effort!");
                Hide();
                new frmQuestion3().Show();
            }
            if (txtOctagon.Text.ToLower() != "octagon" && txtHexagon.Text.ToLower() != "hexagon") //Takes place if none of the above are right
            {
                Player.Score -= 20;
                MessageBox.Show("Incorrect Answer");
                Hide();
                new frmQuestion3().Show();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) //Resets the score to 0 and starts from the first question
        {
            Player.Score = 0;
            Hide();
            new frmQuestion1().Show();
        }

        private void tspLogOut_Click(object sender, EventArgs e) //Resets the score to 0 and shows the log in screen
        {
            Player.Score = 0;
            Hide();
            new frmLogIn().Show();
        }

        private void tspHighScores_Click(object sender, EventArgs e) //Resets the score to 0 and shows the highscore table
        {
            Player.Score = 0;
            Hide();
            new frmHighScores().Show();
        }

        private void tspMainMenu_Click(object sender, EventArgs e) //Resets the score to 0 and shows the Main Menu
        {
            Player.Score = 0;
            Hide();
            new frmMainMenu().Show();
        }

        private void tspExitSystem_Click(object sender, EventArgs e) //Exits system
        {
            Application.Exit();
        }

        private void tspHelp_Click(object sender, EventArgs e) //Shows Help
        {
            MessageBox.Show("Enter the names of the shapes shown in the pictures with your keyboard. Click Confirm when you are happy with your decisions. Do not worry about Capitalisation as this is accounted for, and any combination of upper and lower case letters will be accepted.");
        }
    }
}
