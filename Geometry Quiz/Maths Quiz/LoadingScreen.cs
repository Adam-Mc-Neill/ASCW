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
    public partial class frmLoadingScreen : Form
    {
        public frmLoadingScreen() //This first screen is the loading screen, the timer object is used to steadily increase
                                 //the percentage of the progress bar (pgrLoadingBar) the label lblLoading is also used
                                //to show the percentage of the bar that has been filled
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgrLoadingBar.Increment(5);
            lblLoading.Text = "loading  " + pgrLoadingBar.Value + "%"; //Changes the text on lblLoading to include the value of pgrLoadingBar
            if (pgrLoadingBar.Value>= pgrLoadingBar.Maximum) //an if statement that checks if pgrLoadingBar's value exceeds its maximum, which causes
                                                            // The timer to stop and frmSplashScreen to open.
            {
                LoadTimer.Stop();
                Hide();
                new frmSplashScreen().Show();
            }

        }

        private void pgrLoadingBar_Click(object sender, EventArgs e)
        {

        }
    }
}
