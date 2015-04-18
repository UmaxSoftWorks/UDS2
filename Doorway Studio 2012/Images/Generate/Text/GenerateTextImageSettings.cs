using System.Drawing;
using Umax.Classes.Enums;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Generate.Common;

namespace Umax.Plugins.Images.Generate.Text
{
    public class GenerateTextImageSettings : GenerateImageSettings
    {
        public GenerateTextImageSettings()
        {
            this.BackgroundColorSettings = new ColorSettings()
                                               {
                                                   SelectedColor = Color.FromArgb(255, 255, 255)
                                               };

            this.ModificationsNoise = false;

            this.Font = new FontSettings();

            this.StringSelect = StringSelectType.Sentense;

            this.TextFile = string.Empty;

            this.Number = NumberType.All;
            this.NumberMin = 200;
            this.NumberMax = 300;
        }

        public override string Name
        {
            get { return "GenerateTextImageSettings"; }
        }

        public ColorSettings BackgroundColorSettings { get; set; }

        public bool ModificationsNoise { get; set; }

        public FontSettings Font { get; set; }

        public StringSelectType StringSelect { get; set; }

        public string TextFile { get; set; }

        public NumberType Number { get; set; }
        public int NumberMin { get; set; }
        public int NumberMax { get; set; }

        public override object NewInstance()
        {
            return new GenerateTextImageSettings();
        }

        public override void Dispose()
        {
        }
    }
}
