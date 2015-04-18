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

namespace Umax.Plugins.Images.Generate.Keywords
{
    public class GenerateKeywordsImageMaker : ImageMaker
    {
        public GenerateKeywordsImageMaker()
        {
            this.Settings = new GenerateKeywordsImageSettings();
        }

        public override string Name
        {
            get { return "GenerateKeywordsImageMaker"; }
        }

        public override string ControlName
        {
            get { return "GenerateKeywordsImageControl"; }
        }

        public override string GUIName
        {
            get { return "Generate: Keywords"; }
        }

        protected override string MakeImage(string Path, List<string> Items)
        {
            // Create directories
            IOHelper.CreateDirectory(Path);

            string text = string.Empty;
            for (int i = 0; i < Items.Count; i++)
            {
                text += Items[i] + "\r\n";
            }

            text = text.Trim(' ', '\r', '\n');


            // Save
            string imagePath = IO.Path.Combine(Path, this.MakeFileName(text.Select(StringSelectType.Word, true),
                                                                       (this.Settings as GenerateKeywordsImageSettings).
                                                                           Names)) + ".jpg";
            this.Images.Add(imagePath);

            // Make image
            Bitmap image =
                BitmapHelper.Make(
                    this.Random.Next((this.Settings as GenerateKeywordsImageSettings).WidthMin,
                                     (this.Settings as GenerateKeywordsImageSettings).WidthMax), this.Random.Next(
                                         (this.Settings as GenerateKeywordsImageSettings).HeightMin,
                                         (this.Settings as GenerateKeywordsImageSettings).HeightMax),
                    (this.Settings as GenerateKeywordsImageSettings).BackgroundColorSettings);

            // Draw text
            image.DrawText(text, (this.Settings as GenerateKeywordsImageSettings).Font);


            if ((this.Settings as GenerateKeywordsImageSettings).ModificationsNoise)
            {
                image.DrawNoise();
            }

            image.Save(imagePath);


            return imagePath;
        }

        protected override MakerStateType Validate()
        {
            if ((this.Settings as GenerateKeywordsImageSettings).Names == NameType.FromFile || (this.Settings as GenerateKeywordsImageSettings).Names == NameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as GenerateKeywordsImageSettings).NamesFile))
                {
                    throw new Exception("File with names isn't found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as GenerateKeywordsImageSettings).NamesFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }

        public override object NewInstance()
        {
            return new GenerateKeywordsImageMaker();
        }
    }
}
