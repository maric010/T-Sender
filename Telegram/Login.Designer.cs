﻿namespace Telegram
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.my_Form1 = new Telegram.My_Form();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.my_Form1.SuspendLayout();
            this.SuspendLayout();
            // 
            // my_Form1
            // 
            this.my_Form1.BackColor = System.Drawing.Color.White;
            this.my_Form1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.my_Form1.Controls.Add(this.panel1);
            this.my_Form1.Controls.Add(this.metroControlBox1);
            this.my_Form1.Customization = "AAAA/1paWv9ycnL/";
            this.my_Form1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_Form1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.my_Form1.Image = null;
            this.my_Form1.Location = new System.Drawing.Point(0, 0);
            this.my_Form1.MinimumSize = new System.Drawing.Size(112, 35);
            this.my_Form1.Movable = true;
            this.my_Form1.Name = "my_Form1";
            this.my_Form1.NoRounding = false;
            this.my_Form1.Sizable = true;
            this.my_Form1.Size = new System.Drawing.Size(1561, 1024);
            this.my_Form1.SmartBounds = true;
            this.my_Form1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.my_Form1.TabIndex = 2;
            this.my_Form1.Text = "T-Sender";
            this.my_Form1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.my_Form1.Transparent = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 986);
            this.panel1.TabIndex = 56;
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox1.IsDerivedStyle = true;
            this.metroControlBox1.Location = new System.Drawing.Point(1460, -5);
            this.metroControlBox1.MaximizeBox = false;
            this.metroControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeBox = true;
            this.metroControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroControlBox1.StyleManager = null;
            this.metroControlBox1.TabIndex = 55;
            this.metroControlBox1.Text = "metroControlBox1";
            this.metroControlBox1.ThemeAuthor = "Taiizor";
            this.metroControlBox1.ThemeName = "MetroLight";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1561, 1024);
            this.Controls.Add(this.my_Form1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dungeonForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Login_Load);
            this.my_Form1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private My_Form my_Form1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private Panel panel1;
    }
}