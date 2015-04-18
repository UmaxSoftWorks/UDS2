using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Umax.Interfaces.Tasks;
using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Enums;
using IO = System.IO;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class TagsTabPageControl : UserControl
    {
        public TagsTabPageControl()
        {
            InitializeComponent();
        }

        protected ITaskExecutor executor;

        /// <summary>
        /// Sets task executor
        /// </summary>
        public ITaskExecutor Executor
        {
            set
            {
                this.executor = value;

                for (int i = 0; i < (value.Settings as TaskSettings).Tags.Count; i++)
                {
                    // Encoding
                    string encoding = "ANSI";
                    if ((value.Settings as TaskSettings).FileTokens[i].Encoding == EncodingType.UTF8)
                    {
                        encoding = "UTF-8";
                    }

                    dataGridView.Rows.Add((value.Settings as TaskSettings).Tags[i], encoding);
                }
            }
        }

        public virtual void CollectSettings(ITaskSettings Settings)
        {
            (Settings as TaskSettings).Tags = new List<Tag>();

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                (Settings as TaskSettings).Tags.Add(
                    new Tag()
                        {
                            Path = dataGridView.Rows[i].Cells[0].Value == null
                                       ? string.Empty
                                       : dataGridView.Rows[i].Cells[0].Value.ToString(),
                            Encoding = dataGridView.Rows[i].Cells[1].Value.ToString() == "ANSI"
                                           ? EncodingType.ANSI
                                           : EncodingType.UTF8
                        });
            }
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

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i < items.Length)
                {
                    dataGridView.Rows[i].Cells[0].Value = items[i];
                }
                else
                {
                    break;
                }
            }
        }

        private void clearToolStripButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = string.Empty;
                dataGridView.Rows[i].Cells[1].Value = "ANSI";
            }
        }

        public int SitesCount
        {
            set
            {
                if (dataGridView.Rows.Count < value)
                {
                    dataGridView.Rows.Add();
                }
                else
                {
                    dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1);
                }
            }
        }
    }
}
