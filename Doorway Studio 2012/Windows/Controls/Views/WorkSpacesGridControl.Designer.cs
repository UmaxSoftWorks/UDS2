namespace Umax.Windows.Controls.Views
{
    partial class WorkSpacesGridControl
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
            this.mainTable = new Umax.UI.XPTable.Models.Table();
            this.mainCModel = new Umax.UI.XPTable.Models.ColumnModel();
            this.imageColumn = new Umax.UI.XPTable.Models.ImageColumn();
            this.nameColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.progressBarColumn = new Umax.UI.XPTable.Models.ProgressBarColumn();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTModel
            // 
            this.mainTModel.SelectionChanged += new Umax.UI.XPTable.Events.SelectionEventHandler(this.mainTModelSelectionChanged);
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
            this.mainTable.Size = new System.Drawing.Size(162, 314);
            this.mainTable.TabIndex = 6;
            this.mainTable.TableModel = this.mainTModel;
            this.mainTable.CellClick += new Umax.UI.XPTable.Events.CellMouseEventHandler(this.mainTableCellClick);
            this.mainTable.CellDoubleClick += new Umax.UI.XPTable.Events.CellMouseEventHandler(this.mainTableCellDoubleClick);
            // 
            // mainCModel
            // 
            this.mainCModel.Columns.AddRange(new Umax.UI.XPTable.Models.Column[] {
            this.imageColumn,
            this.nameColumn,
            this.progressBarColumn});
            // 
            // imageColumn
            // 
            this.imageColumn.Sortable = false;
            this.imageColumn.Width = 20;
            // 
            // nameColumn
            // 
            this.nameColumn.Editable = false;
            this.nameColumn.Sortable = false;
            this.nameColumn.Text = "WorkSpace";
            this.nameColumn.Width = 90;
            // 
            // progressBarColumn
            // 
            this.progressBarColumn.Sortable = false;
            this.progressBarColumn.Text = "%";
            this.progressBarColumn.Width = 45;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripSeparator1,
            this.copyToolStripButton,
            this.editToolStripButton,
            this.toolStripSeparator2,
            this.deleteToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.Size = new System.Drawing.Size(162, 23);
            this.mainToolStrip.TabIndex = 7;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.ToolTipText = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.CreateWorkSpace);
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
            this.copyToolStripButton.Click += new System.EventHandler(this.CopyWorkSpace);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.EditWorkSpace);
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
            this.deleteToolStripButton.Click += new System.EventHandler(this.DeleteWorkSpace);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
            // 
            // WorkSpacesGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WorkSpacesGridControl";
            this.Size = new System.Drawing.Size(162, 337);
            this.Load += new System.EventHandler(this.WorkSpacesControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Umax.UI.XPTable.Models.TableModel mainTModel;
        protected Umax.UI.XPTable.Models.Table mainTable;
        protected Umax.UI.XPTable.Models.ImageColumn imageColumn;
        protected Umax.UI.XPTable.Models.TextColumn nameColumn;
        protected Umax.UI.XPTable.Models.ProgressBarColumn progressBarColumn;
        protected Umax.UI.XPTable.Models.ColumnModel mainCModel;
        protected System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.ToolStripButton newToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton copyToolStripButton;
        protected System.Windows.Forms.ToolStripButton editToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.Timer mainTimer;
    }
}
