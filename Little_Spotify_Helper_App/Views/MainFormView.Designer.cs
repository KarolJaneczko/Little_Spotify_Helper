namespace Little_Spotify_Helper_App {
    partial class MainFormView {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Logo_PictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo_PictureBox).BeginInit();
            SuspendLayout();
            // 
            // Logo_PictureBox
            // 
            Logo_PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Logo_PictureBox.BackgroundImage = Properties.Resources.Little_Spotify_Helper;
            Logo_PictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            Logo_PictureBox.BorderStyle = BorderStyle.FixedSingle;
            Logo_PictureBox.Location = new Point(12, 50);
            Logo_PictureBox.Name = "Logo_PictureBox";
            Logo_PictureBox.Size = new Size(539, 116);
            Logo_PictureBox.TabIndex = 0;
            Logo_PictureBox.TabStop = false;
            // 
            // MainFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 702);
            Controls.Add(Logo_PictureBox);
            Name = "MainFormView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Logo_PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Logo_PictureBox;
    }
}
