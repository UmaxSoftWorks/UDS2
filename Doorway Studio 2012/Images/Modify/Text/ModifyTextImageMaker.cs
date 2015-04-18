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

namespace Umax.Plugins.Images.Modify.Text
{
    public class ModifyTextImageMaker : DataCompatibleImageMaker
    {
        public ModifyTextImageMaker()
        {
            this.Settings = new ModifyTextImageSettings();
        }

        public override string Name
        {
            get { return "ModifyTextImageMaker"; }
        }

        public override string ControlName
        {
            get { return "ModifyTextImageControl"; }
        }

        public override string GUIName
        {
            get { return "Modify: Text"; }
        }

        protected string Content { get; set; }

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

                string text = this.SelectText((this.Settings as ModifyTextImageSettings).StringSelect);

                string imagePath =
                    IO.Path.Combine(Path,
                                    this.MakeFileName(Path, text.Select(StringSelectType.Word, true),
                                                      (this.Settings as ModifyTextImageSettings).Rename)) + ".jpg";
                this.Images.Add(imagePath);

                // Make image
                Image image = Image.FromFile(Path);

                ((Bitmap)image).DrawText(text, (this.Settings as ModifyTextImageSettings).Font);

                if ((this.Settings as ModifyTextImageSettings).ModificationsImageNoise)
                {
                    ((Bitmap)image).DrawNoise();
                }

                image.Save(imagePath);

                originalImagePath = imagePath;
            }

            return originalImagePath;
        }

        public override void Initialize()
        {
            base.Initialize();

            if ((this.Settings as ModifyTextImageSettings).Number == NumberType.Limited)
            {
                this.MaximumCount = this.Random.Next((this.Settings as ModifyTextImageSettings).NumberMin,
                                                     (this.Settings as ModifyTextImageSettings).NumberMax);
            }
        }

        protected override MakerStateType Validate()
        {
            base.Validate();

            if ((this.Settings as ModifyTextImageSettings).Rename == RenameType.FromFile || (this.Settings as ModifyTextImageSettings).Rename == RenameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as ModifyTextImageSettings).RenameFile))
                {
                    throw new Exception("File with names not found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as ModifyTextImageSettings).RenameFile,
                                                               Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            this.Content = IO.File.ReadAllText((this.Settings as ModifyTextImageSettings).TextFile, Encoding.Default);

            if (this.Content.Length == 0)
            {
                throw new Exception("Text file is empty.");
            }

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
            return new ModifyTextImageMaker();
        }
    }
}
