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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void BtnSignUp_Click(object sender, EventArgs e) //Allows user to toggle between the sign up and log in forms.
        {
            Hide();
            new frmSignUp().Show();      
        }

        private void BtnLogIn_Click(object sender, EventArgs e) 
        {
            bool userfound = false; //This will become true if the user is found

            string userName = txtUsername.Text.Trim(); //Converts the text entered into the username field into a string.
            string password = txtPassword.Text.Trim(); //Converts the text entered into the password field into a string

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                if (File.Exists("users.txt"))
                {
                    string[] userFile = File.ReadLines("users.txt").ToArray();
                    userfound = false;

                    for (int i = 0; i < userFile.Length; i++)
                    {
                        string[] users = userFile[i].Split('~');

                        if (userName == users[0] && password == users[1])
                        {
                            userfound = true;
                        }
                    }

                    if (userfound == true)
                    {
                        Player.Username = userName;
                        MessageBox.Show("Welcome Back, " + txtUsername.Text + "!");

                        Hide();
                        new frmMainMenu().Show();
                    }

                }
                if (userfound == false) //Error message urging user to ensure entered credentials are correct
                {
                    MessageBox.Show("Error: Check Your Credentials and Try Again");
                }
            }
            else //Error message urging user to fill all fields
            {
                MessageBox.Show("Please fill in all fields", "Error");
            }

            
        }

        private void tspMainMenu_Click(object sender, EventArgs e)
        {
            Player.Score = 0;
            Hide();
            new frmSplashScreen().Show();
        }

        private void tspHelp_Click(object sender, EventArgs e) //Displays a Messagebox with help
        {
            MessageBox.Show("Enter the same account credentials that you signed up with to Log In and play the quiz! Click the 'Sign Up' button if you haven't made an account yet, or wish to make another!");
        }

        private void tspExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
