using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    public class My_Form : AirLibrary
    {
        private Color TitleColor;

        private Color Xcolor;

        private Color Xellipse;

        private int X;

        private int Y;

        public My_Form()
        {
            base.TransparencyKey = Color.Fuchsia;
            base.StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 9f);
            SetColor("Title color", Color.Black);
            SetColor("X-color", 90, 90, 90);
            SetColor("X-ellipse", 114, 114, 114);
            MinimumSize = new Size(112, 35);
        }

        protected override void ColorHook()
        {
            TitleColor = GetColor("Title color");
            Xcolor = GetColor("X-color");
            Xellipse = GetColor("X-ellipse");
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            X = e.Location.X;
            Y = e.Location.Y;
            base.OnMouseMove(e);
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnClick(e);
        }

        protected override void PaintHook()
        {
            G.Clear(BackColor);
            DrawCorners(Color.Fuchsia);
            DrawCorners(Color.Fuchsia, 1, 0, base.Width - 2, base.Height);
            DrawCorners(Color.Fuchsia, 0, 1, base.Width, base.Height - 2);
            DrawCorners(Color.Fuchsia, 2, 0, base.Width - 4, base.Height);
            DrawCorners(Color.Fuchsia, 0, 2, base.Width, base.Height - 4);
            G.SmoothingMode = SmoothingMode.HighQuality;
            DrawText(new SolidBrush(TitleColor), new Point(8, 7));
        }
    }
}
