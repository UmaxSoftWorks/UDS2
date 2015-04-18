using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Plugins.Images.Common.DataCompatible;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Helpers;
using IO = System.IO;

namespace Umax.Plugins.Images.Modify.Keyword
{
    public class ModifyKeywordImageMaker : DataCompatibleImageMaker
    {
        public ModifyKeywordImageMaker()
        {
            this.Settings = new ModifyKeywordImageSettings();
        }

        public override string Name
        {
            get { return "ModifyKeywordImageMaker"; }
        }

        public override string ControlName
        {
            get { return "ModifyKeywordImageControl"; }
        }

        public override string GUIName
        {
            get { return "Modify: Keyword"; }
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

                string keyword = Items[this.Random.Next(Items.Count)];

                string imagePath =
                    IO.Path.Combine(Path,
                                    this.MakeFileName(Path, keyword,
                                                      (this.Settings as ModifyKeywordImageSettings).Rename)) + ".jpg";
                this.Images.Add(imagePath);

                // Make image
                Image image = Image.FromFile(Path);

                ((Bitmap)image).DrawText(keyword, (this.Settings as ModifyKeywordImageSettings).Font);

                if ((this.Settings as ModifyKeywordImageSettings).ModificationsImageNoise)
                {
                    ((Bitmap) image).DrawNoise();
                }

                image.Save(imagePath);

                originalImagePath = imagePath;
            }

            return originalImagePath;
        }

        protected override MakerStateType Validate()
        {
            base.Validate();

            if ((this.Settings as ModifyKeywordImageSettings).Rename == RenameType.FromFile || (this.Settings as ModifyKeywordImageSettings).Rename == RenameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as ModifyKeywordImageSettings).RenameFile))
                {
                    throw new Exception("File with names not found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as ModifyKeywordImageSettings).RenameFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }

        public override object NewInstance()
        {
            return new ModifyKeywordImageMaker();
        }
    }
}
