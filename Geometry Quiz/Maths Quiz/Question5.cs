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
    public partial class frmQuestion5 : Form
    {
        public frmQuestion5()
        {
            InitializeComponent();
            CenterToScreen();
            AllowDropping();
            lblScore.Text = "Score: " + Player.Score;
            lblUser.Text = "User:" + Player.Username;
           
        }

        private int Answers = 0; //Answers variable

        private void AllowDropping() //Makes the pictures drop zones
        {
            picOval.AllowDrop = true;
            picParallelogram.AllowDrop = true;
            picPentagon.AllowDrop = true;
        }

        private void LabelGrabbed(object sender, MouseEventArgs e) //Enables dragging of the labels
        {
            Label selectedLabel = (Label)sender;
            selectedLabel.DoDragDrop(selectedLabel.Text, DragDropEffects.Copy);
        }

        private void AllowDragDropCopy(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PentagonDragDrop(object sender, DragEventArgs e) 
        {
            String result = (string)e.Data.GetData(DataFormats.Text);
            

            if (result == lblPentagon.Text) //Compares the labels text with the correct answer
            {
                lblPentagon.Visible = false; //Label and picture made invisble
                picPentagon.Visible = false;
                Player.Score += 100; //Score increased for correct answer
                lblScore.Text = "Score: " + Player.Score; //Score updated
                Answers++; //Increases answers variable
                if (Answers == 3) //Checks if answers is 3, if it is the program advances
                {
                    Hide();
                    new frmResultScreen().Show();
                }
            }
            else //Repeated with a decrease instead of an increase and with the dropzone picture and its respective label dissappearing
            {
                lblPentagon.Visible = false;
                picPentagon.Visible = false;
                Player.Score -= 10;
                lblScore.Text = "Score: " + Player.Score;
                Answers++;
                if (Answers == 3)
                {
                    Hide();
                    new frmResultScreen().Show();
                }
            }
        }

        private void ParallelogramDragDrop(object sender, DragEventArgs e) //Reoeat of above code
        {
            String result = (string)e.Data.GetData(DataFormats.Text);
            if (result == "Parallelogram")
            {
                lblParallelogram.Visible = false;
                picParallelogram.Visible = false;
                Player.Score += 100;
                lblScore.Text = "Score: " + Player.Score;
                Answers++;
                if (Answers == 3)
                {
                    Hide();
                    new frmResultScreen().Show();
                }
            }
            else
            {
                lblParallelogram.Visible = false;
                picParallelogram.Visible = false;
                Player.Score -= 10;
                lblScore.Text = "Score: " + Player.Score;
                Answers++;
                if (Answers == 3)
                {
                    Hide();
                    new frmResultScreen().Show();
                }
            }
        }

        private void OvalDragDrop(object sender, DragEventArgs e) //Repeat of above code
        {
            String result = (string)e.Data.GetData(DataFormats.Text);
            if (result == lblOval.Text)
            {
                lblOval.Visible = false;
                picOval.Visible = false;
                Player.Score += 100;
                lblScore.Text = "Score: " + Player.Score;
                Answers++;
                if (Answers == 3)
                {
                    Hide();
                    new frmResultScreen().Show();
                }
            }
            else
            {
                lblOval.Visible = false;
                picOval.Visible = false;
                Player.Score -= 10;
                lblScore.Text = "Score: " + Player.Score;
                Answers++;
                if (Answers == 3)
                {
                    Hide();
                    new frmResultScreen().Show();
                }
            }
            


        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) //See frmQuestion1 for Menu Strip/Tool Bar functionality explained
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
            MessageBox.Show("Click the mouse on one of the labels to pick it up, move the mouse to the correct shape and release the mouseclick to submit a response. Once all three attempts are made, you will automatically proceed");
        }


    }
}
