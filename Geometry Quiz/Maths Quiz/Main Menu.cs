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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnEasy_Click(object sender, EventArgs e) //Starts the game when clicked
        {
            Hide();
            new frmQuestion1().Show();
        }
      
        private void tspLogOut_Click(object sender, EventArgs e) //Shows the Log In Screen
        {
            Player.Score = 0;
            Hide();
            new frmLogIn().Show();
        }

        private void tspHighScores_Click(object sender, EventArgs e) //Shows the HighScore Screen
        {
            Player.Score = 0;
            Hide();
            new frmHighScores().Show();
        }

        private void btnExit_Click(object sender, EventArgs e) //Exits the game
        {
            Hide();
        }

        private void btnHighScores_Click(object sender, EventArgs e) //Shows frmHighScores
        {
            Hide();
            new frmHighScores().Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e) //Shows frmLogIn
        {
            Hide();
            new frmLogIn().Show();
        }

        private void tspHelp_Click(object sender, EventArgs e) //Shows some help for the user
        {
            MessageBox.Show("From here you can start the game, view the high scores, log out or exit.");
        }
    }
}
