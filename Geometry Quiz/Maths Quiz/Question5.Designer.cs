namespace Maths_Quiz
{
    partial class frmQuestion5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestion5));
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblOval = new System.Windows.Forms.Label();
            this.lblPentagon = new System.Windows.Forms.Label();
            this.lblParallelogram = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picParallelogram = new System.Windows.Forms.PictureBox();
            this.picOval = new System.Windows.Forms.PictureBox();
            this.picPentagon = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.picParallelogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPentagon)).BeginInit();
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
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestion.Location = new System.Drawing.Point(49, 103);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(537, 34);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Drag the Names to Their Respective Shapes";
            // 
            // lblOval
            // 
            this.lblOval.AutoSize = true;
            this.lblOval.BackColor = System.Drawing.Color.Orange;
            this.lblOval.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOval.Location = new System.Drawing.Point(52, 171);
            this.lblOval.Name = "lblOval";
            this.lblOval.Size = new System.Drawing.Size(78, 40);
            this.lblOval.TabIndex = 6;
            this.lblOval.Text = "Oval";
            this.lblOval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lblPentagon
            // 
            this.lblPentagon.AutoSize = true;
            this.lblPentagon.BackColor = System.Drawing.Color.Orange;
            this.lblPentagon.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblPentagon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPentagon.Location = new System.Drawing.Point(48, 265);
            this.lblPentagon.Name = "lblPentagon";
            this.lblPentagon.Size = new System.Drawing.Size(138, 40);
            this.lblPentagon.TabIndex = 7;
            this.lblPentagon.Text = "Pentagon";
            this.lblPentagon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lblParallelogram
            // 
            this.lblParallelogram.AutoSize = true;
            this.lblParallelogram.BackColor = System.Drawing.Color.Orange;
            this.lblParallelogram.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblParallelogram.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblParallelogram.Location = new System.Drawing.Point(52, 360);
            this.lblParallelogram.Name = "lblParallelogram";
            this.lblParallelogram.Size = new System.Drawing.Size(201, 40);
            this.lblParallelogram.TabIndex = 8;
            this.lblParallelogram.Text = "Parallelogram";
            this.lblParallelogram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // picParallelogram
            // 
            this.picParallelogram.BackColor = System.Drawing.Color.Transparent;
            this.picParallelogram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picParallelogram.BackgroundImage")));
            this.picParallelogram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picParallelogram.Location = new System.Drawing.Point(467, 265);
            this.picParallelogram.Name = "picParallelogram";
            this.picParallelogram.Size = new System.Drawing.Size(134, 63);
            this.picParallelogram.TabIndex = 9;
            this.picParallelogram.TabStop = false;
            this.picParallelogram.Tag = "Parallelogram";
            this.picParallelogram.DragDrop += new System.Windows.Forms.DragEventHandler(this.ParallelogramDragDrop);
            this.picParallelogram.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // picOval
            // 
            this.picOval.BackColor = System.Drawing.Color.Transparent;
            this.picOval.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picOval.BackgroundImage")));
            this.picOval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOval.Location = new System.Drawing.Point(467, 348);
            this.picOval.Name = "picOval";
            this.picOval.Size = new System.Drawing.Size(134, 79);
            this.picOval.TabIndex = 10;
            this.picOval.TabStop = false;
            this.picOval.Tag = "Oval";
            this.picOval.DragDrop += new System.Windows.Forms.DragEventHandler(this.OvalDragDrop);
            this.picOval.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // picPentagon
            // 
            this.picPentagon.BackColor = System.Drawing.Color.Transparent;
            this.picPentagon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPentagon.BackgroundImage")));
            this.picPentagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPentagon.Image = ((System.Drawing.Image)(resources.GetObject("picPentagon.Image")));
            this.picPentagon.Location = new System.Drawing.Point(467, 152);
            this.picPentagon.Name = "picPentagon";
            this.picPentagon.Size = new System.Drawing.Size(134, 83);
            this.picPentagon.TabIndex = 11;
            this.picPentagon.TabStop = false;
            this.picPentagon.Tag = "Pentagon";
            this.picPentagon.DragDrop += new System.Windows.Forms.DragEventHandler(this.PentagonDragDrop);
            this.picPentagon.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
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
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score: ";
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
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "User: ";
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
            this.tspRestart.Name = "tspRestart";
            this.tspRestart.Size = new System.Drawing.Size(152, 22);
            this.tspRestart.Text = "Restart Quiz";
            this.tspRestart.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
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
            // frmQuestion5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maths_Quiz.Properties.Resources.Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.mnuMenuStrip);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picPentagon);
            this.Controls.Add(this.picOval);
            this.Controls.Add(this.picParallelogram);
            this.Controls.Add(this.lblParallelogram);
            this.Controls.Add(this.lblPentagon);
            this.Controls.Add(this.lblOval);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.picTitle);
            this.Name = "frmQuestion5";
            this.Text = "Question5";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParallelogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPentagon)).EndInit();
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblOval;
        private System.Windows.Forms.Label lblPentagon;
        private System.Windows.Forms.Label lblParallelogram;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picParallelogram;
        private System.Windows.Forms.PictureBox picOval;
        private System.Windows.Forms.PictureBox picPentagon;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblUser;
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