using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    internal class Round : Button
    {
        private int bordersize = 0;

        private int borderRadius = 40;

        private Color bordercolor = Color.PaleVioletRed;

        public int Bordersize
        {
            get
            {
                return bordersize;
            }
            set
            {
                bordersize = value;
            }
        }

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
            }
        }

        public Color Bordercolor
        {
            get
            {
                return bordercolor;
            }
            set
            {
                bordercolor = value;
            }
        }

        public Round()
        {
            base.FlatStyle = FlatStyle.Flat;
            base.FlatAppearance.BorderSize = 0;
            base.Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rect.X, rect.Y, radius, radius, 180f, 90f);
            graphicsPath.AddArc(rect.Width - radius, rect.Y, radius, radius, 270f, 90f);
            graphicsPath.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0f, 90f);
            graphicsPath.AddArc(rect.X, rect.Height - radius, radius, radius, 90f, 90f);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rect = new RectangleF(0f, 0f, base.Width, base.Height);
            RectangleF rect2 = new RectangleF(1f, 1f, (float)base.Width - 0.8f, base.Height - 1);
            
            base.Region = new Region(rect);
                using (Pen pen3 = new Pen(bordercolor, bordersize))
                {
                    pen3.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawEllipse(pen3, 0, 0, base.Width - 1, base.Height - 1);
                }
           }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            base.Parent.BackColorChanged += Container_BackColorChanged;
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (base.DesignMode)
            {
                Invalidate();
            }
        }
    }
}
