using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using IO = System.IO;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class PagesTabPageControl : UserControl
    {
        public PagesTabPageControl()
        {
            InitializeComponent();
        }

        protected virtual void addToolStripButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows.Add();
        }

        protected virtual void removeToolStripButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
        }

        protected virtual void clearToolStripButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
        }

        public virtual void ValidateSettings()
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[0] == null)
                {
                    throw new Exception("Please specify Static page keyword!");
                }
                if (string.IsNullOrEmpty(dataGridView.Rows[i].Cells[0].Value.ToString()))
                {
                    throw new Exception("Please specify Static page keyword!");
                }
            }
        }

        public virtual void CollectSettings()
        {
            (this.Task.Executor.Settings as TaskSettings).StaticPages = new List<string>();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView.Rows[i].Cells[0].Value.ToString()))
                {
                    if (dataGridView.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }

                    (this.Task.Executor.Settings as TaskSettings).StaticPages.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
                }
            }
        }

        private ITask task;
        public ITask Task
        {
            get { return this.task; }
            set
            {
                this.task = value;

                for (int i = 0; i < (value.Executor.Settings as TaskSettings).StaticPages.Count; i++)
                {
                    dataGridView.Rows.Add((value.Executor.Settings as TaskSettings).StaticPages[i]);
                }
            }
        }

        private void PagesTabPageControlLoad(object sender, EventArgs e)
        {
            addToolStripButton.Image = Resources.Resources.PlusBlue;
            removeToolStripButton.Image = Resources.Resources.MinusBlue;
            openToolStripButton.Image = Resources.Resources.Folder;
            clearToolStripButton.Image = Resources.Resources.Delete;
        }

        private void openToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            string[] items = IO.File.ReadAllLines(mainOpenFileDialog.FileName, Encoding.Default);

            dataGridView.Rows.Clear();

            for (int i = 0; i < items.Length; i++)
            {
                dataGridView.Rows.Add(items[i]);
            }
        }
    }
}
