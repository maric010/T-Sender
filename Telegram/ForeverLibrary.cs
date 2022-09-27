using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    public class ForeverColors
    {
        public Color Forever = ForeverLibrary.ForeverColor;
    }
    public static class ForeverLibrary
    {
        public static Color ForeverColor = Color.FromArgb(49, 193, 120);

        public static readonly StringFormat NearSF = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Near
        };

        public static readonly StringFormat CenterSF = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        public static GraphicsPath RoundRec(Rectangle Rectangle, int Curve)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            int num = Curve * 2;
            graphicsPath.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, num, num), -180f, 90f);
            graphicsPath.AddArc(new Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Y, num, num), -90f, 90f);
            graphicsPath.AddArc(new Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 0f, 90f);
            graphicsPath.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 90f, 90f);
            graphicsPath.AddLine(new Point(Rectangle.X, Rectangle.Height - num + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return graphicsPath;
        }

        public static GraphicsPath RoundRect(float x, float y, float w, float h, double r = 0.3, bool TL = true, bool TR = true, bool BR = true, bool BL = true)
        {
            float num = Math.Min(w, h) * (float)r;
            float num2 = x + w;
            float num3 = y + h;
            GraphicsPath graphicsPath;
            GraphicsPath result = graphicsPath = new GraphicsPath();
            if (TL)
            {
                graphicsPath.AddArc(x, y, num, num, 180f, 90f);
            }
            else
            {
                graphicsPath.AddLine(x, y, x, y);
            }

            if (TR)
            {
                graphicsPath.AddArc(num2 - num, y, num, num, 270f, 90f);
            }
            else
            {
                graphicsPath.AddLine(num2, y, num2, y);
            }

            if (BR)
            {
                graphicsPath.AddArc(num2 - num, num3 - num, num, num, 0f, 90f);
            }
            else
            {
                graphicsPath.AddLine(num2, num3, num2, num3);
            }

            if (BL)
            {
                graphicsPath.AddArc(x, num3 - num, num, num, 90f, 90f);
            }
            else
            {
                graphicsPath.AddLine(x, num3, x, num3);
            }

            graphicsPath.CloseFigure();
            return result;
        }

        public static GraphicsPath DrawArrow(int x, int y, bool flip)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            int num = 12;
            int num2 = 6;
            if (flip)
            {
                graphicsPath.AddLine(x + 1, y, x + num + 1, y);
                graphicsPath.AddLine(x + num, y, x + num2, y + num2 - 1);
            }
            else
            {
                graphicsPath.AddLine(x, y + num2, x + num, y + num2);
                graphicsPath.AddLine(x + num, y + num2, x + num2, y);
            }

            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        public static ForeverColors GetColors(Control control)
        {
            if (control == null)
            {
                throw new ArgumentNullException();
            }

            ForeverColors foreverColors = new ForeverColors();
            while (control != null && control.GetType() != typeof(ForeverForm))
            {
                control = control.Parent;
            }

            if (control != null)
            {
                ForeverForm foreverForm = (ForeverForm)control;
                foreverColors.Forever = foreverForm.ForeverColor;
            }

            return foreverColors;
        }
    }
}
