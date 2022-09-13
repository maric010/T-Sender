using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;
namespace Telegram
{
    public class TButton : ButtonFoxBase
    {
        private Graphics G;

        private Color _BaseColor = FoxLibrary.ColorFromHex("#F9F9F9");

        private Color _OverColor = FoxLibrary.ColorFromHex("#F2F2F2");

        private Color _DownColor = FoxLibrary.ColorFromHex("#E8E8E8");

        private Color _BorderColor = FoxLibrary.ColorFromHex("#C1C1C1");

        private Color _DisabledBaseColor = FoxLibrary.ColorFromHex("#F9F9F9");

        private Color _DisabledTextColor = FoxLibrary.ColorFromHex("#A6B2BE");

        private Color _DisabledBorderColor = FoxLibrary.ColorFromHex("#D1D1D1");

        private StringAlignment _TextAlignment = StringAlignment.Center;
        private Image _Image;

        private Size _ImageSize;

        private ContentAlignment _ImageAlign = ContentAlignment.MiddleLeft;
        public Image Image
        {
            get
            {
                return _Image;
            }
            set
            {
                if (value == null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;
                Invalidate();
            }
        }
        public ContentAlignment ImageAlign
        {
            get
            {
                return _ImageAlign;
            }
            set
            {
                _ImageAlign = value;
                Invalidate();
            }
        }
        private static PointF ImageLocation(StringFormat SF, SizeF Area, SizeF ImageArea)
        {
            PointF result = default(PointF);
            switch (SF.Alignment)
            {
                case StringAlignment.Center:
                    result.X = (Area.Width - ImageArea.Width) / 2f;
                    break;
                case StringAlignment.Near:
                    result.X = 2f;
                    break;
                case StringAlignment.Far:
                    result.X = Area.Width - ImageArea.Width - 2f;
                    break;
            }

            switch (SF.LineAlignment)
            {
                case StringAlignment.Center:
                    result.Y = (Area.Height - ImageArea.Height) / 2f;
                    break;
                case StringAlignment.Near:
                    result.Y = 2f;
                    break;
                case StringAlignment.Far:
                    result.Y = Area.Height - ImageArea.Height - 2f;
                    break;
            }

            return result;
        }

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

        public Color OverColor
        {
            get
            {
                return _OverColor;
            }
            set
            {
                _OverColor = value;
            }
        }

        public Color DownColor
        {
            get
            {
                return _DownColor;
            }
            set
            {
                _DownColor = value;
            }
        }

        public Color BorderColor
        {
            get
            {
                return _BorderColor;
            }
            set
            {
                _BorderColor = value;
            }
        }

        public Color DisabledBaseColor
        {
            get
            {
                return _DisabledBaseColor;
            }
            set
            {
                _DisabledBaseColor = value;
            }
        }

        public Color DisabledTextColor
        {
            get
            {
                return _DisabledTextColor;
            }
            set
            {
                _DisabledTextColor = value;
            }
        }

        public Color DisabledBorderColor
        {
            get
            {
                return _DisabledBorderColor;
            }
            set
            {
                _DisabledBorderColor = value;
            }
        }
        public StringAlignment TextAlignment
        {
            get
            {
                return _TextAlignment;
            }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }
        public TButton()
        {
            Font = new Font("Segoe UI", 10f);
            _TextAlignment = StringAlignment.Center;
        }
        private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
        {
            StringFormat stringFormat = new StringFormat();
            switch (_ContentAlignment)
            {
                case ContentAlignment.MiddleCenter:
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleLeft:
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleRight:
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.TopCenter:
                    stringFormat.LineAlignment = StringAlignment.Near;
                    stringFormat.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.TopLeft:
                    stringFormat.LineAlignment = StringAlignment.Near;
                    stringFormat.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    stringFormat.LineAlignment = StringAlignment.Near;
                    stringFormat.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    stringFormat.LineAlignment = StringAlignment.Far;
                    stringFormat.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    stringFormat.LineAlignment = StringAlignment.Far;
                    stringFormat.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.BottomRight:
                    stringFormat.LineAlignment = StringAlignment.Far;
                    stringFormat.Alignment = StringAlignment.Far;
                    break;
            }

            return stringFormat;
        }
        protected Size ImageSize => _ImageSize;
        protected override void OnPaint(PaintEventArgs e)
        {
            G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            PointF pointF = ImageLocation(GetStringFormat(ImageAlign), base.Size, ImageSize);
            G.Clear(base.Parent.BackColor);
            
            if (base.Enabled)
            {
                switch (State)
                {
                    case FoxLibrary.MouseState.None:
                        {
                            using (SolidBrush brush3 = new SolidBrush(_BaseColor))
                            {
                                G.FillPath(brush3, FoxLibrary.RoundRect(FoxLibrary.FullRectangle(base.Size, Subtract: true), 0));
                            }

                            break;
                        }
                    case FoxLibrary.MouseState.Over:
                        {
                            using (SolidBrush brush2 = new SolidBrush(_OverColor))
                            {
                                G.FillPath(brush2, FoxLibrary.RoundRect(FoxLibrary.FullRectangle(base.Size, Subtract: true), 0));
                            }

                            break;
                        }
                    case FoxLibrary.MouseState.Down:
                        {
                            using (SolidBrush brush = new SolidBrush(_DownColor))
                            {
                                G.FillPath(brush, FoxLibrary.RoundRect(FoxLibrary.FullRectangle(base.Size, Subtract: true), 0));
                            }

                            break;
                        }
                }

                using (Pen pen = new Pen(_BorderColor))
                {
                    G.DrawPath(pen, FoxLibrary.RoundRect(FoxLibrary.FullRectangle(base.Size, Subtract: true), 0));
                }

                using (SolidBrush solidBrush = new SolidBrush(ForeColor))
                {
                    FoxLibrary.CenterString(G, Text, Font, solidBrush.Color, new Rectangle(3, 0, base.Width, base.Height));
                }
            }
            else
            {
                using (SolidBrush brush4 = new SolidBrush(_DisabledBaseColor))
                {
                    G.FillPath(brush4, FoxLibrary.RoundRect(FoxLibrary.FullRectangle(base.Size, Subtract: true), 0));
                }

                using (SolidBrush solidBrush2 = new SolidBrush(_DisabledTextColor))
                {
                    FoxLibrary.CenterString(G, Text, Font, solidBrush2.Color, new Rectangle(3, 0, base.Width, base.Height));
                }


                using (Pen pen2 = new Pen(_DisabledBorderColor))
                {
                    G.DrawPath(pen2, FoxLibrary.RoundRect(FoxLibrary.FullRectangle(base.Size, Subtract: true), 0));
                }
            }

            base.OnPaint(e);
        }
    }
}
