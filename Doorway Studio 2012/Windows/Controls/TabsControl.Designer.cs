namespace Umax.Windows.Controls
{
    partial class TabsControl
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
            this.components = new System.ComponentModel.Container();
            this.mainTabControl = new Umax.UI.XPTab.XPTabControl();
            this.welcomeTabPage = new System.Windows.Forms.TabPage();
            this.welcomeWebBrowser = new System.Windows.Forms.WebBrowser();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.generalWebBrowser = new System.Windows.Forms.WebBrowser();
            this.historyTabPage = new System.Windows.Forms.TabPage();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainTabControl.SuspendLayout();
            this.welcomeTabPage.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Top;
            this.mainTabControl.Controls.Add(this.welcomeTabPage);
            this.mainTabControl.Controls.Add(this.generalTabPage);
            this.mainTabControl.Controls.Add(this.historyTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(473, 295);
            this.mainTabControl.TabIndex = 3;
            // 
            // welcomeTabPage
            // 
            this.welcomeTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.welcomeTabPage.Controls.Add(this.welcomeWebBrowser);
            this.welcomeTabPage.ImageIndex = 4;
            this.welcomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.welcomeTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeTabPage.Name = "welcomeTabPage";
            this.welcomeTabPage.Size = new System.Drawing.Size(465, 269);
            this.welcomeTabPage.TabIndex = 0;
            this.welcomeTabPage.Text = "Welcome";
            // 
            // welcomeWebBrowser
            // 
            this.welcomeWebBrowser.AllowNavigation = false;
            this.welcomeWebBrowser.AllowWebBrowserDrop = false;
            this.welcomeWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.welcomeWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.welcomeWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.welcomeWebBrowser.Name = "welcomeWebBrowser";
            this.welcomeWebBrowser.ScrollBarsEnabled = false;
            this.welcomeWebBrowser.Size = new System.Drawing.Size(465, 269);
            this.welcomeWebBrowser.TabIndex = 0;
            this.welcomeWebBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // generalTabPage
            // 
            this.generalTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.generalTabPage.Controls.Add(this.generalWebBrowser);
            this.generalTabPage.ImageIndex = 5;
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(465, 269);
            this.generalTabPage.TabIndex = 1;
            this.generalTabPage.Text = "General";
            // 
            // generalWebBrowser
            // 
            this.generalWebBrowser.AllowNavigation = false;
            this.generalWebBrowser.AllowWebBrowserDrop = false;
            this.generalWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.generalWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.generalWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.generalWebBrowser.Name = "generalWebBrowser";
            this.generalWebBrowser.ScrollBarsEnabled = false;
            this.generalWebBrowser.Size = new System.Drawing.Size(465, 269);
            this.generalWebBrowser.TabIndex = 0;
            this.generalWebBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // historyTabPage
            // 
            this.historyTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.historyTabPage.ImageIndex = 2;
            this.historyTabPage.Location = new System.Drawing.Point(4, 22);
            this.historyTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(465, 269);
            this.historyTabPage.TabIndex = 2;
            this.historyTabPage.Text = "Statistics";
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TabsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TabsControl";
            this.Size = new System.Drawing.Size(473, 295);
            this.Load += new System.EventHandler(this.TabsControlLoad);
            this.mainTabControl.ResumeLayout(false);
            this.welcomeTabPage.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Umax.UI.XPTab.XPTabControl mainTabControl;
        protected System.Windows.Forms.TabPage welcomeTabPage;
        protected System.Windows.Forms.WebBrowser welcomeWebBrowser;
        protected System.Windows.Forms.TabPage generalTabPage;
        protected System.Windows.Forms.WebBrowser generalWebBrowser;
        protected System.Windows.Forms.TabPage historyTabPage;
        protected System.Windows.Forms.ImageList mainImageList;
    }
}
