namespace Umax.Windows.Windows.Common
{
    partial class Options
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("PlugIns");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("WebUI");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Logging");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Maintenance");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Environment", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Start Up");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Notifications");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Updates");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Monitor");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Reporting");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("GUI", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.Location = new System.Drawing.Point(12, 12);
            this.mainTreeView.Name = "mainTreeView";
            treeNode1.Name = "EnvironmentGeneralNode";
            treeNode1.Text = "General";
            treeNode2.Name = "EnvironmentPlugInsNode";
            treeNode2.Text = "PlugIns";
            treeNode3.Name = "EnvironmentWebUINode";
            treeNode3.Text = "WebUI";
            treeNode4.Name = "EnvironmentLoggingNode";
            treeNode4.Text = "Logging";
            treeNode5.Name = "EnvironmentMaintenanceNode";
            treeNode5.Text = "Maintenance";
            treeNode6.Name = "EnvironmentNode";
            treeNode6.Text = "Environment";
            treeNode7.Name = "GUIGeneralNode";
            treeNode7.Text = "General";
            treeNode8.Name = "GUIStartUpNode";
            treeNode8.Text = "Start Up";
            treeNode9.Name = "GUINotificationsNode";
            treeNode9.Text = "Notifications";
            treeNode10.Name = "GUIUpdatesNode";
            treeNode10.Text = "Updates";
            treeNode11.Name = "GUIMonitorNode";
            treeNode11.Text = "Monitor";
            treeNode12.Name = "GUIReportingNode";
            treeNode12.Text = "Reporting";
            treeNode13.Name = "GUINode";
            treeNode13.Text = "GUI";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode13});
            this.mainTreeView.ShowLines = false;
            this.mainTreeView.Size = new System.Drawing.Size(174, 349);
            this.mainTreeView.TabIndex = 0;
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mainTreeView_AfterSelect);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(192, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(530, 349);
            this.mainPanel.TabIndex = 3;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 371);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012: Options";
            this.Load += new System.EventHandler(this.OptionsLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.Panel mainPanel;
    }
}