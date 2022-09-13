using ReaLTaiizor.Enum.Metro;
using ReaLTaiizor.Extension.Metro;
using ReaLTaiizor.Interface.Metro;
using ReaLTaiizor.Manager;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using ReaLTaiizor.Action.Metro;
using System.Collections;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.Drawing.Imaging;
namespace Telegram
{

    internal class MetroEllipseDesigner : ControlDesigner
    {
        private readonly string[] _propertiesToRemove = new string[5]
        {
            "BackgroundImage",
            "BackgroundImageLayout",
            "ForeColor",
            "RightToLeft",
            "ImeMode"
        };

        private DesignerActionListCollection _actionListCollection;

        public override DesignerActionListCollection ActionLists
        {
            get
            {
                DesignerActionListCollection designerActionListCollection = _actionListCollection;
                if (designerActionListCollection == null)
                {
                    DesignerActionListCollection obj = new DesignerActionListCollection
                    {
                        new MetroEllipseActionList(base.Component)
                    };
                    DesignerActionListCollection designerActionListCollection2 = obj;
                    _actionListCollection = obj;
                    designerActionListCollection = designerActionListCollection2;
                }

                return designerActionListCollection;
            }
        }

        protected override void PostFilterProperties(IDictionary properties)
        {
            string[] propertiesToRemove = _propertiesToRemove;
            foreach (string key in propertiesToRemove)
            {
                properties.Remove(key);
            }

            base.PostFilterProperties(properties);
        }
    }

    internal class Methods
    {
        public static void DrawImageFromBase64(Graphics graphics, string base64Image, Rectangle rect)
        {
            Image image;
            using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(base64Image)))
            {
                image = Image.FromStream(memoryStream);
                memoryStream.Close();
            }

