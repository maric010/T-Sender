using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    public static class FoxLibrary
    {
        public enum MouseState : byte
        {
            None,
            Over,
            Down
        }

        public enum RoundingStyle : byte
        {
            All,
            Top,
            Bottom,
            Left,
            Right,
            TopRight,
            BottomRight
        }

        public static void CenterString(Graphics G, string T, Font F, Color C, Rectangle R)
        {
            SizeF sizeF = G.MeasureString(T, F);
            using (SolidBrush brush = new SolidBrush(C))
            {//(int)((float)(R.X + R.Width / 2) - sizeF.Width / 2f)
                G.DrawString(T, F, brush, new Point(40, (int)((float)(R.Y + R.Height / 2) - sizeF.Height / 2f)));
            }
        }

        public static Color ColorFromHex(string Hex)
        {
            return Color.FromArgb((int)long.Parse($"FFFFFFFFFF{Hex.Substring(1)}", NumberStyles.HexNumber));
        }

        public static Rectangle FullRectangle(Size S, bool Subtract)
        {
            if (Subtract)
            {
                return new Rectangle(0, 0, S.Width - 1, S.Height - 1);
            }

            return new Rectangle(0, 0, S.Width, S.Height);
        }

        public static GraphicsPath RoundRect(Rectangle Rect, int Rounding, RoundingStyle Style = RoundingStyle.All)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            int num = Rounding * 2;
            graphicsPath.StartFigure();
            if (Rounding == 0)
            {
                graphicsPath.AddRectangle(Rect);
                graphicsPath.CloseAllFigures();
                return graphicsPath;
            }

            switch (Style)
            {
                case RoundingStyle.All:
                    graphicsPath.AddArc(new Rectangle(Rect.X, Rect.Y, num, num), -180f, 90f);
                    graphicsPath.AddArc(new Rectangle(Rect.Width - num + Rect.X, Rect.Y, num, num), -90f, 90f);
                    graphicsPath.AddArc(new Rectangle(Rect.Width - num + Rect.X, Rect.Height - num + Rect.Y, num, num), 0f, 90f);
                    graphicsPath.AddArc(new Rectangle(Rect.X, Rect.Height - num + Rect.Y, num, num), 90f, 90f);
                    break;
                case RoundingStyle.Top:
                    graphicsPath.AddArc(new Rectangle(Rect.X, Rect.Y, num, num), -180f, 90f);
                    graphicsPath.AddArc(new Rectangle(Rect.Width - num + Rect.X, Rect.Y, num, num), -90f, 90f);
                    graphicsPath.AddLine(new Point(Rect.X + Rect.Width, Rect.Y + Rect.Height), new Point(Rect.X, Rect.Y + Rect.Height));
                    break;
                case RoundingStyle.Bottom:
                    graphicsPath.AddLine(new Point(Rect.X, Rect.Y), new Point(Rect.X + Rect.Width, Rect.Y));
                    graphicsPath.AddArc(new Rectangle(Rect.Width - num + Rect.X, Rect.Height - num + Rect.Y, num, num), 0f, 90f);
                    graphicsPath.AddArc(new Rectangle(Rect.X, Rect.Height - num + Rect.Y, num, num), 90f, 90f);
                    break;
                case RoundingStyle.Left:
                    graphicsPath.AddArc(new Rectangle(Rect.X, Rect.Y, num, num), -180f, 90f);
                    graphicsPath.AddLine(new Point(Rect.X + Rect.Width, Rect.Y), new Point(Rect.X + Rect.Width, Rect.Y + Rect.Height));
                    graphicsPath.AddArc(new Rectangle(Rect.X, Rect.Height - num + Rect.Y, num, num), 90f, 90f);
                    break;
                case RoundingStyle.Right:
                    graphicsPath.AddLine(new Point(Rect.X, Rect.Y + Rect.Height), new Point(Rect.X, Rect.Y));
                    graphicsPath.AddArc(new Rectangle(Rect.Width - num + Rect.X, Rect.Y, num, num), -90f, 90f);
                    graphicsPath.AddArc(new Rectangle(Rect.Width - num + Rect.X, Rect.Height - num + Rect.Y, num, num), 0f, 90f);
                    break;
                case RoundingStyle.TopRight:
                    graphicsPath.AddLine(new Point(Rect.X, Rect.Y + 1), new Point(Rect.X, Rect.Y));
                    graphicsPath.AddArc(new Rectangle(Rect.Width - num + Rect.X, Rect.Y, num, num), -90f, 90f);
                    graphicsPath.AddLine(new Point(Rect.X + Rect.Width, Rect.Y + Rect.Height - 1), new Point(Rect.X + Rect.Width, Rect.Y + Rect.Height));
                    graphicsPath.AddLine(new Point(Rect.X + 1, Rect.Y + Rect.Height), new Point(Rect.X, Rect.Y + Rect.Height));
                    break;
                case RoundingStyle.BottomRight:
                    graphicsPath.AddLine(new Point(Rect.X, Rect.Y + 1), new Point(Rect.X, Rect.Y));
                    graphicsPath.AddLine(new Point(Rect.X + Rect.Width - 1, Rect.Y), new Point(Rect.X + Rect.Width, Rect.Y));
                    graphicsPath.AddArc(new Rectangle(Rect.Width - num + Rect.X, Rect.Height - num + Rect.Y, num, num), 0f, 90f);
                    graphicsPath.AddLine(new Point(Rect.X + 1, Rect.Y + Rect.Height), new Point(Rect.X, Rect.Y + Rect.Height));
                    break;
            }

            graphicsPath.CloseAllFigures();
            return graphicsPath;
        }
    }
}
