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

namespace Umax.Plugins.Images.Modify.Resize
{
    public class ModifyResizeImageMaker : DataCompatibleImageMaker
    {
        public ModifyResizeImageMaker()
        {
            this.Settings = new ModifyResizeImageSettings();
        }

        public override string Name
        {
            get { return "ModifyResizeImageMaker"; }
        }

        public override string ControlName
        {
            get { return "ModifyResizeImageControl"; }
        }

        public override string GUIName
        {
            get { return "Modify: Resize"; }
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

                string imagePath =
                    IO.Path.Combine(Path,
                                    this.MakeFileName(
                                        originalImagePath.Substring(originalImagePath.LastIndexOf("\\") + 1), Items,
                                        (this.Settings as ModifyResizeImageSettings).Rename)) + ".jpg";
                this.Images.Add(imagePath);

                // Make image
                Image image = Image.FromFile(Path);

                ((Bitmap) image).Resize(
                    this.Random.Next((this.Settings as ModifyResizeImageSettings).WidthMin,
                                     (this.Settings as ModifyResizeImageSettings).WidthMax),
                    this.Random.Next((this.Settings as ModifyResizeImageSettings).HeightMin,
                                     (this.Settings as ModifyResizeImageSettings).HeightMax),
                    (this.Settings as ModifyResizeImageSettings).Resize,
                    (this.Settings as ModifyResizeImageSettings).BackgroundColorSettings);

                if ((this.Settings as ModifyResizeImageSettings).ModificationsImageNoise)
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

            if ((this.Settings as ModifyResizeImageSettings).Rename == RenameType.FromFile || (this.Settings as ModifyResizeImageSettings).Rename == RenameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as ModifyResizeImageSettings).RenameFile))
                {
                    throw new Exception("File with names not found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as ModifyResizeImageSettings).RenameFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }

        public override object NewInstance()
        {
            return new ModifyResizeImageMaker();
        }
    }
}
