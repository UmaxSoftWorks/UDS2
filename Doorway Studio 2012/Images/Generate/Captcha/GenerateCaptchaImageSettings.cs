using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Generate.Common;

namespace Umax.Plugins.Images.Generate.Captcha
{
    public class GenerateCaptchaImageSettings : GenerateImageSettings
    {
        public GenerateCaptchaImageSettings()
        {
            this.Number = NumberType.All;
            this.NumberMin = 200;
            this.NumberMax = 300;
        }

        public override string Name
        {
            get { return "GenerateCaptchaImageSettings"; }
        }

        public NumberType Number {get; set; }
        public int NumberMin { get; set; }
        public int NumberMax { get; set; }

        public override object NewInstance()
        {
            return new GenerateCaptchaImageSettings();
        }

        public override void Dispose()
        {
        }
    }
}
