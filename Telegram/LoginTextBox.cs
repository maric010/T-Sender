using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Telegram
{
    [DefaultEvent("TextChanged")]
    public class LoginTextBox : Control
    {
        public TextBox DungeonTB = new TextBox();
        
        

        private GraphicsPath Shape;

        private int _maxchars = 32767;

        private bool _ReadOnly;

        private bool _Multiline;

        private HorizontalAlignment ALNType;

        private bool isPasswordMasked;

        private Pen P1;

        private Color _BorderColor = Color.FromArgb(60,161,210);

        private readonly SolidBrush B1;

        private Color _EdgeColor = Color.White;

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

        public Color EdgeColor
        {
            get
            {
                return _EdgeColor;
            }
            set
            {
                _EdgeColor = value;
            }
        }

        public HorizontalAlignment TextAlignment
        {
            get
            {
                return ALNType;
            }
            set
            {
                ALNType = value;
                Invalidate();
            }
        }

        public int MaxLength
        {
            get
            {
                return _maxchars;
            }
            set
            {
                _maxchars = value;
                DungeonTB.MaxLength = MaxLength;
                Invalidate();
            }
        }

        public bool UseSystemPasswordChar
        {
            get
            {
                return isPasswordMasked;
            }
            set
            {
                DungeonTB.UseSystemPasswordChar = UseSystemPasswordChar;
                isPasswordMasked = value;
                Invalidate();
            }
        }

        public bool ReadOnly
        {
            get
            {
                return _ReadOnly;
            }
            set
            {
                _ReadOnly = value;
                if (DungeonTB != null)
                {
                    DungeonTB.ReadOnly = value;
                }
            }
        }

        public bool Multiline
        {
            get
            {
                return _Multiline;
            }
            set
            {
                _Multiline = value;
                if (DungeonTB != null)
                {
                    DungeonTB.Multiline = value;
                    if (value)
                    {
                        DungeonTB.Height = base.Height - 10;
                    }
                    else
                    {
                        base.Height = DungeonTB.Height + 10;
                    }
                }
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            DungeonTB.Text = Text;
            Invalidate();
        }

        private void OnBaseTextChanged(object s, EventArgs e)
        {
            Text = DungeonTB.Text;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            DungeonTB.ForeColor = ForeColor;
            Invalidate();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            DungeonTB.Font = Font;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void _OnKeyDown(object Obj, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                DungeonTB.SelectAll();
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                DungeonTB.Copy();
                e.SuppressKeyPress = true;
            }
        }

        private void _Enter(object Obj, EventArgs e)
        {
            P1 = new Pen(Color.FromArgb(205, 87, 40));
            Refresh();
        }

        private void _Leave(object Obj, EventArgs e)
        {
            P1 = new Pen(Color.FromArgb(60, 161, 210));
            Refresh();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_Multiline)
            {
                DungeonTB.Height = base.Height - 10;
            }
            else
            {
                base.Height = 40;
            }

            Shape = new GraphicsPath();
            GraphicsPath shape = Shape;
            shape.AddArc(0, 0, 1, 1, 180f, 90f);
            shape.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
            shape.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
            shape.AddArc(0, base.Height - 11, 1, 10, 90f, 90f);
            shape.CloseAllFigures();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            DungeonTB.Focus();
        }

        public void AddTextBox()
        {
            TextBox dungeonTB = DungeonTB;
            dungeonTB.Size = new Size(base.Width - 10, 33);
            dungeonTB.Location = new Point(10, 10);
            dungeonTB.Text = string.Empty;
            dungeonTB.BorderStyle = BorderStyle.None;
            dungeonTB.TextAlign = HorizontalAlignment.Left;
            dungeonTB.Font = Font;
            dungeonTB.UseSystemPasswordChar = UseSystemPasswordChar;
            dungeonTB.Multiline = false;
            DungeonTB.KeyDown += _OnKeyDown;
            DungeonTB.Enter += _Enter;
            DungeonTB.Leave += _Leave;
            DungeonTB.TextChanged += OnBaseTextChanged;
        }
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        public LoginTextBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
            SetStyle(ControlStyles.UserPaint, value: true);
            AddTextBox();
            base.Controls.Add(DungeonTB);
            P1 = new Pen(_BorderColor,1f);
            B1 = new SolidBrush(_EdgeColor);
            BackColor = Color.Transparent;
            ForeColor = Color.DimGray;
            Text = null;
            base.Size = new Size(135, 40);
            DoubleBuffered = true;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap bitmap = new Bitmap(base.Width+100, base.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            TextBox dungeonTB = DungeonTB;
            dungeonTB.Width = base.Width -100;
            dungeonTB.TextAlign = TextAlignment;
            dungeonTB.UseSystemPasswordChar = UseSystemPasswordChar;
            graphics.Clear(BackColor);
            graphics.FillPath(B1, Shape);
            graphics.DrawPath(P1, Shape);
            e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
            graphics.Dispose();
            bitmap.Dispose();
        }
    }
}
