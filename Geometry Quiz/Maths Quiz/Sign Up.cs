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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void BtnLogIn_Click(object sender, EventArgs e) //Allows users to toggle between the 'Log In' and 'Sign Up' forms incase they selected the wrong one
        {            
            Hide();
            new frmLogIn().Show();
        }
        
        private void BtnSignUp_Click(object sender, EventArgs e) 
        {
            FileStream aFile;
            StreamWriter sw;
            
            string filepath = @"users.txt";
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            try
            {
                if (!File.Exists(filepath))
                {
                    aFile = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                }
                else
                {
                    if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
                    {
                        if (password == confirm) //Checks that the the two password fields are equal and writes them to the file
                        {
                            MessageBox.Show("New user has been registered", "Successful");
                            string[] userFile = File.ReadLines(filepath).ToArray();
                            

                            for (int i = 0; i < userFile.Length; i++)


                            {
                                string[] users = userFile[i].Split('~');

                                if (userName == users[0] && password == users[1])
                                {
                                    MessageBox.Show("User already exists", "Error"); //Displays errror message if the user already exists.
                                    break;
                                }
                            }
                        }
                        else if (password != confirm) //If the password entered do not match the user is prompted with a messagebox asking them to check their passwords
                        {
                            MessageBox.Show("Check that passwords match", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all fields", "Error"); //If the user has left a field blank they are prompted with a messagebox asking them to fill them in.
                    }
                }
                aFile = new FileStream(filepath, FileMode.Append, FileAccess.Write); //Writes a tilda followed by a space and a password to the record in the file.
                sw = new StreamWriter(aFile);

                sw.WriteLine(userName + "~" + password);

                sw.Close();
                aFile.Close();

                
            }
                
            catch (Exception) //If an exception occurs the outlined error messages appear.
            {
                MessageBox.Show("User failed to add", "Error Occured");
            }
        }

        private void tspMainMenu_Click(object sender, EventArgs e) //On click, frmSplashScreen is shown
        {
            Player.Score = 0;
            Hide();
            new frmSplashScreen().Show();
        }

        private void tspHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the name you would like to use as your username, as well as your desired password (this cannot be changed later)");
        }

        private void tspExitSystem_Click(object sender, EventArgs e) //On click the system is closed.
        {
            Application.Exit();
        }

    }
}
