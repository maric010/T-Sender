
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Telegram
{
    public class CircleProgressBar : Control
    {
        public enum _ProgressShape
        {
            Round,
            Flat
        }

        private long _Value;

        private long _Maximum = 100L;

        private Color _PercentColor = Color.White;

        private Color _ProgressColor1 = Color.FromArgb(92, 92, 92);

        private Color _ProgressColor2 = Color.FromArgb(92, 92, 92);

        private _ProgressShape ProgressShapeVal;

        public long Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (value > _Maximum)
                {
                    value = _Maximum;
                }

                _Value = value;
                Invalidate();
            }
        }

        public long Maximum
        {
            get
            {
                return _Maximum;
            }
            set
            {
                if (value < 1)
                {
                    value = 1L;
                }

                _Maximum = value;
                Invalidate();
            }
        }

        public Color PercentColor
        {
            get
            {
                return _PercentColor;
            }
            set
            {
                _PercentColor = value;
                Invalidate();
            }
        }

        public Color ProgressColor1
        {
            get
            {
                return _ProgressColor1;
            }
            set
            {
                _ProgressColor1 = value;
                Invalidate();
            }
        }

        public Color ProgressColor2
        {
            get
            {
                return _ProgressColor2;
            }
            set
            {
                _ProgressColor2 = value;
                Invalidate();
            }
        }

        public _ProgressShape ProgressShape
        {
            get
            {
                return ProgressShapeVal;
            }
            set
            {
                ProgressShapeVal = value;
                Invalidate();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetStandardSize();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetStandardSize();
        }

        protected override void OnPaintBackground(PaintEventArgs p)
        {
            base.OnPaintBackground(p);
        }

        public CircleProgressBar()
        {
            base.Size = new Size(130, 130);
            Font = new Font("Segoe UI", 15f);
            MinimumSize = new Size(100, 100);
            DoubleBuffered = true;
        }

        private void SetStandardSize()
        {
            int num = Math.Max(base.Width, base.Height);
            base.Size = new Size(num, num);
        }

        public void Increment(int Val)
        {
            _Value += Val;
            Invalidate();
        }

        public void Decrement(int Val)
        {
            _Value -= Val;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.Clear(BackColor);
                    using (LinearGradientBrush brush = new LinearGradientBrush(base.ClientRectangle, _ProgressColor1, _ProgressColor2, LinearGradientMode.ForwardDiagonal))
                    {
                        using (Pen pen = new Pen(brush, 3f))
                        {
                            switch (ProgressShapeVal)
                            {
                                case _ProgressShape.Round:
                                    pen.StartCap = LineCap.Round;
                                    pen.EndCap = LineCap.Round;
                                    break;
                                case _ProgressShape.Flat:
                                    pen.StartCap = LineCap.Flat;
                                    pen.EndCap = LineCap.Flat;
                                    break;
                            }

                            graphics.DrawArc(pen, 3, 3, base.Width-6, base.Height-6, -90, (int)Math.Round(360.0 / (double)_Maximum * (double)_Value));
                        }
                    }

                    using (LinearGradientBrush brush2 = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(52, 52, 52), Color.FromArgb(52, 52, 52), LinearGradientMode.Vertical))
                    {
                        //graphics.FillEllipse(brush2, 0, 0, base.Width-1, base.Height-1);
                    }

                    SizeF sizeF = graphics.MeasureString(Convert.ToString(Convert.ToInt32(_Value/20)), Font);
                    graphics.DrawString(Convert.ToString(Convert.ToInt32(_Value/20)+1), Font, new SolidBrush(_PercentColor), Convert.ToInt32((float)(base.Width / 2) - sizeF.Width / 2f)+1, Convert.ToInt32((float)(base.Height / 2) - sizeF.Height / 2f));
                    e.Graphics.DrawImage(bitmap, 0, 0);
                    graphics.Dispose();
                    bitmap.Dispose();
                }
            }
        }
    }
}