            graphics.DrawImage(image, rect);
        }

        public static void DrawImageWithColor(Graphics G, Rectangle r, Image image, Color c)
        {
            float[][] newColorMatrix = new float[5][]
            {
                new float[5]
                {
                    Convert.ToSingle((double)(int)c.R / 255.0),
                    0f,
                    0f,
                    0f,
                    0f
                },
                new float[5]
                {
                    0f,
                    Convert.ToSingle((double)(int)c.G / 255.0),
                    0f,
                    0f,
                    0f
                },
                new float[5]
                {
                    0f,
                    0f,
                    Convert.ToSingle((double)(int)c.B / 255.0),
                    0f,
                    0f
                },
                new float[5]
                {
                    0f,
                    0f,
                    0f,
                    Convert.ToSingle((double)(int)c.A / 255.0),
                    0f
                },
                new float[5]
                {
                    Convert.ToSingle((double)(int)c.R / 255.0),
                    Convert.ToSingle((double)(int)c.G / 255.0),
                    Convert.ToSingle((double)(int)c.B / 255.0),
                    0f,
                    Convert.ToSingle((double)(int)c.A / 255.0)
                }
            };
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(new ColorMatrix(newColorMatrix), ColorMatrixFlag.Default, ColorAdjustType.Default);
            G.DrawImage(image, r, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            image.Dispose();
        }

        public static void DrawImageWithColor(Graphics G, Rectangle r, string image, Color c)
        {
            Image image2 = ImageFromBase64(image);
            float[][] newColorMatrix = new float[5][]
            {
                new float[5]
                {
                    Convert.ToSingle((double)(int)c.R / 255.0),
                    0f,
                    0f,
                    0f,
                    0f
                },
                new float[5]
                {
                    0f,
                    Convert.ToSingle((double)(int)c.G / 255.0),
                    0f,
                    0f,
                    0f
                },
                new float[5]
                {
                    0f,
                    0f,
                    Convert.ToSingle((double)(int)c.B / 255.0),
                    0f,
                    0f
                },
                new float[5]
                {
                    0f,
                    0f,
                    0f,
                    Convert.ToSingle((double)(int)c.A / 255.0),
                    0f
                },
                new float[5]
                {
                    Convert.ToSingle((double)(int)c.R / 255.0),
                    Convert.ToSingle((double)(int)c.G / 255.0),
                    Convert.ToSingle((double)(int)c.B / 255.0),
                    0f,
                    Convert.ToSingle((double)(int)c.A / 255.0)
                }
            };
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(new ColorMatrix(newColorMatrix), ColorMatrixFlag.Default, ColorAdjustType.Default);
            G.DrawImage(image2, r, 0, 0, image2.Width, image2.Height, GraphicsUnit.Pixel, imageAttributes);
        }

        public StringFormat SetPosition(StringAlignment horizontal = StringAlignment.Center, StringAlignment vertical = StringAlignment.Center)
        {
            return new StringFormat
            {
                Alignment = horizontal,
                LineAlignment = vertical
            };
        }

        public static float[][] ColorToMatrix(float alpha, Color c)
        {
            return new float[5][]
            {
                new float[5]
                {
                    Convert.ToSingle((int)c.R / 255),
                    0f,
                    0f,
                    0f,
                    0f
                },
                new float[5]
                {
                    0f,
                    Convert.ToSingle((int)c.G / 255),
                    0f,
                    0f,
                    0f
                },
                new float[5]
                {
                    0f,
                    0f,
                    Convert.ToSingle((int)c.B / 255),
                    0f,
                    0f
                },
                new float[5]
                {
                    0f,
                    0f,
                    0f,
                    Convert.ToSingle((int)c.A / 255),
                    0f
                },
                new float[5]
                {
                    Convert.ToSingle((int)c.R / 255),
                    Convert.ToSingle((int)c.G / 255),
                    Convert.ToSingle((int)c.B / 255),
                    alpha,
                    Convert.ToSingle((int)c.A / 255)
                }
            };
        }

        public void DrawImageWithTransparency(Graphics G, float alpha, Image image, Rectangle rect)
        {
            ColorMatrix colorMatrix = new ColorMatrix
            {
                Matrix33 = alpha
            };
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);
            G.DrawImage(image, new Rectangle(rect.X, rect.Y, image.Width, image.Height), rect.X, rect.Y, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            imageAttributes.Dispose();
        }

        public static Image ImageFromBase64(string base64Image)
        {
            using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(base64Image)))
            {
                return Image.FromStream(stream);
            }
        }

        public static GraphicsPath RoundRec(Rectangle r, int curve, bool topLeft = true, bool topRight = true, bool bottomLeft = true, bool bottomRight = true)
        {
            GraphicsPath graphicsPath = new GraphicsPath(FillMode.Winding);
            if (topLeft)
            {
                graphicsPath.AddArc(r.X, r.Y, curve, curve, 180f, 90f);
            }
            else
            {
                graphicsPath.AddLine(r.X, r.Y, r.X, r.Y);
            }

            if (topRight)
            {
                graphicsPath.AddArc(r.Right - curve, r.Y, curve, curve, 270f, 90f);
            }
            else
            {
                graphicsPath.AddLine(r.Right - r.Width, r.Y, r.Width, r.Y);
            }

            if (bottomRight)
            {
                graphicsPath.AddArc(r.Right - curve, r.Bottom - curve, curve, curve, 0f, 90f);
            }
            else
            {
                graphicsPath.AddLine(r.Right, r.Bottom, r.Right, r.Bottom);
            }

            if (bottomLeft)
            {
                graphicsPath.AddArc(r.X, r.Bottom - curve, curve, curve, 90f, 90f);
            }
            else
            {
                graphicsPath.AddLine(r.X, r.Bottom, r.X, r.Bottom);
            }

            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        public static GraphicsPath RoundRec(int x, int y, int width, int height, int curve, bool topLeft = true, bool topRight = true, bool bottomLeft = true, bool bottomRight = true)
        {
            Rectangle rectangle = new Rectangle(x, y, width, height);
            GraphicsPath graphicsPath = new GraphicsPath(FillMode.Winding);
            if (topLeft)
            {
                graphicsPath.AddArc(rectangle.X, rectangle.Y, curve, curve, 180f, 90f);
            }
            else
            {
                graphicsPath.AddLine(rectangle.X, rectangle.Y, rectangle.X, rectangle.Y);
            }

            if (topRight)
            {
                graphicsPath.AddArc(rectangle.Right - curve, rectangle.Y, curve, curve, 270f, 90f);
            }
            else
            {
                graphicsPath.AddLine(rectangle.Right - rectangle.Width, rectangle.Y, rectangle.Width, rectangle.Y);
            }

            if (bottomRight)
            {
                graphicsPath.AddArc(rectangle.Right - curve, rectangle.Bottom - curve, curve, curve, 0f, 90f);
            }
            else
            {
                graphicsPath.AddLine(rectangle.Right, rectangle.Bottom, rectangle.Right, rectangle.Bottom);
            }

            if (bottomLeft)
            {
                graphicsPath.AddArc(rectangle.X, rectangle.Bottom - curve, curve, curve, 90f, 90f);
            }
            else
            {
                graphicsPath.AddLine(rectangle.X, rectangle.Bottom, rectangle.X, rectangle.Bottom);
            }

            graphicsPath.CloseFigure();
            return graphicsPath;
        }
    }
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(MetroEllipse), "Bitmaps.Ellipse.bmp")]
    [Designer(typeof(MetroEllipseDesigner))]
    [DefaultEvent("Click")]
    [DefaultProperty("Text")]
    [ComVisible(true)]

    public class MetroEllipse : Control, IMetroControl
    {
        private readonly Methods _mth;

        private readonly Utilites _utl;

        private MouseMode _state;

        private Style _style;

        private MetroStyleManager _styleManager;

        private bool _isDerivedStyle = true;

        private int _borderThickness = 7;

        private Image _image;

        private Size _imageSize = new Size(64, 64);

        private Color _normalColor;

        private Color _normalBorderColor;

        private Color _normalTextColor;

        private Color _hoverColor;

        private Color _hoverBorderColor;

        private Color _hoverTextColor;

        private Color _pressColor;

        private Color _pressBorderColor;

        private Color _pressTextColor;

        private Color _disabledBackColor;

        private Color _disabledForeColor;

        private Color _disabledBorderColor;

        [Category("Metro")]
        [Description("Gets or sets the style associated with the control.")]
        public Style Style
        {
            get
            {
                return StyleManager?.Style ?? _style;
            }
            set
            {
                _style = value;
                switch (value)
                {
                    case Style.Light:
                        ApplyTheme();
                        break;
                    case Style.Dark:
                        ApplyTheme(Style.Dark);
                        break;
                    case Style.Custom:
                        ApplyTheme(Style.Custom);
                        break;
                    default:
                        ApplyTheme();
                        break;
                }

                Invalidate();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the The Author name associated with the theme.")]
        public string ThemeAuthor
        {
            get;
            set;
        }

        [Category("Metro")]
        [Description("Gets or sets the The Theme name associated with the theme.")]
        public string ThemeName
        {
            get;
            set;
        }

        [Category("Metro")]
        [Description("Gets or sets the Style Manager associated with the control.")]
        public MetroStyleManager StyleManager
        {
            get
            {
                return _styleManager;
            }
            set
            {
                _styleManager = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color BackColor => Color.Transparent;

        [Category("Metro")]
        [Description("Gets or sets the border thickness associated with the control.")]
        public int BorderThickness
        {
            get
            {
                return _borderThickness;
            }
            set
            {
                _borderThickness = value;
                Refresh();
            }
        }

        [Category("Metro")]
        public new bool Enabled
        {
            get
            {
                return base.Enabled;
            }
            set
            {
                base.Enabled = value;
                if (!value)
                {
                    _state = MouseMode.Disabled;
                }

                Invalidate();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the image associated with the control.")]
        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the image size associated with the control.")]
        public Size ImageSize
        {
            get
            {
                return _imageSize;
            }
            set
            {
                _imageSize = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the control background color in normal mouse sate.")]
        public Color NormalColor
        {
            get
            {
                return _normalColor;
            }
            set
            {
                _normalColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the control border color in normal mouse sate.")]
        public Color NormalBorderColor
        {
            get
            {
                return _normalBorderColor;
            }
            set
            {
                _normalBorderColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the control Text color in normal mouse sate.")]
        public Color NormalTextColor
        {
            get
            {
                return _normalTextColor;
            }
            set
            {
                _normalTextColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the control background color in hover mouse sate.")]
        public Color HoverColor
        {
            get
            {
                return _hoverColor;
            }
            set
            {
                _hoverColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the control border color in hover mouse sate.")]
        public Color HoverBorderColor
        {
            get
            {
                return _hoverBorderColor;
            }
            set
            {
                _hoverBorderColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the control Text color in hover mouse sate.")]
        public Color HoverTextColor
        {
            get
            {
                return _hoverTextColor;
            }
            set
            {
                _hoverTextColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the control background color in pushed mouse sate.")]
        public Color PressColor
        {
            get
            {
                return _pressColor;
            }
            set
            {
                _pressColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the control border color in pushed mouse sate.")]
        public Color PressBorderColor
        {
            get
            {
                return _pressBorderColor;
            }
            set
            {
                _pressBorderColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the control Text color in pushed mouse sate.")]
        public Color PressTextColor
        {
            get
            {
                return _pressTextColor;
            }
            set
            {
                _pressTextColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets backcolor used by the control while disabled.")]
        public Color DisabledBackColor
        {
            get
            {
                return _disabledBackColor;
            }
            set
            {
                _disabledBackColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the forecolor of the control whenever while disabled.")]
        public Color DisabledForeColor
        {
            get
            {
                return _disabledForeColor;
            }
            set
            {
                _disabledForeColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the border color of the control while disabled.")]
        public Color DisabledBorderColor
        {
            get
            {
                return _disabledBorderColor;
            }
            set
            {
                _disabledBorderColor = value;
                Refresh();
            }
        }

        [Category("Metro")]
        [Description("Gets or sets the whether this control reflect to parent(s) style. \n Set it to false if you want the style of this control be independent. ")]
        public bool IsDerivedStyle
        {
            get
            {
                return _isDerivedStyle;
            }
            set
            {
                _isDerivedStyle = value;
                Refresh();
            }
        }

        public MetroEllipse()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
            UpdateStyles();
            base.Font = MetroFonts.Light(10f);
            _utl = new Utilites();
            _mth = new Methods();
            ApplyTheme();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rect = new Rectangle(BorderThickness, BorderThickness, base.Width - (BorderThickness * 2 + 1), base.Height - (BorderThickness * 2 + 1));
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            switch (_state)
            {
                case MouseMode.Normal:
                    {
                        using (SolidBrush brush7 = new SolidBrush(NormalColor))
                        {
                            using (Pen pen4 = new Pen(NormalBorderColor, BorderThickness))
                            {
                                using (SolidBrush brush8 = new SolidBrush(NormalTextColor))
                                {
                                    graphics.FillEllipse(brush7, rect);
                                    graphics.DrawEllipse(pen4, 10, 10, 20, 20);
                                    graphics.DrawString(Text, Font, brush8, new Rectangle(0, 0, base.Width, base.Height), _mth.SetPosition());
                                }
                            }
                        }
                        break;
                    }
                case MouseMode.Hovered:
                    {
                        Cursor = Cursors.Hand;
                        using (SolidBrush brush5 = new SolidBrush(HoverColor))
                        {
                            using (Pen pen3 = new Pen(HoverBorderColor, BorderThickness))
                            {
                                using (SolidBrush brush6 = new SolidBrush(HoverTextColor))
                                {
                                    graphics.FillEllipse(brush5, rect);
                                    graphics.DrawEllipse(pen3, 10, 10, 20, 20);
                                    graphics.DrawString(Text, Font, brush6, new Rectangle(0, 0, base.Width, base.Height), _mth.SetPosition());
                                }
                            }
                        }

                        break;
                    }
                case MouseMode.Pushed:
                    {
                        using (SolidBrush brush3 = new SolidBrush(PressColor))
                        {
                            using (Pen pen2 = new Pen(PressBorderColor, BorderThickness))
                            {
                                using (SolidBrush brush4 = new SolidBrush(PressTextColor))
                                {
                                    graphics.FillEllipse(brush3, rect);
                                    graphics.DrawEllipse(pen2, 10, 10, 20, 20);
                                    graphics.DrawString(Text, Font, brush4, new Rectangle(0, 0, base.Width, base.Height), _mth.SetPosition());
                                }
                            }
                        }

                        break;
                    }
                case MouseMode.Disabled:
                    {
                        using (SolidBrush brush = new SolidBrush(DisabledBackColor))
                        {
                            using (Pen pen = new Pen(DisabledBorderColor, BorderThickness))
                            {
                                using (SolidBrush brush2 = new SolidBrush(DisabledForeColor))
                                {
                                    graphics.FillEllipse(brush, rect);
                                    graphics.DrawEllipse(pen, rect);
                                    graphics.DrawString(Text, Font, brush2, new Rectangle(0, 0, base.Width, base.Height), _mth.SetPosition());
                                }
                            }
                        }

                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (Image != null)
            {
                Rectangle rect2 = new Rectangle(new Point((base.Width - ImageSize.Width) / 2, (base.Height - ImageSize.Height) / 2), ImageSize);
                graphics.DrawImage(Image, rect2);
            }
        }

        private void ApplyTheme(Style style = Style.Light)
        {
            if (!IsDerivedStyle)
            {
                return;
            }

            switch (style)
            {
                case Style.Light:
                    NormalColor = Color.FromArgb(79, 170, 214);
                    NormalBorderColor = Color.FromArgb(79, 170, 214);
                    NormalTextColor = Color.White;
                    HoverColor = Color.FromArgb(32, 138, 191);
                    HoverBorderColor = Color.FromArgb(32, 138, 191);
                    HoverTextColor = Color.White;
                    PressColor = Color.FromArgb(32, 138, 191);
                    PressBorderColor = Color.FromArgb(32, 138, 191);
                    PressTextColor = Color.White;
                    DisabledBackColor = Color.FromArgb(204, 204, 204);
                    DisabledBorderColor = Color.FromArgb(155, 155, 155);
                    DisabledForeColor = Color.FromArgb(136, 136, 136);
                    ThemeAuthor = "Taiizor";
                    ThemeName = "MetroLight";
                    break;
                case Style.Dark:
                    NormalColor = Color.FromArgb(32, 32, 32);
                    NormalBorderColor = Color.FromArgb(64, 64, 64);
                    NormalTextColor = Color.FromArgb(204, 204, 204);
                    HoverColor = Color.FromArgb(170, 170, 170);
                    HoverBorderColor = Color.FromArgb(170, 170, 170);
                    HoverTextColor = Color.White;
                    PressColor = Color.FromArgb(240, 240, 240);
                    PressBorderColor = Color.FromArgb(240, 240, 240);
                    PressTextColor = Color.White;
                    DisabledBackColor = Color.FromArgb(80, 80, 80);
                    DisabledBorderColor = Color.FromArgb(109, 109, 109);
                    DisabledForeColor = Color.FromArgb(109, 109, 109);
                    ThemeAuthor = "Taiizor";
                    ThemeName = "MetroDark";
                    break;
                case Style.Custom:
                    if (StyleManager != null)
                    {
                        foreach (KeyValuePair<string, object> item in StyleManager.EllipseDictionary)
                        {
                            if (item.Key == null || item.Key == null)
                            {
                                return;
                            }

                            if (item.Key == "NormalColor")
                            {
                                NormalColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "NormalBorderColor")
                            {
                                NormalBorderColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "NormalTextColor")
                            {
                                NormalTextColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "HoverColor")
                            {
                                HoverColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "HoverBorderColor")
                            {
                                HoverBorderColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "HoverTextColor")
                            {
                                HoverTextColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "PressColor")
                            {
                                PressColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "PressBorderColor")
                            {
                                PressBorderColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "PressTextColor")
                            {
                                PressTextColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "DisabledBackColor")
                            {
                                DisabledBackColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "DisabledBorderColor")
                            {
                                DisabledBorderColor = _utl.HexColor((string)item.Value);
                            }
                            else if (item.Key == "DisabledForeColor")
                            {
                                DisabledForeColor = _utl.HexColor((string)item.Value);
                            }
                        }
                    }

                    Refresh();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("style", style, null);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _state = MouseMode.Hovered;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _state = MouseMode.Pushed;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _state = MouseMode.Hovered;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseEnter(e);
            _state = MouseMode.Normal;
            Invalidate();
        }
    }
    internal class Utilites
    {
        public static PathGradientBrush GlowBrush(Color CenterColor, Color SurroundColor, Point P, Rectangle Rect)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.FillMode = FillMode.Winding;
            graphicsPath.AddRectangle(Rect);
            PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath);
            pathGradientBrush.CenterColor = CenterColor;
            pathGradientBrush.SurroundColors = new Color[1]
            {
                SurroundColor
            };
            pathGradientBrush.FocusScales = P;
            return pathGradientBrush;
        }

        public static SolidBrush SolidBrushRGBColor(int R, int G, int B, int A = 0)
        {
            return new SolidBrush(Color.FromArgb(A, R, G, B));
        }

        public SolidBrush SolidBrushHTMlColor(string C_WithoutHash)
        {
            return new SolidBrush(HexColor(C_WithoutHash));
        }

        public static Pen PenRGBColor(int red, int green, int blue, int alpha, float size)
        {
            return new Pen(Color.FromArgb(alpha, red, green, blue), size);
        }

        public Pen PenHTMlColor(string colorWithoutHash, float size = 1f)
        {
            return new Pen(HexColor(colorWithoutHash), size);
        }

        public Color HexColor(string hexColor)
        {
            return ColorTranslator.FromHtml(hexColor);
        }

        public static Color GetAlphaHexColor(int alpha, string hexColor)
        {
            return Color.FromArgb(alpha, ColorTranslator.FromHtml(hexColor));
        }

        public void InitControlHandle(Control ctrl)
        {
            if (ctrl.IsHandleCreated)
            {
                return;
            }

            foreach (Control control in ctrl.Controls)
            {
                InitControlHandle(control);
            }
        }

        public void SmoothCursor(ref Message message)
        {
            if (message.Msg == 32)
            {
                User32.SetCursor(User32.LoadCursor(IntPtr.Zero, 32649));
                message.Result = IntPtr.Zero;
            }
        }

        public void SmoothCursor(ref Message message, Cursor Cursor)
        {
            if (message.Msg == 32 || !(Cursor != Cursors.Hand))
            {
                User32.SetCursor(User32.LoadCursor(IntPtr.Zero, 32649));
                message.Result = IntPtr.Zero;
            }
        }

        public static void NormalCursor(ref Message message, Cursor Cursor)
        {
            if (message.Msg == 32 && Cursor == Cursors.Hand)
            {
                User32.SetCursor(User32.LoadCursor(IntPtr.Zero, 32649));
                message.Result = IntPtr.Zero;
            }
        }
    }
    internal class User32
    {
        public struct TCHITTESTINFO
        {
            private readonly Point _point;

            public readonly TabControlHitTest flags;

            private TCHITTESTINFO(TabControlHitTest hitTest)
            {
                this = default(TCHITTESTINFO);
                flags = hitTest;
            }

            public TCHITTESTINFO(Point point, TabControlHitTest hitTest)
                : this(hitTest)
            {
                _point = point;
            }

            public TCHITTESTINFO(int x, int y, TabControlHitTest hitTest)
                : this(hitTest)
            {
                new Point(x, y);
            }
        }

        public enum AnimateWindowFlags : uint
        {
            AW_HOR_POSITIVE = 1u,
            AW_HOR_NEGATIVE = 2u,
            AW_VER_POSITIVE = 4u,
            AW_VER_NEGATIVE = 8u,
            AW_CENTER = 0x10u,
            AW_HIDE = 0x10000u,
            AW_ACTIVATE = 0x20000u,
            AW_SLIDE = 0x40000u,
            AW_BLEND = 0x80000u
        }

        [Flags]
        public enum TabControlHitTest
        {
            //
            // Сводка:
            //     The position is not over a tab.
            TCHT_NOWHERE = 0x1,
            //
            // Сводка:
            //     The position is over a tab's icon.
            TCHT_ONITEMICON = 0x2,
            //
            // Сводка:
            //     The position is over a tab's text.
            TCHT_ONITEMLABEL = 0x4,
            //
            // Сводка:
            //     The position is over a tab but not over its icon or its text. For owner-drawn
            //     tab controls, this value is specified if the position is anywhere over a tab.
            //     TCHT_ONITEM is a bitwise-OR operation on TCHT_ONITEMICON and TCHT_ONITEMLABEL.
            TCHT_ONITEM = 0x6
        }

        //
        // Сводка:
        //     Specifies values from Msgs enumeration.
        internal enum Msgs
        {
            //
            // Сводка:
            //     Specified WM_NULL enumeration value.
            WM_NULL = 0,
            //
            // Сводка:
            //     Specified WM_CREATE enumeration value.
            WM_CREATE = 1,
            //
            // Сводка:
            //     Specified WM_DESTROY enumeration value.
            WM_DESTROY = 2,
            //
            // Сводка:
            //     Specified WM_MOVE enumeration value.
            WM_MOVE = 3,
            //
            // Сводка:
            //     Specified WM_SIZE enumeration value.
            WM_SIZE = 5,
            //
            // Сводка:
            //     Specified WM_ACTIVATE enumeration value.
            WM_ACTIVATE = 6,
            //
            // Сводка:
            //     Specified WM_SETFOCUS enumeration value.
            WM_SETFOCUS = 7,
            //
            // Сводка:
            //     Specified WM_KILLFOCUS enumeration value.
            WM_KILLFOCUS = 8,
            //
            // Сводка:
            //     Specified WM_ENABLE enumeration value.
            WM_ENABLE = 10,
            //
            // Сводка:
            //     Specified WM_SETREDRAW enumeration value.
            WM_SETREDRAW = 11,
            //
            // Сводка:
            //     Specified WM_SETTEXT enumeration value.
            WM_SETTEXT = 12,
            //
            // Сводка:
            //     Specified WM_GETTEXT enumeration value.
            WM_GETTEXT = 13,
            //
            // Сводка:
            //     Specified WM_GETTEXTLENGTH enumeration value.
            WM_GETTEXTLENGTH = 14,
            //
            // Сводка:
            //     Specified WM_PAINT enumeration value.
            WM_PAINT = 0xF,
            //
            // Сводка:
            //     Specified WM_CLOSE enumeration value.
            WM_CLOSE = 0x10,
            //
            // Сводка:
            //     Specified WM_QUERYENDSESSION enumeration value.
            WM_QUERYENDSESSION = 17,
            //
            // Сводка:
            //     Specified WM_QUIT enumeration value.
            WM_QUIT = 18,
            //
            // Сводка:
            //     Specified WM_QUERYOPEN enumeration value.
            WM_QUERYOPEN = 19,
            //
            // Сводка:
            //     Specified WM_ERASEBKGND enumeration value.
            WM_ERASEBKGND = 20,
            //
            // Сводка:
            //     Specified WM_SYSCOLORCHANGE enumeration value.
            WM_SYSCOLORCHANGE = 21,
            //
            // Сводка:
            //     Specified WM_ENDSESSION enumeration value.
            WM_ENDSESSION = 22,
            //
            // Сводка:
            //     Specified WM_SHOWWINDOW enumeration value.
            WM_SHOWWINDOW = 24,
            //
            // Сводка:
            //     Specified WM_WININICHANGE enumeration value.
            WM_WININICHANGE = 26,
            //
            // Сводка:
            //     Specified WM_SETTINGCHANGE enumeration value.
            WM_SETTINGCHANGE = 26,
            //
            // Сводка:
            //     Specified WM_DEVMODECHANGE enumeration value.
            WM_DEVMODECHANGE = 27,
            //
            // Сводка:
            //     Specified WM_ACTIVATEAPP enumeration value.
            WM_ACTIVATEAPP = 28,
            //
            // Сводка:
            //     Specified WM_FONTCHANGE enumeration value.
            WM_FONTCHANGE = 29,
            //
            // Сводка:
            //     Specified WM_TIMECHANGE enumeration value.
            WM_TIMECHANGE = 30,
            //
            // Сводка:
            //     Specified WM_CANCELMODE enumeration value.
            WM_CANCELMODE = 0x1F,
            //
            // Сводка:
            //     Specified WM_SETCURSOR enumeration value.
            WM_SETCURSOR = 0x20,
            //
            // Сводка:
            //     Specified WM_MOUSEACTIVATE enumeration value.
            WM_MOUSEACTIVATE = 33,
            //
            // Сводка:
            //     Specified WM_CHILDACTIVATE enumeration value.
            WM_CHILDACTIVATE = 34,
            //
            // Сводка:
            //     Specified WM_QUEUESYNC enumeration value.
            WM_QUEUESYNC = 35,
            //
            // Сводка:
            //     Specified WM_GETMINMAXINFO enumeration value.
            WM_GETMINMAXINFO = 36,
            //
            // Сводка:
            //     Specified WM_PAINTICON enumeration value.
            WM_PAINTICON = 38,
            //
            // Сводка:
            //     Specified WM_ICONERASEBKGND enumeration value.
            WM_ICONERASEBKGND = 39,
            //
            // Сводка:
            //     Specified WM_NEXTDLGCTL enumeration value.
            WM_NEXTDLGCTL = 40,
            //
            // Сводка:
            //     Specified WM_SPOOLERSTATUS enumeration value.
            WM_SPOOLERSTATUS = 42,
            //
            // Сводка:
            //     Specified WM_DRAWITEM enumeration value.
            WM_DRAWITEM = 43,
            //
            // Сводка:
            //     Specified WM_MEASUREITEM enumeration value.
            WM_MEASUREITEM = 44,
            //
            // Сводка:
            //     Specified WM_DELETEITEM enumeration value.
            WM_DELETEITEM = 45,
            //
            // Сводка:
            //     Specified WM_VKEYTOITEM enumeration value.
            WM_VKEYTOITEM = 46,
            //
            // Сводка:
            //     Specified WM_CHARTOITEM enumeration value.
            WM_CHARTOITEM = 47,
            //
            // Сводка:
            //     Specified WM_SETFONT enumeration value.
            WM_SETFONT = 48,
            //
            // Сводка:
            //     Specified WM_GETFONT enumeration value.
            WM_GETFONT = 49,
            //
            // Сводка:
            //     Specified WM_SETHOTKEY enumeration value.
            WM_SETHOTKEY = 50,
            //
            // Сводка:
            //     Specified WM_GETHOTKEY enumeration value.
            WM_GETHOTKEY = 51,
            //
            // Сводка:
            //     Specified WM_QUERYDRAGICON enumeration value.
            WM_QUERYDRAGICON = 55,
            //
            // Сводка:
            //     Specified WM_COMPAREITEM enumeration value.
            WM_COMPAREITEM = 57,
            //
            // Сводка:
            //     Specified WM_GETOBJECT enumeration value.
            WM_GETOBJECT = 61,
            //
            // Сводка:
            //     Specified WM_COMPACTING enumeration value.
            WM_COMPACTING = 65,
            //
            // Сводка:
            //     Specified WM_COMMNOTIFY enumeration value.
            WM_COMMNOTIFY = 68,
            //
            // Сводка:
            //     Specified WM_WINDOWPOSCHANGING enumeration value.
            WM_WINDOWPOSCHANGING = 70,
            //
            // Сводка:
            //     Specified WM_WINDOWPOSCHANGED enumeration value.
            WM_WINDOWPOSCHANGED = 71,
            //
            // Сводка:
            //     Specified WM_POWER enumeration value.
            WM_POWER = 72,
            //
            // Сводка:
            //     Specified WM_COPYDATA enumeration value.
            WM_COPYDATA = 74,
            //
            // Сводка:
            //     Specified WM_CANCELJOURNAL enumeration value.
            WM_CANCELJOURNAL = 75,
            //
            // Сводка:
            //     Specified WM_NOTIFY enumeration value.
            WM_NOTIFY = 78,
            //
            // Сводка:
            //     Specified WM_INPUTLANGCHANGEREQUEST enumeration value.
            WM_INPUTLANGCHANGEREQUEST = 80,
            //
            // Сводка:
            //     Specified WM_INPUTLANGCHANGE enumeration value.
            WM_INPUTLANGCHANGE = 81,
            //
            // Сводка:
            //     Specified WM_TCARD enumeration value.
            WM_TCARD = 82,
            //
            // Сводка:
            //     Specified WM_HELP enumeration value.
            WM_HELP = 83,
            //
            // Сводка:
            //     Specified WM_USERCHANGED enumeration value.
            WM_USERCHANGED = 84,
            //
            // Сводка:
            //     Specified WM_NOTIFYFORMAT enumeration value.
            WM_NOTIFYFORMAT = 85,
            //
            // Сводка:
            //     Specified WM_CONTEXTMENU enumeration value.
            WM_CONTEXTMENU = 123,
            //
            // Сводка:
            //     Specified WM_STYLECHANGING enumeration value.
            WM_STYLECHANGING = 124,
            //
            // Сводка:
            //     Specified WM_STYLECHANGED enumeration value.
            WM_STYLECHANGED = 125,
            //
            // Сводка:
            //     Specified WM_DISPLAYCHANGE enumeration value.
            WM_DISPLAYCHANGE = 126,
            //
            // Сводка:
            //     Specified WM_GETICON enumeration value.
            WM_GETICON = 0x7F,
            //
            // Сводка:
            //     Specified WM_SETICON enumeration value.
            WM_SETICON = 0x80,
            //
            // Сводка:
            //     Specified WM_NCCREATE enumeration value.
            WM_NCCREATE = 129,
            //
            // Сводка:
            //     Specified VK_RMENU enumeration value.
            WM_NCDESTROY = 130,
            //
            // Сводка:
            //     Specified WM_NCCALCSIZE enumeration value.
            WM_NCCALCSIZE = 131,
            //
            // Сводка:
            //     Specified WM_NCHITTEST enumeration value.
            WM_NCHITTEST = 132,
            //
            // Сводка:
            //     Specified WM_NCPAINT enumeration value.
            WM_NCPAINT = 133,
            //
            // Сводка:
            //     Specified WM_NCACTIVATE enumeration value.
            WM_NCACTIVATE = 134,
            //
            // Сводка:
            //     Specified WM_GETDLGCODE enumeration value.
            WM_GETDLGCODE = 135,
            //
            // Сводка:
            //     Specified WM_SYNCPAINT enumeration value.
            WM_SYNCPAINT = 136,
            //
            // Сводка:
            //     Specified WM_NCMOUSEMOVE enumeration value.
            WM_NCMOUSEMOVE = 160,
            //
            // Сводка:
            //     Specified WM_NCLBUTTONDOWN enumeration value.
            WM_NCLBUTTONDOWN = 161,
            //
            // Сводка:
            //     Specified WM_NCLBUTTONUP enumeration value.
            WM_NCLBUTTONUP = 162,
            //
            // Сводка:
            //     Specified WM_NCLBUTTONDBLCLK enumeration value.
            WM_NCLBUTTONDBLCLK = 163,
            //
            // Сводка:
            //     Specified WM_NCRBUTTONDOWN enumeration value.
            WM_NCRBUTTONDOWN = 164,
            //
            // Сводка:
            //     Specified WM_NCRBUTTONUP enumeration value.
            WM_NCRBUTTONUP = 165,
            //
            // Сводка:
            //     Specified WM_NCRBUTTONDBLCLK enumeration value.
            WM_NCRBUTTONDBLCLK = 166,
            //
            // Сводка:
            //     Specified WM_NCMBUTTONDOWN enumeration value.
            WM_NCMBUTTONDOWN = 167,
            //
            // Сводка:
            //     Specified WM_NCMBUTTONUP enumeration value.
            WM_NCMBUTTONUP = 168,
            //
            // Сводка:
            //     Specified WM_NCMBUTTONDBLCLK enumeration value.
            WM_NCMBUTTONDBLCLK = 169,
            //
            // Сводка:
            //     Specified WM_NCXBUTTONDOWN enumeration value.
            WM_NCXBUTTONDOWN = 171,
            //
            // Сводка:
            //     Specified WM_NCXBUTTONUP enumeration value.
            WM_NCXBUTTONUP = 172,
            //
            // Сводка:
            //     Specified WM_KEYDOWN enumeration value.
            WM_KEYDOWN = 0x100,
            //
            // Сводка:
            //     Specified WM_KEYUP enumeration value.
            WM_KEYUP = 257,
            //
            // Сводка:
            //     Specified WM_CHAR enumeration value.
            WM_CHAR = 258,
            //
            // Сводка:
            //     Specified WM_DEADCHAR enumeration value.
            WM_DEADCHAR = 259,
            //
            // Сводка:
            //     Specified WM_SYSKEYDOWN enumeration value.
            WM_SYSKEYDOWN = 260,
            //
            // Сводка:
            //     Specified WM_SYSKEYUP enumeration value.
            WM_SYSKEYUP = 261,
            //
            // Сводка:
            //     Specified WM_SYSCHAR enumeration value.
            WM_SYSCHAR = 262,
            //
            // Сводка:
            //     Specified WM_SYSDEADCHAR enumeration value.
            WM_SYSDEADCHAR = 263,
            //
            // Сводка:
            //     Specified WM_KEYLAST enumeration value.
            WM_KEYLAST = 264,
            //
            // Сводка:
            //     Specified WM_IME_STARTCOMPOSITION enumeration value.
            WM_IME_STARTCOMPOSITION = 269,
            //
            // Сводка:
            //     Specified WM_IME_ENDCOMPOSITION enumeration value.
            WM_IME_ENDCOMPOSITION = 270,
            //
            // Сводка:
            //     Specified WM_IME_COMPOSITION enumeration value.
            WM_IME_COMPOSITION = 271,
            //
            // Сводка:
            //     Specified WM_IME_KEYLAST enumeration value.
            WM_IME_KEYLAST = 271,
            //
            // Сводка:
            //     Specified WM_INITDIALOG enumeration value.
            WM_INITDIALOG = 272,
            //
            // Сводка:
            //     Specified WM_COMMAND enumeration value.
            WM_COMMAND = 273,
            //
            // Сводка:
            //     Specified WM_SYSCOMMAND enumeration value.
            WM_SYSCOMMAND = 274,
            //
            // Сводка:
            //     Specified WM_TIMER enumeration value.
            WM_TIMER = 275,
            //
            // Сводка:
            //     Specified WM_HSCROLL enumeration value.
            WM_HSCROLL = 276,
            //
            // Сводка:
            //     Specified WM_VSCROLL enumeration value.
            WM_VSCROLL = 277,
            //
            // Сводка:
            //     Specified WM_INITMENU enumeration value.
            WM_INITMENU = 278,
            //
            // Сводка:
            //     Specified WM_INITMENUPOPUP enumeration value.
            WM_INITMENUPOPUP = 279,
            //
            // Сводка:
            //     Specified WM_MENUSELECT enumeration value.
            WM_MENUSELECT = 287,
            //
            // Сводка:
            //     Specified WM_MENUCHAR enumeration value.
            WM_MENUCHAR = 288,
            //
            // Сводка:
            //     Specified WM_ENTERIDLE enumeration value.
            WM_ENTERIDLE = 289,
            //
            // Сводка:
            //     Specified WM_MENURBUTTONUP enumeration value.
            WM_MENURBUTTONUP = 290,
            //
            // Сводка:
            //     Specified WM_MENUDRAG enumeration value.
            WM_MENUDRAG = 291,
            //
            // Сводка:
            //     Specified WM_MENUGETOBJECT enumeration value.
            WM_MENUGETOBJECT = 292,
            //
            // Сводка:
            //     Specified WM_UNINITMENUPOPUP enumeration value.
            WM_UNINITMENUPOPUP = 293,
            //
            // Сводка:
            //     Specified WM_MENUCOMMAND enumeration value.
            WM_MENUCOMMAND = 294,
            //
            // Сводка:
            //     Specified WM_CTLCOLORMSGBOX enumeration value.
            WM_CTLCOLORMSGBOX = 306,
            //
            // Сводка:
            //     Specified WM_CTLCOLOREDIT enumeration value.
            WM_CTLCOLOREDIT = 307,
            //
            // Сводка:
            //     Specified WM_CTLCOLORLISTBOX enumeration value.
            WM_CTLCOLORLISTBOX = 308,
            //
            // Сводка:
            //     Specified WM_CTLCOLORBTN enumeration value.
            WM_CTLCOLORBTN = 309,
            //
            // Сводка:
            //     Specified WM_CTLCOLORDLG enumeration value.
            WM_CTLCOLORDLG = 310,
            //
            // Сводка:
            //     Specified WM_CTLCOLORSCROLLBAR enumeration value.
            WM_CTLCOLORSCROLLBAR = 311,
            //
            // Сводка:
            //     Specified WM_CTLCOLORSTATIC enumeration value.
            WM_CTLCOLORSTATIC = 312,
            //
            // Сводка:
            //     Specified WM_MOUSEMOVE enumeration value.
            WM_MOUSEMOVE = 0x200,
            //
            // Сводка:
            //     Specified WM_LBUTTONDOWN enumeration value.
            WM_LBUTTONDOWN = 513,
            //
            // Сводка:
            //     Specified WM_LBUTTONUP enumeration value.
            WM_LBUTTONUP = 514,
            //
            // Сводка:
            //     Specified WM_LBUTTONDBLCLK enumeration value.
            WM_LBUTTONDBLCLK = 515,
            //
            // Сводка:
            //     Specified WM_RBUTTONDOWN enumeration value.
            WM_RBUTTONDOWN = 516,
            //
            // Сводка:
            //     Specified WM_RBUTTONUP enumeration value.
            WM_RBUTTONUP = 517,
            //
            // Сводка:
            //     Specified WM_RBUTTONDBLCLK enumeration value.
            WM_RBUTTONDBLCLK = 518,
            //
            // Сводка:
            //     Specified WM_MBUTTONDOWN enumeration value.
            WM_MBUTTONDOWN = 519,
            //
            // Сводка:
            //     Specified WM_MBUTTONUP enumeration value.
            WM_MBUTTONUP = 520,
            //
            // Сводка:
            //     Specified WM_MBUTTONDBLCLK enumeration value.
            WM_MBUTTONDBLCLK = 521,
            //
            // Сводка:
            //     Specified WM_MOUSEWHEEL enumeration value.
            WM_MOUSEWHEEL = 522,
            //
            // Сводка:
            //     Specified WM_XBUTTONDOWN enumeration value.
            WM_XBUTTONDOWN = 523,
            //
            // Сводка:
            //     Specified WM_XBUTTONUP enumeration value.
            WM_XBUTTONUP = 524,
            //
            // Сводка:
            //     Specified WM_XBUTTONDBLCLK enumeration value.
            WM_XBUTTONDBLCLK = 525,
            //
            // Сводка:
            //     Specified WM_PARENTNOTIFY enumeration value.
            WM_PARENTNOTIFY = 528,
            //
            // Сводка:
            //     Specified WM_ENTERMENULOOP enumeration value.
            WM_ENTERMENULOOP = 529,
            //
            // Сводка:
            //     Specified WM_EXITMENULOOP enumeration value.
            WM_EXITMENULOOP = 530,
            //
            // Сводка:
            //     Specified WM_NEXTMENU enumeration value.
            WM_NEXTMENU = 531,
            //
            // Сводка:
            //     Specified WM_SIZING enumeration value.
            WM_SIZING = 532,
            //
            // Сводка:
            //     Specified WM_CAPTURECHANGED enumeration value.
            WM_CAPTURECHANGED = 533,
            //
            // Сводка:
            //     Specified WM_MOVING enumeration value.
            WM_MOVING = 534,
            //
            // Сводка:
            //     Specified WM_DEVICECHANGE enumeration value.
            WM_DEVICECHANGE = 537,
            //
            // Сводка:
            //     Specified WM_MDICREATE enumeration value.
            WM_MDICREATE = 544,
            //
            // Сводка:
            //     Specified WM_MDIDESTROY enumeration value.
            WM_MDIDESTROY = 545,
            //
            // Сводка:
            //     Specified WM_MDIACTIVATE enumeration value.
            WM_MDIACTIVATE = 546,
            //
            // Сводка:
            //     Specified WM_MDIRESTORE enumeration value.
            WM_MDIRESTORE = 547,
            //
            // Сводка:
            //     Specified WM_MDINEXT enumeration value.
            WM_MDINEXT = 548,
            //
            // Сводка:
            //     Specified WM_MDIMAXIMIZE enumeration value.
            WM_MDIMAXIMIZE = 549,
            //
            // Сводка:
            //     Specified WM_MDITILE enumeration value.
            WM_MDITILE = 550,
            //
            // Сводка:
            //     Specified WM_MDICASCADE enumeration value.
            WM_MDICASCADE = 551,
            //
            // Сводка:
            //     Specified WM_MDIICONARRANGE enumeration value.
            WM_MDIICONARRANGE = 552,
            //
            // Сводка:
            //     Specified WM_MDIGETACTIVE enumeration value.
            WM_MDIGETACTIVE = 553,
            //
            // Сводка:
            //     Specified WM_MDISETMENU enumeration value.
            WM_MDISETMENU = 560,
            //
            // Сводка:
            //     Specified WM_ENTERSIZEMOVE enumeration value.
            WM_ENTERSIZEMOVE = 561,
            //
            // Сводка:
            //     Specified WM_EXITSIZEMOVE enumeration value.
            WM_EXITSIZEMOVE = 562,
            //
            // Сводка:
            //     Specified WM_DROPFILES enumeration value.
            WM_DROPFILES = 563,
            //
            // Сводка:
            //     Specified WM_MDIREFRESHMENU enumeration value.
            WM_MDIREFRESHMENU = 564,
            //
            // Сводка:
            //     Specified WM_IME_SETCONTEXT enumeration value.
            WM_IME_SETCONTEXT = 641,
            //
            // Сводка:
            //     Specified WM_IME_NOTIFY enumeration value.
            WM_IME_NOTIFY = 642,
            //
            // Сводка:
            //     Specified WM_IME_CONTROL enumeration value.
            WM_IME_CONTROL = 643,
            //
            // Сводка:
            //     Specified WM_IME_COMPOSITIONFULL enumeration value.
            WM_IME_COMPOSITIONFULL = 644,
            //
            // Сводка:
            //     Specified WM_IME_SELECT enumeration value.
            WM_IME_SELECT = 645,
            //
            // Сводка:
            //     Specified WM_IME_CHAR enumeration value.
            WM_IME_CHAR = 646,
            //
            // Сводка:
            //     Specified WM_IME_REQUEST enumeration value.
            WM_IME_REQUEST = 648,
            //
            // Сводка:
            //     Specified WM_IME_KEYDOWN enumeration value.
            WM_IME_KEYDOWN = 656,
            //
            // Сводка:
            //     Specified WM_IME_KEYUP enumeration value.
            WM_IME_KEYUP = 657,
            //
            // Сводка:
            //     Specified WM_MOUSEHOVER enumeration value.
            WM_MOUSEHOVER = 673,
            WM_MOUSELEAVE = 675,
            WM_CUT = 768,
            WM_COPY = 769,
            WM_PASTE = 770,
            WM_CLEAR = 771,
            //
            // Сводка:
            //     Specified WM_UNDO enumeration value.
            WM_UNDO = 772,
            //
            // Сводка:
            //     Specified WM_RENDERFORMAT enumeration value.
            WM_RENDERFORMAT = 773,
            //
            // Сводка:
            //     Specified WM_RENDERALLFORMATS enumeration value.
            WM_RENDERALLFORMATS = 774,
            //
            // Сводка:
            //     Specified WM_DESTROYCLIPBOARD enumeration value.
            WM_DESTROYCLIPBOARD = 775,
            //
            // Сводка:
            //     Specified WM_DRAWCLIPBOARD enumeration value.
            WM_DRAWCLIPBOARD = 776,
            //
            // Сводка:
            //     Specified WM_PAINTCLIPBOARD enumeration value.
            WM_PAINTCLIPBOARD = 777,
            //
            // Сводка:
            //     Specified WM_VSCROLLCLIPBOARD enumeration value.
            WM_VSCROLLCLIPBOARD = 778,
            //
            // Сводка:
            //     Specified WM_SIZECLIPBOARD enumeration value.
            WM_SIZECLIPBOARD = 779,
            //
            // Сводка:
            //     Specified WM_ASKCBFORMATNAME enumeration value.
            WM_ASKCBFORMATNAME = 780,
            //
            // Сводка:
            //     Specified WM_CHANGECBCHAIN enumeration value.
            WM_CHANGECBCHAIN = 781,
            //
            // Сводка:
            //     Specified WM_HSCROLLCLIPBOARD enumeration value.
            WM_HSCROLLCLIPBOARD = 782,
            //
            // Сводка:
            //     Specified WM_QUERYNEWPALETTE enumeration value.
            WM_QUERYNEWPALETTE = 783,
            //
            // Сводка:
            //     Specified WM_PALETTEISCHANGING enumeration value.
            WM_PALETTEISCHANGING = 784,
            //
            // Сводка:
            //     Specified WM_PALETTECHANGED enumeration value.
            WM_PALETTECHANGED = 785,
            //
            // Сводка:
            //     Specified WM_HOTKEY enumeration value.
            WM_HOTKEY = 786,
            //
            // Сводка:
            //     Specified WM_PRINT enumeration value.
            WM_PRINT = 791,
            //
            // Сводка:
            //     Specified WM_PRINTCLIENT enumeration value.
            WM_PRINTCLIENT = 792,
            //
            // Сводка:
            //     Specified WM_HANDHELDFIRST enumeration value.
            WM_HANDHELDFIRST = 856,
            //
            // Сводка:
            //     Specified WM_HANDHELDLAST enumeration value.
            WM_HANDHELDLAST = 863,
            //
            // Сводка:
            //     Specified WM_AFXFIRST enumeration value.
            WM_AFXFIRST = 864,
            //
            // Сводка:
            //     Specified WM_AFXLAST enumeration value.
            WM_AFXLAST = 895,
            //
            // Сводка:
            //     Specified WM_PENWINFIRST enumeration value.
            WM_PENWINFIRST = 896,
            //
            // Сводка:
            //     Specified WM_PENWINLAST enumeration value.
            WM_PENWINLAST = 911,
            //
            // Сводка:
            //     Specified WM_APP enumeration value.
            WM_APP = 0x8000,
            //
            // Сводка:
            //     Specified WM_USER enumeration value.
            WM_USER = 0x400,
            //
            // Сводка:
            //     Specified WM_REFLECT enumeration value.
            WM_REFLECT = 0x2000,
            //
            // Сводка:
            //     Specified WM_THEMECHANGED enumeration value.
            WM_THEMECHANGED = 794
        }

        public const int WM_SETCURSOR = 32;

        public const int IDC_HAND = 32649;

        public const byte _AC_SRC_OVER = 0;

        public const byte _AC_SRC_ALPHA = 1;

        public const int _LWA_ALPHA = 2;

        public const int _PAT_INVERT = 5898313;

        public const int _HT_CAPTION = 2;

        public const int _HT_TRANSPARENT = -1;

        public const int _TCM_HITTEST = 4877;

        public const int _WM_NCHITTEST = 132;

        public const int _HTCLIENT = 1;

        public const int _HTCAPTION = 2;

        public const int _SRC_COPY = 13369376;

        public const int _CS_DROPSHADOW = 131072;

        public const int _TCM_ADJUSTRECT = 4904;

        public const int _TCN_FIRST = -550;

        public const int _TCN_SELCHANGE = -551;

        public const int _TCN_SELCHANGING = -552;

        public AnimateWindowFlags AW_HIDE
        {
            get;
            internal set;
        }

        [DllImport("user32")]
        public static extern bool AnimateWindow(IntPtr hwnd, int time, AnimateWindowFlags flags);

        internal void AnimateWindow(IntPtr handle, int v, object p)
        {
            throw new NotImplementedException();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetCursor(IntPtr hCursor);
    }
}
