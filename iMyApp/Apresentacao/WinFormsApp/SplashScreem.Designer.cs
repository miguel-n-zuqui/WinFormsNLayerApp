namespace WinFormsApp
{
    partial class SplashScreem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreem));
            prcCarregar = new ProgressBar();
            SuspendLayout();
            // 
            // prcCarregar
            // 
            prcCarregar.Anchor = AnchorStyles.Bottom;
            prcCarregar.Location = new Point(168, 326);
            prcCarregar.Name = "prcCarregar";
            prcCarregar.Size = new Size(428, 23);
            prcCarregar.TabIndex = 0;
            // 
            // SplashScreem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(795, 450);
            Controls.Add(prcCarregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreem";
            WindowState = FormWindowState.Maximized;
            Shown += SplashScreem_Shown;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar prcCarregar;
    }
}