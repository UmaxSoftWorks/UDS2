using System;
using System.IO;
using System.Windows.Forms;
using Umax.Classes.Enums;
using Umax.Interfaces.Compatibility.ID;
using Umax.Interfaces.Compatibility.Images;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Images;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Modify.Text
{
    public partial class ModifyTextImageControl : UserControl, IImageControl, IImageDataCompatible, IImageIDCompatible
    {
        public ModifyTextImageControl()
        {
            InitializeComponent();

            this.ImageMaker = new ModifyTextImageMaker();
        }

        private IEventedList<IImage> imageData;
        public IEventedList<IImage> ImageData
        {
            get { return this.imageData; }
            set
            {
                this.imageData = value;
                this.UpdateImageControls();
            }
        }

        public int ImageID
        {
            get
            {
                if (this.ImageData == null)
                {
                    return -1;
                }

                // External location
                if (locationComboBox.SelectedIndex == 1)
                {
                    return -1;
                }

                if (imagesComboBox.SelectedIndex < this.ImageData.Count)
                {
                    return this.ImageData[imagesComboBox.SelectedIndex].ID;
                }

                return -1;
            }

            set
            {
                // External location
                if (locationComboBox.SelectedIndex == 1)
                {
                    imagesComboBox.SelectedIndex = -1;
                }

                if (this.ImageData != null)
                {
                    for (int i = 0; i < this.ImageData.Count; i++)
                    {
                        if (this.ImageData[i].ID == value)
                        {
                            imagesComboBox.SelectedIndex = i;
                            return;
                        }
                    }
                }

                imagesComboBox.SelectedIndex = -1;
            }
        }

        protected virtual void UpdateImageControls()
        {
            imagesComboBox.Items.Clear();
            if (this.ImageData == null)
            {
                return;
            }

            for (int i = 0; i < this.ImageData.Count; i++)
            {
                imagesComboBox.Items.Add(this.ImageData[i].Name);
            }
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
                (this.imageMaker as ModifyTextImageMaker).Settings = this.CollectSettings();

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
            switch (locationComboBox.SelectedIndex)
            {
                // Internal
                case 0:
                    {
                        if (this.ImageID == -1)
                        {
                            throw new Exception("Please select Images!");
                        }
                        break;
                    }

                // External
                case 1:
                    {
                        if (locationTextBox.Text == string.Empty)
                        {
                            throw new Exception("Please specify Images Location!");
                        }
                        break;
                    }
            }

            if (renameComboBox.SelectedIndex == 5 || renameComboBox.SelectedIndex == 6)
            {
                if (!File.Exists(renameTextBox.Text))
                {
                    throw new Exception("Please specify image names file!");
                }
            }
        }

        private void ApplySettings()
        {
            switch (((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).Location)
            {
                case LocationType.Internal:
                    {
                        locationComboBox.SelectedIndex = 0;
                        break;
                    }

                case LocationType.External:
                    {
                        locationComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            locationTextBox.Text = ((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).LocationPath;

            this.ImageID = ((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).ImageID;

            switch (((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).Rename)
            {
                // Random
                case RenameType.Random:
                    {
                        renameComboBox.SelectedIndex = 0;
                        break;
                    }

                // Name
                case RenameType.Name:
                    {
                        renameComboBox.SelectedIndex = 1;
                        break;
                    }

                // Name -> En
                case RenameType.NameToEn:
                    {
                        renameComboBox.SelectedIndex = 2;
                        break;
                    }

                case RenameType.Keyword:
                    {
                        renameComboBox.SelectedIndex = 3;
                        break;
                    }

                case RenameType.KeywordToEn:
                    {
                        renameComboBox.SelectedIndex = 4;
                        break;
                    }

                // From file
                case RenameType.FromFile:
                    {
                        renameComboBox.SelectedIndex = 5;
                        break;
                    }

                // From file -> En
                case RenameType.FromFileToEn:
                    {
                        renameComboBox.SelectedIndex = 6;
                        break;
                    }
            }

            renameTextBox.Text = ((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).RenameFile;

            switch (((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).StringSelect)
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

            textTextBox.Text = ((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).TextFile;

            switch (((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).Number)
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

            numberMinNumericUpDown.Value = ((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).NumberMin;
            numberMaxNumericUpDown.Value = ((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).NumberMax;

            fontSelectControl.Settings =
                ((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).Font;


            modificationsImageNoiseCheckBox.Checked =
                ((this.imageMaker as ModifyTextImageMaker).Settings as ModifyTextImageSettings).
                    ModificationsImageNoise;
        }

        private ModifyTextImageSettings CollectSettings()
        {
            ModifyTextImageSettings settings = new ModifyTextImageSettings();

            switch (locationComboBox.SelectedIndex)
            {
                // Internal
                case 0:
                    {
                        settings.Location = LocationType.Internal;
                        break;
                    }

                // External
                case 1:
                    {
                        settings.Location = LocationType.External;
                        break;
                    }
            }

            settings.LocationPath = locationTextBox.Text;

            settings.ImageID = this.ImageID;

            switch (renameComboBox.SelectedIndex)
            {
                // Random
                case 0:
                    {
                        settings.Rename = RenameType.Random;
                        break;
                    }

                // Name
                case 1:
                    {
                        settings.Rename = RenameType.Name;
                        break;
                    }

                // Name -> En
                case 2:
                    {
                        settings.Rename = RenameType.NameToEn;
                        break;
                    }

                // Keyword
                case 3:
                    {
                        settings.Rename = RenameType.Keyword;
                        break;
                    }

                // Keyword -> En
                case 4:
                    {
                        settings.Rename = RenameType.KeywordToEn;
                        break;
                    }

                // From file
                case 5:
                    {
                        settings.Rename = RenameType.FromFile;
                        break;
                    }

                // From file -> En
                case 6:
                    {
                        settings.Rename = RenameType.FromFileToEn;
                        break;
                    }
            }

            settings.RenameFile = renameTextBox.Text;

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

            settings.Font = fontSelectControl.Settings;

            settings.ModificationsImageNoise = modificationsImageNoiseCheckBox.Checked;

            return settings;
        }

        public object NewInstance()
        {
            return new ModifyTextImageControl();
        }

        private void ModifyTextImageControl_Load(object sender, EventArgs e)
        {
            this.UpdateImageControls();
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (locationComboBox.SelectedIndex)
            {
                // Internal
                case 0:
                    {
                        imagesComboBox.Enabled = true;
                        locationTextBox.Enabled = false;
                        locationButton.Enabled = false;
                        break;
                    }

                // External
                case 1:
                    {
                        imagesComboBox.Enabled = false;
                        locationTextBox.Enabled = true;
                        locationButton.Enabled = true;
                        break;
                    }
            }
        }

        private void renameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (renameComboBox.SelectedIndex)
            {

                // Random
                case 0:
                // Name
                case 1:
                // Name -> En
                case 2:
                // Keyword
                case 3:
                // Keyword -> En
                case 4:
                    {
                        renameTextBox.Enabled = false;
                        renameButton.Enabled = false;
                        break;
                    }

                // From file
                case 5:
                // From file -> En
                case 6:
                    {
                        renameTextBox.Enabled = true;
                        renameButton.Enabled = true;
                        break;
                    }
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            renameTextBox.Text = mainOpenFileDialog.FileName;
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            mainFolderBrowserDialog.SelectedPath = string.Empty;
            mainFolderBrowserDialog.ShowDialog();
            if (mainFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }

            locationTextBox.Text = mainFolderBrowserDialog.SelectedPath;
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
    }
}
