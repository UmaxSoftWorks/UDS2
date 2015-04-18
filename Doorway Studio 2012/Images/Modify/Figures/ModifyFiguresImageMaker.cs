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

namespace Umax.Plugins.Images.Modify.Figures
{
    public class ModifyFiguresImageMaker : DataCompatibleImageMaker
    {
        public ModifyFiguresImageMaker()
        {
            this.Settings = new ModifyFiguresImageSettings();
        }

        public override string Name
        {
            get { return "ModifyFiguresImageMaker"; }
        }

        public override string ControlName
        {
            get { return "ModifyFiguresImageControl"; }
        }

        public override string GUIName
        {
            get { return "Modify: Figures"; }
        }

        protected override string MakeImage(string Path, List<string> Items)
        {
            if ((this.MaximumCount < this.CurrentCount + 1) && (this.Settings as ModifyFiguresImageSettings).Number == NumberType.Limited)
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
                                    this.MakeFileName(Path, Items,
                                                      (this.Settings as ModifyFiguresImageSettings).Rename)) + ".jpg";
                this.Images.Add(imagePath);

                // Make image
                Image image = Image.FromFile(Path);

                ((Bitmap) image).DrawFigures(
                    this.Random.Next((this.Settings as ModifyFiguresImageSettings).FiguresNumberMin,
                                     (this.Settings as ModifyFiguresImageSettings).FiguresNumberMax),
                    (this.Settings as ModifyFiguresImageSettings).FiguresColorSettings);

                if ((this.Settings as ModifyFiguresImageSettings).ModificationsImageNoise)
                {
                    ((Bitmap) image).DrawNoise();
                }

                image.Save(imagePath);

                originalImagePath = imagePath;
            }

            return originalImagePath;
        }

        public override void Initialize()
        {
            base.Initialize();

            if ((this.Settings as ModifyFiguresImageSettings).Number == NumberType.Limited)
            {
                this.MaximumCount = this.Random.Next((this.Settings as ModifyFiguresImageSettings).NumberMin,
                                                     (this.Settings as ModifyFiguresImageSettings).NumberMax);
            }
        }

        protected override MakerStateType Validate()
        {
            base.Validate();

            if ((this.Settings as ModifyFiguresImageSettings).Rename == RenameType.FromFile || (this.Settings as ModifyFiguresImageSettings).Rename == RenameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as ModifyFiguresImageSettings).RenameFile))
                {
                    throw new Exception("File with names not found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as ModifyFiguresImageSettings).RenameFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }

        public override object NewInstance()
        {
            return new ModifyFiguresImageMaker();
        }
    }
}
