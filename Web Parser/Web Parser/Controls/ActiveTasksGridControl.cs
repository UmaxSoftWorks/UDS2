using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Umax.Interfaces.Enums;
using Umax.Resources;
using Umax.UI.XPTable.Events;
using WebParser.Windows.Tasks;

namespace WebParser.Controls
{
    public partial class ActiveTasksGridControl : UserControl
    {
        public ActiveTasksGridControl()
        {
            InitializeComponent();
        }

        private void ActiveTasksGridControlLoad(object sender, EventArgs e)
        {
            this.InitializeImages();
            this.InitializeEvents();
        }

        private void InitializeImages()
        {
            startColumn.Image = Resources.Start;
            pauseColumn.Image = Resources.Pause;
            stopColumn.Image = Resources.Stop;
        }

        private void InitializeEvents()
        {
            if (DesignMode)
            {
                return;
            }

            // Subscribe to manager events
            Core.Core.Instanse.Manager.TasksStateChanged += this.UpdateControl;
            Core.Core.Instanse.Manager.TasksProgressChanged += this.UpdateControl;
        }

        /// <summary>
        /// This method should be invoked when main form is closing
        /// </summary>
        public void DeInitializeEvents()
        {
            if (DesignMode)
            {
                return;
            }

            // Unsubscribe to manager events
            Core.Core.Instanse.Manager.TasksStateChanged -= this.UpdateControl;
            Core.Core.Instanse.Manager.TasksProgressChanged -= this.UpdateControl;
        }

        public List<int> TaskIndexes()
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                if (Core.Core.Instanse.Data[i].State == TaskStateType.Running || Core.Core.Instanse.Data[i].State == TaskStateType.Paused)
                {
                    indexes.Add(i);
                }
            }

            return indexes;
        }

        public void UpdateControl()
        {
            List<int> indexes = this.TaskIndexes();

            mainTModel.Rows.Clear();

            for (int i = 0; i < indexes.Count; i++)
            {
                Umax.UI.XPTable.Models.Row row = new Umax.UI.XPTable.Models.Row();

                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[indexes[i]].Name));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[indexes[i]].StartTime.ToString()));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[indexes[i]].Progress));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));

                mainTModel.Rows.Add(row);
            }
        }

        private void mainTableCellButtonClicked(object sender, CellButtonEventArgs e)
        {
            // Handle clicks on buttons
            if (e.Column == 0 || e.Column == 1 || e.Column == 2 || e.Column == 6)
            {
                List<int> indexes = this.TaskIndexes();

                // Start
                if (e.Column == 0)
                {
                    Core.Core.Instanse.Manager.Start(Core.Core.Instanse.Data[indexes[e.Row]]);
                }
                    // Pause
                else if (e.Column == 1)
                {
                    Core.Core.Instanse.Manager.Pause(Core.Core.Instanse.Data[indexes[e.Row]]);
                }
                    // Stop
                else if (e.Column == 2)
                {
                    Core.Core.Instanse.Manager.Stop(Core.Core.Instanse.Data[indexes[e.Row]]);
                }
                    // Log
                else if (e.Column == 6)
                {
                    new TaskLog()
                        {
                            Content = Core.Core.Instanse.Data[indexes[e.Row]].Log
                        }.Show();
                }
            }
        }
    }
}
