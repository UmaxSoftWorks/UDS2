namespace WebParser.Parser.Parsing.Common
{
    partial class WebParserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.uaTabPage = new System.Windows.Forms.TabPage();
            this.proxyTabPage = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainTabPage);
            this.mainTabControl.Controls.Add(this.uaTabPage);
            this.mainTabControl.Controls.Add(this.proxyTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(600, 500);
            this.mainTabControl.TabIndex = 0;
            // 
            // mainTabPage
            // 
            this.mainTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Size = new System.Drawing.Size(592, 474);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Main";
            // 
            // uaTabPage
            // 
            this.uaTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.uaTabPage.Location = new System.Drawing.Point(4, 22);
            this.uaTabPage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.uaTabPage.Name = "uaTabPage";
            this.uaTabPage.Size = new System.Drawing.Size(592, 474);
            this.uaTabPage.TabIndex = 1;
            this.uaTabPage.Text = "User Agent";
            // 
            // proxyTabPage
            // 
            this.proxyTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.proxyTabPage.Location = new System.Drawing.Point(4, 22);
            this.proxyTabPage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.proxyTabPage.Name = "proxyTabPage";
            this.proxyTabPage.Size = new System.Drawing.Size(592, 474);
            this.proxyTabPage.TabIndex = 2;
            this.proxyTabPage.Text = "Proxy";
            // 
            // WebParserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Name = "WebParserControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.TabPage uaTabPage;
        private System.Windows.Forms.TabPage proxyTabPage;
    }
}
