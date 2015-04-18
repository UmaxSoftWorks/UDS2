namespace WebParser.Controls
{
    partial class AllTasksGridControl
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
            this.mainTable = new Umax.UI.XPTable.Models.Table();
            this.mainCModel = new Umax.UI.XPTable.Models.ColumnModel();
            this.stateColumn = new Umax.UI.XPTable.Models.ImageColumn();
            this.nameColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.startColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.logColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.mainTModel = new Umax.UI.XPTable.Models.TableModel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.filterToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.mainTable.Size = new System.Drawing.Size(584, 181);
            this.mainTable.TabIndex = 18;
            this.mainTable.TableModel = this.mainTModel;
            this.mainTable.CellButtonClicked += new Umax.UI.XPTable.Events.CellButtonEventHandler(this.mainTableCellButtonClicked);
            // 
            // mainCModel
            // 
            this.mainCModel.Columns.AddRange(new Umax.UI.XPTable.Models.Column[] {
            this.stateColumn,
            this.nameColumn,
            this.startColumn,
            this.logColumn});
            // 
            // stateColumn
            // 
            this.stateColumn.Width = 20;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 430;
            // 
            // startColumn
            // 
            this.startColumn.Text = "Started";
            this.startColumn.Width = 100;
            // 
            // logColumn
            // 
            this.logColumn.Text = "Log";
            this.logColumn.Width = 30;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.editToolStripButton,
            this.toolStripSeparator1,
            this.startToolStripButton,
            this.pauseToolStripButton,
            this.stopToolStripButton,
            this.toolStripSeparator2,
            this.deleteToolStripButton,
            this.toolStripSeparator3,
            this.filterToolStripSplitButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(584, 23);
            this.mainToolStrip.TabIndex = 17;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButtonClick);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // startToolStripButton
            // 
            this.startToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startToolStripButton.Name = "startToolStripButton";
            this.startToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.startToolStripButton.Text = "Start";
            this.startToolStripButton.Click += new System.EventHandler(this.startToolStripButton_Click);
            // 
            // pauseToolStripButton
            // 
            this.pauseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseToolStripButton.Name = "pauseToolStripButton";
            this.pauseToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.pauseToolStripButton.Text = "Pause";
            this.pauseToolStripButton.Click += new System.EventHandler(this.pauseToolStripButtonClick);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.stopToolStripButton.Text = "Stop";
            this.stopToolStripButton.Click += new System.EventHandler(this.stopToolStripButtonClick);
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
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButtonClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // filterToolStripSplitButton
            // 
            this.filterToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filterToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todayToolStripMenuItem,
            this.weekToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.yearToolStripMenuItem,
            this.allToolStripMenuItem});
            this.filterToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterToolStripSplitButton.Name = "filterToolStripSplitButton";
            this.filterToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.filterToolStripSplitButton.Text = "filterToolStripSplitButton";
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.Checked = true;
            this.todayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.todayToolStripMenuItem.Text = "Today";
            this.todayToolStripMenuItem.Click += new System.EventHandler(this.todayToolStripMenuItemClick);
            // 
            // weekToolStripMenuItem
            // 
            this.weekToolStripMenuItem.Name = "weekToolStripMenuItem";
            this.weekToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.weekToolStripMenuItem.Text = "Week";
            this.weekToolStripMenuItem.Click += new System.EventHandler(this.weekToolStripMenuItemClick);
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.monthToolStripMenuItem.Text = "Month";
            this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItemClick);
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.yearToolStripMenuItem.Text = "Year";
            this.yearToolStripMenuItem.Click += new System.EventHandler(this.yearToolStripMenuItemClick);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItemClick);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AllTasksGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AllTasksGridControl";
            this.Size = new System.Drawing.Size(584, 204);
            this.Load += new System.EventHandler(this.AllTasksGridControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Umax.UI.XPTable.Models.Table mainTable;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton startToolStripButton;
        private System.Windows.Forms.ToolStripButton pauseToolStripButton;
        private System.Windows.Forms.ToolStripButton stopToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton filterToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem todayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        protected Umax.UI.XPTable.Models.ColumnModel mainCModel;
        protected Umax.UI.XPTable.Models.TableModel mainTModel;
        private Umax.UI.XPTable.Models.ImageColumn stateColumn;
        private Umax.UI.XPTable.Models.TextColumn nameColumn;
        private Umax.UI.XPTable.Models.TextColumn startColumn;
        private Umax.UI.XPTable.Models.ButtonColumn logColumn;
        private System.Windows.Forms.ImageList mainImageList;
    }
}
