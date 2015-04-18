using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Plugins.Images.Common.DataCompatible;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Helpers;
using BitmapHelper = Umax.Plugins.Images.Helpers.BitmapHelper;
using IO = System.IO;

namespace Umax.Plugins.Images.Modify.Border.Keyword
{
    public class ModifyBorderKeywordImageMaker : DataCompatibleImageMaker
    {
        public ModifyBorderKeywordImageMaker()
        {
            this.Settings = new ModifyBorderKeywordImageSettings();
        }

        public override string Name
        {
            get { return "ModifyBorderKeywordImageMaker"; }
        }

        public override string ControlName
        {
            get { return "ModifyBorderKeywordImageControl"; }
        }

        public override string GUIName
        {
            get { return "Modify: Border (Keyword)"; }
        }

        protected override string MakeImage(string Path, List<string> Items)
        {
            // Create directories
            IOHelper.CreateDirectory(Path);

            string keyword = Items[this.Random.Next(Items.Count)];

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

                // Save
                string imagePath = IO.Path.Combine(Path, this.MakeFileName(originalImagePath.Substring(originalImagePath.LastIndexOf("\\") + 1), keyword,
                                                                           (this.Settings as ModifyBorderKeywordImageSettings).Rename)) + ".jpg";
                this.Images.Add(imagePath);

                // Open original image
                Image originalImage = Image.FromFile(originalImagePath);
                if ((this.Settings as ModifyBorderKeywordImageSettings).ModificationsImageNoise)
                {
                    ((Bitmap) originalImage).DrawNoise();
                }

                // Make image
                int left = this.Random.Next((this.Settings as ModifyBorderKeywordImageSettings).LeftMin,
                                            (this.Settings as ModifyBorderKeywordImageSettings).LeftMax);

                int right = this.Random.Next((this.Settings as ModifyBorderKeywordImageSettings).RightMin,
                                             (this.Settings as ModifyBorderKeywordImageSettings).RightMax);

                int top = this.Random.Next(
                    (this.Settings as ModifyBorderKeywordImageSettings).TopMin,
                    (this.Settings as ModifyBorderKeywordImageSettings).TopMax);

                int bottom = this.Random.Next(
                    (this.Settings as ModifyBorderKeywordImageSettings).BottomMin,
                    (this.Settings as ModifyBorderKeywordImageSettings).BottomMax);


                Bitmap image =
                    BitmapHelper.Make(originalImage.Width + left + right,
                                                                                 originalImage.Height + top + bottom,
                                                                                 (this.Settings as ModifyBorderKeywordImageSettings).BackgroundColorSettings);

                // Draw text
                Bitmap textImage = image.Clone(new Rectangle(0, image.Height - bottom, image.Width, bottom),
                                               System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                textImage.DrawText(keyword, (this.Settings as ModifyBorderKeywordImageSettings).Font);


                // Insert text image
                image.DrawImage(textImage, 0, originalImage.Height + top);

                if ((this.Settings as ModifyBorderKeywordImageSettings).ModificationsBorderNoise)
                {
                    image.DrawNoise();
                }

                // Insert original image into new one
                image.DrawImage((Bitmap) originalImage, (left + right)/2, (top + bottom)/2);

                image.Save(imagePath);

                originalImagePath = imagePath;
            }

            return originalImagePath;
        }

        protected override MakerStateType Validate()
        {
            base.Validate();

            if ((this.Settings as ModifyBorderKeywordImageSettings).Rename == RenameType.FromFile || (this.Settings as ModifyBorderKeywordImageSettings).Rename == RenameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as ModifyBorderKeywordImageSettings).RenameFile))
                {
                    throw new Exception("File with names not found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as ModifyBorderKeywordImageSettings).RenameFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }

        public override object NewInstance()
        {
            return new ModifyBorderKeywordImageMaker();
        }
    }
}
