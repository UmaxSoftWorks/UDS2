using System.Drawing;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Generate.Common;

namespace Umax.Plugins.Images.Generate.Keywords
{
    public class GenerateKeywordsImageSettings : GenerateImageSettings
    {
        public GenerateKeywordsImageSettings()
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
            get { return "GenerateKeywordsImageSettings"; }
        }

        public ColorSettings BackgroundColorSettings { get; set; }

        public bool ModificationsNoise { get; set; }

        public FontSettings Font { get; set; }

        public override object NewInstance()
        {
            return new GenerateKeywordsImageSettings();
        }

        public override void Dispose()
        {
        }
    }
}
