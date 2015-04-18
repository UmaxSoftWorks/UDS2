using Umax.Windows.Controls.Views.Data;

namespace Umax.Windows.Controls.Data
{
    partial class TasksDataControl
    {
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

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tasksGridDataControl = new TasksGridDataControl();
            this.tasksTreeDataControl = new TasksTreeDataControl();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.tasksTreeDataControl);
            this.mainSplitContainer.Panel1MinSize = 250;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.tasksGridDataControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(794, 353);
            this.mainSplitContainer.SplitterDistance = 250;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // tasksGridDataControl
            // 
            this.tasksGridDataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksGridDataControl.FilterType = Umax.Windows.Enums.TasksDateFilterType.None;
            this.tasksGridDataControl.Location = new System.Drawing.Point(0, 0);
            this.tasksGridDataControl.Margin = new System.Windows.Forms.Padding(0);
            this.tasksGridDataControl.Name = "tasksGridDataControl";
            this.tasksGridDataControl.SelectedDate = new System.DateTime(((long)(0)));
            this.tasksGridDataControl.Size = new System.Drawing.Size(540, 353);
            this.tasksGridDataControl.TabIndex = 0;
            // 
            // tasksTreeDataControl
            // 
            this.tasksTreeDataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksTreeDataControl.Location = new System.Drawing.Point(0, 0);
            this.tasksTreeDataControl.Name = "tasksTreeDataControl";
            this.tasksTreeDataControl.Size = new System.Drawing.Size(250, 353);
            this.tasksTreeDataControl.TabIndex = 0;
            // 
            // TasksDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "TasksDataControl";
            this.Size = new System.Drawing.Size(794, 353);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        private TasksGridDataControl tasksGridDataControl;
        private TasksTreeDataControl tasksTreeDataControl;
    }
}
