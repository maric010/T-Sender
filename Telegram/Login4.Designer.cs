namespace Telegram
{
    partial class Login4
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
            this.dungeonTextBox1 = new ReaLTaiizor.Controls.MaterialSingleTextBox();
            this.foreverButton1 = new Telegram.ForeverButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.dungeonTextBox2 = new ReaLTaiizor.Controls.MaterialSingleTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dungeonTextBox1
            // 
            this.dungeonTextBox1.Depth = 0;
            this.dungeonTextBox1.Font = new System.Drawing.Font("Montserrat", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonTextBox1.Hint = "Новый пароль";
            this.dungeonTextBox1.Location = new System.Drawing.Point(93, 241);
            this.dungeonTextBox1.MaxLength = 32767;
            this.dungeonTextBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.dungeonTextBox1.Name = "dungeonTextBox1";
            this.dungeonTextBox1.PasswordChar = '\0';
            this.dungeonTextBox1.SelectedText = "";
            this.dungeonTextBox1.SelectionLength = 0;
            this.dungeonTextBox1.SelectionStart = 0;
            this.dungeonTextBox1.Size = new System.Drawing.Size(350, 25);
            this.dungeonTextBox1.TabIndex = 107;
            this.dungeonTextBox1.TabStop = false;
            this.dungeonTextBox1.UseAccentColor = false;
            this.dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // foreverButton1
            // 
            this.foreverButton1.BackColor = System.Drawing.Color.Transparent;
            this.foreverButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.foreverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButton1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverButton1.Location = new System.Drawing.Point(168, 327);
            this.foreverButton1.Name = "foreverButton1";
            this.foreverButton1.Rounded = true;
            this.foreverButton1.Size = new System.Drawing.Size(200, 45);
            this.foreverButton1.TabIndex = 106;
            this.foreverButton1.Text = "Восстановить";
            this.foreverButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButton1.Click += new System.EventHandler(this.foreverButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Telegram.Properties.Resources.Logo_T_sender1;
            this.pictureBox2.Location = new System.Drawing.Point(144, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Montserrat", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bigLabel2.Location = new System.Drawing.Point(80, 126);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(372, 66);
            this.bigLabel2.TabIndex = 104;
            this.bigLabel2.Text = "Восстановление пароля\r\nВведите новый пароль от 8 до 14 символов\r\n(без пробелов и " +
    "специальных символов).\r\n";
            this.bigLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dungeonTextBox2
            // 
            this.dungeonTextBox2.Depth = 0;
            this.dungeonTextBox2.Font = new System.Drawing.Font("Montserrat", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonTextBox2.Hint = "Подтвердить пароль";
            this.dungeonTextBox2.Location = new System.Drawing.Point(93, 272);
            this.dungeonTextBox2.MaxLength = 32767;
            this.dungeonTextBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.dungeonTextBox2.Name = "dungeonTextBox2";
            this.dungeonTextBox2.PasswordChar = '*';
            this.dungeonTextBox2.SelectedText = "";
            this.dungeonTextBox2.SelectionLength = 0;
            this.dungeonTextBox2.SelectionStart = 0;
            this.dungeonTextBox2.Size = new System.Drawing.Size(350, 25);
            this.dungeonTextBox2.TabIndex = 108;
            this.dungeonTextBox2.TabStop = false;
            this.dungeonTextBox2.UseAccentColor = false;
            this.dungeonTextBox2.UseSystemPasswordChar = false;
            // 
            // Login4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 464);
            this.Controls.Add(this.dungeonTextBox2);
            this.Controls.Add(this.dungeonTextBox1);
            this.Controls.Add(this.foreverButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bigLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login4";
            this.Text = "Login2";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialSingleTextBox dungeonTextBox1;
        private ForeverButton foreverButton1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.MaterialSingleTextBox dungeonTextBox2;
    }
}