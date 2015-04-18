using System.Drawing;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Classes
{
    public class ColorSettings
    {
        public ColorSettings()
        {
            this.Color = ColorType.Random;
            this.SelectedColor = System.Drawing.Color.FromArgb(0, 0, 0);

            this.SelectedColorRangeRMin = 100;
            this.SelectedColorRangeRMax = 200;
            this.SelectedColorRangeGMin = 100;
            this.SelectedColorRangeGMax = 200;
            this.SelectedColorRangeBMin = 100;
            this.SelectedColorRangeBMax = 200;
        }

        public ColorType Color { get; set; }
        public Color SelectedColor { get; set; }

        public int SelectedColorRangeRMin { get; set; }
        public int SelectedColorRangeRMax { get; set; }
        public int SelectedColorRangeGMin { get; set; }
        public int SelectedColorRangeGMax { get; set; }
        public int SelectedColorRangeBMin { get; set; }
        public int SelectedColorRangeBMax { get; set; }
    }
}
