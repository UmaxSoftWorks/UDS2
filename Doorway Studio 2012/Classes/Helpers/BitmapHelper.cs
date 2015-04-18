using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Umax.Classes.Enums;

namespace Umax.Classes.Helpers
{
    public static class BitmapHelper
    {
        public static Bitmap Make(int Width, int Height)
        {
            Random random = new Random();

            Brush[] brushes = new Brush[]
                                  {
                                      new HatchBrush(HatchStyle.SmallConfetti, Color.LightGray, Color.White),
                                      new LinearGradientBrush(
                                          new Point(0, 0),
                                          new Point(Width, Height),
                                          Color.FromArgb(255,
                                                         random.Next(255),
                                                         random.Next(255),
                                                         random.Next(255)),
                                          Color.FromArgb(
                                              random.Next(255),
                                              random.Next(255),
                                              random.Next(255),
                                              random.Next(255))),
                                      new SolidBrush(Color.FromArgb(255,
                                                                    random.Next(255),
                                                                    random.Next(255),
                                                                    random.Next(255)))
                                  };

            return Make(Width, Height, brushes[random.Next(brushes.Length)]);
        }

        public static Bitmap Make(int Width, int Height, Color Color)
        {
            return Make(Width, Height, new SolidBrush(Color));
        }


        public static Bitmap Make(int Width, int Height, Brush Brush)
        {
            Bitmap bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillRectangle(Brush, new Rectangle(0, 0, Width, Height));
            }

            return bitmap;
        }

        public static void DrawNoise(this Bitmap Image)
        {
            Random random = new Random();

            Image.DrawNoise(new HatchBrush(HatchStyle.SmallConfetti,
                                                  Color.FromArgb(255,
                                                                 random.Next(255),
                                                                 random.Next(255),
                                                                 random.Next(255)),
                                                  Color.FromArgb(255,
                                                                 random.Next(255),
                                                                 random.Next(255),
                                                                 random.Next(255))));
        }

