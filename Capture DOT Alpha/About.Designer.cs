namespace Capture_DOT_Alpha
{
    partial class About
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
            this.head = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.develop = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.head.Location = new System.Drawing.Point(13, 13);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(142, 24);
            this.head.TabIndex = 0;
            this.head.Text = "Capture DOT";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(13, 51);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(252, 60);
            this.description.TabIndex = 1;
            this.description.Text = "Screenshot capturing \r\nsoftware. One, two, three \r\nand your screenshot is ready.";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(13, 120);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(159, 80);
            this.info.TabIndex = 2;
            this.info.Text = "Version: v1.0.0-Alpha\r\nBuild date: 06/09/2020\r\nMade by ncyxie.\r\nThanks to XeZrunn" +
    "er.\r\nThanks to zero9178.\r\n";
            // 
            // develop
            // 
            this.develop.AutoSize = true;
            this.develop.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.develop.Location = new System.Drawing.Point(13, 208);
            this.develop.Name = "develop";
            this.develop.Size = new System.Drawing.Size(252, 32);
            this.develop.TabIndex = 3;
            this.develop.Text = "Application developed by using .NET \r\nCore WinForms.";
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ok_button.Location = new System.Drawing.Point(91, 254);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(103, 33);
            this.ok_button.TabIndex = 4;
            this.ok_button.Text = "&OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.develop);
            this.Controls.Add(this.info);
            this.Controls.Add(this.description);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label develop;
        private System.Windows.Forms.Button ok_button;
    }
}