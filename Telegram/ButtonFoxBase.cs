using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Telegram
{
    public abstract class ButtonFoxBase : Control
    {
        public delegate void ClickEventHandler(object sender, EventArgs e);

        public FoxLibrary.MouseState State;

        private bool IsEnabled;

        public new bool Enabled
        {
            get
            {
                return EnabledCalc;
            }
            set
            {
                IsEnabled = value;
                if (Enabled)
                {
                    Cursor = Cursors.Hand;
                }
                else
                {
                    Cursor = Cursors.Default;
                }

                Invalidate();
            }
        }

        [DisplayName("Enabled")]
        public bool EnabledCalc
        {
            get
            {
                return IsEnabled;
            }
            set
            {
                Enabled = value;
                Invalidate();
            }
        }

        public new event ClickEventHandler Click;

        public ButtonFoxBase()
        {
            DoubleBuffered = true;
            Enabled = true;
            base.Size = new Size(120, 40);
            ForeColor = FoxLibrary.ColorFromHex("#424E5A");
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = FoxLibrary.MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = FoxLibrary.MouseState.None;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = FoxLibrary.MouseState.Over;
            Invalidate();
            if (Enabled)
            {
                this.Click?.Invoke(this, e);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = FoxLibrary.MouseState.Down;
            Invalidate();
        }
    }
}
