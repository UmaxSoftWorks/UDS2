using System;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Plugins.Tasks.Enums;
using Umax.Windows.Classes;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class KeywordsTabPageControl : UserControl
    {
        public KeywordsTabPageControl()
        {
            InitializeComponent();
        }

        protected ITask task;

        /// <summary>
        /// Sets task executor
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

        private IWorkSpace workSpace;
        public IWorkSpace WorkSpace
        {
            protected get { return this.workSpace; }
            set
            {
                this.workSpace = value;

                generalKeywordsComboBox.Items.Clear();
                synonymsKeywordsComboBox.Items.Clear();
                mergeKeywordsComboBox.Items.Clear();
                for (int i = 0; i < this.WorkSpace.Keywords.Count; i++)
                {
                    generalKeywordsComboBox.Items.Add(new IDElement(this.WorkSpace.Keywords[i].ID, this.WorkSpace.Keywords[i].Name));
                    synonymsKeywordsComboBox.Items.Add(new IDElement(this.WorkSpace.Keywords[i].ID, this.WorkSpace.Keywords[i].Name));
                    mergeKeywordsComboBox.Items.Add(new IDElement(this.WorkSpace.Keywords[i].ID, this.WorkSpace.Keywords[i].Name));
                }
            }
        }


        public virtual void ValidateSettings()
        {
            if (generalKeywordsComboBox.SelectedIndex == -1)
            {
                throw new Exception("Please select Keywords!");
            }

            if (synonymsComboBox.SelectedIndex == 1)
            {
                if (synonymsKeywordsComboBox.SelectedIndex == -1)
                {
                    throw new Exception("Please select Keywords Synonyms!");
                }
            }
            else if (synonymsComboBox.SelectedIndex == 2 && synonymsFileTextBox.Text == string.Empty)
            {
                throw new Exception("Please specify file with Keywords Synonyms!");
            }

            if (mergeComboBox.SelectedIndex == 1)
            {
                if (mergeKeywordsComboBox.SelectedIndex == -1)
                {
                    throw new Exception("Please select Merge Keywords!");
                }
            }
            else if (mergeKeywordsComboBox.SelectedIndex == 2 && mergeFileTextBox.Text == string.Empty)
            {
                throw new Exception("Please specify file with Merge Keywords!");
            }
        }

        public virtual void CollectSettings()
        {
            (this.Task.Executor.Settings as TaskSettings).KeywordsID = (generalKeywordsComboBox.SelectedItem as IDElement).ID;
            switch (generalSelectComboBox.SelectedIndex)
            {
                // All
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsSelect = KeywordsSelectType.All;
                        break;
                    }

                // First
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsSelect = KeywordsSelectType.First;
                        break;
                    }

                // Last
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsSelect = KeywordsSelectType.Last;
                        break;
                    }

                // Random
                case 3:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsSelect = KeywordsSelectType.Random;
                        break;
                    }

                // Successively
                case 4:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsSelect = KeywordsSelectType.OneByOne;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).KeywordsSelectMin = (int)generalSelectMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsSelectMax = (int)generalSelectMaxNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsOnPageMin = (int)pageMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsOnPageMax = (int)pageMaxNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsReorder = reorderCheckBox.Checked;
            (this.Task.Executor.Settings as TaskSettings).KeywordsReorderWords = reorderWordsCheckBox.Checked;
            (this.Task.Executor.Settings as TaskSettings).KeywordsReorderWordsMinPercent = (int)reorderWordsMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsReorderWordsMaxPercent = (int)reorderWordsMaxNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateTwoWords = generateTwoWordsCheckBox.Checked;
            (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateTwoWordsMin = (int)generateTwoWordsMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateTwoWordsMax = (int)generateTwoWordsMaxNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateThreeWords = generateThreeWordsCheckBox.Checked;
            (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateThreeWordsMin = (int)generateThreeWordsMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateThreeWordsMax = (int)generateThreeWordsMaxNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateFourWords = generateFourWordsCheckBox.Checked;
            (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateFourWordsMin = (int)generateFourWordsMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateFourWordsMax = (int)generateFourWordsMaxNumericUpDown.Value;

            switch (synonymsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsSynonyms = KeywordsSynonymsType.None;
                        break;
                    }

                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsSynonyms = KeywordsSynonymsType.Internal;
                        break;
                    }

                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsSynonyms = KeywordsSynonymsType.External;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsID = synonymsKeywordsComboBox.SelectedIndex == -1 ? -1 : (synonymsKeywordsComboBox.SelectedItem as IDElement).ID;


            (this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsFileEncoding = synonymsEncodingComboBox.SelectedIndex == 0 ? EncodingType.ANSI : EncodingType.UTF8;

            (this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsFilePath = synonymsFileTextBox.Text;
            (this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsMinPercent = (int)synonymsMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsMaxPercent = (int)synonymsMaxNumericUpDown.Value;

            switch (mergeComboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsMerge = KeywordsMergeType.None;
                        break;
                    }

                    // Internal
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsMerge = KeywordsMergeType.Internal;
                        break;
                    }

                // External
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsMerge = KeywordsMergeType.External;
                        break;
                    }
            }

            switch (mergeUsageComboBox.SelectedIndex)
            {
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsMergeUsage = KeywordsMergeUsageType.OneToOne;
                        break;
                    }

                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsMergeUsage = KeywordsMergeUsageType.OneToMany;
                        break;
                    }

                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).KeywordsMergeUsage = KeywordsMergeUsageType.OneToAll;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).KeywordsMergeID = mergeKeywordsComboBox.SelectedIndex == -1 ? -1 : (mergeKeywordsComboBox.SelectedItem as IDElement).ID;

            (this.Task.Executor.Settings as TaskSettings).KeywordsMergeFileEncoding = mergeEncodingComboBox.SelectedIndex == 0 ? EncodingType.ANSI : EncodingType.UTF8;

            (this.Task.Executor.Settings as TaskSettings).KeywordsMergeFilePath = mergeFileTextBox.Text;
            (this.Task.Executor.Settings as TaskSettings).KeywordsMergeMin = (int)mergeNMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).KeywordsMergeMax = (int)mergeNMaxNumericUpDown.Value;
        }

        protected virtual void generalSelectComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (generalSelectComboBox.SelectedIndex == 0)
            {
                generalSelectMinNumericUpDown.Enabled = false;
                generalSelectMaxNumericUpDown.Enabled = false;
            }
            else
            {
                generalSelectMinNumericUpDown.Enabled = true;
                generalSelectMaxNumericUpDown.Enabled = true;
            }
        }

        protected virtual void reorderWordsCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            reorderWordsMinNumericUpDown.Enabled = reorderWordsCheckBox.Checked;
            reorderWordsMaxNumericUpDown.Enabled = reorderWordsCheckBox.Checked;
        }

        protected virtual void generateTwoWordsCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            generateTwoWordsMinNumericUpDown.Enabled = generateTwoWordsCheckBox.Checked;
            generateTwoWordsMaxNumericUpDown.Enabled = generateTwoWordsCheckBox.Checked;
        }

        protected virtual void generateThreeWordsCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            generateThreeWordsMinNumericUpDown.Enabled = generateThreeWordsCheckBox.Checked;
            generateThreeWordsMaxNumericUpDown.Enabled = generateThreeWordsCheckBox.Checked;
        }

        protected virtual void generateFourWordsCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            generateFourWordsMinNumericUpDown.Enabled = generateFourWordsCheckBox.Checked;
            generateFourWordsMaxNumericUpDown.Enabled = generateFourWordsCheckBox.Checked;
        }

        protected virtual void synonymsButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            synonymsFileTextBox.Text = mainOpenFileDialog.FileName;
        }

        protected virtual void mergeButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            mergeFileTextBox.Text = mainOpenFileDialog.FileName;
        }

        protected virtual void synonymsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (synonymsComboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        synonymsKeywordsComboBox.Enabled = false;
                        synonymsMinNumericUpDown.Enabled = false;
                        synonymsMaxNumericUpDown.Enabled = false;
                        synonymsFileTextBox.Enabled = false;
                        synonymsButton.Enabled = false;
                        synonymsEncodingComboBox.Enabled = false;
                        break;
                    }

                // Internal
                case 1:
                    {
                        synonymsKeywordsComboBox.Enabled = true;
                        synonymsMinNumericUpDown.Enabled = true;
                        synonymsMaxNumericUpDown.Enabled = true;
                        synonymsFileTextBox.Enabled = false;
                        synonymsButton.Enabled = false;
                        synonymsEncodingComboBox.Enabled = false;
                        break;
                    }

                // External
                case 2:
                    {
                        synonymsKeywordsComboBox.Enabled = false;
                        synonymsMinNumericUpDown.Enabled = true;
                        synonymsMaxNumericUpDown.Enabled = true;
                        synonymsFileTextBox.Enabled = true;
                        synonymsButton.Enabled = true;
                        synonymsEncodingComboBox.Enabled = true;
                        break;
                    }
            }
        }

        protected virtual void mergeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mergeComboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        mergeKeywordsComboBox.Enabled = false;
                        mergeNMinNumericUpDown.Enabled = false;
                        mergeNMaxNumericUpDown.Enabled = false;
                        mergeFileTextBox.Enabled = false;
                        mergeButton.Enabled = false;
                        mergeEncodingComboBox.Enabled = false;
                        break;
                    }

                // Internal
                case 1:
                    {
                        mergeKeywordsComboBox.Enabled = true;
                        mergeNMinNumericUpDown.Enabled = true;
                        mergeNMaxNumericUpDown.Enabled = true;
                        mergeFileTextBox.Enabled = false;
                        mergeButton.Enabled = false;
                        mergeEncodingComboBox.Enabled = false;
                        break;
                    }

                // External
                case 2:
                    {
                        mergeKeywordsComboBox.Enabled = false;
                        mergeNMinNumericUpDown.Enabled = false;
                        mergeNMaxNumericUpDown.Enabled = false;
                        mergeFileTextBox.Enabled = true;
                        mergeButton.Enabled = true;
                        mergeEncodingComboBox.Enabled = true;
                        break;
                    }
            }
        }

        private void UpdateControl()
        {
            // General
            if ((this.Task.Executor.Settings as TaskSettings).WorkSpaceID != -1)
            {
                // Select keywords
                for (int i = 0; i < generalKeywordsComboBox.Items.Count; i++)
                {
                    if ((generalKeywordsComboBox.Items[i] as IDElement).ID == (this.Task.Executor.Settings as TaskSettings).KeywordsID)
                    {
                        generalKeywordsComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }

            switch ((this.Task.Executor.Settings as TaskSettings).KeywordsSelect)
            {
                case KeywordsSelectType.All:
                    {
                        generalSelectComboBox.SelectedIndex = 0;
                        break;
                    }

                case KeywordsSelectType.First:
                    {
                        generalSelectComboBox.SelectedIndex = 1;
                        break;
                    }

                case KeywordsSelectType.Last:
                    {
                        generalSelectComboBox.SelectedIndex = 2;
                        break;
                    }

                case KeywordsSelectType.Random:
                    {
                        generalSelectComboBox.SelectedIndex = 3;
                        break;
                    }

                case KeywordsSelectType.OneByOne:
                    {
                        generalSelectComboBox.SelectedIndex = 4;
                        break;
                    }
            }

            generalSelectMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsSelectMin;
            generalSelectMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsSelectMax;

            // Keywords/page
            pageMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsOnPageMin;
            pageMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsOnPageMax;

            // Reorder
            reorderCheckBox.Checked = (this.Task.Executor.Settings as TaskSettings).KeywordsReorder;
            reorderWordsCheckBox.Checked = (this.Task.Executor.Settings as TaskSettings).KeywordsReorderWords;
            reorderWordsMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsReorderWordsMinPercent;
            reorderWordsMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsReorderWordsMaxPercent;

            // Synonyms
            switch ((this.Task.Executor.Settings as TaskSettings).KeywordsSynonyms)
            {
                case KeywordsSynonymsType.None:
                    {
                        synonymsComboBox.SelectedIndex = 0;
                        break;
                    }

                case KeywordsSynonymsType.Internal:
                    {
                        synonymsComboBox.SelectedIndex = 1;
                        break;
                    }

                case KeywordsSynonymsType.External:
                    {
                        synonymsComboBox.SelectedIndex = 2;
                        break;
                    }
            }

            for (int i = 0; i < synonymsKeywordsComboBox.Items.Count; i++)
            {
                if ((synonymsKeywordsComboBox.Items[i] as IDElement).ID == (this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsID)
                {
                    synonymsKeywordsComboBox.SelectedIndex = i;
                    break;
                }
            }

            synonymsFileTextBox.Text = (this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsFilePath;
            synonymsMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsMinPercent;
            synonymsMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsMaxPercent;
            switch ((this.Task.Executor.Settings as TaskSettings).KeywordsSynonymsFileEncoding)
            {
                case EncodingType.ANSI:
                    {
                        synonymsEncodingComboBox.SelectedIndex = 0;
                        break;
                    }

                case EncodingType.UTF8:
                    {
                        synonymsEncodingComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            // Merge
            switch ((this.Task.Executor.Settings as TaskSettings).KeywordsMerge)
            {
                case KeywordsMergeType.None:
                    {
                        mergeComboBox.SelectedIndex = 0;
                        break;
                    }

                case KeywordsMergeType.Internal:
                    {
                        mergeComboBox.SelectedIndex = 1;
                        break;
                    }

                case KeywordsMergeType.External:
                    {
                        mergeComboBox.SelectedIndex = 2;
                        break;
                    }
            }

            // Merge
            switch ((this.Task.Executor.Settings as TaskSettings).KeywordsMergeUsage)
            {
                case KeywordsMergeUsageType.OneToOne:
                    {
                        mergeUsageComboBox.SelectedIndex = 0;
                        break;
                    }

                case KeywordsMergeUsageType.OneToMany:
                    {
                        mergeUsageComboBox.SelectedIndex = 1;
                        break;
                    }

                case KeywordsMergeUsageType.OneToAll:
                    {
                        mergeUsageComboBox.SelectedIndex = 2;
                        break;
                    }
            }

            for (int i = 0; i < mergeKeywordsComboBox.Items.Count; i++)
            {
                if ((mergeKeywordsComboBox.Items[i] as IDElement).ID == (this.Task.Executor.Settings as TaskSettings).KeywordsMergeID)
                {
                    mergeKeywordsComboBox.SelectedIndex = i;
                    break;
                }
            }

            mergeFileTextBox.Text = (this.Task.Executor.Settings as TaskSettings).KeywordsMergeFilePath;
            mergeNMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsMergeMin;
            mergeNMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsMergeMax;
            switch ((this.Task.Executor.Settings as TaskSettings).KeywordsMergeFileEncoding)
            {
                case EncodingType.ANSI:
                    {
                        mergeEncodingComboBox.SelectedIndex = 0;
                        break;
                    }
                case EncodingType.UTF8:
                    {
                        mergeEncodingComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            // Generation
            generateTwoWordsCheckBox.Checked = (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateTwoWords;
            generateTwoWordsMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateTwoWordsMin;
            generateTwoWordsMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateTwoWordsMax;
            generateThreeWordsCheckBox.Checked = (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateThreeWords;
            generateThreeWordsMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateThreeWordsMin;
            generateThreeWordsMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateThreeWordsMax;
            generateFourWordsCheckBox.Checked = (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateFourWords;
            generateFourWordsMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateFourWordsMin;
            generateFourWordsMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).KeywordsGenerateFourWordsMax;
        }
    }
}