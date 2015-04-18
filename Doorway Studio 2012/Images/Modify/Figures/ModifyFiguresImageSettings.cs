using System.Drawing;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Modify.Common;

namespace Umax.Plugins.Images.Modify.Figures
{
    public class ModifyFiguresImageSettings : ModifyImageSettings
    {
        public ModifyFiguresImageSettings()
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

            this.ModificationsNoise = false;
        }

        public override string Name
        {
            get { return "ModifyFiguresImageSettings"; }
        }

        public NumberType Number { get; set; }
        public int NumberMin { get; set; }
        public int NumberMax { get; set; }

        public int FiguresNumberMin { get; set; }
        public int FiguresNumberMax { get; set; }

        public ColorSettings FiguresColorSettings { get; set; }

        public bool ModificationsNoise { get; set; }

        public override object NewInstance()
        {
            return new ModifyFiguresImageSettings();
        }

        public override void Dispose()
        {

        }
    }
}
