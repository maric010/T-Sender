using ReaLTaiizor.Enum.Metro;
using ReaLTaiizor.Interface.Metro;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    #region MetroControlBox

    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(ControlBox), "Bitmaps.ControlButton.bmp")]
    //[Designer(typeof(MetroControlBoxDesigner))]
    [DefaultProperty("Click")]
    [ComVisible(true)]
    public class ControlBox : ContainerControl, IMetroControl
    {
        #region Interfaces

        [Category("Metro"), Description("Gets or sets the style associated with the control.")]
        public Style Style
        {
            get => StyleManager?.Style ?? _style;
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

        [Category("Metro"), Description("Gets or sets the Style Manager associated with the control.")]
        public MetroStyleManager StyleManager
        {
            get => _styleManager;
            set { _styleManager = value; Invalidate(); }
        }

        [Category("Metro"), Description("Gets or sets the The Author name associated with the theme.")]
        public string ThemeAuthor { get; set; }

        [Category("Metro"), Description("Gets or sets the The Theme name associated with the theme.")]
        public string ThemeName { get; set; }

        #endregion Interfaces

        #region Global Vars

        private readonly Utilites _utl;

        #endregion Global Vars

        #region Internal Vars

        private Style _style;
        private MetroStyleManager _styleManager;
        private LocationType _DefaultLocation = LocationType.Normal;

        private bool _isDerivedStyle = true;
        private bool _maximizeBox = true;
        private Color _closeNormalForeColor;
        private Color _closeHoverForeColor;
        private Color _closeHoverBackColor;
        private Color _maximizeHoverForeColor;
        private Color _maximizeHoverBackColor;
        private Color _maximizeNormalForeColor;
        private Color _minimizeHoverForeColor;
        private Color _minimizeHoverBackColor;
        private Color _minimizeNormalForeColor;
        private Color _disabledForeColor;

        #endregion Internal Vars

        #region Constructors

        public ControlBox()
        {
            SetStyle
            (
                ControlStyles.ResizeRedraw |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.SupportsTransparentBackColor,
                    true
            );
            UpdateStyles();
            _utl = new Utilites();
            base.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cursor = Cursors.Hand;
            ApplyTheme();
        }

        #endregion Constructors

        #region ApplyTheme

        private void ApplyTheme(Style style = Style.Light)
        {
            if (!IsDerivedStyle)
            {
                return;
            }

            switch (style)
            {
                case Style.Light:
                    CloseHoverBackColor = Color.FromArgb(183, 40, 40);
                    CloseHoverForeColor = Color.Black;
                    CloseNormalForeColor = Color.Black;
                    MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
                    MaximizeHoverForeColor = Color.Black;
                    MaximizeNormalForeColor = Color.Black;
                    MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
                    MinimizeHoverForeColor = Color.Black;
                    MinimizeNormalForeColor = Color.Black;
                    DisabledForeColor = Color.Black;
                    ThemeAuthor = "Taiizor";
                    ThemeName = "MetroLight";
                    break;
                case Style.Dark:
                    CloseHoverBackColor = Color.FromArgb(183, 40, 40);
                    CloseHoverForeColor = Color.White;
                    CloseNormalForeColor = Color.White;
                    MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
                    MaximizeHoverForeColor = Color.White;
                    MaximizeNormalForeColor = Color.White;
                    MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
                    MinimizeHoverForeColor = Color.White;
                    MinimizeNormalForeColor = Color.White;
                    DisabledForeColor = Color.Silver;
                    ThemeAuthor = "Taiizor";
                    ThemeName = "MetroDark";
                    break;
                case Style.Custom:
                    if (StyleManager != null)
                    {
                        foreach (System.Collections.Generic.KeyValuePair<string, object> varkey in StyleManager.ControlBoxDictionary)
                        {
                            switch (varkey.Key)
                            {
                                case "CloseHoverBackColor":
                                    CloseHoverBackColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                case "CloseHoverForeColor":
                                    CloseHoverForeColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                case "CloseNormalForeColor":
                                    CloseNormalForeColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                case "MaximizeHoverBackColor":
                                    MaximizeHoverBackColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                case "MaximizeHoverForeColor":
                                    MaximizeHoverForeColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                case "MaximizeNormalForeColor":
                                    MaximizeNormalForeColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                case "MinimizeHoverBackColor":
                                    MinimizeHoverBackColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                case "MinimizeHoverForeColor":
                                    MinimizeHoverForeColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                case "MinimizeNormalForeColor":
                                    MinimizeNormalForeColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                case "DisabledForeColor":
                                    DisabledForeColor = _utl.HexColor((string)varkey.Value);
                                    break;
                                default:
                                    return;
                            }
                        }
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(style), style, null);
            }
            Invalidate();
        }

        #endregion Theme Changing

        #region Properties

        #region Public

        [Category("Metro"), Description("Gets or sets the Default Location associated with the control.")]
        public LocationType DefaultLocation
        {
            get => _DefaultLocation;
            set => _DefaultLocation = value;
        }

        [Category("Metro")]
        [Description("Gets or sets the whether this control reflect to parent(s) style. \n " +
                     "Set it to false if you want the style of this control be independent. ")]
        public bool IsDerivedStyle
        {
            get => _isDerivedStyle;
            set
            {
                _isDerivedStyle = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets a value indicating whether the Maximize button is Enabled in the caption bar of the form.")]
        public bool MaximizeBox
        {
            get => _maximizeBox;
            set
            {
                try
                {
                    base.ParentForm.MaximizeBox = value;
                    Invalidate();
                }
                catch
                {
                }
            }
        }

        [Category("Metro"), Description("Gets or sets a value indicating whether the Minimize button is Enabled in the caption bar of the form.")]
        private bool _minimizeBox = true;
        public bool MinimizeBox
        {
            get => _minimizeBox;
            set
            {
                _minimizeBox = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets Close forecolor used by the control.")]
        public Color CloseNormalForeColor
        {
            get => _closeNormalForeColor;
            set
            {
                _closeNormalForeColor = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets Close forecolor used by the control.")]
        public Color CloseHoverForeColor
        {
            get => _closeHoverForeColor;
            set
            {
                _closeHoverForeColor = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets Close backcolor used by the control.")]
        public Color CloseHoverBackColor
        {
            get => _closeHoverBackColor;
            set
            {
                _closeHoverBackColor = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets Maximize forecolor used by the control.")]
        public Color MaximizeHoverForeColor
        {
            get => _maximizeHoverForeColor;
            set
            {
                _maximizeHoverForeColor = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets Maximize backcolor used by the control.")]
        public Color MaximizeHoverBackColor
        {
            get => _maximizeHoverBackColor;
            set
            {
                _maximizeHoverBackColor = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets Maximize forecolor used by the control.")]
        public Color MaximizeNormalForeColor
        {
            get => _maximizeNormalForeColor;
            set
            {
                _maximizeNormalForeColor = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets Minimize forecolor used by the control.")]
        public Color MinimizeHoverForeColor
        {
            get => _minimizeHoverForeColor;
            set
            {
                _minimizeHoverForeColor = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets Minimize backcolor used by the control.")]
        public Color MinimizeHoverBackColor
        {
            get => _minimizeHoverBackColor;
            set
            {
                _minimizeHoverBackColor = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets Minimize forecolor used by the control.")]
        public Color MinimizeNormalForeColor
        {
            get => _minimizeNormalForeColor;
            set
            {
                _minimizeNormalForeColor = value;
                Refresh();
            }
        }

        [Category("Metro"), Description("Gets or sets disabled forecolor used by the control.")]
        public Color DisabledForeColor
        {
            get => _disabledForeColor;
            set
            {
                _disabledForeColor = value;
                Refresh();
            }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override Color BackColor => Color.Transparent;

        #endregion

        #region Private 

        private bool MinimizeHovered { get; set; }

        private bool MaximizeHovered { get; set; }

        private bool CloseHovered { get; set; }

        #endregion

        #endregion

        #region Draw Control

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            using (SolidBrush brush = new SolidBrush(CloseHovered ? CloseHoverBackColor : Color.Transparent))
            {
                using (Font font = new Font("Marlett", 12f))
                {
                    using (SolidBrush solidBrush = new SolidBrush(CloseHovered ? CloseHoverForeColor : CloseNormalForeColor))
                    {
                        using (StringFormat format = new StringFormat
                        {
                            Alignment = StringAlignment.Center
                        })
                        {
                            graphics.FillRectangle(brush, new Rectangle(70, 5, 27, base.Height));
                            graphics.DrawString("r", font, CloseHovered ? solidBrush : Brushes.Gray, new Point(base.Width - 16, 8), format);
                        }
                    }
                }
            }

            using (SolidBrush brush2 = new SolidBrush((!MaximizeBox) ? Color.Transparent : (MaximizeHovered ? MaximizeHoverBackColor : Color.Transparent)))
            {
                using (Font font2 = new Font("Marlett", 12f))
                {
                    using (SolidBrush brush3 = new SolidBrush((!MaximizeBox) ? DisabledForeColor : (MaximizeHovered ? MaximizeHoverForeColor : MaximizeNormalForeColor)))
                    {
                        Form form = base.Parent.FindForm();
                        string s = (form != null && form.WindowState == FormWindowState.Maximized) ? "2" : "1";
                        using (StringFormat format2 = new StringFormat
                        {
                            Alignment = StringAlignment.Center
                        })
                        {
                            graphics.FillRectangle(brush2, new Rectangle(38, 5, 24, base.Height));
                            graphics.DrawString(s, font2, brush3, new Point(51, 7), format2);
                        }
                    }
                }
            }

            using (SolidBrush brush4 = new SolidBrush((!MinimizeBox) ? Color.Transparent : (MinimizeHovered ? MinimizeHoverBackColor : Color.Transparent)))
            {
                using (Font font3 = new Font("Marlett", 12f))
                {
                    using (SolidBrush brush5 = new SolidBrush((!MinimizeBox) ? DisabledForeColor : (MinimizeHovered ? MinimizeHoverForeColor : MinimizeNormalForeColor)))
                    {
                        using (StringFormat format3 = new StringFormat
                        {
                            Alignment = StringAlignment.Center
                        })
                        {
                            graphics.FillRectangle(brush4, new Rectangle(5, 5, 27, base.Height));
                            graphics.DrawString("0", font3, brush5, new Point(20, 7), format3);
                        }
                    }
                }
            }
        }


        #endregion

        #region Events

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            try
            {
                switch (DefaultLocation)
                {
                    case LocationType.Space:
                        Location = new((Parent.Width - Width) - 12, 13);
                        break;
                    case LocationType.Edge:
                        Location = new(Parent.Width - Width, 0);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                //
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            base.Height = 40;
            //Size = new(100, 33);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Location.Y > 0 && e.Location.Y < (Height - 2))
            {
                if (e.Location.X > 0 && e.Location.X < 34)
                {
                    MinimizeHovered = true;
                    MaximizeHovered = false;
                    CloseHovered = false;
                }
                else if (e.Location.X > 33 && e.Location.X < 65)
                {
                    MinimizeHovered = false;
                    MaximizeHovered = true;
                    CloseHovered = false;
                }
                else if (e.Location.X > 64 && e.Location.X < Width)
                {
                    MinimizeHovered = false;
                    MaximizeHovered = false;
                    CloseHovered = true;
                }
                else
                {
                    MinimizeHovered = false;
                    MaximizeHovered = false;
                    CloseHovered = false;
                }
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (CloseHovered)
            {
                Parent.FindForm()?.Close();
            }
            else if (MinimizeHovered)
            {
                if (!MinimizeBox)
                {
                    return;
                }

                Parent.FindForm().WindowState = FormWindowState.Minimized;
            }
            else if (MaximizeHovered)
            {
                if (MaximizeBox)
                {
                    Parent.FindForm().WindowState = Parent.FindForm()?.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
                }
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MinimizeHovered = false;
            MaximizeHovered = false;
            CloseHovered = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }

        #endregion
    }

    #endregion
}
