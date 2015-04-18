using System.Drawing;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Generate.Common;

namespace Umax.Plugins.Images.Generate.Figures
{
    public class GenerateFiguresImageSettings : GenerateImageSettings
    {
        public GenerateFiguresImageSettings()
        {
            this.Number = NumberType.All;
            this.NumberMin = 200;
            this.NumberMax = 300;

            this.FiguresNumberMin = 2;
            this.FiguresNumberMax = 5;

            this.FiguresColorSettings = new ColorSettings()
                                            {
                                                SelectedColor = Color.FromArgb(0, 0, 0)
                                            };

            this.BackgroundColorSettings = new ColorSettings()
                                               {
                                                   SelectedColor = Color.FromArgb(255, 255, 255)
                                               };

            this.ModificationsNoise = false;
        }

        public override string Name
        {
            get { return "GenerateFiguresImageSettings"; }
        }

        public NumberType Number { get; set; }
        public int NumberMin { get; set; }
        public int NumberMax { get; set; }

        public int FiguresNumberMin { get; set; }
        public int FiguresNumberMax { get; set; }

        public ColorSettings FiguresColorSettings { get; set; }

        public ColorSettings BackgroundColorSettings { get; set; }

        public bool ModificationsNoise { get; set; }

        public override object NewInstance()
        {
            return new GenerateFiguresImageSettings();
        }

        public override void Dispose()
        {
        }
    }
}
