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
using BitmapHelper = Umax.Plugins.Images.Helpers.BitmapHelper;
using IO = System.IO;

namespace Umax.Plugins.Images.Modify.Border.Text
{
    public class ModifyBorderTextImageMaker : DataCompatibleImageMaker
    {
        public ModifyBorderTextImageMaker()
        {
            this.Settings = new ModifyBorderTextImageSettings();
        }

        public override string Name
        {
            get { return "ModifyBorderTextImageMaker"; }
        }

        public override string ControlName
        {
            get { return "ModifyBorderTextImageControl"; }
        }

        public override string GUIName
        {
            get { return "Modify: Border (Text)"; }
        }

        /// <summary>
        /// Gets or sets Content
        /// </summary>
        protected string Content { get; set; }

        protected override string MakeImage(string Path, List<string> Items)
        {
            if ((this.MaximumCount < this.CurrentCount + 1) && (this.Settings as ModifyBorderTextImageSettings).Number == NumberType.Limited)
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

                string text = SelectText((this.Settings as ModifyBorderTextImageSettings).StringSelect);

                string imagePath = IO.Path.Combine(Path,
                                                   this.MakeFileName(Path, text.Select(StringSelectType.Word, true),
                                                                     (this.Settings as ModifyBorderTextImageSettings).Rename)) + ".jpg";
                this.Images.Add(imagePath);

                // Open original image
                Image originalImage = Image.FromFile(Path);
                if ((this.Settings as ModifyBorderTextImageSettings).ModificationsImageNoise)
                {
                    ((Bitmap) originalImage).DrawNoise();
                }

                // Make image
                int left = this.Random.Next((this.Settings as ModifyBorderTextImageSettings).LeftMin,
                                            (this.Settings as ModifyBorderTextImageSettings).LeftMax);

                int right = this.Random.Next((this.Settings as ModifyBorderTextImageSettings).RightMin,
                                             (this.Settings as ModifyBorderTextImageSettings).RightMax);

                int top = this.Random.Next(
                    (this.Settings as ModifyBorderTextImageSettings).TopMin,
                    (this.Settings as ModifyBorderTextImageSettings).TopMax);

                int bottom = this.Random.Next(
                    (this.Settings as ModifyBorderTextImageSettings).BottomMin,
                    (this.Settings as ModifyBorderTextImageSettings).BottomMax);


                Bitmap image =
                    BitmapHelper.Make(originalImage.Width + left + right,
                                                                                 originalImage.Height + top + bottom,
                                                                                 (this.Settings as ModifyBorderTextImageSettings).BackgroundColorSettings);

                // Draw text
                Bitmap textImage = image.Clone(new Rectangle(0, image.Height - bottom, image.Width, bottom),
                                               System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                textImage.DrawText(text, (this.Settings as ModifyBorderTextImageSettings).Font);


                // Insert text image
                image.DrawImage(textImage, 0, originalImage.Height + top);

                if ((this.Settings as ModifyBorderTextImageSettings).ModificationsBorderNoise)
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

        public override void Initialize()
        {
            base.Initialize();

            if ((this.Settings as ModifyBorderTextImageSettings).Number == NumberType.Limited)
            {
                this.MaximumCount = this.Random.Next((this.Settings as ModifyBorderTextImageSettings).NumberMin,
                                                     (this.Settings as ModifyBorderTextImageSettings).NumberMax);
            }
        }

        protected override MakerStateType Validate()
        {
            base.Validate();

            if ((this.Settings as ModifyBorderTextImageSettings).Rename == RenameType.FromFile || (this.Settings as ModifyBorderTextImageSettings).Rename == RenameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as ModifyBorderTextImageSettings).RenameFile))
                {
                    throw new Exception("File with names not found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as ModifyBorderTextImageSettings).RenameFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            this.Content = IO.File.ReadAllText((this.Settings as ModifyBorderTextImageSettings).TextFile, Encoding.Default);

            return MakerStateType.Initialized;
        }

        protected string SelectText(StringSelectType Type)
        {
            switch (Type)
            {
                case StringSelectType.Word:
                    {
                        return this.Content.Select(StringSelectType.Word, true);
                    }

                case StringSelectType.Sentense:
                    {
                        return this.Content.Select(StringSelectType.Sentense, true);
                    }
                case StringSelectType.Line:
                    {
                        return this.Content.Select(StringSelectType.Line, true);
                    }

                case StringSelectType.Phrase:
                    {
                        return this.Content.Select(StringSelectType.Phrase, true);
                    }
            }

            return this.Content.Select(StringSelectType.Word, true);
        }

        public override object NewInstance()
        {
            return new ModifyBorderTextImageMaker();
        }
    }
}
