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

namespace Umax.Plugins.Images.Generate.Figures
{
    public class GenerateFiguresImageMaker : ImageMaker
    {
        public GenerateFiguresImageMaker()
        {
            this.Settings = new GenerateFiguresImageSettings();
        }

        public override string Name
        {
            get { return "GenerateFiguresImageMaker"; }
        }

        public override string ControlName
        {
            get { return "GenerateFiguresImageControl"; }
        }

        public override string GUIName
        {
            get { return "Generate: Figures"; }
        }

        protected override string MakeImage(string Path, List<string> Items)
        {
            if ((this.MaximumCount < this.CurrentCount + 1) && (this.Settings as GenerateFiguresImageSettings).Number == NumberType.Limited)
            {
                if (this.Images.Count == 0)
                {
                    throw new Exception("Image limit reached and no used images available.");
                }

                return this.Images[Random.Next(this.Images.Count)];
            }

            // Create directories
            IOHelper.CreateDirectory(Path);

            // Save
            string imagePath = IO.Path.Combine(Path, this.MakeFileName(Items,
                                                                       (this.Settings as GenerateFiguresImageSettings).
                                                                           Names)) + ".jpg";
            this.Images.Add(imagePath);

            // Make image
            Bitmap image =
                BitmapHelper.Make(
                    this.Random.Next((this.Settings as GenerateFiguresImageSettings).WidthMin,
                                     (this.Settings as GenerateFiguresImageSettings).WidthMax), this.Random.Next(
                                         (this.Settings as GenerateFiguresImageSettings).HeightMin,
                                         (this.Settings as GenerateFiguresImageSettings).HeightMax),
                    (this.Settings as GenerateFiguresImageSettings).BackgroundColorSettings);

            image.DrawFigures(this.Random.Next((this.Settings as GenerateFiguresImageSettings).FiguresNumberMin,
                                               (this.Settings as GenerateFiguresImageSettings).FiguresNumberMax),
                              (this.Settings as GenerateFiguresImageSettings).FiguresColorSettings);

            // Noise
            if ((this.Settings as GenerateFiguresImageSettings).ModificationsNoise)
            {
                image.DrawNoise();
            }

            image.Save(imagePath);

            return imagePath;
        }

        public override void Initialize()
        {
            base.Initialize();

            if ((this.Settings as GenerateFiguresImageSettings).Number == NumberType.Limited)
            {
                this.MaximumCount = this.Random.Next((this.Settings as GenerateFiguresImageSettings).NumberMin,
                                                     (this.Settings as GenerateFiguresImageSettings).NumberMax);
            }
        }

        protected override MakerStateType Validate()
        {
            if ((this.Settings as GenerateFiguresImageSettings).Names == NameType.FromFile || (this.Settings as GenerateFiguresImageSettings).Names == NameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as GenerateFiguresImageSettings).NamesFile))
                {
                    throw new Exception("File with names isn't found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as GenerateFiguresImageSettings).NamesFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }

        public override object NewInstance()
        {
            return new GenerateFiguresImageMaker();
        }
    }
}
