namespace Umax.Windows.Controls.Views.Data
{
    partial class TasksGridDataControl
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
            this.filterToolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.filterAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.filterNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainCModel = new Umax.UI.XPTable.Models.ColumnModel();
            this.imageColumn = new Umax.UI.XPTable.Models.ImageColumn();
            this.workSpaceTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.nameTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.buttonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.mainTModel = new Umax.UI.XPTable.Models.TableModel();
            this.filterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainTable = new Umax.UI.XPTable.Models.Table();
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // filterToolStripButton
            // 
            this.filterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filterToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAllToolStripMenuItem,
            this.toolStripSeparator20,
            this.filterNewToolStripMenuItem,
            this.filterActiveToolStripMenuItem,
            this.filterCompletedToolStripMenuItem});
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
            this.filterAllToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.filterAllToolStripMenuItem.Text = "All";
            this.filterAllToolStripMenuItem.Click += new System.EventHandler(this.FilterAll);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(130, 6);
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
            // mainCModel
            // 
            this.mainCModel.Columns.AddRange(new Umax.UI.XPTable.Models.Column[] {
            this.imageColumn,
            this.workSpaceTextColumn,
            this.nameTextColumn,
            this.buttonColumn});
            // 
            // imageColumn
            // 
            this.imageColumn.Sortable = false;
            this.imageColumn.Width = 20;
            // 
            // workSpaceTextColumn
            // 
            this.workSpaceTextColumn.Sortable = false;
            this.workSpaceTextColumn.Text = "WorkSpace";
            this.workSpaceTextColumn.Width = 150;
            // 
            // nameTextColumn
            // 
            this.nameTextColumn.Sortable = false;
            this.nameTextColumn.Text = "Task";
            this.nameTextColumn.Width = 300;
            // 
            // buttonColumn
            // 
            this.buttonColumn.Sortable = false;
            this.buttonColumn.Text = "Log";
            this.buttonColumn.Width = 40;
            // 
            // filterToolStripTextBox
            // 
            this.filterToolStripTextBox.Name = "filterToolStripTextBox";
            this.filterToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.filterToolStripTextBox.TextChanged += new System.EventHandler(this.FilterTextChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
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
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.copyToolStripButton.Text = "Copy Tasks";
            this.copyToolStripButton.Click += new System.EventHandler(this.CopyTask);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripSeparator4,
            this.copyToolStripButton,
            this.editToolStripButton,
            this.toolStripSeparator5,
            this.runToolStripButton,
            this.pauseToolStripButton,
            this.stopToolStripButton,
            this.toolStripSeparator6,
            this.deleteToolStripButton,
            this.toolStripSeparator8,
            this.filterToolStripTextBox,
            this.filterToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(540, 23);
            this.mainToolStrip.TabIndex = 20;
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
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
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
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
            this.mainTable.Size = new System.Drawing.Size(540, 307);
            this.mainTable.TabIndex = 21;
            this.mainTable.TableModel = this.mainTModel;
            this.mainTable.CellDoubleClick += new Umax.UI.XPTable.Events.CellMouseEventHandler(this.mainTableCellDoubleClick);
            this.mainTable.CellButtonClicked += new Umax.UI.XPTable.Events.CellButtonEventHandler(this.mainTableCellButtonClicked);
            // 
            // TasksGridDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TasksGridDataControl";
            this.Size = new System.Drawing.Size(540, 330);
            this.Load += new System.EventHandler(this.TasksGridDataControlLoad);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStripSplitButton filterToolStripButton;
        protected System.Windows.Forms.ToolStripMenuItem filterAllToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        protected System.Windows.Forms.ToolStripMenuItem filterNewToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem filterActiveToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem filterCompletedToolStripMenuItem;
        protected UI.XPTable.Models.ColumnModel mainCModel;
        protected UI.XPTable.Models.TableModel mainTModel;
        protected System.Windows.Forms.ToolStripTextBox filterToolStripTextBox;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        protected System.Windows.Forms.ToolStripButton deleteToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        protected System.Windows.Forms.ToolStripButton newToolStripButton;
        protected System.Windows.Forms.ToolStripButton copyToolStripButton;
        protected System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.ToolStripButton editToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        protected System.Windows.Forms.ToolStripButton runToolStripButton;
        protected System.Windows.Forms.ToolStripButton pauseToolStripButton;
        protected System.Windows.Forms.ToolStripButton stopToolStripButton;
        protected System.Windows.Forms.Timer mainTimer;
        protected System.Windows.Forms.ImageList mainImageList;
        protected Umax.UI.XPTable.Models.ImageColumn imageColumn;
        protected Umax.UI.XPTable.Models.TextColumn workSpaceTextColumn;
        protected Umax.UI.XPTable.Models.TextColumn nameTextColumn;
        protected Umax.UI.XPTable.Models.ButtonColumn buttonColumn;
        protected UI.XPTable.Models.Table mainTable;
    }
}