        public static void DrawNoise(this Bitmap Image, Brush Brush)
        {
            Random random = new Random();

            using (Graphics g = Graphics.FromImage(Image))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int m = Math.Max(Image.Width, Image.Height);
                for (int i = 0; i < (int)(Image.Width * Image.Height / 30F); i++)
                {
                    int x = random.Next(Image.Width);
                    int y = random.Next(Image.Height);
                    int w = random.Next(m / 50);
                    int h = random.Next(m / 50);
                    g.FillEllipse(Brush, x, y, w, h);
                }
            }
        }

        public static void DrawFigures(this Bitmap Image, int Number)
        {
            for (int i = 0; i < Number; i++)
            {
                Image.DrawFigure();
            }
        }

        public static void DrawFigures(this Bitmap Image, int Number, BitmapFigureType Type)
        {
            for (int i = 0; i < Number; i++)
            {
                Image.DrawFigure(Type);
            }
        }

        public static void DrawFigures(this Bitmap Image, int Number, Color Color)
        {
            Image.DrawFigures(Number, new SolidBrush(Color));
        }

        public static void DrawFigures(this Bitmap Image, int Number, Brush Brush)
        {
            for (int i = 0; i < Number; i++)
            {
                Image.DrawFigure(Brush);
            }
        }

        public static void DrawFigures(this Bitmap Image, int Number, Color Color, BitmapFigureType Type)
        {
            Image.DrawFigures(Number, new SolidBrush(Color), Type);
        }

        public static void DrawFigures(this Bitmap Image, int Number, Brush Brush, BitmapFigureType Type)
        {
            for (int i = 0; i < Number; i++)
            {
                Image.DrawFigure(Brush, Type);
            }
        }

        public static void DrawFigure(this Bitmap Image)
        {
            Random random = new Random();

            Image.DrawFigure((BitmapFigureType)
                        Enum.Parse(typeof(BitmapFigureType),
                                   Enum.GetNames(typeof(BitmapFigureType))[random.Next(Enum.GetNames(typeof(BitmapFigureType)).Length)]));
        }

        public static void DrawFigure(this Bitmap Image, BitmapFigureType Type)
        {
            Random random = new Random();

            Brush[] brushes = new Brush[]
                                  {
                                      new HatchBrush((HatchStyle)
                                                     Enum.Parse(typeof (HatchStyle),
                                                                Enum.GetNames(typeof (HatchStyle))[
                                                                    random.Next(
                                                                        Enum.GetNames(typeof (HatchStyle)).Length)]),
                                                     Color.FromArgb(255,
                                                                    random.Next(255),
                                                                    random.Next(255),
                                                                    random.Next(255)),
                                                     Color.FromArgb(255,
                                                                    random.Next(255),
                                                                    random.Next(255),
                                                                    random.Next(255))),
                                      new SolidBrush(Color.FromArgb(255,
                                                                    random.Next(255),
                                                                    random.Next(255),
                                                                    random.Next(255)))
                                  };

            Image.DrawFigure(brushes[random.Next(brushes.Length)],
                                    (BitmapFigureType)
                                    Enum.Parse(typeof(BitmapFigureType),
                                               Enum.GetNames(typeof(BitmapFigureType))[random.Next(Enum.GetNames(typeof(BitmapFigureType)).Length)]));
        }

        public static void DrawFigure(this Bitmap Image, Color Color)
        {
            Image.DrawFigure(new SolidBrush(Color));
        }

        public static void DrawFigure(this Bitmap Image, Brush Brush)
        {
            Random random = new Random();
            Image.DrawFigure(Brush, (BitmapFigureType)
                                    Enum.Parse(typeof(BitmapFigureType),
                                               Enum.GetNames(typeof(BitmapFigureType))[
                                                   random.Next(Enum.GetNames(typeof(BitmapFigureType)).Length)]));
        }

        public static void DrawFigure(this Bitmap Image, Color Color, BitmapFigureType Type)
        {
            Image.DrawFigure(new SolidBrush(Color), Type);
        }

        public static void DrawFigure(this Bitmap Image, Brush Brush, BitmapFigureType Type)
        {
            Random random = new Random();
            using (Graphics g = Graphics.FromImage(Image))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                switch (Type)
                {
                    case BitmapFigureType.Circle:
                        {
                            int radius = random.Next(Image.Width / 10);
                            g.DrawEllipse(new Pen(Brush), random.Next(Image.Width), random.Next(Image.Height), radius, radius);
                            break;
                        }

                    case BitmapFigureType.Ellipse:
                        {
                            g.DrawEllipse(new Pen(Brush), random.Next(Image.Width), random.Next(Image.Height), random.Next(Image.Width / 10), random.Next(Image.Height / 10));
                            break;
                        }

                    case BitmapFigureType.Triangle:
                        {
                            break;
                        }

                    case BitmapFigureType.Square:
                        {
                            int radius = random.Next(Image.Width / 10);
                            g.DrawRectangle(new Pen(Brush), random.Next(Image.Width), random.Next(Image.Height), radius, radius);
                            break;
                        }

                    case BitmapFigureType.Paralellogram:
                        {
                            g.DrawRectangle(new Pen(Brush), random.Next(Image.Width), random.Next(Image.Height), random.Next(Image.Width / 10), random.Next(Image.Height / 10));
                            break;
                        }

                    case BitmapFigureType.Pentagon:
                        {

                            break;
                        }

                    case BitmapFigureType.Hexagon:
                        {

                            break;
                        }
                }
            }
        }

        internal const double TextSizeCoefficient = 0.8;

        public static void DrawText(this Bitmap Image, string Text)
        {
            Image.DrawText(Text, new Font(FontFamily.GenericSerif.Name, Image.Height, FontStyle.Bold));
        }

        public static void DrawText(this Bitmap Image, string Text, Color Color)
        {
            Image.DrawText(Text, new Font(FontFamily.GenericSerif.Name, Image.Height, FontStyle.Bold), new SolidBrush(Color));
        }

        public static void DrawText(this Bitmap Image, string Text, Font Font)
        {
            Random random = new Random();

            Brush[] brushes = new Brush[]
                                  {
                                      new HatchBrush(HatchStyle.LargeConfetti, Color.LightGray, Color.DarkGray),
                                      new SolidBrush(Color.FromArgb(0, 0, 0)),
                                      new SolidBrush(Color.FromArgb(255, 255, 255)),
                                      new SolidBrush(Color.FromArgb(255,
                                                                    random.Next(255),
                                                                    random.Next(255),
                                                                    random.Next(255)))
                                  };

            Image.DrawText(Text, Font, brushes[random.Next(brushes.Length)]);
        }

        public static void DrawText(this Bitmap Image, string Text, Font Font, Color Color)
        {
            Image.DrawText(Text, Font, new SolidBrush(Color));
        }

        public static void DrawText(this Bitmap Image, string Text, Font Font, Brush Brush)
        {
            Random random = new Random();
            using (Graphics g = Graphics.FromImage(Image))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rectangle = new Rectangle(0, 0, Image.Width, Image.Height);

                // Set up the text font.
                SizeF size;
                float fontSize = rectangle.Height + 1;

                // Adjust the font size until the text fits within the image.
                do
                {
                    fontSize--;
                    Font = new Font(Font.FontFamily.Name, fontSize);

                    size = g.MeasureString(Text, Font);
                } while (size.Width > TextSizeCoefficient * rectangle.Width);

                // Draw the text.
                g.FillPath(Brush,
                           MakeGraphicsPath(Text, Font, rectangle,
                                            (BitmapTextType)
                                            Enum.Parse(typeof(BitmapTextType),
                                                       Enum.GetNames(typeof(BitmapTextType))[
                                                           random.Next(Enum.GetNames(typeof(BitmapTextType)).Length)])));
            }
        }

        internal static GraphicsPath MakeGraphicsPath(string Text, Font Font, Rectangle Rectangle, BitmapTextType TextType)
        {
            Random random = new Random();

            // Set up the text format.
            StringFormat format = new StringFormat()
                                      {
                                          Alignment = StringAlignment.Center,
                                          LineAlignment = StringAlignment.Center
                                      };

            // Prepare text to draw
            GraphicsPath path = new GraphicsPath();
            switch (TextType)
            {
                case BitmapTextType.Complete:
                    {
                        path.AddString(Text, Font.FontFamily, (int)Font.Style, Font.Size, Rectangle, format);
                        float v = 4F;
                        PointF[] points =
                            {
                                new PointF(random.Next(Rectangle.Width)/v,
                                           random.Next(Rectangle.Height)/v),
                                new PointF(Rectangle.Width - random.Next(Rectangle.Width)/v,
                                           random.Next(Rectangle.Height)/v),
                                new PointF(random.Next(Rectangle.Width)/v,
                                           Rectangle.Height - random.Next(Rectangle.Height)/v),
                                new PointF(Rectangle.Width - random.Next(Rectangle.Width)/v,
                                           Rectangle.Height - random.Next(Rectangle.Height)/v)
                            };

                        Matrix matrix = new Matrix();
                        matrix.Translate(0F, 0F);
                        path.Warp(points, Rectangle, matrix, WarpMode.Perspective, 0F);
                        break;
                    }

                case BitmapTextType.Separated:
                    {
                        string temp = string.Empty;

                        for (int i = 0; i < Text.Length; i++)
                        {
                            temp += Text[i].ToString() + " ";
                        }

                        Text = temp.Trim();
                        if (Text.Length == 0)
                        {
                            Text = " ";
                        }

                        // keyword positioning
                        // to space equally
                        int posx;
                        int posy;
                        int deltax;

                        deltax = Convert.ToInt32((Rectangle.Width * TextSizeCoefficient) / Text.Length);
                        posx = Convert.ToInt32((Rectangle.Width - (Rectangle.Width * TextSizeCoefficient)) / 2);

                        // write each keyword char
                        for (int i = 0; i < Text.Length; i++)
                        {
                            posy = (int)((Rectangle.Height / 2) + ((Rectangle.Height * TextSizeCoefficient) / 2)) + (int)((((i % 2) == 0) ? -2 : 2) * (((Rectangle.Height * TextSizeCoefficient) / 3)));
                            posx += deltax;

                            path.AddString(Text[i].ToString(), Font.FontFamily, (int)Font.Style, Font.Size, new Point(posx, posy), format);
                        }

                        break;
                    }
            }

            return path;
        }

        public static void DrawCurve(this Bitmap Image)
        {
            Image.DrawCurve(new Random().Next(5, 15));
        }

        public static void DrawCurve(this Bitmap Image, Color Color)
        {
            Image.DrawCurve(new Random().Next(5, 15), Color);
        }

        public static void DrawCurve(this Bitmap Image, int Points)
        {
            Image.DrawCurve(Points, Color.Black);
        }

        public static void DrawCurve(this Bitmap Image, int Points, Color Color)
        {
            Random random = new Random();

            using (Graphics g = Graphics.FromImage(Image))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Point[] ps = new Point[Points];

                for (int i = 0; i < Points; i++)
                {
                    ps[i] = new Point(random.Next(Image.Width), random.Next(Image.Height));
                }

                g.DrawCurve(new Pen(Color, 2), ps, Convert.ToSingle(random.NextDouble()));
            }
        }

        public static void DrawImage(this Bitmap Image, Bitmap InsertImage, int X, int Y)
        {
            using (Graphics g = Graphics.FromImage(Image))
            {
                g.DrawImage(InsertImage, X, Y);
            }
        }
    }
}
