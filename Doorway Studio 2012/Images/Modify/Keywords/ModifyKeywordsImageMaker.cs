using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Plugins.Images.Common.DataCompatible;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Helpers;
using IO = System.IO;

namespace Umax.Plugins.Images.Modify.Keywords
{
    public class ModifyKeywordsImageMaker : DataCompatibleImageMaker
    {
        public ModifyKeywordsImageMaker()
        {
            this.Settings = new ModifyKeywordsImageSettings();
        }

        public override string Name
        {
            get { return "ModifyKeywordsImageMaker"; }
        }

        public override string ControlName
        {
            get { return "ModifyKeywordsImageControl"; }
        }

        public override string GUIName
        {
            get { return "Modify: Keywords"; }
        }

        protected override string MakeImage(string Path, List<string> Items)
        {
            // Create directories
            IOHelper.CreateDirectory(Path);

            // Select image
            string originalImagePath = this.Select();

            // HTTP
            if (!originalImagePath.ToLower().StartsWith("http"))
            {
                // File
                if (originalImagePath.Contains("\\Files\\"))
                {
                    string directories = originalImagePath.Substring(originalImagePath.LastIndexOf("\\Files\\") + 7);
                    if (directories.Contains("\\"))
                    {
                        IOHelper.CreateDirectory(IO.Path.Combine(Path, directories));
                    }
                }

                string text = string.Empty;
                for (int i = 0; i < Items.Count; i++)
                {
                    text += Items[i] + "\r\n";
                }

                text = text.Trim(' ', '\r', '\n');

                string imagePath =
                    IO.Path.Combine(Path,
                                    this.MakeFileName(Path, text.Select(StringSelectType.Word, true),
                                                      (this.Settings as ModifyKeywordsImageSettings).Rename)) + ".jpg";
                this.Images.Add(imagePath);

                // Make image
                Image image = Image.FromFile(Path);

                ((Bitmap)image).DrawText(text, (this.Settings as ModifyKeywordsImageSettings).Font);

                if ((this.Settings as ModifyKeywordsImageSettings).ModificationsImageNoise)
                {
                    ((Bitmap)image).DrawNoise();
                }

                image.Save(imagePath);

                originalImagePath = imagePath;
            }

            return originalImagePath;
        }

        protected override MakerStateType Validate()
        {
            base.Validate();

            if ((this.Settings as ModifyKeywordsImageSettings).Rename == RenameType.FromFile || (this.Settings as ModifyKeywordsImageSettings).Rename == RenameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as ModifyKeywordsImageSettings).RenameFile))
                {
                    throw new Exception("File with names not found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as ModifyKeywordsImageSettings).RenameFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }

        public override object NewInstance()
        {
            return new ModifyKeywordsImageMaker();
        }
    }
}
