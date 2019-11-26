namespace Maths_Quiz
{
    partial class frmQuestion1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestion1));
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            this.mnuMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.BackgroundImage = global::Maths_Quiz.Properties.Resources.Title;
            this.picTitle.Location = new System.Drawing.Point(21, 24);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(580, 89);
            this.picTitle.TabIndex = 1;
            this.picTitle.TabStop = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(299, 124);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 13);
            this.lblQuestion.TabIndex = 2;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.BackColor = System.Drawing.Color.Transparent;
            this.lblQ.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.lblQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQ.Location = new System.Drawing.Point(82, 103);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(465, 34);
            this.lblQ.TabIndex = 3;
            this.lblQ.Text = "What is the name of the shape below?";
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnAnswerB.Location = new System.Drawing.Point(249, 326);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(134, 79);
            this.btnAnswerB.TabIndex = 4;
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswerB_Click);
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnAnswerA.Location = new System.Drawing.Point(62, 326);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(134, 79);
            this.btnAnswerA.TabIndex = 5;
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.btnIncorrect_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnAnswerC.Location = new System.Drawing.Point(437, 326);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(134, 79);
            this.btnAnswerC.TabIndex = 6;
            this.btnAnswerC.Tag = "Circle";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.btnCorrectAnswer_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(151, 145);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(337, 166);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 7;
            this.pic1.TabStop = false;
            this.pic1.Tag = "RHOMBUS";
            this.pic1.Visible = false;
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
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2.Image = global::Maths_Quiz.Properties.Resources.OctagonPng;
            this.pic2.Location = new System.Drawing.Point(206, 145);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(235, 166);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 16;
            this.pic2.TabStop = false;
            this.pic2.Tag = "OCTAGON";
            this.pic2.Visible = false;
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.Transparent;
            this.pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic3.Image = global::Maths_Quiz.Properties.Resources.HexagonPng;
            this.pic3.Location = new System.Drawing.Point(206, 145);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(207, 177);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 17;
            this.pic3.TabStop = false;
            this.pic3.Tag = "HEXAGON";
            this.pic3.Visible = false;
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.Color.Transparent;
            this.pic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.Location = new System.Drawing.Point(216, 154);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(207, 166);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 18;
            this.pic4.TabStop = false;
            this.pic4.Tag = "CIRCLE";
            this.pic4.Visible = false;
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.Color.Transparent;
            this.pic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
            this.pic5.Location = new System.Drawing.Point(168, 142);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(295, 178);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5.TabIndex = 19;
            this.pic5.TabStop = false;
            this.pic5.Tag = "PENTAGON";
            this.pic5.Visible = false;
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
            this.mnuMenuStrip.TabIndex = 20;
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
            this.tspRestart.Name = "tspRestart";
            this.tspRestart.Size = new System.Drawing.Size(137, 22);
            this.tspRestart.Text = "Restart Quiz";
            this.tspRestart.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
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
            this.tspHighScores.Size = new System.Drawing.Size(135, 22);
            this.tspHighScores.Text = "HighScores";
            this.tspHighScores.Click += new System.EventHandler(this.tspHighScores_Click);
            // 
            // tspMainMenu
            // 
            this.tspMainMenu.Name = "tspMainMenu";
            this.tspMainMenu.Size = new System.Drawing.Size(135, 22);
            this.tspMainMenu.Text = "Main Menu";
            this.tspMainMenu.Click += new System.EventHandler(this.tspMainMenu_Click);
            // 
            // tspHelp
            // 
            this.tspHelp.Name = "tspHelp";
            this.tspHelp.Size = new System.Drawing.Size(135, 22);
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
            // frmQuestion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maths_Quiz.Properties.Resources.Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.mnuMenuStrip);
            this.MainMenuStrip = this.mnuMenuStrip;
            this.Name = "frmQuestion1";
            this.Text = "Question1";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
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