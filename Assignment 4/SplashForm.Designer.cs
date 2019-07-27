namespace Assignment_4
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.SplashProgressBar = new System.Windows.Forms.ProgressBar();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashLabel = new System.Windows.Forms.Label();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashProgressBar
            // 
            this.SplashProgressBar.Location = new System.Drawing.Point(12, 396);
            this.SplashProgressBar.Name = "SplashProgressBar";
            this.SplashProgressBar.Size = new System.Drawing.Size(296, 72);
            this.SplashProgressBar.TabIndex = 0;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashLabel
            // 
            this.SplashLabel.BackColor = System.Drawing.Color.Transparent;
            this.SplashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.SplashLabel.Location = new System.Drawing.Point(0, 5);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(317, 307);
            this.SplashLabel.TabIndex = 1;
            this.SplashLabel.Text = "BMI Calculator";
            this.SplashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Interval = 300;
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.Controls.Add(this.SplashLabel);
            this.Controls.Add(this.SplashProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar SplashProgressBar;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label SplashLabel;
        private System.Windows.Forms.Timer ProgressTimer;
    }
}