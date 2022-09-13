namespace Telegram
{
    partial class media_video
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
            this.dungeonLabel5 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonHeaderLabel6 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonButtonLeft1 = new ReaLTaiizor.Controls.DungeonButtonLeft();
            this.SuspendLayout();
            // 
            // dungeonLabel5
            // 
            this.dungeonLabel5.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel5.Location = new System.Drawing.Point(6, 23);
            this.dungeonLabel5.Name = "dungeonLabel5";
            this.dungeonLabel5.Size = new System.Drawing.Size(280, 29);
            this.dungeonLabel5.TabIndex = 32;
            this.dungeonLabel5.Text = "Максимальный размер видео файла 15 мегабайт";
            // 
            // dungeonHeaderLabel6
            // 
            this.dungeonHeaderLabel6.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dungeonHeaderLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel6.Location = new System.Drawing.Point(6, 0);
            this.dungeonHeaderLabel6.Name = "dungeonHeaderLabel6";
            this.dungeonHeaderLabel6.Size = new System.Drawing.Size(270, 20);
            this.dungeonHeaderLabel6.TabIndex = 31;
            this.dungeonHeaderLabel6.Text = "Выберите видео файл:";
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(155, 55);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(124, 20);
            this.dungeonLabel3.TabIndex = 29;
            this.dungeonLabel3.Text = "Файл не выбран";
            // 
            // dungeonButtonLeft1
            // 
            this.dungeonButtonLeft1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonButtonLeft1.BorderColor = System.Drawing.Color.Black;
            this.dungeonButtonLeft1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonButtonLeft1.Image = null;
            this.dungeonButtonLeft1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dungeonButtonLeft1.InactiveColorA = System.Drawing.Color.White;
            this.dungeonButtonLeft1.InactiveColorB = System.Drawing.Color.White;
            this.dungeonButtonLeft1.Location = new System.Drawing.Point(6, 55);
            this.dungeonButtonLeft1.Name = "dungeonButtonLeft1";
            this.dungeonButtonLeft1.PressedColorA = System.Drawing.Color.White;
            this.dungeonButtonLeft1.PressedColorB = System.Drawing.Color.White;
            this.dungeonButtonLeft1.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.dungeonButtonLeft1.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.dungeonButtonLeft1.Size = new System.Drawing.Size(128, 22);
            this.dungeonButtonLeft1.TabIndex = 28;
            this.dungeonButtonLeft1.Text = "Выберите файл";
            this.dungeonButtonLeft1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.dungeonButtonLeft1.Click += new System.EventHandler(this.dungeonButtonLeft1_Click);
            // 
            // media_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(295, 87);
            this.Controls.Add(this.dungeonLabel5);
            this.Controls.Add(this.dungeonHeaderLabel6);
            this.Controls.Add(this.dungeonLabel3);
            this.Controls.Add(this.dungeonButtonLeft1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "media_video";
            this.Text = "media_img";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel5;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel6;
        private ReaLTaiizor.Controls.DungeonButtonLeft dungeonButtonLeft1;
        public ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
    }
}