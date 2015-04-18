using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Tasks;
using Umax.Plugins.Tasks.Enums;
using IO = System.IO;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class TokensTabPageControl : UserControl
    {
        public TokensTabPageControl()
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

        public virtual void CollectSettings()
        {
            switch (mainLinkComboBox.SelectedIndex)
            {
                    // Full URL
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).TokenMainLink = TokenMainLinkType.FullURL;
                        break;
                    }

                    // /
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).TokenMainLink = TokenMainLinkType.Slash;
                        break;
                    }

                    // index
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).TokenMainLink = TokenMainLinkType.Index;
                        break;
                    }

                    // Other
                case 3:
                    {
                        (this.Task.Executor.Settings as TaskSettings).TokenMainLink = TokenMainLinkType.Other;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).TokenMainLinks = new List<string>();
            for (int i = 0; i < mainLinkDataGridView.RowCount; i++)
            {
                (this.Task.Executor.Settings as TaskSettings).TokenMainLinks.Add(mainLinkDataGridView.Rows[i].Cells[0].Value == null
                                                                                     ? string.Empty
                                                                                     : mainLinkDataGridView.Rows[i].Cells[0].Value.ToString());
            }

            (this.Task.Executor.Settings as TaskSettings).TokenTitle = new List<string>();
            for (int i = 0; i < titleDataGridView.RowCount; i++)
            {
                (this.Task.Executor.Settings as TaskSettings).TokenTitle.Add(titleDataGridView.Rows[i].Cells[0].Value == null
                                                                                 ? string.Empty
                                                                                 : titleDataGridView.Rows[i].Cells[0].Value.ToString());
            }

            (this.Task.Executor.Settings as TaskSettings).TokenSite = new List<string>();
            for (int i = 0; i < siteDataGridView.RowCount; i++)
            {
                (this.Task.Executor.Settings as TaskSettings).TokenSite.Add(siteDataGridView.Rows[i].Cells[0].Value == null
                                                                                ? string.Empty
                                                                                : siteDataGridView.Rows[i].Cells[0].Value.ToString());
            }

            (this.Task.Executor.Settings as TaskSettings).TokenCounter = new List<string>();
            for (int i = 0; i < counterDataGridView.RowCount; i++)
            {
                (this.Task.Executor.Settings as TaskSettings).TokenCounter.Add(counterDataGridView.Rows[i].Cells[0].Value == null
                                                                                   ? string.Empty
                                                                                   : counterDataGridView.Rows[i].Cells[0].Value.ToString());
            }

            (this.Task.Executor.Settings as TaskSettings).TokenInternalLinks = new List<string>();
            for (int i = 0; i < internalLinksDataGridView.RowCount; i++)
            {
                (this.Task.Executor.Settings as TaskSettings).TokenInternalLinks.Add(internalLinksDataGridView.Rows[i].Cells[0].Value == null
                                                                                         ? string.Empty
                                                                                         : internalLinksDataGridView.Rows[i].Cells[0].Value.ToString());
            }

            (this.Task.Executor.Settings as TaskSettings).TokenExternalLinks = new List<string[]>();
            for (int i = 0; i < externalLinksDataGridView.RowCount; i++)
            {
                (this.Task.Executor.Settings as TaskSettings).TokenExternalLinks.Add(
                    new string[]
                        {
                            externalLinksDataGridView.Rows[i].Cells[0].Value == null
                                ? string.Empty
                                : externalLinksDataGridView.Rows[i].Cells[0].Value.ToString(),
                            externalLinksDataGridView.Rows[i].Cells[1].Value == null
                                ? string.Empty
                                : externalLinksDataGridView.Rows[i].Cells[1].Value.ToString(),
                        });
            }
        }

        protected virtual void mainLinkComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainLinkComboBox.SelectedIndex == 3)
            {
                mainLinkDataGridView.Enabled = true;
            }
            else
            {
                mainLinkDataGridView.Enabled = false;
            }
        }

        protected virtual void externalLinksAddToolStripButtonClick(object sender, EventArgs e)
        {
            externalLinksDataGridView.Rows.Add();
        }

        protected virtual void externalLinksRemoveToolStripButtonClick(object sender, EventArgs e)
        {
            if (externalLinksDataGridView.SelectedRows.Count > 0)
            {
                externalLinksDataGridView.Rows.RemoveAt(externalLinksDataGridView.SelectedRows[0].Index);
            }
        }

        protected virtual void externalLinksClearToolStripButtonClick(object sender, EventArgs e)
        {
            externalLinksDataGridView.Rows.Clear();
        }

        public int SitesCount
        {
            set
            {
                if (mainLinkDataGridView.Rows.Count < value)
                {
                    mainLinkDataGridView.Rows.Add();
                    titleDataGridView.Rows.Add();
                    siteDataGridView.Rows.Add();
                    counterDataGridView.Rows.Add();
                    internalLinksDataGridView.Rows.Add();
                }
                else
                {
                    mainLinkDataGridView.Rows.RemoveAt(mainLinkDataGridView.Rows.Count - 1);
                    titleDataGridView.Rows.RemoveAt(titleDataGridView.Rows.Count - 1);
                    siteDataGridView.Rows.RemoveAt(siteDataGridView.Rows.Count - 1);
                    counterDataGridView.Rows.RemoveAt(counterDataGridView.Rows.Count - 1);
                    internalLinksDataGridView.Rows.RemoveAt(internalLinksDataGridView.Rows.Count - 1);
                }
            }
        }

        private void TokensTabPageControlLoad(object sender, EventArgs e)
        {
            mainLinkOpenToolStripButton.Image = Umax.Resources.Resources.Folder;
            mainLinkClearToolStripButton.Image = Umax.Resources.Resources.Delete;

            titleOpenToolStripButton.Image = Umax.Resources.Resources.Folder;
            titleClearToolStripButton.Image = Umax.Resources.Resources.Delete;

            siteOpenToolStripButton.Image = Umax.Resources.Resources.Folder;
            siteClearToolStripButton.Image = Umax.Resources.Resources.Delete;

            counterOpenToolStripButton.Image = Umax.Resources.Resources.Folder;
            counterClearToolStripButton.Image = Umax.Resources.Resources.Delete;

            internalLinksOpenToolStripButton.Image = Umax.Resources.Resources.Folder;
            internalLinksClearToolStripButton.Image = Umax.Resources.Resources.Delete;

            externalLinksAddToolStripButton.Image = Umax.Resources.Resources.PlusBlue;
            externalLinksRemoveToolStripButton.Image = Umax.Resources.Resources.MinusBlue;
            externalLinksOpenToolStripButton.Image = Umax.Resources.Resources.Folder;
            externalLinksClearToolStripButton.Image = Umax.Resources.Resources.Delete;
        }

        private void externalLinksOpenToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            string[] items = IO.File.ReadAllLines(mainOpenFileDialog.FileName, Encoding.Default);

            externalLinksDataGridView.Rows.Clear();

            for (int i = 0; i < items.Length; i++)
            {
                externalLinksDataGridView.Rows.Add(items[i]);
            }
        }

        private void internalLinksOpenToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            string[] items = IO.File.ReadAllLines(mainOpenFileDialog.FileName, Encoding.Default);

            for (int i = 0; i < internalLinksDataGridView.Rows.Count; i++)
            {
                if (i < items.Length)
                {
                    internalLinksDataGridView.Rows[i].Cells[0].Value = items[i];
                }
                else
                {
                    break;
                }
            }
        }

        private void internalLinksClearToolStripButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < internalLinksDataGridView.Rows.Count; i++)
            {
                internalLinksDataGridView.Rows[i].Cells[0].Value = string.Empty;
            }
        }

        private void counterOpenToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            string[] items = IO.File.ReadAllLines(mainOpenFileDialog.FileName, Encoding.Default);


            for (int i = 0; i < counterDataGridView.Rows.Count; i++)
            {
                if (i < items.Length)
                {
                    counterDataGridView.Rows[i].Cells[0].Value = items[i];
                }
                else
                {
                    break;
                }
            }
        }

        private void counterClearToolStripButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < counterDataGridView.Rows.Count; i++)
            {
                counterDataGridView.Rows[i].Cells[0].Value = string.Empty;
            }
        }

        private void siteClearToolStripButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < siteDataGridView.Rows.Count; i++)
            {
                siteDataGridView.Rows[i].Cells[0].Value = string.Empty;
            }
        }

        private void siteOpenToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            string[] items = IO.File.ReadAllLines(mainOpenFileDialog.FileName, Encoding.Default);


            for (int i = 0; i < siteDataGridView.Rows.Count; i++)
            {
                if (i < items.Length)
                {
                    siteDataGridView.Rows[i].Cells[0].Value = items[i];
                }
                else
                {
                    break;
                }
            }
        }

        private void titleClearToolStripButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < titleDataGridView.Rows.Count; i++)
            {
                titleDataGridView.Rows[i].Cells[0].Value = string.Empty;
            }
        }

        private void titleOpenToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            string[] items = IO.File.ReadAllLines(mainOpenFileDialog.FileName, Encoding.Default);


            for (int i = 0; i < titleDataGridView.Rows.Count; i++)
            {
                if (i < items.Length)
                {
                    titleDataGridView.Rows[i].Cells[0].Value = items[i];
                }
                else
                {
                    break;
                }
            }
        }

        private void mainLinkOpenToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            string[] items = IO.File.ReadAllLines(mainOpenFileDialog.FileName, Encoding.Default);

            for (int i = 0; i < mainLinkDataGridView.Rows.Count; i++)
            {
                if (i < items.Length)
                {
                    mainLinkDataGridView.Rows[i].Cells[0].Value = items[i];
                }
                else
                {
                    break;
                }
            }
        }

        private void mainLinkClearToolStripButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < mainLinkDataGridView.Rows.Count; i++)
            {
                mainLinkDataGridView.Rows[i].Cells[0].Value = string.Empty;
            }
        }

        private void UpdateControl()
        {
            switch ((this.Task.Executor.Settings as TaskSettings).TokenMainLink)
            {
                case TokenMainLinkType.FullURL:
                    {
                        mainLinkComboBox.SelectedIndex = 0;
                        break;
                    }

                case TokenMainLinkType.Slash:
                    {
                        mainLinkComboBox.SelectedIndex = 1;
                        break;
                    }

                case TokenMainLinkType.Index:
                    {
                        mainLinkComboBox.SelectedIndex = 2;
                        break;
                    }

                case TokenMainLinkType.Other:
                    {
                        mainLinkComboBox.SelectedIndex = 3;
                        break;
                    }
            }

            if (mainLinkComboBox.SelectedIndex == 3)
            {
                for (int i = 0; i < (this.Task.Executor.Settings as TaskSettings).TokenMainLinks.Count; i++)
                {
                    mainLinkDataGridView.Rows.Add((this.Task.Executor.Settings as TaskSettings).TokenMainLinks[i]);
                }
            }

            for (int i = 0; i < (this.Task.Executor.Settings as TaskSettings).TokenTitle.Count; i++)
            {
                titleDataGridView.Rows.Add((this.Task.Executor.Settings as TaskSettings).TokenTitle[i]);
            }

            for (int i = 0; i < (this.Task.Executor.Settings as TaskSettings).TokenSite.Count; i++)
            {
                siteDataGridView.Rows.Add((this.Task.Executor.Settings as TaskSettings).TokenSite[i]);
            }

            for (int i = 0; i < (this.Task.Executor.Settings as TaskSettings).TokenSite.Count; i++)
            {
                counterDataGridView.Rows.Add((this.Task.Executor.Settings as TaskSettings).TokenCounter[i]);
            }

            for (int i = 0; i < (this.Task.Executor.Settings as TaskSettings).TokenInternalLinks.Count; i++)
            {
                internalLinksDataGridView.Rows.Add((this.Task.Executor.Settings as TaskSettings).TokenInternalLinks[i]);
            }

            for (int i = 0; i < (this.Task.Executor.Settings as TaskSettings).TokenExternalLinks.Count; i++)
            {
                externalLinksDataGridView.Rows.Add((this.Task.Executor.Settings as TaskSettings).TokenExternalLinks[i]);
            }
        }
    }
}
