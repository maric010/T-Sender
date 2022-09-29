
using ReaLTaiizor.Colors;
using ReaLTaiizor.Util;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Telegram
{
    public class HopeRadioButton : System.Windows.Forms.RadioButton
    {
        private Color _EnabledCheckedColor = HopeColors.PrimaryColor;

        private Color _EnabledUncheckedColor = ColorTranslator.FromHtml("#9c9ea1");

        private Color _DisabledColor = ColorTranslator.FromHtml("#c4c6ca");

        private Color _EnabledStringColor = ColorTranslator.FromHtml("#929292");

        private Color _DisabledStringColor = ColorTranslator.FromHtml("#babbbd");

        private Color _CheckedColor = HopeColors.PrimaryColor;

        private int SizeAnimationNum;

        private int PointAnimationNum = 10;

        private readonly System.Windows.Forms.Timer SizeAnimationTimer = new System.Windows.Forms.Timer
        {
            Interval = 35
        };

        private bool enterFalg;

        private bool _Enable = true;

        public bool Enable
        {
            get
            {
                return _Enable;
            }
            set
            {
                _Enable = value;
                Invalidate();
            }
        }

        public Color EnabledCheckedColor
        {
            get
            {
                return _EnabledCheckedColor;
            }
            set
            {
                _EnabledCheckedColor = value;
                Invalidate();
            }
        }

        public Color EnabledUncheckedColor
        {
            get
            {
                return _EnabledUncheckedColor;
            }
            set
            {
                _EnabledUncheckedColor = value;
                Invalidate();
            }
        }

        public Color DisabledColor
        {
            get
            {
                return _DisabledColor;
            }
            set
            {
                _DisabledColor = value;
                Invalidate();
            }
        }

        public Color EnabledStringColor
        {
            get
            {
                return _EnabledStringColor;
            }
            set
            {
                _EnabledStringColor = value;
                Invalidate();
            }
        }

        public Color DisabledStringColor
        {
            get
            {
                return _DisabledStringColor;
            }
            set
            {
                _DisabledStringColor = value;
                Invalidate();
            }
        }

        public Color CheckedColor
        {
            get
            {
                return _CheckedColor;
            }
            set
            {
                _CheckedColor = value;
                Invalidate();
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SizeAnimationTimer.Start();
        }

        protected override void OnResize(EventArgs e)
        {
            base.Height = 20;
            base.Width = 25 + TextRenderer.MeasureText(Text, Font).Width;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.Height = 20;
            base.Width = 25 + TextRenderer.MeasureText(Text, Font).Width;
        }

        protected override void OnMouseEnter(EventArgs eventargs)
        {
            base.OnMouseEnter(eventargs);
            enterFalg = true;
            if (_Enable)
            {
                Cursor = Cursors.Hand;
            }
            else
            {
                Cursor = Cursors.Default;
            }

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs eventargs)
        {
            base.OnMouseLeave(eventargs);
            enterFalg = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(BackColor);
            Rectangle rect = new Rectangle(1, 1, 18, 18);
            SolidBrush brush = new SolidBrush((!_Enable) ? _DisabledColor : ((base.Checked || enterFalg) ? _EnabledCheckedColor : _EnabledUncheckedColor));
            graphics.FillEllipse(brush, rect);
            graphics.FillEllipse(new SolidBrush(Color.White), new Rectangle(3, 3, 14, 14));
            graphics.FillEllipse(brush, new Rectangle(PointAnimationNum, PointAnimationNum, SizeAnimationNum, SizeAnimationNum));
            graphics.DrawString(Text, Font, new SolidBrush((!_Enable) ? _DisabledStringColor : (base.Checked ? _CheckedColor : ForeColor)), new RectangleF(22f, 0f, base.Width - 22, base.Height), HopeStringAlign.Center);
        }

        private void AnimationTick(object sender, EventArgs e)
        {
            if (base.Checked)
            {
                if (SizeAnimationNum < 8)
                {
                    SizeAnimationNum += 2;
                    PointAnimationNum--;
                    Invalidate();
                }
            }
            else if (SizeAnimationNum != 0)
            {
                SizeAnimationNum -= 2;
                PointAnimationNum++;
                Invalidate();
            }
        }

        public HopeRadioButton()
        {
            SizeAnimationTimer.Tick += AnimationTick;
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12f);
            ForeColor = Color.Black;
            Cursor = Cursors.Hand;
        }
    }
}
