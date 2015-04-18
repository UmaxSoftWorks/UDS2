using System;
using System.Collections.Generic;
using System.Text;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Plugins.Images.Common.DataCompatible;
using Umax.Plugins.Images.Enums;
using IO = System.IO;

namespace Umax.Plugins.Images.Copy
{
    public class CopyImageMaker : DataCompatibleImageMaker
    {
        public CopyImageMaker()
        {
            this.Settings = new CopyImageSettings();
        }

        public override string Name
        {
            get { return "CopyImageMaker"; }
        }

        public override string ControlName
        {
            get { return "CopyImageControl"; }
        }

        public override string GUIName
        {
            get { return "Copy"; }
        }

        protected override string MakeImage(string Path, List<string> Items)
        {
            if ((this.MaximumCount < this.CurrentCount + 1) && (this.Settings as CopyImageSettings).Number == NumberType.Limited)
            {
                if (this.Images.Count == 0)
                {
                    throw new Exception("Image limit reached and no used images available.");
                }

                return this.Images[Random.Next(this.Images.Count)];
            }

            // Create directories
            IOHelper.CreateDirectory(Path);

            // Select image
            string image = this.Select();

            // HTTP
            if (!image.ToLower().StartsWith("http"))
            {
                // File
                if (image.Contains("\\Files\\"))
                {
                    string directories = image.Substring(image.LastIndexOf("\\Files\\") + 7);
                    if (directories.Contains("\\"))
                    {
                        IOHelper.CreateDirectory(IO.Path.Combine(Path, directories));
                    }
                }

                // Copy
                string imagePath = IO.Path.Combine(Path,
                                                   this.MakeFileName(image.Substring(image.LastIndexOf("\\") + 1),
                                                                     Items, (this.Settings as CopyImageSettings).Rename));
                IO.File.Copy(image, imagePath);

                image = imagePath;
            }

            this.Images.Add(image);

            return image;
        }

        public override void Initialize()
        {
            base.Initialize();

            if ((this.Settings as CopyImageSettings).Number == NumberType.Limited)
            {
                this.MaximumCount = this.Random.Next((this.Settings as CopyImageSettings).NumberMin,
                                                     (this.Settings as CopyImageSettings).NumberMax);
            }
        }

        protected override MakerStateType Validate()
        {
            base.Validate();

            if ((this.Settings as CopyImageSettings).Rename == RenameType.FromFile || (this.Settings as CopyImageSettings).Rename == RenameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as CopyImageSettings).RenameFile))
                {
                    throw new Exception("File with names not found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as CopyImageSettings).RenameFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }

        public override void Save(string ImagePath)
        {
            this.ImageData = null;
            base.Save(ImagePath);
        }

        public override object NewInstance()
        {
            return new CopyImageMaker();
        }
    }
}
