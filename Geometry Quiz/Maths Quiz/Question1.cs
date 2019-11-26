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
    public partial class frmQuestion1 : Form
    {
        public string Answer;

        public frmQuestion1()
        {
            InitializeComponent();
            CenterToScreen();
            lblScore.Text = "Score: " + Player.Score; //Displays the players score
            lblUser.Text = "User:" + Player.Username; //Displays the players username
            Random rnd = new Random();
            int Ques = rnd.Next(1,6); //Generates a random number between 1-5
            switch (Ques)
            
    {
            case 1: //Based on the number generated one of these cases will be executed, this will decide what text is shown on the buttons and what picture is displayed. This will also change the variable 'Answer' to that iteration of the questions answer.
                pic1.Visible = true;
                btnAnswerA.Text = "RHOMBUS";
                btnAnswerB.Text = "CIRCLE";
                btnAnswerC.Text = "SQUARE";
                Answer = "RHOMBUS";
                break;
            case 2:
                pic2.Visible = true;
                btnAnswerA.Text = "RHOMBUS";
                btnAnswerB.Text = "OCTAGON";
                btnAnswerC.Text = "SQUARE";
                Answer = "OCTAGON";
                break;
            case 3:
                pic3.Visible = true;
                btnAnswerA.Text = "RHOMBUS";
                btnAnswerB.Text = "PENTAGON";
                btnAnswerC.Text = "HEXAGON";
                Answer = "HEXAGON";
                break;
            case 4:
                pic4.Visible = true;
                btnAnswerA.Text = "RHOMBUS";
                btnAnswerB.Text = "CIRCLE";
                btnAnswerC.Text = "SQUARE";
                Answer = "CIRCLE";
                break;
            case 5:
                pic5.Visible = true;
                btnAnswerA.Text = "PENTAGON";
                btnAnswerB.Text = "CIRCLE";
                btnAnswerC.Text = "SQUARE";
                  Answer = "PENTAGON";
                break;
        
    }
        }
        
        private void btnIncorrect_Click(object sender, EventArgs e) 
        {

            if (btnAnswerA.Text == Answer ) //Checks that the selected buttons text against that of the answers
            {
                MessageBox.Show("Correct Answer, Good Job!"); //If it's correct a messagebox is shown congratulating the player
                Player.Score += 200; //If correct the players score increases by 200
                Hide();
                new frmQuestion2().Show(); //Question 2 is shown
            }
            else 
            {
                MessageBox.Show("Incorrect Answer, Try again"); //If the answer is wrong this messagebox is displayed
                Hide();
                new frmQuestion2().Show(); //Question 2 is shown
            }
        }


        private void btnCorrectAnswer_Click(object sender, EventArgs e) //Code is repeated for the other 2 buttons. See above for full details
        
    
        {
        if (btnAnswerC.Text == Answer)
        {
            MessageBox.Show("Correct Answer, Good Job!");
            Player.Score += 200;
            Hide();
            new frmQuestion2().Show();
        }
        else
        {
            MessageBox.Show("Incorrect Answer, Try again");
            Hide();
            new frmQuestion2().Show();
        }
    }

        private void btnAnswerB_Click(object sender, EventArgs e) //Code is repeated for the other 2 buttons. See above for full details
    {


        if (btnAnswerB.Text == Answer)
        {
            MessageBox.Show("Correct Answer, Good Job!");
            Player.Score += 200;
            Hide();
            new frmQuestion2().Show();
        }
        else
        {
            MessageBox.Show("Incorrect Answer, Try again");
            Hide();
            new frmQuestion2().Show();
        }
    }

    private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
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

    private void tspHelp_Click(object sender, EventArgs e)//Shows Help for the user.
    {
        MessageBox.Show("Select the button with the name of the shape shown in it, there are three to choose from. If the picture is not displaying for you, click the Restart button.");
    }

    private void tspExitSystem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    }
    }

