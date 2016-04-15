namespace FinalProject
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.splashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.splashScreenContainer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenTimer
            // 
            this.splashScreenTimer.Enabled = true;
            this.splashScreenTimer.Interval = 5000;
            this.splashScreenTimer.Tick += new System.EventHandler(this.splashScreenTimer_tick);
            // 
            // splashScreenContainer
            // 
            this.splashScreenContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splashScreenContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splashScreenContainer.Image = ((System.Drawing.Image)(resources.GetObject("splashScreenContainer.Image")));
            this.splashScreenContainer.InitialImage = null;
            this.splashScreenContainer.Location = new System.Drawing.Point(0, 0);
            this.splashScreenContainer.Name = "splashScreenContainer";
            this.splashScreenContainer.Size = new System.Drawing.Size(800, 480);
            this.splashScreenContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashScreenContainer.TabIndex = 0;
            this.splashScreenContainer.TabStop = false;
            this.splashScreenContainer.WaitOnLoad = true;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.splashScreenContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer splashScreenTimer;
        private System.Windows.Forms.PictureBox splashScreenContainer;
    }
}

