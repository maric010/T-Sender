﻿namespace Telegram
{
    partial class media_img
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonButtonLeft1 = new ReaLTaiizor.Controls.DungeonButtonLeft();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dungeonLabel5
            // 
            this.dungeonLabel5.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel5.Location = new System.Drawing.Point(114, 31);
            this.dungeonLabel5.Name = "dungeonLabel5";
            this.dungeonLabel5.Size = new System.Drawing.Size(320, 120);
            this.dungeonLabel5.TabIndex = 32;
            this.dungeonLabel5.Text = "Максимальный размер изображения 500 килобайт\r\nРекомендуем использовать квадратное" +
    " изображение 200х200 рх\r\nМаксимальный размер изображения\r\n1600х1600 px\r\n";
            // 
            // dungeonHeaderLabel6
            // 
            this.dungeonHeaderLabel6.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dungeonHeaderLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel6.Location = new System.Drawing.Point(114, 0);
            this.dungeonHeaderLabel6.Name = "dungeonHeaderLabel6";
            this.dungeonHeaderLabel6.Size = new System.Drawing.Size(309, 27);
            this.dungeonHeaderLabel6.TabIndex = 31;
            this.dungeonHeaderLabel6.Text = "Выберите изображение:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Telegram.Properties.Resources.img_522136;
            this.pictureBox3.InitialImage = global::Telegram.Properties.Resources.img_522136;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(281, 167);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(154, 25);
            this.dungeonLabel3.TabIndex = 29;
            this.dungeonLabel3.Text = "Файл не выбран";
            // 
            // dungeonButtonLeft1
            // 
            this.dungeonButtonLeft1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonButtonLeft1.BorderColor = System.Drawing.Color.Black;
            this.dungeonButtonLeft1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dungeonButtonLeft1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonButtonLeft1.Image = null;
            this.dungeonButtonLeft1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dungeonButtonLeft1.InactiveColorA = System.Drawing.Color.White;
            this.dungeonButtonLeft1.InactiveColorB = System.Drawing.Color.White;
            this.dungeonButtonLeft1.Location = new System.Drawing.Point(111, 167);
            this.dungeonButtonLeft1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dungeonButtonLeft1.Name = "dungeonButtonLeft1";
            this.dungeonButtonLeft1.PressedColorA = System.Drawing.Color.White;
            this.dungeonButtonLeft1.PressedColorB = System.Drawing.Color.White;
            this.dungeonButtonLeft1.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.dungeonButtonLeft1.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.dungeonButtonLeft1.Size = new System.Drawing.Size(155, 29);
            this.dungeonButtonLeft1.TabIndex = 28;
            this.dungeonButtonLeft1.Text = "Выберите файл";
            this.dungeonButtonLeft1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.dungeonButtonLeft1.Click += new System.EventHandler(this.dungeonButtonLeft1_Click);
            // 
            // media_img
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 200);
            this.Controls.Add(this.dungeonLabel5);
            this.Controls.Add(this.dungeonHeaderLabel6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dungeonLabel3);
            this.Controls.Add(this.dungeonButtonLeft1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "media_img";
            this.Text = "media_img";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel5;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel6;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.DungeonButtonLeft dungeonButtonLeft1;
        public ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
    }
}