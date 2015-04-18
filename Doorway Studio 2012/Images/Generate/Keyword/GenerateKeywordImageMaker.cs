using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Plugins.Images.Common;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Helpers;
using BitmapHelper = Umax.Plugins.Images.Helpers.BitmapHelper;
using IO = System.IO;

namespace Umax.Plugins.Images.Generate.Keyword
{
    public class GenerateKeywordImageMaker : ImageMaker
    {
        public GenerateKeywordImageMaker()
        {
            this.Settings = new GenerateKeywordImageSettings();
        }

        public override string Name
        {
            get { return "GenerateKeywordImageMaker"; }
        }

        public override string ControlName
        {
            get { return "GenerateKeywordImageControl"; }
        }

        public override string GUIName
        {
            get { return "Generate: Keyword"; }
        }

        protected override string MakeImage(string Path, List<string> Items)
        {
            // Create directories
            IOHelper.CreateDirectory(Path);

            string keyword = Items[this.Random.Next(Items.Count)];

            // Save
            string imagePath = IO.Path.Combine(Path, this.MakeFileName(keyword,
                                                                       (this.Settings as GenerateKeywordImageSettings).
                                                                           Names)) + ".jpg";
            this.Images.Add(imagePath);

            // Make image
            Bitmap image =
                BitmapHelper.Make(
                    this.Random.Next((this.Settings as GenerateKeywordImageSettings).WidthMin,
                                     (this.Settings as GenerateKeywordImageSettings).WidthMax), this.Random.Next(
                                         (this.Settings as GenerateKeywordImageSettings).HeightMin,
                                         (this.Settings as GenerateKeywordImageSettings).HeightMax),
                    (this.Settings as GenerateKeywordImageSettings).BackgroundColorSettings);

            // Draw text
            image.DrawText(keyword, (this.Settings as GenerateKeywordImageSettings).Font);
            
            if ((this.Settings as GenerateKeywordImageSettings).ModificationsNoise)
            {
                image.DrawNoise();
            }

            image.Save(imagePath);


            return imagePath;
        }

        protected override MakerStateType Validate()
        {
            if ((this.Settings as GenerateKeywordImageSettings).Names == NameType.FromFile || (this.Settings as GenerateKeywordImageSettings).Names == NameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as GenerateKeywordImageSettings).NamesFile))
                {
                    throw new Exception("File with names isn't found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as GenerateKeywordImageSettings).NamesFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }


        public override object NewInstance()
        {
            return new GenerateKeywordImageMaker();
        }
    }
}
