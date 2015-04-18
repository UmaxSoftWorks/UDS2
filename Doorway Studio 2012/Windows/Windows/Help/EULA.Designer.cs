namespace Umax.Windows.Windows.Help
{
    partial class EULA
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
            this.licenseLabel = new System.Windows.Forms.Label();
            this.licenseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.agreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(14, 22);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(201, 13);
            this.licenseLabel.TabIndex = 0;
            this.licenseLabel.Text = "Doorway Studio 2010 license agreement:";
            // 
            // licenseLinkLabel
            // 
            this.licenseLinkLabel.AutoSize = true;
            this.licenseLinkLabel.Location = new System.Drawing.Point(283, 22);
            this.licenseLinkLabel.Name = "licenseLinkLabel";
            this.licenseLinkLabel.Size = new System.Drawing.Size(64, 13);
            this.licenseLinkLabel.TabIndex = 1;
            this.licenseLinkLabel.TabStop = true;
            this.licenseLinkLabel.Text = "Read online";
            // 
            // agreeButton
            // 
            this.agreeButton.Location = new System.Drawing.Point(272, 49);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(75, 23);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "Agree";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // EULA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 84);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.licenseLinkLabel);
            this.Controls.Add(this.licenseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EULA";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012: EULA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EULA_FormClosing);
            this.Load += new System.EventHandler(this.EULA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.LinkLabel licenseLinkLabel;
        private System.Windows.Forms.Button agreeButton;

    }
}