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
    public partial class frmQuestion4 : Form
    {
        public frmQuestion4()
        {
            InitializeComponent();
            CenterToScreen();
            lblScore.Text = "Score: " + Player.Score;
            lblUser.Text = "User:" + Player.Username;
        }
        private int Answers = 0; //Variable created to count correct answers
        //On this question the player selects four answers; one from each groupbox.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdbQ1T.Checked == true) //On click of the button, adds 50 points for a correct answer and takes 5 for incorrect answers.
            {
                Player.Score += 50;
                Answers++; //Incrementation of the answer variable
            }
            if (rdbQ1F.Checked == true) //Repeat of above code
            {
                Player.Score -= 5;
            }

            if (rdbQ2T.Checked == true) //Repeat of above code
            {
                Player.Score -= 5;
            }
            if (rdbQ2F.Checked == true)//Repeat of above code
            {
                Player.Score += 50;
                Answers++;
            }

            if (rdbQ3T.Checked == true)//Repeat of above code
            {
                Player.Score -= 5;
            }
            if (rdbQ3F.Checked == true)//Repeat of above code
            {
                Player.Score += 50;
                Answers++;
            }

            if (rdbQ4T.Checked == true)//Repeat of above code
            {
                Player.Score += 50;
                Answers++;
            }
            if (rdbQ4F.Checked == true)//Repeat of above code
            {
                Player.Score -= 5;
            }
            MessageBox.Show("You got " + Answers + "/4 Answers Correct!"); //Shows a messagebox that uses the Answers variable to show the player how many questions they got right
            Hide();
            new frmQuestion5().Show();

        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) //See menu strip items on frmQuestion1 (Repeated)
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
            MessageBox.Show("Choose between the two answers - true or false - for each of the four questions, using a mouseclick. When all are answered, click the submit button!");
        }
    }
}
