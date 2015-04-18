using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Plugins.Images.Common;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Helpers;
using BitmapHelper = Umax.Plugins.Images.Helpers.BitmapHelper;
using IO = System.IO;

namespace Umax.Plugins.Images.Generate.Text
{
    public class GenerateTextImageMaker : ImageMaker
    {
        public GenerateTextImageMaker()
        {
            this.Settings = new GenerateTextImageSettings();
        }

        public override string Name
        {
            get { return "GenerateTextImageMaker"; }
        }

        public override string ControlName
        {
            get { return "GenerateTextImageControl"; }
        }

        public override string GUIName
        {
            get { return "Generate: Text"; }
        }

        protected string Content { get; set; }

        protected override string MakeImage(string Path, List<string> Items)
        {
            if ((this.MaximumCount < this.CurrentCount + 1) && (this.Settings as GenerateTextImageSettings).Number == NumberType.Limited)
            {
                if (this.Images.Count == 0)
                {
                    throw new Exception("Image limit reached and no used images available.");
                }

                return this.Images[Random.Next(this.Images.Count)];
            }

            // Create directories
            IOHelper.CreateDirectory(Path);

            string text = this.SelectText((this.Settings as GenerateTextImageSettings).StringSelect);


            // Save
            string imagePath = IO.Path.Combine(Path, this.MakeFileName(text.Select(StringSelectType.Word, true),
                                                                       (this.Settings as GenerateTextImageSettings).
                                                                           Names)) + ".jpg";
            this.Images.Add(imagePath);

            // Make image
            Bitmap image =
                BitmapHelper.Make(
                    this.Random.Next((this.Settings as GenerateTextImageSettings).WidthMin,
                                     (this.Settings as GenerateTextImageSettings).WidthMax), this.Random.Next(
                                         (this.Settings as GenerateTextImageSettings).HeightMin,
                                         (this.Settings as GenerateTextImageSettings).HeightMax),
                    (this.Settings as GenerateTextImageSettings).BackgroundColorSettings);

            // Draw text
            image.DrawText(text, (this.Settings as GenerateTextImageSettings).Font);


            if ((this.Settings as GenerateTextImageSettings).ModificationsNoise)
            {
                image.DrawNoise();
            }

            image.Save(imagePath);

            return imagePath;
        }

        public override void Initialize()
        {
            base.Initialize();

            if ((this.Settings as GenerateTextImageSettings).Number == NumberType.Limited)
            {
                this.MaximumCount = this.Random.Next((this.Settings as GenerateTextImageSettings).NumberMin,
                                                     (this.Settings as GenerateTextImageSettings).NumberMax);
            }
        }

        protected override MakerStateType Validate()
        {
            if ((this.Settings as GenerateTextImageSettings).Names == NameType.FromFile ||
                (this.Settings as GenerateTextImageSettings).Names == NameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as GenerateTextImageSettings).NamesFile))
                {
                    throw new Exception("File with names isn't found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as GenerateTextImageSettings).NamesFile,
                                                               Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            this.Content = IO.File.ReadAllText((this.Settings as GenerateTextImageSettings).TextFile, Encoding.Default);

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
            return new GenerateTextImageMaker();
        }
    }
}
