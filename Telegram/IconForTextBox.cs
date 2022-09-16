using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Telegram
{
    [DefaultEvent("TextChanged")]
    public class IconForTextBox : Control
    {



        private GraphicsPath Shape;

        private HorizontalAlignment ALNType;


        private Pen P1;

        private Color _BorderColor = Color.White;

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

     

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            base.Height = 50;
            Shape = new GraphicsPath();
            GraphicsPath shape = Shape;
            shape.AddArc(0, 0, 10, 10, 180f, 90f);
            shape.AddArc(base.Width - 11, 0, 10, 1, -90f, 90f);
            shape.AddArc(base.Width - 11, base.Height - 11, 10, 20, 0f, 90f);
            shape.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
            shape.CloseAllFigures();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }

       
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        public IconForTextBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
            SetStyle(ControlStyles.UserPaint, value: true);
            P1 = new Pen(_BorderColor, 0.1f);
            B1 = new SolidBrush(_EdgeColor);
            BackColor = Color.Red;
            ForeColor = Color.DimGray;
            Text = null;
            Font = new Font("Tahoma", 11f);
            base.Size = new Size(135, 50);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap bitmap = new Bitmap(base.Width + 100, base.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(BackColor);
            graphics.FillPath(B1, Shape);
            graphics.DrawPath(P1, Shape);
            e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
            graphics.Dispose();
            bitmap.Dispose();
        }
    }
}
