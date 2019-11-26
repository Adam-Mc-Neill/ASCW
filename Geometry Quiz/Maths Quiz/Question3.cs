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
    public partial class frmQuestion3 : Form
    {
        public frmQuestion3()
        {
            InitializeComponent();
            CenterToScreen();
            lblScore.Text = "Score: " + Player.Score;
            lblUser.Text = "User:" + Player.Username;
            
        }
        private int Answers = 0; //Variable created to count number of correct answers to use when providing feedback later

       
        private void cbQuad2_SelectedIndexChanged(object sender, EventArgs e) //The correct answers will add 50 points and increment 'Answers' by 1 and the incorrect ones will take 0 away.
        {
            {
                string quadAnswer2 = cbQuad2.SelectedItem.ToString(); //Changes the int value of the ComboBox to a string variable
                if (quadAnswer2 == "4") //Compares the selected number with the correct answer
                {
                    Player.Score += 50; //adds 50 to score
                    Answers++; //adds 1 to answers
                    
                }
                else
                {
                    Player.Score -= 5;
                }

            }

        }

        private void cbQuad1_SelectedIndexChanged(object sender, EventArgs e) //Repeat of above code
        {
            {
                string quadAnswer1 = cbQuad1.SelectedItem.ToString();
                if (quadAnswer1 == "4")
                {
                    Player.Score += 50;
                    Answers++;
                }
                else
                {
                    Player.Score -= 5;
                }

            }

        }

        private void cbTri1_SelectedIndexChanged(object sender, EventArgs e) //Repeat of above code
        {
            {
                string triAnswer1 = cbTri1.SelectedItem.ToString();
                if (triAnswer1 == "3")
                {
                    Player.Score += 50;
                    Answers++;
                }
                else
                {
                    Player.Score -= 5;
                }

            }

        }

        private void cbTri2_SelectedIndexChanged(object sender, EventArgs e) //Repeat of above code
        {
            {
                string triAnswer2 = cbTri2.SelectedItem.ToString();
                if (triAnswer2 == "3")
                {
                    Player.Score += 50;
                    Answers++;
                }
                else
                {
                    Player.Score -= 5;
                }

            }

        }

        private void cbHex1_SelectedIndexChanged(object sender, EventArgs e) //Repeat of above code
        {
            {
                string hexAnswer1 = cbHex1.SelectedItem.ToString();
                if (hexAnswer1 == "6")
                {
                    Player.Score += 50;
                    Answers++;
                }
                else
                {
                    Player.Score -= 5;
                }

            }

        }

        private void cbHex2_SelectedIndexChanged(object sender, EventArgs e) //Repeat of above code
        {
            {
                string hexAnswer2 = cbHex2.SelectedItem.ToString();
                if (hexAnswer2 == "6")
                {
                    Player.Score += 50;
                    Answers++;
                }
                else
                {
                    Player.Score -= 5;
                }

            }
        }

        private void cbOct1_SelectedIndexChanged(object sender, EventArgs e) //Repeat of above code
        {
            {
                string octAnswer1 = cbOct1.SelectedItem.ToString();
                if (octAnswer1 == "8")
                {
                    Player.Score += 50;
                    Answers++;
                }
                else
                {
                    Player.Score -= 5;
                }

            }
        }

        private void cbOct2_SelectedIndexChanged(object sender, EventArgs e) //Repeat of above code
        {
            {
                string octAnswer2 = cbOct2.SelectedItem.ToString();
                if (octAnswer2 == "9")
                {
                    Player.Score += 50;
                    Answers++;
                }
                else
                {
                    Player.Score -= 5;
                }
                

            }
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

        private void btnConfirm_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("You got " + Answers + "/8 Answers Correct!"); //The messagebox uses the variable 'Answers' to show how many answers the player got right
            Hide();
            new frmQuestion4().Show();
        }

        private void tspExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tspHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on the arrows to present a list of options from which your answer can be selected, again by clicking on the answer you think is correct. Click the Confirm button to continue to the next question.");
        }
    }
}


