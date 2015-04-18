using System.Drawing;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Helpers
{
    internal static class FontHelper
    {
        public static Font Make(FontSettings Settings)
        {
            switch (Settings.Font)
            {
                case FontType.Random:
                    {
                        return Umax.Classes.Helpers.FontHelper.Make();
                    }

                case FontType.Selected:
                    {
                        return Umax.Classes.Helpers.FontHelper.Make(Settings.FontName, Settings.FontSize, Settings.FontStyle);
                    }
            }

            return Umax.Classes.Helpers.FontHelper.Make();
        }
    }
}
