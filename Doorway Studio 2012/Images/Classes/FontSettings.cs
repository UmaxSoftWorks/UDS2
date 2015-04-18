using System.Drawing;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Classes
{
    public class FontSettings
    {
        public FontSettings()
        {
            this.Font = FontType.Random;
            this.FontName = string.Empty;
            this.FontSize = 10;

            this.FontStyle = FontStyle.Regular;

            this.FontColorSettings = new ColorSettings()
            {
                SelectedColor = Color.FromArgb(0, 0, 0)
            };
        }

        public virtual FontType Font { get; set; }
        public virtual string FontName { get; set; }
        public virtual int FontSize { get; set; }

        public FontStyle FontStyle { get; set; }

        public virtual ColorSettings FontColorSettings { get; set; }
    }
}
