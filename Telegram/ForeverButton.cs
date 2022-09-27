using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    public class ForeverButton : Control
    {
        private int W;

        private int H;

        private bool _Rounded;

        private MouseStateForever State;

        private Color _BaseColor = ForeverLibrary.ForeverColor;

        private Color _TextColor = Color.FromArgb(243, 243, 243);

        [Category("Colors")]
        public Color BaseColor
        {
            get
            {
                return _BaseColor;
            }
            set
            {
                _BaseColor = value;
            }
        }

        [Category("Colors")]
        public Color TextColor
        {
            get
            {
                return _TextColor;
            }
            set
            {
                _TextColor = value;
            }
        }

        [Category("Options")]
        public bool Rounded
        {
            get
            {
                return _Rounded;
            }
            set
            {
                _Rounded = value;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseStateForever.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseStateForever.Over;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseStateForever.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseStateForever.None;
            Invalidate();
        }

        public ForeverButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
            DoubleBuffered = true;
            base.Size = new Size(120, 40);
            BackColor = Color.Transparent;
            Font = new Font("Segoe UI", 12f);
            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(base.Width, base.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            W = base.Width - 1;
            H = base.Height - 1;
            GraphicsPath graphicsPath = new GraphicsPath();
            Rectangle rectangle = new Rectangle(0, 0, W, H);
            Graphics graphics2 = graphics;
            graphics2.SmoothingMode = SmoothingMode.HighQuality;
            graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics2.Clear(BackColor);
            switch (State)
            {
                case MouseStateForever.None:
                    if (Rounded)
                    {
                        graphicsPath = ForeverLibrary.RoundRec(rectangle, 5);
                        graphics2.FillPath(new SolidBrush(_BaseColor), graphicsPath);
                        graphics2.DrawString(Text, Font, new SolidBrush(_TextColor), rectangle, ForeverLibrary.CenterSF);
                    }
                    else
                    {
                        graphics2.FillRectangle(new SolidBrush(_BaseColor), rectangle);
                        graphics2.DrawString(Text, Font, new SolidBrush(_TextColor), rectangle, ForeverLibrary.CenterSF);
                    }

                    break;
                case MouseStateForever.Over:
                    if (Rounded)
                    {
                        graphicsPath = ForeverLibrary.RoundRec(rectangle, 5);
                        graphics2.FillPath(new SolidBrush(_BaseColor), graphicsPath);
                        graphics2.FillPath(new SolidBrush(Color.FromArgb(100, Color.FromArgb(39, 152, 95))), graphicsPath);
                        graphics2.DrawString(Text, Font, new SolidBrush(_TextColor), rectangle, ForeverLibrary.CenterSF);
                    }
                    else
                    {
                        graphics2.FillRectangle(new SolidBrush(_BaseColor), rectangle);
                        graphics2.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.FromArgb(39, 152, 95))), rectangle);
                        graphics2.DrawString(Text, Font, new SolidBrush(_TextColor), rectangle, ForeverLibrary.CenterSF);
                    }

                    break;
                case MouseStateForever.Down:
                    if (Rounded)
                    {
                        graphicsPath = ForeverLibrary.RoundRec(rectangle, 5);
                        graphics2.FillPath(new SolidBrush(_BaseColor), graphicsPath);
                        graphics2.FillPath(new SolidBrush(Color.FromArgb(20, Color.Black)), graphicsPath);
                        graphics2.DrawString(Text, Font, new SolidBrush(_TextColor), rectangle, ForeverLibrary.CenterSF);
                    }
                    else
                    {
                        graphics2.FillRectangle(new SolidBrush(_BaseColor), rectangle);
                        graphics2.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Black)), rectangle);
                        graphics2.DrawString(Text, Font, new SolidBrush(_TextColor), rectangle, ForeverLibrary.CenterSF);
                    }

                    break;
            }

            base.OnPaint(e);
            graphics.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
            bitmap.Dispose();
        }

        private void UpdateColors()
        {
            ForeverColors colors = ForeverLibrary.GetColors(this);
            _BaseColor = colors.Forever;
        }
    }
}
