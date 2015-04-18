using System;
using System.Windows.Forms;
using Umax.Interfaces.Images;
using System.IO;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Generate.Captcha
{
    public partial class GenerateCaptchaImageControl : UserControl, IImageControl
    {
        public GenerateCaptchaImageControl()
        {
            InitializeComponent();

            this.ImageMaker = new GenerateCaptchaImageMaker();
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
                (this.imageMaker as GenerateCaptchaImageMaker).Settings = this.CollectSettings();

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
            switch (((this.imageMaker as GenerateCaptchaImageMaker).Settings as GenerateCaptchaImageSettings).Names)
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

            nameTextBox.Text = ((this.imageMaker as GenerateCaptchaImageMaker).Settings as GenerateCaptchaImageSettings).NamesFile;

            switch (((this.imageMaker as GenerateCaptchaImageMaker).Settings as GenerateCaptchaImageSettings).Number)
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

            numberMinNumericUpDown.Value = ((this.imageMaker as GenerateCaptchaImageMaker).Settings as GenerateCaptchaImageSettings).NumberMin;
            numberMaxNumericUpDown.Value = ((this.imageMaker as GenerateCaptchaImageMaker).Settings as GenerateCaptchaImageSettings).NumberMax;

            sizeHeigthMinNumericUpDown.Value = ((this.imageMaker as GenerateCaptchaImageMaker).Settings as GenerateCaptchaImageSettings).HeightMin;
            sizeHeigthMaxNumericUpDown.Value = ((this.imageMaker as GenerateCaptchaImageMaker).Settings as GenerateCaptchaImageSettings).HeightMax;

            sizeWidthMinNumericUpDown.Value = ((this.imageMaker as GenerateCaptchaImageMaker).Settings as GenerateCaptchaImageSettings).WidthMin;
            sizeWidthMaxNumericUpDown.Value = ((this.imageMaker as GenerateCaptchaImageMaker).Settings as GenerateCaptchaImageSettings).WidthMax;
        }

        private GenerateCaptchaImageSettings CollectSettings()
        {
            GenerateCaptchaImageSettings settings = new GenerateCaptchaImageSettings();

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

            switch (numberComboBox.SelectedIndex)
            {
                case 0:
                    {
                        settings.Number = NumberType.All;
                        break;
                    }

                case 1:
                    {
                        settings.Number = NumberType.Limited;
                        break;
                    }
            }

            settings.NumberMin = (int) numberMinNumericUpDown.Value;
            settings.NumberMax = (int) numberMaxNumericUpDown.Value;

            settings.HeightMin = (int) sizeHeigthMinNumericUpDown.Value;
            settings.HeightMax = (int) sizeHeigthMaxNumericUpDown.Value;

            settings.WidthMin = (int) sizeWidthMinNumericUpDown.Value;
            settings.WidthMax = (int) sizeWidthMaxNumericUpDown.Value;

            return settings;
        }

        public object NewInstance()
        {
            return new GenerateCaptchaImageControl();
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
