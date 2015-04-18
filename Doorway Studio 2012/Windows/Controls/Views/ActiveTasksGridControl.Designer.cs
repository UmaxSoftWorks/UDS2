namespace Umax.Windows.Controls.Views
{
    partial class ActiveTasksGridControl
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
            this.mainCModel = new Umax.UI.XPTable.Models.ColumnModel();
            this.startButtonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.pauseButtonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.stopButtonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.workSpaceTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.nameTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.progressBarColumn = new Umax.UI.XPTable.Models.ProgressBarColumn();
            this.stateTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.logButtonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.startedTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.elapsedTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.mainTable = new Umax.UI.XPTable.Models.Table();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCModel
            // 
            this.mainCModel.Columns.AddRange(new Umax.UI.XPTable.Models.Column[] {
            this.startButtonColumn,
            this.pauseButtonColumn,
            this.stopButtonColumn,
            this.workSpaceTextColumn,
            this.nameTextColumn,
            this.progressBarColumn,
            this.stateTextColumn,
            this.logButtonColumn,
            this.startedTextColumn,
            this.elapsedTextColumn});
            // 
            // startButtonColumn
            // 
            this.startButtonColumn.Sortable = false;
            this.startButtonColumn.Width = 20;
            // 
            // pauseButtonColumn
            // 
            this.pauseButtonColumn.Sortable = false;
            this.pauseButtonColumn.Width = 20;
            // 
            // stopButtonColumn
            // 
            this.stopButtonColumn.Sortable = false;
            this.stopButtonColumn.Width = 20;
            // 
            // workSpaceTextColumn
            // 
            this.workSpaceTextColumn.Sortable = false;
            this.workSpaceTextColumn.Text = "WorkSpace";
            this.workSpaceTextColumn.Width = 100;
            // 
            // nameTextColumn
            // 
            this.nameTextColumn.Sortable = false;
            this.nameTextColumn.Text = "Task";
            this.nameTextColumn.Width = 100;
            // 
            // progressBarColumn
            // 
            this.progressBarColumn.Sortable = false;
            this.progressBarColumn.Text = "%";
            this.progressBarColumn.Width = 50;
            // 
            // stateTextColumn
            // 
            this.stateTextColumn.Sortable = false;
            this.stateTextColumn.Text = "State";
            // 
            // logButtonColumn
            // 
            this.logButtonColumn.Sortable = false;
            this.logButtonColumn.Text = "Log";
            this.logButtonColumn.Width = 35;
            // 
            // startedTextColumn
            // 
            this.startedTextColumn.Sortable = false;
            this.startedTextColumn.Text = "Started";
            this.startedTextColumn.Width = 100;
            // 
            // elapsedTextColumn
            // 
            this.elapsedTextColumn.Sortable = false;
            this.elapsedTextColumn.Text = "Elapsed";
            this.elapsedTextColumn.Width = 100;
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
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.NoItemsText = "";
            this.mainTable.Size = new System.Drawing.Size(639, 108);
            this.mainTable.TabIndex = 3;
            this.mainTable.TableModel = this.mainTModel;
            this.mainTable.CellDoubleClick += new Umax.UI.XPTable.Events.CellMouseEventHandler(this.mainTableCellDoubleClick);
            this.mainTable.CellButtonClicked += new Umax.UI.XPTable.Events.CellButtonEventHandler(this.mainTableCellButtonClicked);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
            // 
            // ActiveTasksGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ActiveTasksGridControl";
            this.Size = new System.Drawing.Size(639, 108);
            this.Load += new System.EventHandler(this.ActiveTasksControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Umax.UI.XPTable.Models.TableModel mainTModel;
        protected Umax.UI.XPTable.Models.ColumnModel mainCModel;
        protected Umax.UI.XPTable.Models.Table mainTable;
        protected Umax.UI.XPTable.Models.ButtonColumn startButtonColumn;
        protected Umax.UI.XPTable.Models.ButtonColumn pauseButtonColumn;
        protected Umax.UI.XPTable.Models.ButtonColumn stopButtonColumn;
        protected Umax.UI.XPTable.Models.TextColumn workSpaceTextColumn;
        protected Umax.UI.XPTable.Models.TextColumn nameTextColumn;
        protected Umax.UI.XPTable.Models.ProgressBarColumn progressBarColumn;
        protected Umax.UI.XPTable.Models.TextColumn stateTextColumn;
        protected Umax.UI.XPTable.Models.ButtonColumn logButtonColumn;
        protected Umax.UI.XPTable.Models.TextColumn startedTextColumn;
        protected Umax.UI.XPTable.Models.TextColumn elapsedTextColumn;
        private System.Windows.Forms.Timer mainTimer;
    }
}
