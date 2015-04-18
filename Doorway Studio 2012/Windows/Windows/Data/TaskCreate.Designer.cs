namespace Umax.Windows.Windows.Data
{
    partial class TaskCreate
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
            this.tasksListView = new System.Windows.Forms.ListView();
            this.tasksColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemsImageList = new System.Windows.Forms.ImageList(this.components);
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.categoriesTreeView = new System.Windows.Forms.TreeView();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksListView
            // 
            this.tasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tasksColumnHeader});
            this.tasksListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksListView.LargeImageList = this.itemsImageList;
            this.tasksListView.Location = new System.Drawing.Point(0, 0);
            this.tasksListView.MultiSelect = false;
            this.tasksListView.Name = "tasksListView";
            this.tasksListView.Size = new System.Drawing.Size(532, 268);
            this.tasksListView.TabIndex = 1;
            this.tasksListView.UseCompatibleStateImageBehavior = false;
            this.tasksListView.DoubleClick += new System.EventHandler(this.tasksListViewDoubleClick);
            // 
            // tasksColumnHeader
            // 
            this.tasksColumnHeader.Text = "Task Type";
            // 
            // itemsImageList
            // 
            this.itemsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.itemsImageList.ImageSize = new System.Drawing.Size(64, 64);
            this.itemsImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.okButton.Location = new System.Drawing.Point(382, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(457, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // categoriesTreeView
            // 
            this.categoriesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesTreeView.ImageIndex = 0;
            this.categoriesTreeView.ImageList = this.mainImageList;
            this.categoriesTreeView.Location = new System.Drawing.Point(0, 0);
            this.categoriesTreeView.Name = "categoriesTreeView";
            this.categoriesTreeView.SelectedImageIndex = 0;
            this.categoriesTreeView.Size = new System.Drawing.Size(150, 291);
            this.categoriesTreeView.TabIndex = 5;
            this.categoriesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.categoriesTreeViewAfterSelect);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.categoriesTreeView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.tasksListView);
            this.mainSplitContainer.Panel2.Controls.Add(this.actionPanel);
            this.mainSplitContainer.Size = new System.Drawing.Size(686, 291);
            this.mainSplitContainer.SplitterDistance = 150;
            this.mainSplitContainer.TabIndex = 9;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.okButton);
            this.actionPanel.Controls.Add(this.cancelButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 268);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(532, 23);
            this.actionPanel.TabIndex = 6;
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 291);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "CreateTask";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012: Create Task";
            this.Load += new System.EventHandler(this.CreateTaskLoad);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView tasksListView;
        private System.Windows.Forms.ColumnHeader tasksColumnHeader;
        private System.Windows.Forms.ImageList itemsImageList;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TreeView categoriesTreeView;
        private System.Windows.Forms.ImageList mainImageList;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Panel actionPanel;



    }
}