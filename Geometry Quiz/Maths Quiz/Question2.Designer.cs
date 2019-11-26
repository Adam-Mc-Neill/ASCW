namespace Maths_Quiz
{
    partial class frmQuestion2
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.picOctagon = new System.Windows.Forms.PictureBox();
            this.picHexagon = new System.Windows.Forms.PictureBox();
            this.txtOctagon = new System.Windows.Forms.TextBox();
            this.txtHexagon = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.picOctagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHexagon)).BeginInit();
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
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestion.Location = new System.Drawing.Point(105, 106);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(454, 34);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Enter the names of the shapes below.";
            // 
            // picOctagon
            // 
            this.picOctagon.BackColor = System.Drawing.Color.Transparent;
            this.picOctagon.BackgroundImage = global::Maths_Quiz.Properties.Resources.OctagonPng;
            this.picOctagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOctagon.Location = new System.Drawing.Point(57, 146);
            this.picOctagon.Name = "picOctagon";
            this.picOctagon.Size = new System.Drawing.Size(210, 153);
            this.picOctagon.TabIndex = 3;
            this.picOctagon.TabStop = false;
            // 
            // picHexagon
            // 
            this.picHexagon.BackColor = System.Drawing.Color.Transparent;
            this.picHexagon.BackgroundImage = global::Maths_Quiz.Properties.Resources.HexagonPng;
            this.picHexagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHexagon.Location = new System.Drawing.Point(360, 146);
            this.picHexagon.Name = "picHexagon";
            this.picHexagon.Size = new System.Drawing.Size(210, 153);
            this.picHexagon.TabIndex = 5;
            this.picHexagon.TabStop = false;
            // 
            // txtOctagon
            // 
            this.txtOctagon.Location = new System.Drawing.Point(57, 332);
            this.txtOctagon.Name = "txtOctagon";
            this.txtOctagon.Size = new System.Drawing.Size(210, 20);
            this.txtOctagon.TabIndex = 6;
            // 
            // txtHexagon
            // 
            this.txtHexagon.Location = new System.Drawing.Point(360, 332);
            this.txtHexagon.Name = "txtHexagon";
            this.txtHexagon.Size = new System.Drawing.Size(210, 20);
            this.txtHexagon.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(231, 371);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(173, 58);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(18, 412);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 16);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "User: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScore.Location = new System.Drawing.Point(12, 428);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(50, 16);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Score: ";
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
            this.mnuMenuStrip.TabIndex = 21;
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
            this.mnuGame.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // tspRestart
            // 
            this.tspRestart.Name = "tspRestart";
            this.tspRestart.Size = new System.Drawing.Size(137, 22);
            this.tspRestart.Text = "Restart Quiz";
            // 
            // tspLogOut
            // 
            this.tspLogOut.Name = "tspLogOut";
            this.tspLogOut.Size = new System.Drawing.Size(137, 22);
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
            this.tspHighScores.Name = "tspHighScores";
            this.tspHighScores.Size = new System.Drawing.Size(152, 22);
            this.tspHighScores.Text = "HighScores";
            this.tspHighScores.Click += new System.EventHandler(this.tspHighScores_Click);
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
            // frmQuestion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maths_Quiz.Properties.Resources.Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.mnuMenuStrip);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtHexagon);
            this.Controls.Add(this.txtOctagon);
            this.Controls.Add(this.picHexagon);
            this.Controls.Add(this.picOctagon);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.picTitle);
            this.Name = "frmQuestion2";
            this.Text = "Question2";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOctagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHexagon)).EndInit();
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox picOctagon;
        private System.Windows.Forms.PictureBox picHexagon;
        private System.Windows.Forms.TextBox txtOctagon;
        private System.Windows.Forms.TextBox txtHexagon;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblScore;
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