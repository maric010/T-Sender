namespace Telegram
{
    partial class Account_del
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
            this.lostCancelButton1 = new ReaLTaiizor.Controls.LostCancelButton();
            this.circleProgressBar1 = new Telegram.CircleProgressBar();
            this.my_Form1.SuspendLayout();
            this.SuspendLayout();
            // 
            // my_Form1
            // 
            this.my_Form1.BackColor = System.Drawing.Color.White;
            this.my_Form1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.my_Form1.Controls.Add(this.lostCancelButton1);
            this.my_Form1.Controls.Add(this.circleProgressBar1);
            this.my_Form1.Customization = "AAAA/1paWv9ycnL/";
            this.my_Form1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_Form1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.my_Form1.Image = null;
            this.my_Form1.Location = new System.Drawing.Point(0, 0);
            this.my_Form1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.my_Form1.MinimumSize = new System.Drawing.Size(98, 26);
            this.my_Form1.Movable = true;
            this.my_Form1.Name = "my_Form1";
            this.my_Form1.NoRounding = false;
            this.my_Form1.Sizable = true;
            this.my_Form1.Size = new System.Drawing.Size(262, 188);
            this.my_Form1.SmartBounds = true;
            this.my_Form1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.my_Form1.TabIndex = 0;
            this.my_Form1.Text = "Удаляется аккаунт";
            this.my_Form1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.my_Form1.Transparent = false;
            this.my_Form1.Click += new System.EventHandler(this.my_Form1_Click);
            // 
            // lostCancelButton1
            // 
            this.lostCancelButton1.BackColor = System.Drawing.Color.Crimson;
            this.lostCancelButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostCancelButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lostCancelButton1.ForeColor = System.Drawing.Color.White;
            this.lostCancelButton1.HoverColor = System.Drawing.Color.IndianRed;
            this.lostCancelButton1.Image = null;
            this.lostCancelButton1.Location = new System.Drawing.Point(67, 142);
            this.lostCancelButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lostCancelButton1.Name = "lostCancelButton1";
            this.lostCancelButton1.Size = new System.Drawing.Size(131, 38);
            this.lostCancelButton1.TabIndex = 5;
            this.lostCancelButton1.Text = "Вернуть";
            this.lostCancelButton1.Click += new System.EventHandler(this.lostCancelButton1_Click);
            // 
            // circleProgressBar1
            // 
            this.circleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circleProgressBar1.ForeColor = System.Drawing.Color.Red;
            this.circleProgressBar1.Location = new System.Drawing.Point(67, 53);
            this.circleProgressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleProgressBar1.Maximum = ((long)(100));
            this.circleProgressBar1.MinimumSize = new System.Drawing.Size(20, 20);
            this.circleProgressBar1.Name = "circleProgressBar1";
            this.circleProgressBar1.PercentColor = System.Drawing.Color.Red;
            this.circleProgressBar1.ProgressColor1 = System.Drawing.Color.Red;
            this.circleProgressBar1.ProgressColor2 = System.Drawing.Color.Red;
            this.circleProgressBar1.ProgressShape = Telegram.CircleProgressBar._ProgressShape.Round;
            this.circleProgressBar1.Size = new System.Drawing.Size(25, 25);
            this.circleProgressBar1.TabIndex = 4;
            this.circleProgressBar1.Text = "circleProgressBar1";
            this.circleProgressBar1.Value = ((long)(100));
            // 
            // Account_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 188);
            this.Controls.Add(this.my_Form1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(98, 26);
            this.Name = "Account_del";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account_del";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Account_del_Load);
            this.my_Form1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private My_Form my_Form1;
        private ReaLTaiizor.Controls.LostCancelButton lostCancelButton1;
        private CircleProgressBar circleProgressBar1;
    }
}