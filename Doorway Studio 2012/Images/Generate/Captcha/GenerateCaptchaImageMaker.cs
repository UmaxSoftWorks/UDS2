using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Plugins.Images.Common;
using Umax.Plugins.Images.Enums;
using IO = System.IO;

namespace Umax.Plugins.Images.Generate.Captcha
{
    public class GenerateCaptchaImageMaker: ImageMaker
    {
        public GenerateCaptchaImageMaker()
        {
            this.Settings = new GenerateCaptchaImageSettings();
        }

        public override string Name
        {
            get { return "GenerateCaptchaImageMaker"; }
        }

        public override string ControlName
        {
            get { return "GenerateCaptchaImageControl"; }
        }

        public override string GUIName
        {
            get { return "Generate: Captcha"; }
        }

        protected override string MakeImage(string Path, List<string> Items)
        {
            if ((this.MaximumCount < this.CurrentCount + 1) && (this.Settings as GenerateCaptchaImageSettings).Number == NumberType.Limited)
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
                                                                       (this.Settings as GenerateCaptchaImageSettings).
                                                                           Names)) + ".jpg";
            this.Images.Add(imagePath);

            // Make image
            Bitmap image = BitmapHelper.Make(
                this.Random.Next((this.Settings as GenerateCaptchaImageSettings).WidthMin,
                                 (this.Settings as GenerateCaptchaImageSettings).WidthMax),
                this.Random.Next((this.Settings as GenerateCaptchaImageSettings).HeightMin,
                                 (this.Settings as GenerateCaptchaImageSettings).HeightMax));

            image.DrawText((StringHelper.MakeRandom(2, 4, StringCharactersType.UpperCase) +
                            StringHelper.MakeRandom(2, 4, StringCharactersType.LowerCase)).Mix());
            image.DrawCurve();
            image.DrawNoise();
            image.Save(imagePath);

            return imagePath;
        }

        public override void Initialize()
        {
            base.Initialize();

            if ((this.Settings as GenerateCaptchaImageSettings).Number == NumberType.Limited)
            {
                this.MaximumCount = this.Random.Next((this.Settings as GenerateCaptchaImageSettings).NumberMin,
                                                     (this.Settings as GenerateCaptchaImageSettings).NumberMax);
            }
        }

        protected override MakerStateType Validate()
        {
            if ((this.Settings as GenerateCaptchaImageSettings).Names == NameType.FromFile || (this.Settings as GenerateCaptchaImageSettings).Names == NameType.FromFileToEn)
            {
                if (IO.File.Exists((this.Settings as GenerateCaptchaImageSettings).NamesFile))
                {
                    throw new Exception("File with names isn't found.");
                }

                this.ExternalImageNames = IO.File.ReadAllLines((this.Settings as GenerateCaptchaImageSettings).NamesFile, Encoding.Default);

                if (this.ExternalImageNames.Length == 0)
                {
                    throw new Exception("File with names empty.");
                }
            }

            return MakerStateType.Initialized;
        }

        public override object NewInstance()
        {
            return new GenerateCaptchaImageMaker();
        }
    }
}
