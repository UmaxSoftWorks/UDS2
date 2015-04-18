using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Umax.Interfaces.Images;
using System.IO;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Generate.Keyword
{
    public partial class GenerateKeywordImageControl : UserControl, IImageControl
    {
        public GenerateKeywordImageControl()
        {
            InitializeComponent();

            this.ImageMaker = new GenerateKeywordImageMaker();
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
                (this.imageMaker as GenerateKeywordImageMaker).Settings = this.CollectSettings();

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
                if (!File.Exists(nameTextBox.Text))
                {
                    throw new Exception("Please specify image names file!");
                }
            }
        }

        private void ApplySettings()
        {
            switch (((this.imageMaker as GenerateKeywordImageMaker).Settings as GenerateKeywordImageSettings).Names)
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

            nameTextBox.Text = ((this.imageMaker as GenerateKeywordImageMaker).Settings as GenerateKeywordImageSettings).NamesFile;

            sizeHeigthMinNumericUpDown.Value = ((this.imageMaker as GenerateKeywordImageMaker).Settings as GenerateKeywordImageSettings).HeightMin;
            sizeHeigthMaxNumericUpDown.Value = ((this.imageMaker as GenerateKeywordImageMaker).Settings as GenerateKeywordImageSettings).HeightMax;

            sizeWidthMinNumericUpDown.Value = ((this.imageMaker as GenerateKeywordImageMaker).Settings as GenerateKeywordImageSettings).WidthMin;
            sizeWidthMaxNumericUpDown.Value = ((this.imageMaker as GenerateKeywordImageMaker).Settings as GenerateKeywordImageSettings).WidthMax;

            fontSelectControl.Settings = ((this.imageMaker as GenerateKeywordImageMaker).Settings as GenerateKeywordImageSettings).Font;

            // Background
            backgroundCompleteColorSelectControl.Settings =
                ((this.imageMaker as GenerateKeywordImageMaker).Settings as GenerateKeywordImageSettings).BackgroundColorSettings;

            modificationsNoiseCheckBox.Checked =
                ((this.imageMaker as GenerateKeywordImageMaker).Settings as GenerateKeywordImageSettings).
                    ModificationsNoise;
        }

        private GenerateKeywordImageSettings CollectSettings()
        {
            GenerateKeywordImageSettings settings = new GenerateKeywordImageSettings();

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

            settings.HeightMin = (int) sizeHeigthMinNumericUpDown.Value;
            settings.HeightMax = (int) sizeHeigthMaxNumericUpDown.Value;

            settings.WidthMin = (int) sizeWidthMinNumericUpDown.Value;
            settings.WidthMax = (int) sizeWidthMaxNumericUpDown.Value;

            settings.Font =
                fontSelectControl.Settings;

            // Background
            settings.BackgroundColorSettings = backgroundCompleteColorSelectControl.Settings;

            settings.ModificationsNoise = modificationsNoiseCheckBox.Checked;

            return settings;
        }

        public object NewInstance()
        {
            return new GenerateKeywordImageControl();
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

        private void GenerateKeywordImageControl_Load(object sender, EventArgs e)
        {
        }
    }
}
