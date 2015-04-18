namespace Umax.Windows.Controls.Views.Data
{
    partial class TasksTreeDataControl
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
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.newTaskTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyTaskTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editTaskTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.runTaskTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseTaskTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopTaskTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteTaskTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.filterTreeToolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.filterAllTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.filterDayTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMonthTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterYearTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTreeView.ImageIndex = 0;
            this.mainTreeView.ImageList = this.mainImageList;
            this.mainTreeView.Location = new System.Drawing.Point(0, 23);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.SelectedImageIndex = 0;
            this.mainTreeView.Size = new System.Drawing.Size(250, 307);
            this.mainTreeView.TabIndex = 4;
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mainTreeViewAfterSelect);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskTreeToolStripButton,
            this.toolStripSeparator1,
            this.copyTaskTreeToolStripButton,
            this.editTaskTreeToolStripButton,
            this.toolStripSeparator2,
            this.runTaskTreeToolStripButton,
            this.pauseTaskTreeToolStripButton,
            this.stopTaskTreeToolStripButton,
            this.toolStripSeparator3,
            this.deleteTaskTreeToolStripButton,
            this.filterTreeToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.Size = new System.Drawing.Size(250, 23);
            this.mainToolStrip.TabIndex = 5;
            // 
            // newTaskTreeToolStripButton
            // 
            this.newTaskTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTaskTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTaskTreeToolStripButton.Name = "newTaskTreeToolStripButton";
            this.newTaskTreeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.newTaskTreeToolStripButton.Text = "New";
            this.newTaskTreeToolStripButton.Click += new System.EventHandler(this.CreateTask);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // copyTaskTreeToolStripButton
            // 
            this.copyTaskTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyTaskTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyTaskTreeToolStripButton.Name = "copyTaskTreeToolStripButton";
            this.copyTaskTreeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.copyTaskTreeToolStripButton.Text = "Copy";
            this.copyTaskTreeToolStripButton.Click += new System.EventHandler(this.CopyTask);
            // 
            // editTaskTreeToolStripButton
            // 
            this.editTaskTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editTaskTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editTaskTreeToolStripButton.Name = "editTaskTreeToolStripButton";
            this.editTaskTreeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.editTaskTreeToolStripButton.Text = "Edit";
            this.editTaskTreeToolStripButton.Click += new System.EventHandler(this.EditTask);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // runTaskTreeToolStripButton
            // 
            this.runTaskTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runTaskTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runTaskTreeToolStripButton.Name = "runTaskTreeToolStripButton";
            this.runTaskTreeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.runTaskTreeToolStripButton.Text = "Run";
            this.runTaskTreeToolStripButton.Click += new System.EventHandler(this.RunTask);
            // 
            // pauseTaskTreeToolStripButton
            // 
            this.pauseTaskTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseTaskTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseTaskTreeToolStripButton.Name = "pauseTaskTreeToolStripButton";
            this.pauseTaskTreeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.pauseTaskTreeToolStripButton.Text = "Pause";
            this.pauseTaskTreeToolStripButton.Click += new System.EventHandler(this.PauseTask);
            // 
            // stopTaskTreeToolStripButton
            // 
            this.stopTaskTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopTaskTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopTaskTreeToolStripButton.Name = "stopTaskTreeToolStripButton";
            this.stopTaskTreeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.stopTaskTreeToolStripButton.Text = "Stop";
            this.stopTaskTreeToolStripButton.Click += new System.EventHandler(this.StopTask);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // deleteTaskTreeToolStripButton
            // 
            this.deleteTaskTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTaskTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTaskTreeToolStripButton.Name = "deleteTaskTreeToolStripButton";
            this.deleteTaskTreeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.deleteTaskTreeToolStripButton.Text = "Delete";
            this.deleteTaskTreeToolStripButton.Click += new System.EventHandler(this.DeleteTask);
            // 
            // filterTreeToolStripButton
            // 
            this.filterTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filterTreeToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAllTreeToolStripMenuItem,
            this.toolStripSeparator7,
            this.filterDayTreeToolStripMenuItem,
            this.filterMonthTreeToolStripMenuItem,
            this.filterYearTreeToolStripMenuItem});
            this.filterTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterTreeToolStripButton.Name = "filterTreeToolStripButton";
            this.filterTreeToolStripButton.Size = new System.Drawing.Size(16, 4);
            this.filterTreeToolStripButton.Text = "Filter";
            // 
            // filterAllTreeToolStripMenuItem
            // 
            this.filterAllTreeToolStripMenuItem.Checked = true;
            this.filterAllTreeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filterAllTreeToolStripMenuItem.Name = "filterAllTreeToolStripMenuItem";
            this.filterAllTreeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filterAllTreeToolStripMenuItem.Text = "All";
            this.filterAllTreeToolStripMenuItem.Click += new System.EventHandler(this.FilterAll);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(107, 6);
            // 
            // filterDayTreeToolStripMenuItem
            // 
            this.filterDayTreeToolStripMenuItem.Name = "filterDayTreeToolStripMenuItem";
            this.filterDayTreeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filterDayTreeToolStripMenuItem.Text = "Day";
            this.filterDayTreeToolStripMenuItem.Click += new System.EventHandler(this.FilterDay);
            // 
            // filterMonthTreeToolStripMenuItem
            // 
            this.filterMonthTreeToolStripMenuItem.Name = "filterMonthTreeToolStripMenuItem";
            this.filterMonthTreeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filterMonthTreeToolStripMenuItem.Text = "Month";
            this.filterMonthTreeToolStripMenuItem.Click += new System.EventHandler(this.FilterMonth);
            // 
            // filterYearTreeToolStripMenuItem
            // 
            this.filterYearTreeToolStripMenuItem.Name = "filterYearTreeToolStripMenuItem";
            this.filterYearTreeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filterYearTreeToolStripMenuItem.Text = "Year";
            this.filterYearTreeToolStripMenuItem.Click += new System.EventHandler(this.FilterYear);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
            // 
            // TasksTreeDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTreeView);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TasksTreeDataControl";
            this.Size = new System.Drawing.Size(250, 330);
            this.Load += new System.EventHandler(this.TasksTreeDataControlLoad);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TreeView mainTreeView;
        protected System.Windows.Forms.ImageList mainImageList;
        protected System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.ToolStripButton newTaskTreeToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton copyTaskTreeToolStripButton;
        protected System.Windows.Forms.ToolStripButton editTaskTreeToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripButton runTaskTreeToolStripButton;
        protected System.Windows.Forms.ToolStripButton pauseTaskTreeToolStripButton;
        protected System.Windows.Forms.ToolStripButton stopTaskTreeToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.ToolStripButton deleteTaskTreeToolStripButton;
        protected System.Windows.Forms.ToolStripSplitButton filterTreeToolStripButton;
        protected System.Windows.Forms.ToolStripMenuItem filterAllTreeToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        protected System.Windows.Forms.ToolStripMenuItem filterDayTreeToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem filterMonthTreeToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem filterYearTreeToolStripMenuItem;
        protected System.Windows.Forms.Timer mainTimer;
    }
}
