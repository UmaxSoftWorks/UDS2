using System.Drawing;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Generate.Common;

namespace Umax.Plugins.Images.Generate.Keyword
{
    public class GenerateKeywordImageSettings : GenerateImageSettings
    {
        public GenerateKeywordImageSettings()
        {
            this.BackgroundColorSettings = new ColorSettings()
                                               {
                                                   SelectedColor = Color.FromArgb(255, 255, 255)
                                               };

            this.ModificationsNoise = false;

            this.Font = new FontSettings();
        }

        public override string Name
        {
            get { return "GenerateKeywordImageSettings"; }
        }

        public ColorSettings BackgroundColorSettings { get; set; }

        public bool ModificationsNoise { get; set; }

        public FontSettings Font { get; set; }

        public override object NewInstance()
        {
            return new GenerateKeywordImageSettings();
        }

        public override void Dispose()
        {
        }
    }
}
