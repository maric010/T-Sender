using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    public class TPanel : Panel
    {
        private float _thickness = 1;
        public float Thickness
        {
            get
            {
                return _thickness;
            }
            set
            {
                _thickness = value;
                _pen = new Pen(_borderColor, Thickness);
                Invalidate();
            }
        }

        private Color _borderColor = Color.FromArgb(170, 212, 235);
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                _pen = new Pen(_borderColor, Thickness);
                Invalidate();
            }
        }

        private int _radius = 20;
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
                Invalidate();
            }
        }

        private Pen _pen;

        public TPanel() : base()
        {
            _pen = new Pen(BorderColor, Thickness);
            DoubleBuffered = true;
        }
        private Rectangle GetLeftUpper(int e)
        {
            return new Rectangle(0, 0, e, e);
        }
        private Rectangle GetRightUpper(int e)
        {
            return new Rectangle(Width - e, 0, e, e);
        }
        private Rectangle GetRightLower(int e)
        {
            return new Rectangle(Width - e, Height - e, e, e);
        }
        private Rectangle GetLeftLower(int e)
        {
            return new Rectangle(0, Height - e, e, e);
        }
        GraphicsPath path;
        private void ExtendedDraw(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            path = new GraphicsPath();
            path.AddArc(0, 0, 10, 10, 180f, 90f);
            path.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
            path.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
            path.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
            path.CloseAllFigures();
            //Region = new Region(path);
        }
        private void DrawSingleBorder(Graphics graphics)
        {
            /*
            graphics.DrawArc(_pen, new Rectangle(0, 0, Radius, Radius), 180, 90);
            graphics.DrawArc(_pen, new Rectangle(Width - Radius - 1, -1, Radius, Radius), 270, 90);
            graphics.DrawArc(_pen, new Rectangle(Width - Radius - 1, Height - Radius - 1, Radius, Radius), 0, 90);
            graphics.DrawArc(_pen, new Rectangle(0, Height - Radius - 1, Radius, Radius), 90, 90);
            */

            //graphics.FillPath(B1, Shape);
            graphics.DrawPath(_pen, path);
            //graphics.DrawRectangle(_pen, 0.0f, 0.0f, (float)Width - 1.0f, (float)Height - 1.0f);
        
        }
        private void Draw3DBorder(Graphics graphics)
        {
            DrawSingleBorder(graphics);
        }
        private void DrawBorder(Graphics graphics)
        {
            DrawSingleBorder(graphics);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ExtendedDraw(e);
            DrawBorder(e.Graphics);
        }
    }
}
