using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Umax.Interfaces.Compatibility.ID;
using Umax.Interfaces.Compatibility.Images;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Images;
using System.IO;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Modify.Keywords
{
    public partial class ModifyKeywordsImageControl : UserControl, IImageControl, IImageDataCompatible, IImageIDCompatible
    {
        public ModifyKeywordsImageControl()
        {
            InitializeComponent();

            this.ImageMaker = new ModifyKeywordsImageMaker();
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
                (this.imageMaker as ModifyKeywordsImageMaker).Settings = this.CollectSettings();

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
            switch (((this.imageMaker as ModifyKeywordsImageMaker).Settings as ModifyKeywordsImageSettings).Location)
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

            locationTextBox.Text = ((this.imageMaker as ModifyKeywordsImageMaker).Settings as ModifyKeywordsImageSettings).LocationPath;

            this.ImageID = ((this.imageMaker as ModifyKeywordsImageMaker).Settings as ModifyKeywordsImageSettings).ImageID;

            switch (((this.imageMaker as ModifyKeywordsImageMaker).Settings as ModifyKeywordsImageSettings).Rename)
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

            renameTextBox.Text = ((this.imageMaker as ModifyKeywordsImageMaker).Settings as ModifyKeywordsImageSettings).RenameFile;

            fontSelectControl.Settings =
                ((this.imageMaker as ModifyKeywordsImageMaker).Settings as ModifyKeywordsImageSettings).Font;


            modificationsNoiseCheckBox.Checked =
                ((this.imageMaker as ModifyKeywordsImageMaker).Settings as ModifyKeywordsImageSettings).
                    ModificationsImageNoise;
        }

        private ModifyKeywordsImageSettings CollectSettings()
        {
            ModifyKeywordsImageSettings settings = new ModifyKeywordsImageSettings();

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

            settings.Font = fontSelectControl.Settings;

            settings.ModificationsImageNoise = modificationsNoiseCheckBox.Checked;

            return settings;
        }

        public object NewInstance()
        {
            return new ModifyKeywordsImageControl();
        }


        private void ModifyKeywordImageControl_Load(object sender, EventArgs e)
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
    }
}
