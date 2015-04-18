using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Umax.Interfaces.Images;
using System.IO;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Generate.Figures
{
    public partial class GenerateFiguresImageControl : UserControl, IImageControl
    {
        public GenerateFiguresImageControl()
        {
            InitializeComponent();

            this.ImageMaker = new GenerateFiguresImageMaker();

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
                (this.imageMaker as GenerateFiguresImageMaker).Settings = this.CollectSettings();

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
            switch (((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).Names)
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

            nameTextBox.Text = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).NamesFile;

            switch (((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).Number)
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

            numberMinNumericUpDown.Value = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).NumberMin;
            numberMaxNumericUpDown.Value = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).NumberMax;

            numberFiguresMinNumericUpDown.Value = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).FiguresNumberMin;
            numberFiguresMaxNumericUpDown.Value = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).FiguresNumberMax;

            sizeHeigthMinNumericUpDown.Value = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).HeightMin;
            sizeHeigthMaxNumericUpDown.Value = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).HeightMax;

            sizeWidthMinNumericUpDown.Value = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).WidthMin;
            sizeWidthMaxNumericUpDown.Value = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).WidthMax;

            figuresCompleteColorSelectControl.Settings = ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).FiguresColorSettings;

            // Background
            backgroundCompleteColorSelectControl.Settings =
                ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).BackgroundColorSettings;

            modificationsNoiseCheckBox.Checked =
                ((this.imageMaker as GenerateFiguresImageMaker).Settings as GenerateFiguresImageSettings).
                    ModificationsNoise;
        }

        private GenerateFiguresImageSettings CollectSettings()
        {
            GenerateFiguresImageSettings settings = new GenerateFiguresImageSettings();

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

            settings.NumberMin = (int)numberMinNumericUpDown.Value;
            settings.NumberMax = (int)numberMaxNumericUpDown.Value;

            settings.FiguresNumberMin = (int) numberFiguresMinNumericUpDown.Value;
            settings.FiguresNumberMax = (int) numberFiguresMaxNumericUpDown.Value;

            settings.FiguresColorSettings = figuresCompleteColorSelectControl.Settings;

            // Background
            settings.BackgroundColorSettings = backgroundCompleteColorSelectControl.Settings;

            settings.ModificationsNoise = modificationsNoiseCheckBox.Checked;

            return settings;
        }

        public object NewInstance()
        {
            return new GenerateFiguresImageControl();
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
