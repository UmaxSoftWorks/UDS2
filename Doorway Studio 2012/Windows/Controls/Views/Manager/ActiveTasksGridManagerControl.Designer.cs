namespace Umax.Windows.Controls.Views.Manager
{
    partial class ActiveTasksGridManagerControl
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
            this.startButtonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.pauseButtonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.stopButtonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.nameTextColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.progressBarColumn = new Umax.UI.XPTable.Models.ProgressBarColumn();
            this.logButtonColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.mainTModel = new Umax.UI.XPTable.Models.TableModel();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
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
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Margin = new System.Windows.Forms.Padding(0);
            this.mainTable.Name = "mainTable";
            this.mainTable.NoItemsText = "";
            this.mainTable.Size = new System.Drawing.Size(284, 98);
            this.mainTable.TabIndex = 3;
            this.mainTable.TableModel = this.mainTModel;
            this.mainTable.CellDoubleClick += new Umax.UI.XPTable.Events.CellMouseEventHandler(this.mainTableCellDoubleClick);
            this.mainTable.CellButtonClicked += new Umax.UI.XPTable.Events.CellButtonEventHandler(this.mainTableCellButtonClicked);
            // 
            // mainCModel
            // 
            this.mainCModel.Columns.AddRange(new Umax.UI.XPTable.Models.Column[] {
            this.startButtonColumn,
            this.pauseButtonColumn,
            this.stopButtonColumn,
            this.nameTextColumn,
            this.progressBarColumn,
            this.logButtonColumn});
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
            // nameTextColumn
            // 
            this.nameTextColumn.Sortable = false;
            this.nameTextColumn.Text = "Task";
            this.nameTextColumn.Width = 115;
            // 
            // progressBarColumn
            // 
            this.progressBarColumn.Sortable = false;
            this.progressBarColumn.Text = "%";
            this.progressBarColumn.Width = 45;
            // 
            // logButtonColumn
            // 
            this.logButtonColumn.Sortable = false;
            this.logButtonColumn.Text = "Log";
            this.logButtonColumn.Width = 45;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
            // 
            // ActiveTasksGridManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ActiveTasksGridManagerControl";
            this.Size = new System.Drawing.Size(284, 98);
            this.Load += new System.EventHandler(this.ActiveTasksGridManagerControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Umax.UI.XPTable.Models.TableModel mainTModel;
        private Umax.UI.XPTable.Models.ButtonColumn startButtonColumn;
        private Umax.UI.XPTable.Models.ButtonColumn pauseButtonColumn;
        private Umax.UI.XPTable.Models.ButtonColumn stopButtonColumn;
        private Umax.UI.XPTable.Models.TextColumn nameTextColumn;
        private Umax.UI.XPTable.Models.ProgressBarColumn progressBarColumn;
        private Umax.UI.XPTable.Models.ButtonColumn logButtonColumn;
        protected Umax.UI.XPTable.Models.Table mainTable;
        protected Umax.UI.XPTable.Models.ColumnModel mainCModel;
        private System.Windows.Forms.Timer mainTimer;
    }
}
