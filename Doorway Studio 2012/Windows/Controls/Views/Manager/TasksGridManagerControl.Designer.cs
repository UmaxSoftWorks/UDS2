namespace Umax.Windows.Controls.Views.Manager
{
    partial class TasksGridManagerControl
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
            this.mainTModel = new Umax.UI.XPTable.Models.TableModel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.filterToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.filterAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.filterNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateImageColumn = new Umax.UI.XPTable.Models.ImageColumn();
            this.taskTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.dateTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.logButtonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.mainCModel = new Umax.UI.XPTable.Models.ColumnModel();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainTable = new Umax.UI.XPTable.Models.Table();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripSeparator1,
            this.copyToolStripButton,
            this.editToolStripButton,
            this.toolStripSeparator2,
            this.runToolStripButton,
            this.pauseToolStripButton,
            this.stopToolStripButton,
            this.toolStripSeparator3,
            this.deleteToolStripButton,
            this.toolStripSeparator4,
            this.filterToolStripSplitButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.Size = new System.Drawing.Size(278, 23);
            this.mainToolStrip.TabIndex = 6;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.newToolStripButton.Text = "New";
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
            // runToolStripButton
            // 
            this.runToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runToolStripButton.Name = "runToolStripButton";
            this.runToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.runToolStripButton.Text = "Run";
            this.runToolStripButton.Click += new System.EventHandler(this.RunTask);
            // 
            // pauseToolStripButton
            // 
            this.pauseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseToolStripButton.Name = "pauseToolStripButton";
            this.pauseToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.pauseToolStripButton.Text = "Pause";
            this.pauseToolStripButton.Click += new System.EventHandler(this.PauseTask);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.stopToolStripButton.Text = "Stop";
            this.stopToolStripButton.Click += new System.EventHandler(this.StopTask);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // filterToolStripSplitButton
            // 
            this.filterToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filterToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAllToolStripMenuItem,
            this.toolStripSeparator5,
            this.filterNewToolStripMenuItem,
            this.filterActiveToolStripMenuItem,
            this.filterCompletedToolStripMenuItem});
            this.filterToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterToolStripSplitButton.Name = "filterToolStripSplitButton";
            this.filterToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.filterToolStripSplitButton.Text = "Filter";
            // 
            // filterAllToolStripMenuItem
            // 
            this.filterAllToolStripMenuItem.Checked = true;
            this.filterAllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filterAllToolStripMenuItem.Name = "filterAllToolStripMenuItem";
            this.filterAllToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.filterAllToolStripMenuItem.Text = "All";
            this.filterAllToolStripMenuItem.Click += new System.EventHandler(this.FilterAll);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(130, 6);
            // 
            // filterNewToolStripMenuItem
            // 
            this.filterNewToolStripMenuItem.Name = "filterNewToolStripMenuItem";
            this.filterNewToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.filterNewToolStripMenuItem.Text = "New";
            this.filterNewToolStripMenuItem.Click += new System.EventHandler(this.FilterNew);
            // 
            // filterActiveToolStripMenuItem
            // 
            this.filterActiveToolStripMenuItem.Name = "filterActiveToolStripMenuItem";
            this.filterActiveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.filterActiveToolStripMenuItem.Text = "Active";
            this.filterActiveToolStripMenuItem.Click += new System.EventHandler(this.FilterActive);
            // 
            // filterCompletedToolStripMenuItem
            // 
            this.filterCompletedToolStripMenuItem.Name = "filterCompletedToolStripMenuItem";
            this.filterCompletedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.filterCompletedToolStripMenuItem.Text = "Completed";
            this.filterCompletedToolStripMenuItem.Click += new System.EventHandler(this.FilterCompleted);
            // 
            // stateImageColumn
            // 
            this.stateImageColumn.Sortable = false;
            this.stateImageColumn.Width = 20;
            // 
            // taskTextColumn
            // 
            this.taskTextColumn.Sortable = false;
            this.taskTextColumn.Text = "Task";
            this.taskTextColumn.Width = 150;
            // 
            // dateTextColumn
            // 
            this.dateTextColumn.Sortable = false;
            this.dateTextColumn.Text = "Date";
            this.dateTextColumn.Width = 55;
            // 
            // logButtonColumn
            // 
            this.logButtonColumn.Sortable = false;
            this.logButtonColumn.Text = "Log";
            this.logButtonColumn.Width = 45;
            // 
            // mainCModel
            // 
            this.mainCModel.Columns.AddRange(new Umax.UI.XPTable.Models.Column[] {
            this.stateImageColumn,
            this.taskTextColumn,
            this.dateTextColumn,
            this.logButtonColumn});
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainTable
            // 
            this.mainTable.ColumnModel = this.mainCModel;
            this.mainTable.CustomEditKey = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F5)));
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.EditStartAction = Umax.UI.XPTable.Editors.EditStartAction.CustomKey;
            this.mainTable.EnableHeaderContextMenu = false;
            this.mainTable.FullRowSelect = true;
            this.mainTable.Location = new System.Drawing.Point(0, 23);
            this.mainTable.Name = "mainTable";
            this.mainTable.NoItemsText = "";
            this.mainTable.Size = new System.Drawing.Size(278, 187);
            this.mainTable.TabIndex = 5;
            this.mainTable.TableModel = this.mainTModel;
            this.mainTable.CellDoubleClick += new Umax.UI.XPTable.Events.CellMouseEventHandler(this.mainTableCellDoubleClick);
            this.mainTable.CellButtonClicked += new Umax.UI.XPTable.Events.CellButtonEventHandler(this.mainTableCellButtonClicked);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
            // 
            // TasksGridManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TasksGridManagerControl";
            this.Size = new System.Drawing.Size(278, 210);
            this.Load += new System.EventHandler(this.TasksGridManagerControlLoad);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Umax.UI.XPTable.Models.TableModel mainTModel;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton runToolStripButton;
        private System.Windows.Forms.ToolStripButton pauseToolStripButton;
        private System.Windows.Forms.ToolStripButton stopToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton filterToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem filterAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem filterNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCompletedToolStripMenuItem;
        private Umax.UI.XPTable.Models.ImageColumn stateImageColumn;
        private Umax.UI.XPTable.Models.TextColumn taskTextColumn;
        private Umax.UI.XPTable.Models.ButtonColumn logButtonColumn;
        private Umax.UI.XPTable.Models.TextColumn dateTextColumn;
        private System.Windows.Forms.ImageList mainImageList;
        protected Umax.UI.XPTable.Models.ColumnModel mainCModel;
        protected Umax.UI.XPTable.Models.Table mainTable;
        private System.Windows.Forms.Timer mainTimer;
    }
}
