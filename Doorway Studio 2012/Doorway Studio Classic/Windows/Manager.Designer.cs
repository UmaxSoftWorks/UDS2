using Umax.Resources;
using Umax.Windows.Controls;
using Umax.Windows.Controls.Views;
using Umax.Windows.Controls.Views.Manager;
using Umax.Windows.Enums;

namespace DoorwayStudio.Windows
{
    partial class Manager
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
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logContol = new Umax.Windows.Controls.Views.LogContol();
            this.activeTasksGridManagerControl = new Umax.Windows.Controls.Views.Manager.ActiveTasksGridManagerControl();
            this.tasksGridManagerControl = new Umax.Windows.Controls.Views.Manager.TasksGridManagerControl();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenuStrip = new Umax.Windows.Controls.MenuStrip(this.components);
            this.mainTrayIcon = new Umax.Windows.Controls.TrayIcon(this.components);
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 440);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
            this.mainStatusStrip.TabIndex = 7;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.logContol, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.activeTasksGridManagerControl, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.tasksGridManagerControl, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 416);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // logContol
            // 
            this.logContol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logContol.Location = new System.Drawing.Point(0, 312);
            this.logContol.Margin = new System.Windows.Forms.Padding(0);
            this.logContol.Name = "logContol";
            this.logContol.Size = new System.Drawing.Size(284, 104);
            this.logContol.TabIndex = 3;
            // 
            // activeTasksGridManagerControl
            // 
            this.activeTasksGridManagerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeTasksGridManagerControl.Location = new System.Drawing.Point(0, 208);
            this.activeTasksGridManagerControl.Margin = new System.Windows.Forms.Padding(0);
            this.activeTasksGridManagerControl.Name = "activeTasksGridManagerControl";
            this.activeTasksGridManagerControl.Size = new System.Drawing.Size(284, 104);
            this.activeTasksGridManagerControl.TabIndex = 4;
            // 
            // tasksGridManagerControl
            // 
            this.tasksGridManagerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksGridManagerControl.FilterType = Umax.Windows.Enums.TasksDateFilterType.None;
            this.tasksGridManagerControl.Location = new System.Drawing.Point(0, 0);
            this.tasksGridManagerControl.Margin = new System.Windows.Forms.Padding(0);
            this.tasksGridManagerControl.Name = "tasksGridManagerControl";
            this.tasksGridManagerControl.SelectedDate = new System.DateTime(((long)(0)));
            this.tasksGridManagerControl.Size = new System.Drawing.Size(284, 208);
            this.tasksGridManagerControl.TabIndex = 5;
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 43200000;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.MenuType = Umax.Windows.Enums.MainMenuType.Manager;
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.mainMenuStrip.TabIndex = 8;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // mainTrayIcon
            // 
            this.mainTrayIcon.Icon = null;
            this.mainTrayIcon.Text = "";
            this.mainTrayIcon.Visible = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerFormClosed);
            this.Load += new System.EventHandler(this.ManagerLoad);
            this.ResizeBegin += new System.EventHandler(this.ManagerResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.ManagerResizeEnd);
            this.ClientSizeChanged += new System.EventHandler(this.ManagerClientSizeChanged);
            this.LocationChanged += new System.EventHandler(this.ManagerLocationChanged);
            this.SizeChanged += new System.EventHandler(this.ManagerSizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManagerKeyDown);
            this.Move += new System.EventHandler(this.ManagerMove);
            this.Resize += new System.EventHandler(this.ManagerResize);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Timer updateTimer;
        private LogContol logContol;
        private ActiveTasksGridManagerControl activeTasksGridManagerControl;
        private TasksGridManagerControl tasksGridManagerControl;
        private MenuStrip mainMenuStrip;
        private TrayIcon mainTrayIcon;
    }
}