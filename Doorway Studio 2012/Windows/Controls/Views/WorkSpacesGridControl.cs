using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Classes.Containers.Items;
using Umax.Classes.Helpers;
using Umax.Interfaces.Events;
using Umax.Windows.Helpers;
using Umax.Windows.Interfaces;
using Helper = Core.Helpers.Helper;

namespace Umax.Windows.Controls.Views
{
    public partial class WorkSpacesGridControl : UserControl, IEventedControl, IWorkSpacesContol
    {
        public WorkSpacesGridControl()
        {
            InitializeComponent();
        }

        private int selectedWorkSpace;
        public int SelectedWorkSpace
        {
            get
            {
                if (mainTModel.Rows.Count == 0)
                {
                    return -1;
                }

                return selectedWorkSpace;
            }

            protected set
            {
                this.selectedWorkSpace = value;

                if (this.WorkSpaceChanged != null)
                {
                    this.WorkSpaceChanged();
                }
            }
        }

        public event SimpleEventHandler WorkSpaceChanged;

        private void WorkSpacesControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();
            this.InitializeEvents();

            this.UpdateControl();

            mainTimer.Start();
        }

        protected virtual void InitializeImages()
        {
            newToolStripButton.Image = Resources.Resources.PlusGreen;
            copyToolStripButton.Image = Resources.Resources.Copy;
            editToolStripButton.Image = Resources.Resources.Edit;
            deleteToolStripButton.Image = Resources.Resources.MinusGreen;

            imageColumn.Image = Resources.Resources.WorkSpace;
        }

        public void InitializeEvents()
        {
            Core.Core.Instanse.Data.Items.CountChanged += this.EventHandler;
        }

        public void DeInitializeEvents()
        {
            Core.Core.Instanse.Data.Items.CountChanged -= this.EventHandler;

            mainTimer.Stop();
        }

        protected void EventHandler()
        {
            if (this.CanUpdate() && !DesignMode)
            {
                this.Invoke((MethodInvoker)delegate { this.UpdateControl(); });
            }
        }

        protected bool Initialized { get; set; }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            List<Umax.UI.XPTable.Models.Row> rows = new List<Umax.UI.XPTable.Models.Row>();

            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Umax.UI.XPTable.Models.Row row = new Umax.UI.XPTable.Models.Row();

                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty, Resources.Resources.WorkSpace, new Umax.UI.XPTable.Models.CellStyle()));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[i].Name));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(100));

                rows.Add(row);
            }

            mainTModel.Rows.Clear();
            mainTModel.Rows.AddRange(rows.ToArray());
        }

        protected void mainTModelSelectionChanged(object sender, Umax.UI.XPTable.Events.SelectionEventArgs e)
        {
            try
            {
                this.SelectedWorkSpace = mainTable.SelectedIndicies[0];
            }
            catch (Exception)
            {
                this.SelectedWorkSpace = -1;
            }
        }

        public void DeleteWorkSpace(object sender, EventArgs e)
        {
            if (this.SelectedWorkSpace != -1)
            {
                if (WinHelper.MessageBox("Do you really want to delete this WorkSpace?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                Helper.DeleteWorkSpace(this.SelectedWorkSpace);
            }
        }

        public void EditWorkSpace(object sender, EventArgs e)
        {

        }

        public void CopyWorkSpace(object sender, EventArgs e)
        {
            if (this.SelectedWorkSpace == -1)
            {
                return;
            }

            DataHelper.CopyWorkSpace(FindForm(), Core.Core.Instanse.Data[this.SelectedWorkSpace]);
        }

        public void CreateWorkSpace(object sender, EventArgs e)
        {
            DataHelper.CreateWorkSpace();
        }

        protected void mainTableCellClick(object sender, Umax.UI.XPTable.Events.CellMouseEventArgs e)
        {

        }

        protected void mainTableCellDoubleClick(object sender, Umax.UI.XPTable.Events.CellMouseEventArgs e)
        {

        }

        private void mainTimerTick(object sender, EventArgs e)
        {
            this.EventHandler();
        }
    }
}
