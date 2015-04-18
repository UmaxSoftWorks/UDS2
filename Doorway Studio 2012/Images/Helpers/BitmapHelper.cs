using System;
using System.Drawing;
using Umax.Classes.Helpers;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Helpers
{
    internal static class BitmapHelper
    {
        public static Bitmap Make(int Width, int Height, ColorSettings Settings)
        {
            Random random = new Random();

            switch (Settings.Color)
            {
                case ColorType.Random:
                    {
                        return Make(Width, Height);
                    }

                case ColorType.Range:
                    {
                        return Make(Width, Height, Color.FromArgb(
                            random.Next(Settings.SelectedColorRangeRMin, Settings.SelectedColorRangeRMax),
                            random.Next(Settings.SelectedColorRangeGMin, Settings.SelectedColorRangeGMax),
                            random.Next(Settings.SelectedColorRangeBMin, Settings.SelectedColorRangeBMax)));
                    }

                case ColorType.Selected:
                    {
                        return Make(Width, Height, Settings.SelectedColor);
                    }
            }

            return Make(Width, Height);
        }

        public static Bitmap Make(int Width, int Height)
        {
            Random random = new Random();

            return Make(Width, Height, Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
        }

        public static Bitmap Make(int Width, int Height, Color Color)
        {
            return Make(Width, Height, Color);
        }

        public static void DrawFigures(this Bitmap Image, int Figures, ColorSettings Settings)
        {
            Random random = new Random();

            switch (Settings.Color)
            {
                case ColorType.Random:
                    {
                        for (int i = 0; i < Figures; i++)
                        {
                            Image.DrawFigure(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
                        }

                        break;
                    }

                case ColorType.Range:
                    {
                        for (int i = 0; i < Figures; i++)
                        {
                            Image.DrawFigure(
                                Color.FromArgb(
                                    random.Next(Settings.SelectedColorRangeRMin, Settings.SelectedColorRangeRMax),
                                    random.Next(Settings.SelectedColorRangeGMin, Settings.SelectedColorRangeGMax),
                                    random.Next(Settings.SelectedColorRangeBMin, Settings.SelectedColorRangeBMax)));
                        }

                        break;
                    }

                case ColorType.Selected:
                    {
                        Image.DrawFigures(Figures, Settings.SelectedColor);
                        break;
                    }
            }
        }

        public static void DrawText(this Bitmap Image, string Text, FontSettings Settings)
        {
            Font font = FontHelper.Make(Settings);
            Random random = new Random();

            switch (Settings.FontColorSettings.Color)
            {
                case ColorType.Random:
                    {
                        Image.DrawText(Text, font);

                        break;
                    }

                case ColorType.Range:
                    {
                        Image.DrawText(Text, font,
                                       Color.FromArgb(
                                           random.Next(Settings.FontColorSettings.SelectedColorRangeRMin,
                                                       Settings.FontColorSettings.SelectedColorRangeRMax),
                                           random.Next(Settings.FontColorSettings.SelectedColorRangeGMin,
                                                       Settings.FontColorSettings.SelectedColorRangeGMax),
                                           random.Next(Settings.FontColorSettings.SelectedColorRangeBMin,
                                                       Settings.FontColorSettings.SelectedColorRangeBMax)));
                        break;
                    }

                case ColorType.Selected:
                    {
                        Image.DrawText(Text, font, Settings.FontColorSettings.SelectedColor);
                        break;
                    }
            }
        }

        public static void Resize(this Bitmap Image, int Width, int Height, ResizeType Type)
        {
            Image.Resize(Width, Height, Type, Color.FromArgb(0, 0, 0));
        }

        public static void Resize(this Bitmap Image, int Width, int Height, ResizeType Type, ColorSettings Settings)
        {
            Random random = new Random();

            switch (Settings.Color)
            {
                case ColorType.Random:
                    {
                        Image.Resize(Width, Height, Type,
                                     Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
                        break;
                    }

                case ColorType.Range:
                    {
                        Image.Resize(Width, Height, Type,
                                     Color.FromArgb(
                                         random.Next(Settings.SelectedColorRangeRMin,
                                                     Settings.SelectedColorRangeRMax),
                                         random.Next(Settings.SelectedColorRangeGMin,
                                                     Settings.SelectedColorRangeGMax),
                                         random.Next(Settings.SelectedColorRangeBMin,
                                                     Settings.SelectedColorRangeBMax)));
                        break;
                    }

                case ColorType.Selected:
                    {
                        Image.Resize(Width, Height, Type, Settings.SelectedColor);
                        break;
                    }
            }
        }

        public static void Resize(this Bitmap Image, int Width, int Height, ResizeType Type, Color Color)
        {
            switch (Type)
            {
                case ResizeType.KeepRatio:
                    {
                        Image.Resize(Width, Height, Color, true);
                        break;
                    }

                case ResizeType.IgnoreRatio:
                    {
                        Image.Resize(Width, Height, Color, false);
                        break;
                    }

                case ResizeType.KeepRatioBackground:
                    {
                        // Resize
                        Image.Resize(Width, Height, Color, true);

                        // Background
                        Bitmap image = Make(Width, Height, Color);
                        image.DrawImage(Image, (Width - Image.Width)/2, (Height - Image.Height)/2);
                        Image = image;
                        break;
                    }
            }
        }

        internal static void Resize(this Bitmap Image, int Width, int Height, Color Color, bool KeepRatio)
        {
            if (KeepRatio)
            {
                int NewHeight = Image.Height*Width/Image.Width;
                if (NewHeight > Height)
                {
                    // Resize with height instead
                    Width = Image.Width*Height/Image.Height;
                    NewHeight = Height;
                }
            }

            Image.Resize(Width, Height);
        }

        internal static void Resize(this Bitmap Image, int Width, int Height)
        {
            Bitmap result = new Bitmap(Width, Height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(Image, 0, 0, Width, Height);
            }

            Image = result;
        }
    }
}
