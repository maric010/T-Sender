namespace Telegram
{
    partial class GridAccountDel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.circleProgressBar1 = new Telegram.CircleProgressBar();
            this.dungeonLinkLabel1 = new ReaLTaiizor.Controls.DungeonLinkLabel();
            this.SuspendLayout();
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(58, 3);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(89, 17);
            this.dungeonLabel2.TabIndex = 8;
            this.dungeonLabel2.Text = "Вы удалили";
            this.dungeonLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // circleProgressBar1
            // 
            this.circleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circleProgressBar1.ForeColor = System.Drawing.Color.Red;
            this.circleProgressBar1.Location = new System.Drawing.Point(3, -1);
            this.circleProgressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleProgressBar1.Maximum = ((long)(100));
            this.circleProgressBar1.MinimumSize = new System.Drawing.Size(20, 20);
            this.circleProgressBar1.Name = "circleProgressBar1";
            this.circleProgressBar1.PercentColor = System.Drawing.Color.Red;
            this.circleProgressBar1.ProgressColor1 = System.Drawing.Color.Red;
            this.circleProgressBar1.ProgressColor2 = System.Drawing.Color.Red;
            this.circleProgressBar1.ProgressShape = Telegram.CircleProgressBar._ProgressShape.Round;
            this.circleProgressBar1.Size = new System.Drawing.Size(24, 24);
            this.circleProgressBar1.TabIndex = 15;
            this.circleProgressBar1.Text = "circleProgressBar1";
            this.circleProgressBar1.Value = ((long)(100));
            this.circleProgressBar1.Click += new System.EventHandler(this.circleProgressBar1_Click);
            // 
            // dungeonLinkLabel1
            // 
            this.dungeonLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.dungeonLinkLabel1.AutoSize = true;
            this.dungeonLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLinkLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.dungeonLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.dungeonLinkLabel1.Location = new System.Drawing.Point(842, 3);
            this.dungeonLinkLabel1.Name = "dungeonLinkLabel1";
            this.dungeonLinkLabel1.Size = new System.Drawing.Size(64, 17);
            this.dungeonLinkLabel1.TabIndex = 16;
            this.dungeonLinkLabel1.TabStop = true;
            this.dungeonLinkLabel1.Text = "Вернуть";
            this.dungeonLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.dungeonLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dungeonLinkLabel1_LinkClicked);
            // 
            // GridAccountDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dungeonLinkLabel1);
            this.Controls.Add(this.circleProgressBar1);
            this.Controls.Add(this.dungeonLabel2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GridAccountDel";
            this.Size = new System.Drawing.Size(908, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private CircleProgressBar circleProgressBar1;
        private ReaLTaiizor.Controls.DungeonLinkLabel dungeonLinkLabel1;
    }
}
