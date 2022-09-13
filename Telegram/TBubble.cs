using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Telegram
{
    public class TBubble : UserControl
    {

        private Image msgStatusImage = null;

        private Panel messageBottom = new Panel();

        private Label time = new Label();

        private PictureBox msgStatus = new PictureBox();

        private bool isAdded = false;

        private IContainer components = null;

        private Panel panel1;

        private Panel panel2;


        private Label label1;

        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string Body
        {
            get
            {
                return label1.Text.Replace(Environment.NewLine, "\n");
            }
            set
            {
                label1.Text = value.Replace("\n", Environment.NewLine);
            }
        }


        public Cursor ChatTextCursor
        {
            get
            {
                return label1.Cursor;
            }
            set
            {
                label1.Cursor = value;
            }
        }

        public Color MsgColor
        {
            get
            {
                return label1.BackColor;
            }
            set
            {
                label1.BackColor = value;
            }
        }

        public Color MsgTextColor
        {
            get
            {
                return label1.ForeColor;
            }
            set
            {
                label1.ForeColor = value;
            }
        }

        public Color TimeColor
        {
            get
            {
                return time.ForeColor;
            }
            set
            {
                time.ForeColor = value;
            }
        }

        public string Time
        {
            get
            {
                return time.Text;
            }
            set
            {
                time.Text = value;
                SetTimeWidth();
            }
        }



       

        public TBubble()
        {
            InitializeComponent();
        }

        private void SetTimeWidth()
        {
            time.Width = TextRenderer.MeasureText(time.Text, time.Font).Width;
        }

       
        private void SetMsgStatus()
        {
            
        }

        private void YouBubble_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            label1.MaximumSize = new Size((base.Width - panel1.Width - 21) / 2, 0);
            label1.Width = base.Width - panel1.Width - 21;
            if (label1.Height < panel2.Height + 1)
            {
                MinimumSize = new Size(0, panel2.Height + 11 + 15);
                base.Height = panel2.Height + 11 + 15;
            }
            else
            {
                MinimumSize = new Size(0, label1.Height + 10 + 15);
                base.Height = label1.Height + 10 + 15;
            }

            if (!isAdded)
            {
                messageBottom.Size = new Size(0, 15);
                messageBottom.Dock = DockStyle.Bottom;
                messageBottom.Padding = new Padding(47, 0, 0, 0);
                messageBottom.BackColor = Color.Transparent;
                messageBottom.ForeColor = Color.White;
                time.Dock = DockStyle.Left;
                SetTimeWidth();
                msgStatus.Dock = DockStyle.Left;
                msgStatus.SizeMode = PictureBoxSizeMode.StretchImage;
                msgStatus.Size = new Size(15, 15);
                messageBottom.Controls.Add(msgStatus);
                messageBottom.Controls.Add(time);
                base.Controls.Add(messageBottom);
                SetMsgStatus();
                isAdded = true;
            }

            GraphicsPath path = RoundedRectangle.Create(panel2.ClientRectangle, 16, RoundedRectangle.RectangleCorners.All);
            panel2.Region = new Region(path);
            GraphicsPath path3 = RoundedRectangle.Create(label1.ClientRectangle, 5, RoundedRectangle.RectangleCorners.All);
            label1.Region = new Region(path3);
            base.OnPaint(e);
        }

       

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(45, 51);
            panel1.TabIndex = 2;
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Location = new System.Drawing.Point(4, 0);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(1);
            panel2.Size = new System.Drawing.Size(34, 34);
            panel2.TabIndex = 1;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Font = new System.Drawing.Font("Arial", 8.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(45, 5);
            label1.MaximumSize = new System.Drawing.Size(140, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(3);
            label1.Size = new System.Drawing.Size(139, 150);
            label1.TabIndex = 3;
            label1.Text = " This is a sample text message. This is a sample text message. This is a sample text message. \r\n\r\nThis is a sample text message. ";
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            base.Controls.Add(label1);
            base.Name = "YouBubble";
            base.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            base.Size = new System.Drawing.Size(320, 61);
            base.Load += new System.EventHandler(YouBubble_Load);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}