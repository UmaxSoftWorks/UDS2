using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Umax.Classes.Enums;
using Umax.Interfaces.Images;
using System.IO;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Generate.Text
{
    public partial class GenerateTextImageControl : UserControl, IImageControl
    {
        public GenerateTextImageControl()
        {
            InitializeComponent();

            this.ImageMaker = new GenerateTextImageMaker();

        }

        private IImageMaker imageMaker;
        public virtual IImageMaker ImageMaker
        {
            get
            {
                if (this.imageMaker == null)
                {
                    return null;
                }

                // Validate settings
                this.ValidateSettings();

                // Collect settings
                (this.imageMaker as GenerateTextImageMaker).Settings = this.CollectSettings();

                return this.imageMaker;
            }

            set
            {
                this.imageMaker = value;
                this.ApplySettings();
            }
        }

        private void ValidateSettings()
        {
            if (nameComboBox.SelectedIndex == 2 || nameComboBox.SelectedIndex == 3)
            {
                if (nameTextBox.Text == string.Empty || !File.Exists(nameTextBox.Text))
                {
                    throw new Exception("Please specify image names file!");
                }
            }

            if (textTextBox.Text == string.Empty || !File.Exists(textTextBox.Text))
            {
                throw new Exception("Please specify text file!");
            }
        }

        private void ApplySettings()
        {
            switch (((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).Names)
            {
                    // Random
                case NameType.Random:
                    {
                        nameComboBox.SelectedIndex = 0;
                        break;
                    }

                    // Keyword
                case NameType.Keyword:
                    {
                        nameComboBox.SelectedIndex = 1;
                        break;
                    }

                    // Keyword -> En
                case NameType.KeywordToEn:
                    {
                        nameComboBox.SelectedIndex = 2;
                        break;
                    }

                    // From file
                case NameType.FromFile:
                    {
                        nameComboBox.SelectedIndex = 3;
                        break;
                    }

                    // From file -> En
                case NameType.FromFileToEn:
                    {
                        nameComboBox.SelectedIndex = 4;
                        break;
                    }
            }

            nameTextBox.Text = ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).NamesFile;

            switch (((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).StringSelect)
            {
                case StringSelectType.Word:
                    {
                        textComboBox.SelectedIndex = 0;
                        break;
                    }

                case StringSelectType.Sentense:
                    {
                        textComboBox.SelectedIndex = 1;
                        break;
                    }

                case StringSelectType.Line:
                    {
                        textComboBox.SelectedIndex = 2;
                        break;
                    }

                case StringSelectType.Phrase:
                    {
                        textComboBox.SelectedIndex = 3;
                        break;
                    }
            }

            textTextBox.Text = ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).TextFile;

            switch (((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).Number)
            {
                case NumberType.All:
                    {
                        numberComboBox.SelectedIndex = 0;
                        break;
                    }

                case NumberType.Limited:
                    {
                        numberComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            numberMinNumericUpDown.Value = ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).NumberMin;
            numberMaxNumericUpDown.Value = ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).NumberMax;

            sizeHeigthMinNumericUpDown.Value = ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).HeightMin;
            sizeHeigthMaxNumericUpDown.Value = ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).HeightMax;

            sizeWidthMinNumericUpDown.Value = ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).WidthMin;
            sizeWidthMaxNumericUpDown.Value = ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).WidthMax;

            fontSelectControl.Settings =
                ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).Font;

            // Background
            backgroundCompleteColorSelectControl.Settings =
                ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).BackgroundColorSettings;

            modificationsNoiseCheckBox.Checked =
                ((this.imageMaker as GenerateTextImageMaker).Settings as GenerateTextImageSettings).
                    ModificationsNoise;
        }

        private GenerateTextImageSettings CollectSettings()
        {
            GenerateTextImageSettings settings = new GenerateTextImageSettings();

            switch (nameComboBox.SelectedIndex)
            {
                    // Random
                case 0:
                    {
                        settings.Names = NameType.Random;
                        break;
                    }

                    // Keyword
                case 1:
                    {
                        settings.Names = NameType.Keyword;
                        break;
                    }

                    // Keyword -> En
                case 2:
                    {
                        settings.Names = NameType.KeywordToEn;
                        break;
                    }

                    // From file
                case 3:
                    {
                        settings.Names = NameType.FromFile;
                        break;
                    }

                    // From file -> En
                case 4:
                    {
                        settings.Names = NameType.FromFileToEn;
                        break;
                    }
            }

            settings.NamesFile = nameTextBox.Text;

            switch (textComboBox.SelectedIndex)
            {
                case 0:
                    {
                        settings.StringSelect = StringSelectType.Word;
                        break;
                    }

                case 1:
                    {
                        settings.StringSelect = StringSelectType.Sentense;
                        break;
                    }

                case 2:
                    {
                        settings.StringSelect = StringSelectType.Line;
                        break;
                    }

                case 3:
                    {
                        settings.StringSelect = StringSelectType.Phrase;
                        break;
                    }
            }

            settings.TextFile = textTextBox.Text;

            switch (numberComboBox.SelectedIndex)
            {
                // All
                case 0:
                    {
                        settings.Number = NumberType.All;
                        break;
                    }

                // Limited
                case 1:
                    {
                        settings.Number = NumberType.Limited;
                        break;
                    }
            }

            settings.NumberMin = (int)numberMinNumericUpDown.Value;
            settings.NumberMax = (int)numberMaxNumericUpDown.Value;

            settings.HeightMin = (int) sizeHeigthMinNumericUpDown.Value;
            settings.HeightMax = (int) sizeHeigthMaxNumericUpDown.Value;

            settings.WidthMin = (int) sizeWidthMinNumericUpDown.Value;
            settings.WidthMax = (int) sizeWidthMaxNumericUpDown.Value;

            settings.Font = fontSelectControl.Settings;

            // Background
            settings.BackgroundColorSettings = backgroundCompleteColorSelectControl.Settings;

            settings.ModificationsNoise = modificationsNoiseCheckBox.Checked;

            return settings;
        }

        public object NewInstance()
        {
            return new GenerateTextImageControl();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            nameTextBox.Text = mainOpenFileDialog.FileName;
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (nameComboBox.SelectedIndex)
            {
                // Random
                case 0:
                // Keyword
                case 1:
                // Keyword -> En
                case 2:
                    {
                        nameTextBox.Enabled = false;
                        nameButton.Enabled = false;
                        break;
                    }

                // From file
                case 3:
                // From file -> En
                case 4:
                    {
                        nameTextBox.Enabled = true;
                        nameButton.Enabled = true;
                        break;
                    }
            }
        }

        private void GenerateTextImageControl_Load(object sender, EventArgs e)
        {
        }

        private void textButton_Click(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            textTextBox.Text = mainOpenFileDialog.FileName;
        }

        private void numberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (numberComboBox.SelectedIndex)
            {
                // All
                case 0:
                    {
                        numberMinNumericUpDown.Enabled = false;
                        numberMaxNumericUpDown.Enabled = false;
                        break;
                    }

                // Limited
                case 1:
                    {
                        numberMinNumericUpDown.Enabled = true;
                        numberMaxNumericUpDown.Enabled = true;
                        break;
                    }
            }
        }
    }
}
