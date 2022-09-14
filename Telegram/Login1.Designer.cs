namespace Telegram
{
    partial class Login1
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
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.loginTextBox1 = new Telegram.LoginTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginTextBox2 = new Telegram.LoginTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dungeonLinkLabel1
            // 
            this.dungeonLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.dungeonLinkLabel1.AutoSize = true;
            this.dungeonLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.dungeonLinkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.dungeonLinkLabel1.Location = new System.Drawing.Point(51, 334);
            this.dungeonLinkLabel1.Name = "dungeonLinkLabel1";
            this.dungeonLinkLabel1.Size = new System.Drawing.Size(154, 25);
            this.dungeonLinkLabel1.TabIndex = 73;
            this.dungeonLinkLabel1.TabStop = true;
            this.dungeonLinkLabel1.Text = "Забыли пароль?";
            this.dungeonLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.dungeonLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dungeonLinkLabel1_LinkClicked);
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.White;
            this.dungeonLabel2.Location = new System.Drawing.Point(483, 81);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(78, 25);
            this.dungeonLabel2.TabIndex = 72;
            this.dungeonLabel2.Text = "Пароль";
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.White;
            this.dungeonLabel1.Location = new System.Drawing.Point(483, 13);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(190, 25);
            this.dungeonLabel1.TabIndex = 71;
            this.dungeonLabel1.Text = "E-mail пользователя";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bigLabel2.Location = new System.Drawing.Point(51, 124);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(275, 57);
            this.bigLabel2.TabIndex = 76;
            this.bigLabel2.Text = "Авторизация";
            // 
            // loginTextBox1
            // 
            this.loginTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.loginTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(161)))), ((int)(((byte)(210)))));
            this.loginTextBox1.EdgeColor = System.Drawing.Color.White;
            this.loginTextBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.loginTextBox1.Location = new System.Drawing.Point(50, 210);
            this.loginTextBox1.MaxLength = 32767;
            this.loginTextBox1.Multiline = false;
            this.loginTextBox1.Name = "loginTextBox1";
            this.loginTextBox1.ReadOnly = false;
            this.loginTextBox1.Size = new System.Drawing.Size(450, 50);
            this.loginTextBox1.TabIndex = 78;
            this.loginTextBox1.Text = "asdas";
            this.loginTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTextBox1.UseSystemPasswordChar = false;
            this.loginTextBox1.Enter += new System.EventHandler(this.loginTextBox1_Enter);
            this.loginTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login1_KeyDown);
            this.loginTextBox1.Leave += new System.EventHandler(this.loginTextBox1_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Telegram.Properties.Resources.email;
            this.pictureBox3.Location = new System.Drawing.Point(61, 218);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Telegram.Properties.Resources.password;
            this.pictureBox1.Location = new System.Drawing.Point(61, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // loginTextBox2
            // 
            this.loginTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.loginTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(161)))), ((int)(((byte)(210)))));
            this.loginTextBox2.EdgeColor = System.Drawing.Color.White;
            this.loginTextBox2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.loginTextBox2.Location = new System.Drawing.Point(51, 265);
            this.loginTextBox2.MaxLength = 32767;
            this.loginTextBox2.Multiline = false;
            this.loginTextBox2.Name = "loginTextBox2";
            this.loginTextBox2.ReadOnly = false;
            this.loginTextBox2.Size = new System.Drawing.Size(450, 50);
            this.loginTextBox2.TabIndex = 80;
            this.loginTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTextBox2.UseSystemPasswordChar = true;
            this.loginTextBox2.Enter += new System.EventHandler(this.loginTextBox2_Enter);
            this.loginTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login1_KeyDown);
            this.loginTextBox2.Leave += new System.EventHandler(this.loginTextBox2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(99, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 82;
            this.label1.Text = "email@example.com";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(99, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 83;
            this.label2.Text = "Введите пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // foreverButton1
            // 
            this.foreverButton1.BackColor = System.Drawing.Color.Transparent;
            this.foreverButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(181)))), ((int)(((byte)(112)))));
            this.foreverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverButton1.Location = new System.Drawing.Point(51, 378);
            this.foreverButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.foreverButton1.Name = "foreverButton1";
            this.foreverButton1.Rounded = true;
            this.foreverButton1.Size = new System.Drawing.Size(120, 50);
            this.foreverButton1.TabIndex = 84;
            this.foreverButton1.Text = "Войти";
            this.foreverButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButton1.Click += new System.EventHandler(this.dungeonButtonLeft1_Click);
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 568);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.foreverButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginTextBox2);
            this.Controls.Add(this.loginTextBox1);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.dungeonLinkLabel1);
            this.Controls.Add(this.dungeonLabel2);
            this.Controls.Add(this.dungeonLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login1";
            this.Text = "Login1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLinkLabel dungeonLinkLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private LoginTextBox loginTextBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private LoginTextBox loginTextBox2;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
    }
}