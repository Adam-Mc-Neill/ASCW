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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen() //This screen allows the user to log in, sign up, seek help and terminate the programs execution
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e) //This event opens frmLogIn when the button is clicked
        {
            Hide();
            new frmLogIn().Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e) //This event opens frmSignUp when the button is clicked
        {
            Hide();
            new frmSignUp().Show();
        }

        private void btnExitQuiz_Click(object sender, EventArgs e) //When clicked the program is closed
        {
            Application.Exit();
        }
       
        private void tspHelp_Click(object sender, EventArgs e) //Displays a help message for the user when clicked in a Messagebox
        {
            MessageBox.Show("If this is your first time playing, click 'Sign Up' to create an account and start the quiz. If you have already joined, select 'Log In'.");
        }

        private void tspExitSystem_Click(object sender, EventArgs e) //When clicked the program is closed
        {
            Application.Exit();
        }
    }
}
