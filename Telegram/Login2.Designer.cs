namespace Telegram
{
    partial class Login2
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
            this.dungeonLinkLabel1 = new ReaLTaiizor.Controls.DungeonLinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.foreverButton1 = new Telegram.ForeverButton();
            this.dungeonTextBox1 = new ReaLTaiizor.Controls.DungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dungeonLinkLabel1
            // 
            this.dungeonLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.dungeonLinkLabel1.AutoSize = true;
            this.dungeonLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLinkLabel1.ForeColor = System.Drawing.Color.Teal;
            this.dungeonLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.dungeonLinkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.dungeonLinkLabel1.Location = new System.Drawing.Point(236, 317);
            this.dungeonLinkLabel1.Name = "dungeonLinkLabel1";
            this.dungeonLinkLabel1.Size = new System.Drawing.Size(51, 20);
            this.dungeonLinkLabel1.TabIndex = 78;
            this.dungeonLinkLabel1.TabStop = true;
            this.dungeonLinkLabel1.Text = "Войти";
            this.dungeonLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.dungeonLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dungeonLinkLabel1_LinkClicked);
            this.dungeonLinkLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.dungeonLinkLabel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Telegram.Properties.Resources.Logo_T_sender1;
            this.pictureBox2.Location = new System.Drawing.Point(144, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Montserrat", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bigLabel2.Location = new System.Drawing.Point(17, 126);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(512, 44);
            this.bigLabel2.TabIndex = 92;
            this.bigLabel2.Text = "Восстановление пароля\r\nВведите email, который вы использовали при регистрации.";
            this.bigLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foreverButton1
            // 
            this.foreverButton1.BackColor = System.Drawing.Color.Transparent;
            this.foreverButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.foreverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButton1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverButton1.Location = new System.Drawing.Point(168, 254);
            this.foreverButton1.Name = "foreverButton1";
            this.foreverButton1.Rounded = true;
            this.foreverButton1.Size = new System.Drawing.Size(200, 45);
            this.foreverButton1.TabIndex = 94;
            this.foreverButton1.Text = "Восстановить";
            this.foreverButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButton1.Click += new System.EventHandler(this.dungeonButtonLeft1_Click);
            // 
            // dungeonTextBox1
            // 
            this.dungeonTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dungeonTextBox1.EdgeColor = System.Drawing.Color.White;
            this.dungeonTextBox1.Font = new System.Drawing.Font("Montserrat", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.dungeonTextBox1.Location = new System.Drawing.Point(85, 195);
            this.dungeonTextBox1.MaxLength = 32767;
            this.dungeonTextBox1.Multiline = false;
            this.dungeonTextBox1.Name = "dungeonTextBox1";
            this.dungeonTextBox1.ReadOnly = false;
            this.dungeonTextBox1.Size = new System.Drawing.Size(373, 28);
            this.dungeonTextBox1.TabIndex = 95;
            this.dungeonTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 397);
            this.Controls.Add(this.dungeonTextBox1);
            this.Controls.Add(this.foreverButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.dungeonLinkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login2";
            this.Text = "ё";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.DungeonLinkLabel dungeonLinkLabel1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ForeverButton foreverButton1;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
    }
}