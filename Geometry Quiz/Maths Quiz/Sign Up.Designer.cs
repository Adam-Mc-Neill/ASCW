namespace Maths_Quiz
{
    partial class frmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tspRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tspLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.tspHighScores = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tspHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tspExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.mnuMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = global::Maths_Quiz.Properties.Resources.Title;
            this.picTitle.Location = new System.Drawing.Point(21, 24);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(580, 89);
            this.picTitle.TabIndex = 1;
            this.picTitle.TabStop = false;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lblSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSignUp.Location = new System.Drawing.Point(229, 116);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(175, 51);
            this.lblSignUp.TabIndex = 3;
            this.lblSignUp.Text = "Sign Up";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(148, 181);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(72, 294);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(186, 25);
            this.lblConfirm.TabIndex = 8;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(298, 181);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(298, 299);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(219, 20);
            this.txtConfirm.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(298, 243);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(219, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(148, 238);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSignUp.Image = global::Maths_Quiz.Properties.Resources.Sign_Up_Button;
            this.BtnSignUp.Location = new System.Drawing.Point(360, 353);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(157, 54);
            this.BtnSignUp.TabIndex = 13;
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogIn.Image = global::Maths_Quiz.Properties.Resources.Log_In_Button;
            this.BtnLogIn.Location = new System.Drawing.Point(153, 353);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(131, 54);
            this.BtnLogIn.TabIndex = 14;
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // mnuMenuStrip
            // 
            this.mnuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGame,
            this.mnuView,
            this.mnuExit});
            this.mnuMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuStrip.Name = "mnuMenuStrip";
            this.mnuMenuStrip.Size = new System.Drawing.Size(632, 21);
            this.mnuMenuStrip.TabIndex = 23;
            this.mnuMenuStrip.Text = "Cool";
            // 
            // mnuGame
            // 
            this.mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspRestart,
            this.tspLogOut});
            this.mnuGame.Name = "mnuGame";
            this.mnuGame.Size = new System.Drawing.Size(46, 17);
            this.mnuGame.Text = "Game";
            // 
            // tspRestart
            // 
            this.tspRestart.Enabled = false;
            this.tspRestart.Name = "tspRestart";
            this.tspRestart.Size = new System.Drawing.Size(134, 22);
            this.tspRestart.Text = "Restart Quiz";
            // 
            // tspLogOut
            // 
            this.tspLogOut.Enabled = false;
            this.tspLogOut.Name = "tspLogOut";
            this.tspLogOut.Size = new System.Drawing.Size(134, 22);
            this.tspLogOut.Text = "Log Out";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHighScores,
            this.tspMainMenu,
            this.tspHelp});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(41, 17);
            this.mnuView.Text = "View";
            // 
            // tspHighScores
            // 
            this.tspHighScores.Enabled = false;
            this.tspHighScores.Name = "tspHighScores";
            this.tspHighScores.Size = new System.Drawing.Size(127, 22);
            this.tspHighScores.Text = "HighScores";
            // 
            // tspMainMenu
            // 
            this.tspMainMenu.Name = "tspMainMenu";
            this.tspMainMenu.Size = new System.Drawing.Size(127, 22);
            this.tspMainMenu.Text = "Main Menu";
            // 
            // tspHelp
            // 
            this.tspHelp.Name = "tspHelp";
            this.tspHelp.Size = new System.Drawing.Size(127, 22);
            this.tspHelp.Text = "Help";
            this.tspHelp.Click += new System.EventHandler(this.tspHelp_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspExitSystem});
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 17);
            this.mnuExit.Text = "Exit";
            // 
            // tspExitSystem
            // 
            this.tspExitSystem.Name = "tspExitSystem";
            this.tspExitSystem.Size = new System.Drawing.Size(130, 22);
            this.tspExitSystem.Text = "Exit System";
            this.tspExitSystem.Click += new System.EventHandler(this.tspExitSystem_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maths_Quiz.Properties.Resources.Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.mnuMenuStrip);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.picTitle);
            this.Name = "frmSignUp";
            this.Text = "Sign_Up";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.MenuStrip mnuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuGame;
        private System.Windows.Forms.ToolStripMenuItem tspRestart;
        private System.Windows.Forms.ToolStripMenuItem tspLogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem tspHighScores;
        private System.Windows.Forms.ToolStripMenuItem tspMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tspHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem tspExitSystem;
    }
}