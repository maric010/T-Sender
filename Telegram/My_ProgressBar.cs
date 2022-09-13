
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Telegram
{
    public class My_ProgressBar : Control
    {
        public enum Style
        {
            ToolTip,
            ValueInSide,
            ValueOutSide
        }
        public static class HopeColors
        {
            public static Color DefaultColor = ColorTranslator.FromHtml("#ffffff");

            public static Color PrimaryColor = ColorTranslator.FromHtml("#409eff");

            public static Color LightPrimary = ColorTranslator.FromHtml("#5cadff");

            public static Color DarkPrimary = ColorTranslator.FromHtml("#2b85e4");

            public static Color Success = ColorTranslator.FromHtml("#67c23a");

            public static Color Warning = ColorTranslator.FromHtml("#e6a23c");

            public static Color Danger = ColorTranslator.FromHtml("#f56c6c");

            public static Color Info = ColorTranslator.FromHtml("#909399");

            public static Color MainText = ColorTranslator.FromHtml("#303133");

            public static Color RegularText = ColorTranslator.FromHtml("#606266");

            public static Color SecondaryText = ColorTranslator.FromHtml("#909399");

            public static Color PlaceholderText = ColorTranslator.FromHtml("#c0c4cc");

            public static Color OneLevelBorder = ColorTranslator.FromHtml("#dcdfe6");

            public static Color TwoLevelBorder = ColorTranslator.FromHtml("#e4e7ed");

            public static Color ThreeLevelBorder = ColorTranslator.FromHtml("#ebeef5");

            public static Color FourLevelBorder = ColorTranslator.FromHtml("#f2f6fc");
        }
        public static class HopeStringAlign
        {
            public static StringFormat TopLeft => new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            };

            public static StringFormat TopCenter => new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Near
            };

            public static StringFormat TopRight => new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Near
            };

            public static StringFormat Left => new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            public static StringFormat Center => new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            public static StringFormat Right => new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };

            public static StringFormat BottomLeft => new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Far
            };

            public static StringFormat BottomCenter => new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Far
            };

            public static StringFormat BottomRight => new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Far
            };
        }
        private Style _style;

        private bool _isError;

        private int _valueNumber;

        private Color _DangerColor = HopeColors.Danger;

        private Color _BaseColor = HopeColors.PrimaryColor;

        private Color _FullBallonColor = HopeColors.Success;

        private Color _FullBarColor = HopeColors.Success;

        private Color _BarColor = HopeColors.OneLevelBorder;

        private string _FullBallonText = "Ok!";

        public Style ProgressBarStyle
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
                Invalidate();
            }
        }

        public bool IsError
        {
            get
            {
                return _isError;
            }
            set
            {
                _isError = value;
                Invalidate();
            }
        }

        public int ValueNumber
        {
            get
            {
                return _valueNumber;
            }
            set
            {
                _valueNumber = ((value > 100) ? 100 : ((value >= 0) ? value : 0));
                Invalidate();
            }
        }

        public Color DangerColor
        {
            get
            {
                return _DangerColor;
            }
            set
            {
                _DangerColor = value;
            }
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

        public Color FullBallonColor
        {
            get
            {
                return _FullBallonColor;
            }
            set
            {
                _FullBallonColor = value;
            }
        }

        public Color FullBarColor
        {
            get
            {
                return _FullBarColor;
            }
            set
            {
                _FullBarColor = value;
            }
        }

        public Color BarColor
        {
            get
            {
                return _BarColor;
            }
            set
            {
                _BarColor = value;
            }
        }

        public string FullBallonText
        {
            get
            {
                return _FullBallonText;
            }
            set
            {
                _FullBallonText = value;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            switch (_style)
            {
                case Style.ToolTip:
                    base.Height = 32;
                    break;
                case Style.ValueInSide:
                    base.Height = 32;
                    break;
                case Style.ValueOutSide:
                    base.Height = 32;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(BackColor);
            Color color = _isError ? _DangerColor : _BaseColor;
            switch (_style)
            {
                case Style.ToolTip:
                    {
                        float num5 = (float)(_valueNumber * (base.Width - 32) / 100) + 16f;
                        int num6 = 25;
                        graphics.FillPolygon(new SolidBrush((_valueNumber == 100 && !_isError) ? _FullBallonColor : color), new PointF[7]
                        {
                    new PointF(num5, num6),
                    new PointF(num5 + 5f, num6 - 5),
                    new PointF(num5 + 16f, num6 - 5),
                    new PointF(num5 + 16f, num6 - 25),
                    new PointF(num5 - 16f, num6 - 25),
                    new PointF(num5 - 16f, num6 - 5),
                    new PointF(num5 - 5f, num6 - 5)
                        });
                        graphics.DrawString((_valueNumber != 100) ? (_valueNumber + "%") : _FullBallonText, Font, new SolidBrush(ForeColor), new RectangleF(num5 - 16f, num6 - 25, 32f, 20f), HopeStringAlign.Center);
                        graphics.FillRectangle(new SolidBrush(_BarColor), new RectangleF(16f, 25f, base.Width - 32, base.Height - 25));
                        graphics.FillRectangle(new SolidBrush((_valueNumber == 100 && !_isError) ? _FullBarColor : color), new RectangleF(16f, 25f, num5 - 16f, base.Height - 25));
                        break;
                    }
                case Style.ValueInSide:
                    {
                        GraphicsPath graphicsPath3 = new GraphicsPath();
                        graphicsPath3.AddArc(new RectangleF(0f, 0f, base.Height, base.Height), 90f, 180f);
                        graphicsPath3.AddArc(new RectangleF(base.Width - base.Height, 0f, base.Height, base.Height), -90f, 180f);
                        graphicsPath3.CloseAllFigures();
                        graphics.FillPath(new SolidBrush(_BarColor), graphicsPath3);
                        if (_valueNumber == 0)
                        {
                        //    graphics.DrawString("0%", new Font("Segoe UI", 9f), new SolidBrush(ForeColor), new RectangleF(5f, 0f, 50f, base.Height), HopeStringAlign.Left);
                            break;
                        }

                        GraphicsPath graphicsPath4 = new GraphicsPath();
                        graphicsPath4.AddArc(new RectangleF(0f, 0f, base.Height, base.Height), 90f, 180f);
                        graphicsPath4.AddArc(new RectangleF(_valueNumber * (base.Width - base.Height) / 100, 0f, base.Height, base.Height), -90f, 180f);
                        graphicsPath4.CloseAllFigures();
                        graphics.FillPath(new SolidBrush((_valueNumber == 100 && !_isError) ? _FullBarColor : color), graphicsPath4);
                        //graphics.DrawString(_valueNumber + "%", new Font("Segoe UI", 9f), new SolidBrush(ForeColor), new RectangleF(_valueNumber * (base.Width - base.Height) / 100 - 33, 0f, 45f, base.Height), HopeStringAlign.Right);
                        break;
                    }
                case Style.ValueOutSide:
                    {
                        GraphicsPath graphicsPath = new GraphicsPath();
                        graphicsPath.AddArc(new RectangleF(0f, 4f, base.Height - 8, base.Height - 8), 90f, 180f);
                        graphicsPath.AddArc(new RectangleF(base.Width - 50, 4f, base.Height - 8, base.Height - 8), -90f, 180f);
                        graphicsPath.CloseAllFigures();
                        graphics.FillPath(new SolidBrush(_BarColor), graphicsPath);
                        if (_valueNumber != 0)
                        {
                            GraphicsPath graphicsPath2 = new GraphicsPath();
                            graphicsPath2.AddArc(new RectangleF(0f, 4f, base.Height - 8, base.Height - 8), 90f, 180f);
                            graphicsPath2.AddArc(new RectangleF(_valueNumber * (base.Width - 50) / 100, 4f, base.Height - 8, base.Height - 8), -90f, 180f);
                            graphicsPath2.CloseAllFigures();
                            graphics.FillPath(new SolidBrush((_valueNumber == 100 && !_isError) ? _FullBarColor : color), graphicsPath2);
                        }

                        if (_isError)
                        {
                            graphics.FillEllipse(new SolidBrush(_DangerColor), new RectangleF(base.Width - 40, 0f, base.Height, base.Height));
                            int num = base.Width - 40 + 4;
                            int num2 = base.Height - 4;
                            graphics.DrawLine(new Pen(ForeColor), num, num2 - 6, num + 6, num2);
                            graphics.DrawLine(new Pen(ForeColor), num + 6, num2 - 6, num, num2);
                        }
                        else if (_valueNumber == 100)
                        {
                            graphics.FillEllipse(new SolidBrush(_FullBarColor), new RectangleF(base.Width - 40, 0f, base.Height, base.Height));
                            int num3 = base.Width - 40 + 4;
                            int num4 = base.Height - 4;
                            graphics.DrawLine(new Pen(ForeColor), num3, num4 - 3, num3 + 3, num4);
                            graphics.DrawLine(new Pen(ForeColor), num3 + 3, num4, num3 + 6, num4 - 6);
                        }
                        else
                        {
                            graphics.DrawString(_valueNumber + "%", new Font("Segoe UI", 10f), new SolidBrush(ForeColor), new RectangleF(base.Width - 40, 0f, 50f, base.Height), HopeStringAlign.Left);
                        }

                        break;
                    }
            }
        }

        public My_ProgressBar()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10f);
            ForeColor = HopeColors.FourLevelBorder;
        }
    }

}