using System;
using System.Drawing;
using System.Drawing.Text;

namespace Umax.Classes.Helpers
{
    public static class FontHelper
    {
        internal const int MaximumSize = 72;

        public static Font Make()
        {
            return Make(RandomFontName(), new Random().Next(MaximumSize));
        }

        public static Font Make(string Name)
        {
            return Make(Name, new Random().Next(MaximumSize));
        }

        public static Font Make(int Size)
        {
            return Make(RandomFontName(), Size);
        }

        public static Font Make(string Name, int Size)
        {
            Random random = new Random();
            FontStyle style = FontStyle.Regular;

            if (random.Next(2) == 0)
            {
                style = FontStyle.Bold;
            }

            if (random.Next(2) == 0)
            {
                style |= FontStyle.Italic;
            }

            if (random.Next(2) == 0)
            {
                style |= FontStyle.Strikeout;
            }

            if (random.Next(2) == 0)
            {
                style |= FontStyle.Underline;
            }

            return Make(Name, Size, style);
        }

        public static Font Make(FontStyle Style)
        {
            return Make(RandomFontName(), new Random().Next(MaximumSize), Style);
        }

        public static Font Make(string Name, int Size, FontStyle Style)
        {
            return new Font(Name, Size, Style);
        }

        public static FontFamily[] Fonts
        {
            get
            {
                return new InstalledFontCollection().Families;
            }
        }

        public static string RandomFontName()
        {
            Random random = new Random();
            FontFamily[] fontList = Fonts;
            string name = string.Empty;

            do
            {
                int index = random.Next(fontList.Length);
                if (fontList[index].IsStyleAvailable(FontStyle.Bold) &&
                    fontList[index].IsStyleAvailable(FontStyle.Italic) &&
                    fontList[index].IsStyleAvailable(FontStyle.Underline) &&
                    fontList[index].IsStyleAvailable(FontStyle.Strikeout))
                {
                    name = fontList[index].Name;
                }
            } while (string.IsNullOrEmpty(name));

            return name;
        }

        public static FontFamily RandomFont()
        {
            Random random = new Random();
            FontFamily[] fontList = Fonts;
            string name = string.Empty;
            int index = 0;

            do
            {
                index = random.Next(fontList.Length);
                if (fontList[index].IsStyleAvailable(FontStyle.Bold) &&
                    fontList[index].IsStyleAvailable(FontStyle.Italic) &&
                    fontList[index].IsStyleAvailable(FontStyle.Underline) &&
                    fontList[index].IsStyleAvailable(FontStyle.Strikeout))
                {
                    name = fontList[index].Name;
                }
            } while (string.IsNullOrEmpty(name));

            return fontList[index];
        }
    }
}
