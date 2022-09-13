using System.Drawing;
using System.Drawing.Drawing2D;

namespace Telegram
{
    public abstract class RoundedRectangle
    {
        public enum RectangleCorners
        {
            None = 0,
            TopLeft = 1,
            TopRight = 2,
            BottomLeft = 4,
            BottomRight = 8,
            All = 0xF
        }

        public static GraphicsPath Create(int x, int y, int width, int height, int radius, RectangleCorners corners)
        {
            int num = x + width;
            int num2 = y + height;
            int num3 = num - radius;
            int num4 = num2 - radius;
            int num5 = x + radius;
            int num6 = y + radius;
            int num7 = radius * 2;
            int x2 = num - num7;
            int y2 = num2 - num7;
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            if ((RectangleCorners.TopLeft & corners) == RectangleCorners.TopLeft)
            {
                graphicsPath.AddArc(x, y, num7, num7, 180f, 90f);
            }
            else
            {
                graphicsPath.AddLine(x, num6, x, y);
                graphicsPath.AddLine(x, y, num5, y);
            }

            graphicsPath.AddLine(num5, y, num3, y);
            if ((RectangleCorners.TopRight & corners) == RectangleCorners.TopRight)
            {
                graphicsPath.AddArc(x2, y, num7, num7, 270f, 90f);
            }
            else
            {
                graphicsPath.AddLine(num3, y, num, y);
                graphicsPath.AddLine(num, y, num, num6);
            }

            graphicsPath.AddLine(num, num6, num, num4);
            if ((RectangleCorners.BottomRight & corners) == RectangleCorners.BottomRight)
            {
                graphicsPath.AddArc(x2, y2, num7, num7, 0f, 90f);
            }
            else
            {
                graphicsPath.AddLine(num, num4, num, num2);
                graphicsPath.AddLine(num, num2, num3, num2);
            }

            graphicsPath.AddLine(num3, num2, num5, num2);
            if ((RectangleCorners.BottomLeft & corners) == RectangleCorners.BottomLeft)
            {
                graphicsPath.AddArc(x, y2, num7, num7, 90f, 90f);
            }
            else
            {
                graphicsPath.AddLine(num5, num2, x, num2);
                graphicsPath.AddLine(x, num2, x, num4);
            }

            graphicsPath.AddLine(x, num4, x, num6);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        public static GraphicsPath Create(Rectangle rect, int radius, RectangleCorners c)
        {
            return Create(rect.X, rect.Y, rect.Width, rect.Height, radius, c);
        }

        public static GraphicsPath Create(int x, int y, int width, int height, int radius)
        {
            return Create(x, y, width, height, radius, RectangleCorners.All);
        }

        public static GraphicsPath Create(Rectangle rect, int radius)
        {
            return Create(rect.X, rect.Y, rect.Width, rect.Height, radius);
        }

        public static GraphicsPath Create(int x, int y, int width, int height)
        {
            return Create(x, y, width, height, 5);
        }

        public static GraphicsPath Create(Rectangle rect)
        {
            return Create(rect.X, rect.Y, rect.Width, rect.Height);
        }
    }
}
