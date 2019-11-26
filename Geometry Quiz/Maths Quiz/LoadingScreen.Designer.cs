namespace Maths_Quiz
{
    partial class frmLoadingScreen
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
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.pgrLoadingBar = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.BackgroundImage = global::Maths_Quiz.Properties.Resources.Title;
            this.picTitle.Location = new System.Drawing.Point(21, 24);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(580, 89);
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // pgrLoadingBar
            // 
            this.pgrLoadingBar.Location = new System.Drawing.Point(146, 282);
            this.pgrLoadingBar.Name = "pgrLoadingBar";
            this.pgrLoadingBar.Size = new System.Drawing.Size(339, 44);
            this.pgrLoadingBar.TabIndex = 1;
            this.pgrLoadingBar.Click += new System.EventHandler(this.pgrLoadingBar_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblLoading.Location = new System.Drawing.Point(241, 243);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(147, 36);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Loading...";
            // 
            // LoadTimer
            // 
            this.LoadTimer.Enabled = true;
            this.LoadTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maths_Quiz.Properties.Resources.Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pgrLoadingBar);
            this.Controls.Add(this.picTitle);
            this.Name = "frmLoadingScreen";
            this.Text = "LoadingScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.ProgressBar pgrLoadingBar;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer LoadTimer;
    }
}