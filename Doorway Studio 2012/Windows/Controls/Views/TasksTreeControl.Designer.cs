namespace Umax.Windows.Controls.Views
{
    partial class TasksTreeControl
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
            this.mainTasksTreeView = new System.Windows.Forms.TreeView();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainTasksToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.filterToolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.filterAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.filterDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTasksToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTasksTreeView
            // 
            this.mainTasksTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTasksTreeView.ImageIndex = 0;
            this.mainTasksTreeView.ImageList = this.mainImageList;
            this.mainTasksTreeView.Location = new System.Drawing.Point(0, 23);
            this.mainTasksTreeView.Name = "mainTasksTreeView";
            this.mainTasksTreeView.SelectedImageIndex = 0;
            this.mainTasksTreeView.Size = new System.Drawing.Size(162, 314);
            this.mainTasksTreeView.TabIndex = 24;
            this.mainTasksTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainTreeViewNodeMouseDoubleClick);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainTasksToolStrip
            // 
            this.mainTasksToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripSeparator1,
            this.copyToolStripButton,
            this.editToolStripButton,
            this.toolStripSeparator2,
            this.deleteToolStripButton,
            this.toolStripSeparator3,
            this.filterToolStripButton});
            this.mainTasksToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainTasksToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainTasksToolStrip.Name = "mainTasksToolStrip";
            this.mainTasksToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainTasksToolStrip.Size = new System.Drawing.Size(162, 23);
            this.mainTasksToolStrip.TabIndex = 25;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.newToolStripButton.Text = "Create";
            this.newToolStripButton.Click += new System.EventHandler(this.CreateTask);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.copyToolStripButton.Text = "Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.CopyTask);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.EditTask);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.DeleteTask);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // filterToolStripButton
            // 
            this.filterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filterToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAllToolStripMenuItem,
            this.toolStripSeparator4,
            this.filterDayToolStripMenuItem,
            this.filterMonthToolStripMenuItem,
            this.filterYearToolStripMenuItem});
            this.filterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterToolStripButton.Name = "filterToolStripButton";
            this.filterToolStripButton.Size = new System.Drawing.Size(16, 4);
            this.filterToolStripButton.Text = "Filter";
            // 
            // filterAllToolStripMenuItem
            // 
            this.filterAllToolStripMenuItem.Checked = true;
            this.filterAllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filterAllToolStripMenuItem.Name = "filterAllToolStripMenuItem";
            this.filterAllToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filterAllToolStripMenuItem.Text = "All";
            this.filterAllToolStripMenuItem.Click += new System.EventHandler(this.FilterAll);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(107, 6);
            // 
            // filterDayToolStripMenuItem
            // 
            this.filterDayToolStripMenuItem.Name = "filterDayToolStripMenuItem";
            this.filterDayToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filterDayToolStripMenuItem.Text = "Day";
            this.filterDayToolStripMenuItem.Click += new System.EventHandler(this.FilterDay);
            // 
            // filterMonthToolStripMenuItem
            // 
            this.filterMonthToolStripMenuItem.Name = "filterMonthToolStripMenuItem";
            this.filterMonthToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filterMonthToolStripMenuItem.Text = "Month";
            this.filterMonthToolStripMenuItem.Click += new System.EventHandler(this.FilterMonth);
            // 
            // filterYearToolStripMenuItem
            // 
            this.filterYearToolStripMenuItem.Name = "filterYearToolStripMenuItem";
            this.filterYearToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filterYearToolStripMenuItem.Text = "Year";
            this.filterYearToolStripMenuItem.Click += new System.EventHandler(this.FilterYear);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
            // 
            // TasksTreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTasksTreeView);
            this.Controls.Add(this.mainTasksToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TasksTreeControl";
            this.Size = new System.Drawing.Size(162, 337);
            this.Load += new System.EventHandler(this.TasksTreeControlLoad);
            this.mainTasksToolStrip.ResumeLayout(false);
            this.mainTasksToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TreeView mainTasksTreeView;
        protected System.Windows.Forms.ImageList mainImageList;
        protected System.Windows.Forms.ToolStrip mainTasksToolStrip;
        protected System.Windows.Forms.ToolStripButton newToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton copyToolStripButton;
        protected System.Windows.Forms.ToolStripButton editToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripButton deleteToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.ToolStripSplitButton filterToolStripButton;
        protected System.Windows.Forms.ToolStripMenuItem filterAllToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        protected System.Windows.Forms.ToolStripMenuItem filterDayToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem filterMonthToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem filterYearToolStripMenuItem;
        private System.Windows.Forms.Timer mainTimer;
    }
}
