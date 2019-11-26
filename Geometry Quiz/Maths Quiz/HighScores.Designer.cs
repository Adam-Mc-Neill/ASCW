namespace Maths_Quiz
{
    partial class frmHighScores
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
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore5 = new System.Windows.Forms.Label();
            this.lblScore4 = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
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
            this.picTitle.TabIndex = 3;
            this.picTitle.TabStop = false;
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
            this.tspLogOut.Click += new System.EventHandler(this.tspLogOut_Click);
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
            this.tspHighScores.Enabled = false;
            this.tspHighScores.Name = "tspHighScores";
            this.tspHighScores.Size = new System.Drawing.Size(152, 22);
            this.tspHighScores.Text = "HighScores";
            // 
            // tspMainMenu
            // 
            this.tspMainMenu.Name = "tspMainMenu";
            this.tspMainMenu.Size = new System.Drawing.Size(152, 22);
            this.tspMainMenu.Text = "Main Menu";
            this.tspMainMenu.Click += new System.EventHandler(this.tspMainMenu_Click);
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
            this.tspExitSystem.Click += new System.EventHandler(this.tspExitSystem_Click);
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScores.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.lblHighScores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHighScores.Location = new System.Drawing.Point(212, 116);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(214, 34);
            this.lblHighScores.TabIndex = 23;
            this.lblHighScores.Text = "HIGH-SCORES";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.Transparent;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScore1.Location = new System.Drawing.Point(212, 160);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(139, 31);
            this.lblScore1.TabIndex = 24;
            this.lblScore1.Text = "Top Score";
            // 
            // lblScore3
            // 
            this.lblScore3.AutoSize = true;
            this.lblScore3.BackColor = System.Drawing.Color.Transparent;
            this.lblScore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScore3.Location = new System.Drawing.Point(212, 260);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(85, 31);
            this.lblScore3.TabIndex = 25;
            this.lblScore3.Text = "Score";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScore2.Location = new System.Drawing.Point(212, 210);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(85, 31);
            this.lblScore2.TabIndex = 26;
            this.lblScore2.Text = "Score";
            // 
            // lblScore5
            // 
            this.lblScore5.AutoSize = true;
            this.lblScore5.BackColor = System.Drawing.Color.Transparent;
            this.lblScore5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScore5.Location = new System.Drawing.Point(212, 360);
            this.lblScore5.Name = "lblScore5";
            this.lblScore5.Size = new System.Drawing.Size(85, 31);
            this.lblScore5.TabIndex = 27;
            this.lblScore5.Text = "Score";
            // 
            // lblScore4
            // 
            this.lblScore4.AutoSize = true;
            this.lblScore4.BackColor = System.Drawing.Color.Transparent;
            this.lblScore4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScore4.Location = new System.Drawing.Point(212, 310);
            this.lblScore4.Name = "lblScore4";
            this.lblScore4.Size = new System.Drawing.Size(85, 31);
            this.lblScore4.TabIndex = 28;
            this.lblScore4.Text = "Score";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(492, 380);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(128, 61);
            this.btnMainMenu.TabIndex = 29;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maths_Quiz.Properties.Resources.Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblScore4);
            this.Controls.Add(this.lblScore5);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore3);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblHighScores);
            this.Controls.Add(this.mnuMenuStrip);
            this.Controls.Add(this.picTitle);
            this.Name = "frmHighScores";
            this.Text = "High Scores";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
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
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore5;
        private System.Windows.Forms.Label lblScore4;
        private System.Windows.Forms.Button btnMainMenu;
    }
}