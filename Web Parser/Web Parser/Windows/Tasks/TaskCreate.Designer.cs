namespace WebParser.Windows.Tasks
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
            this.actionPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksListView
            // 
            this.tasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tasksColumnHeader});
            this.tasksListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksListView.LargeImageList = this.mainImageList;
            this.tasksListView.Location = new System.Drawing.Point(0, 0);
            this.tasksListView.MultiSelect = false;
            this.tasksListView.Name = "tasksListView";
            this.tasksListView.Size = new System.Drawing.Size(516, 207);
            this.tasksListView.TabIndex = 7;
            this.tasksListView.UseCompatibleStateImageBehavior = false;
            this.tasksListView.DoubleClick += new System.EventHandler(this.tasksListViewDoubleClick);
            // 
            // tasksColumnHeader
            // 
            this.tasksColumnHeader.Text = "Task Type";
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.okButton);
            this.actionPanel.Controls.Add(this.cancelButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 207);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(516, 23);
            this.actionPanel.TabIndex = 8;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.okButton.Location = new System.Drawing.Point(366, 0);
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
            this.cancelButton.Location = new System.Drawing.Point(441, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(64, 64);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TaskCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 230);
            this.Controls.Add(this.tasksListView);
            this.Controls.Add(this.actionPanel);
            this.MinimumSize = new System.Drawing.Size(532, 268);
            this.Name = "TaskCreate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Parser 2012: Create Task";
            this.Load += new System.EventHandler(this.TaskCreateLoad);
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView tasksListView;
        private System.Windows.Forms.ColumnHeader tasksColumnHeader;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ImageList mainImageList;
    }
}