namespace WebParser.Controls
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
            this.mainTable = new Umax.UI.XPTable.Models.Table();
            this.mainCModel = new Umax.UI.XPTable.Models.ColumnModel();
            this.startColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.pauseColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.stopColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.nameColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.startDateColumn = new Umax.UI.XPTable.Models.TextColumn();
            this.progressColumn = new Umax.UI.XPTable.Models.ProgressBarColumn();
            this.logColumn = new Umax.UI.XPTable.Models.ButtonColumn();
            this.mainTModel = new Umax.UI.XPTable.Models.TableModel();
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
            this.mainTable.Name = "mainTable";
            this.mainTable.NoItemsText = "";
            this.mainTable.Size = new System.Drawing.Size(584, 107);
            this.mainTable.TabIndex = 18;
            this.mainTable.TableModel = this.mainTModel;
            this.mainTable.CellButtonClicked += new Umax.UI.XPTable.Events.CellButtonEventHandler(this.mainTableCellButtonClicked);
            // 
            // mainCModel
            // 
            this.mainCModel.Columns.AddRange(new Umax.UI.XPTable.Models.Column[] {
            this.startColumn,
            this.pauseColumn,
            this.stopColumn,
            this.nameColumn,
            this.startDateColumn,
            this.progressColumn,
            this.logColumn});
            // 
            // startColumn
            // 
            this.startColumn.Width = 20;
            // 
            // pauseColumn
            // 
            this.pauseColumn.Width = 20;
            // 
            // stopColumn
            // 
            this.stopColumn.Width = 20;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 250;
            // 
            // startDateColumn
            // 
            this.startDateColumn.Text = "Started";
            this.startDateColumn.Width = 150;
            // 
            // progressColumn
            // 
            this.progressColumn.Text = "%";
            this.progressColumn.Width = 90;
            // 
            // logColumn
            // 
            this.logColumn.Text = "Log";
            this.logColumn.Width = 30;
            // 
            // ActiveTasksGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ActiveTasksGridControl";
            this.Size = new System.Drawing.Size(584, 107);
            this.Load += new System.EventHandler(this.ActiveTasksGridControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Umax.UI.XPTable.Models.Table mainTable;
        protected Umax.UI.XPTable.Models.ColumnModel mainCModel;
        protected Umax.UI.XPTable.Models.TableModel mainTModel;
        private Umax.UI.XPTable.Models.ButtonColumn startColumn;
        private Umax.UI.XPTable.Models.ButtonColumn pauseColumn;
        private Umax.UI.XPTable.Models.ButtonColumn stopColumn;
        private Umax.UI.XPTable.Models.TextColumn nameColumn;
        private Umax.UI.XPTable.Models.TextColumn startDateColumn;
        private Umax.UI.XPTable.Models.ProgressBarColumn progressColumn;
        private Umax.UI.XPTable.Models.ButtonColumn logColumn;
    }
}
