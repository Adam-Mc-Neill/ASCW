namespace Maths_Quiz
{
    partial class frmMainMenu
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
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
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.btnPlay.Location = new System.Drawing.Point(62, 178);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(191, 95);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.btnHighScores.Location = new System.Drawing.Point(380, 178);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(191, 95);
            this.btnHighScores.TabIndex = 3;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.btnExit.Location = new System.Drawing.Point(380, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 95);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.btnLogOut.Location = new System.Drawing.Point(62, 325);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(191, 95);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.mnuMenuStrip.Size = new System.Drawing.Size(632, 23);
            this.mnuMenuStrip.TabIndex = 22;
            this.mnuMenuStrip.Text = "Cool";
            // 
            // mnuGame
            // 
            this.mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspRestart,
            this.tspLogOut});
            this.mnuGame.Name = "mnuGame";
            this.mnuGame.Size = new System.Drawing.Size(50, 19);
            this.mnuGame.Text = "Game";
            // 
            // tspRestart
            // 
            this.tspRestart.Enabled = false;
            this.tspRestart.Name = "tspRestart";
            this.tspRestart.Size = new System.Drawing.Size(152, 22);
            this.tspRestart.Text = "Restart Quiz";
            // 
            // tspLogOut
            // 
            this.tspLogOut.Name = "tspLogOut";
            this.tspLogOut.Size = new System.Drawing.Size(152, 22);
            this.tspLogOut.Text = "Log Out";
            this.tspLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHighScores,
            this.tspMainMenu,
            this.tspHelp});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 19);
            this.mnuView.Text = "View";
            // 
            // tspHighScores
            // 
            this.tspHighScores.Name = "tspHighScores";
            this.tspHighScores.Size = new System.Drawing.Size(152, 22);
            this.tspHighScores.Text = "HighScores";
            this.tspHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // tspMainMenu
            // 
            this.tspMainMenu.Enabled = false;
            this.tspMainMenu.Name = "tspMainMenu";
            this.tspMainMenu.Size = new System.Drawing.Size(152, 22);
            this.tspMainMenu.Text = "Main Menu";
            // 
            // tspHelp
            // 
            this.tspHelp.Name = "tspHelp";
            this.tspHelp.Size = new System.Drawing.Size(152, 22);
            this.tspHelp.Text = "Help";
            this.tspHelp.Click += new System.EventHandler(this.tspHelp_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspExitSystem});
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 19);
            this.mnuExit.Text = "Exit";
            // 
            // tspExitSystem
            // 
            this.tspExitSystem.Name = "tspExitSystem";
            this.tspExitSystem.Size = new System.Drawing.Size(152, 22);
            this.tspExitSystem.Text = "Exit System";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maths_Quiz.Properties.Resources.Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.mnuMenuStrip);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picTitle);
            this.Name = "frmMainMenu";
            this.Text = "Main_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
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