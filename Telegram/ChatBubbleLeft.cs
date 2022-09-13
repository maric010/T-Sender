using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Telegram
{
    public class ChatBubbleLeft : Control
    {
        private GraphicsPath Shape;

        private Color _TextColor = Color.FromArgb(52, 52, 52);

        private Color _BubbleColor = Color.FromArgb(217, 217, 217);

        private bool _DrawBubbleArrow = true;

        private bool _SizeAuto = true;

        private bool _SizeAutoW = true;

        private bool _SizeAutoH = true;

        public override Color ForeColor
        {
            get
            {
                return _TextColor;
            }
            set
            {
                _TextColor = value;
                Invalidate();
            }
        }

        public Color BubbleColor
        {
            get
            {
                return _BubbleColor;
            }
            set
            {
                _BubbleColor = value;
                Invalidate();
            }
        }

        public bool DrawBubbleArrow
        {
            get
            {
                return _DrawBubbleArrow;
            }
            set
            {
                _DrawBubbleArrow = value;
                Invalidate();
            }
        }

        public bool SizeAuto
        {
            get
            {
                return _SizeAuto;
            }
            set
            {
                _SizeAuto = value;
                Invalidate();
            }
        }

        public bool SizeAutoW
        {
            get
            {
                return _SizeAutoW;
            }
            set
            {
                _SizeAutoW = value;
                Invalidate();
            }
        }

        public bool SizeAutoH
        {
            get
            {
                return _SizeAutoH;
            }
            set
            {
                _SizeAutoH = value;
                Invalidate();
            }
        }

        public ChatBubbleLeft()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
            DoubleBuffered = true;
            base.Size = new Size(120, 40);
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(52, 52, 52);
            Font = new Font("Segoe UI", 10f);
        }

        protected override void OnResize(EventArgs e)
        {
            Shape = new GraphicsPath();
            GraphicsPath shape = Shape;
            shape.AddArc(9, 0, 10, 10, 180f, 90f);
            shape.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
            shape.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
            shape.AddArc(9, base.Height - 11, 10, 10, 90f, 90f);
            shape.CloseAllFigures();
            Invalidate();
            base.OnResize(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_SizeAuto)
            {
                if (_SizeAutoW && _SizeAutoH)
                {
                    base.Width = TextRenderer.MeasureText(Text, Font).Width + 15;

                    //base.Height = TextRenderer.MeasureText(Text, Font).Height + 15;
                    using (Graphics g = CreateGraphics())
                    {
                        SizeF size = g.MeasureString(base.Text, base.Font, 200);
                        base.Height = (int)Math.Ceiling(size.Height + 15);
                        
                    }
                }
                else if (_SizeAutoW)
                {
                    base.Width = TextRenderer.MeasureText(Text, Font).Width + 15;
                }
                else
                {

                    base.Height = TextRenderer.MeasureText(Text, Font).Height*2;
                    
                }
            }

            Bitmap bitmap = new Bitmap(base.Width, base.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Graphics graphics2 = graphics;
            graphics2.SmoothingMode = SmoothingMode.HighQuality;
            graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics2.Clear(BackColor);
            graphics2.FillPath(new SolidBrush(_BubbleColor), Shape);
            graphics2.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(15, 7, base.Width - 17, base.Height - 5));
            if (_DrawBubbleArrow)
            {
                Point[] points = new Point[3]
                {
                    new Point(9, base.Height - 19),
                    new Point(0, base.Height - 25),
                    new Point(9, base.Height - 30)
                };
                graphics2.FillPolygon(new SolidBrush(_BubbleColor), points);
                graphics2.DrawPolygon(new Pen(new SolidBrush(_BubbleColor)), points);
            }

            graphics.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
            bitmap.Dispose();
        }
    }
}
