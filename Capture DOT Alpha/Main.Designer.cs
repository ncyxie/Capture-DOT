namespace Capture_DOT_Alpha
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.captureScreenshot = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.hideWindow = new System.Windows.Forms.CheckBox();
            this.about = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captureScreenshot
            // 
            this.captureScreenshot.Location = new System.Drawing.Point(237, 390);
            this.captureScreenshot.Name = "captureScreenshot";
            this.captureScreenshot.Size = new System.Drawing.Size(144, 35);
            this.captureScreenshot.TabIndex = 0;
            this.captureScreenshot.Text = "Capture Screenshot";
            this.captureScreenshot.UseVisualStyleBackColor = true;
            this.captureScreenshot.Click += new System.EventHandler(this.captureScreenshot_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(559, 359);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(387, 390);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(89, 35);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // hideWindow
            // 
            this.hideWindow.AutoSize = true;
            this.hideWindow.Location = new System.Drawing.Point(13, 390);
            this.hideWindow.Name = "hideWindow";
            this.hideWindow.Size = new System.Drawing.Size(166, 19);
            this.hideWindow.TabIndex = 3;
            this.hideWindow.Text = "Hide Capture DOT window";
            this.hideWindow.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(482, 390);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(89, 35);
            this.about.TabIndex = 0;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.about);
            this.Controls.Add(this.hideWindow);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.captureScreenshot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture DOT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button captureScreenshot;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox hideWindow;
        private System.Windows.Forms.Button about;
    }
}

