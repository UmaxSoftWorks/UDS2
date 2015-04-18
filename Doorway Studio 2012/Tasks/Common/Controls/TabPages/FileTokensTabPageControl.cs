using System;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class FileTokensTabPageControl : UserControl
    {
        public FileTokensTabPageControl()
        {
            InitializeComponent();
        }

        protected ITask task;

        /// <summary>
        /// Sets task
        /// </summary>
        public ITask Task
        {
            get { return this.task; }
            set
            {
                this.task = value;

                this.UpdateControl();
            }
        }

        private void editToolStripButtonClick(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                mainOpenFileDialog.FileName = string.Empty;
                mainOpenFileDialog.ShowDialog();
                if (mainOpenFileDialog.FileName == string.Empty)
                {
                    return;
                }

                dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[1].Value = mainOpenFileDialog.FileName;
            }
        }

        protected virtual void addToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            dataGridView.Rows.Add();
            dataGridView.Rows[dataGridView.RowCount - 1].Cells[1].Value = mainOpenFileDialog.FileName;
        }

        protected virtual void removeToolStripButtonClick(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
            }
        }

        protected virtual void clearToolStripButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
        }

        public virtual void ValidateSettings()
        {
            // File tokens
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value == null || dataGridView.Rows[i].Cells[1].Value == null ||
                    dataGridView.Rows[i].Cells[2].Value == null || dataGridView.Rows[i].Cells[3].Value == null)
                {
                    throw new Exception("Please specify File Token!");
                }

                if (string.IsNullOrEmpty(dataGridView.Rows[i].Cells[0].Value.ToString()) ||
                    string.IsNullOrEmpty(dataGridView.Rows[i].Cells[1].Value.ToString()) ||
                    string.IsNullOrEmpty(dataGridView.Rows[i].Cells[2].Value.ToString()) ||
                    string.IsNullOrEmpty(dataGridView.Rows[i].Cells[3].Value.ToString()))
                {
                    throw new Exception("Please specify File Token!");
                }
            }
        }

        public virtual void CollectSettings()
        {
            (this.Task.Executor as TaskSettings).FileTokens.Clear();

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value == null ||
                    dataGridView.Rows[i].Cells[1].Value == null)
                {
                    continue;
                }

                FileToken token = new FileToken
                {
                    Token = dataGridView.Rows[i].Cells[0].Value.ToString(),
                    Path = dataGridView.Rows[i].Cells[1].Value.ToString(),
                    Encoding = dataGridView.Rows[i].Cells[2].Value.ToString() == "ANSI" ? EncodingType.ANSI : EncodingType.UTF8
                };

                switch (dataGridView.Rows[i].Cells[3].Value.ToString())
                {
                    // Random
                    case "Random":
                        {
                            token.Type = FileTokenType.ReadRandomLine;
                            break;
                        }

                    // One by One
                    case "One by One":
                        {
                            token.Type = FileTokenType.ReadLineAfterLine;
                            break;
                        }

                    // One line/Site
                    case "One line/Site":
                        {
                            token.Type = FileTokenType.ReadOneLinePerSite;
                            break;
                        }

                    // Random line/Site
                    case "Random line/Site":
                        {
                            token.Type = FileTokenType.ReadRandomLinePerSite;
                            break;
                        }
                }

                (this.Task.Executor as TaskSettings).FileTokens.Add(token);
            }
        }

        private void FileTokensTabPageControlLoad(object sender, EventArgs e)
        {
            addToolStripButton.Image = Resources.Resources.PlusBlue;
            removeToolStripButton.Image = Resources.Resources.MinusBlue;
            editToolStripButton.Image = Resources.Resources.Gears;
            clearToolStripButton.Image = Resources.Resources.Delete;
        }

        private void UpdateControl()
        {
            for (int i = 0; i < (this.Task.Executor.Settings as TaskSettings).FileTokens.Count; i++)
            {
                // Encoding
                string encoding = "ANSI";
                if ((this.Task.Executor.Settings as TaskSettings).FileTokens[i].Encoding == EncodingType.UTF8)
                {
                    encoding = "UTF-8";
                }

                // Type
                string type = string.Empty;
                switch ((this.Task.Executor.Settings as TaskSettings).FileTokens[i].Type)
                {
                    // Random line
                    case FileTokenType.ReadRandomLine:
                        {
                            type = "Random line";
                            break;
                        }

                    // Line after line
                    case FileTokenType.ReadLineAfterLine:
                        {
                            type = "Line after line";
                            break;
                        }

                    // One line/Site
                    case FileTokenType.ReadOneLinePerSite:
                        {
                            type = "One line/Site";
                            break;
                        }

                    // Random line/Site
                    case FileTokenType.ReadRandomLinePerSite:
                        {
                            type = "Random line/Site";
                            break;
                        }
                }

                dataGridView.Rows.Add((this.Task.Executor.Settings as TaskSettings).FileTokens[i].Token, (this.Task.Executor.Settings as TaskSettings).FileTokens[i].Path, encoding, type);
            }
        }
    }
}