namespace Telegram
{
    partial class Grid_Select
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.hopeRadioButton1 = new ReaLTaiizor.Controls.HopeRadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(212)))), ((int)(((byte)(235)))));
            this.panel1.Location = new System.Drawing.Point(10, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 1);
            this.panel1.TabIndex = 1;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Montserrat", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(40, 10);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(63, 22);
            this.dungeonLabel1.TabIndex = 5;
            this.dungeonLabel1.Text = "@dass";
            this.dungeonLabel1.Click += new System.EventHandler(this.hopeRadioButton1_Click);
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Montserrat", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(175, 10);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(150, 22);
            this.dungeonLabel2.TabIndex = 6;
            this.dungeonLabel2.Text = "+375297889595";
            this.dungeonLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dungeonLabel2.Click += new System.EventHandler(this.hopeRadioButton1_Click);
            // 
            // hopeRadioButton1
            // 
            this.hopeRadioButton1.AutoSize = true;
            this.hopeRadioButton1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.hopeRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeRadioButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeRadioButton1.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeRadioButton1.Enable = true;
            this.hopeRadioButton1.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(161)))), ((int)(((byte)(210)))));
            this.hopeRadioButton1.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.hopeRadioButton1.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeRadioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeRadioButton1.ForeColor = System.Drawing.Color.Black;
            this.hopeRadioButton1.Location = new System.Drawing.Point(10, 13);
            this.hopeRadioButton1.Name = "hopeRadioButton1";
            this.hopeRadioButton1.Size = new System.Drawing.Size(25, 20);
            this.hopeRadioButton1.TabIndex = 7;
            this.hopeRadioButton1.UseVisualStyleBackColor = true;
            this.hopeRadioButton1.CheckedChanged += new System.EventHandler(this.hopeRadioButton1_CheckedChanged);
            this.hopeRadioButton1.Click += new System.EventHandler(this.hopeRadioButton1_Click);
            // 
            // Grid_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.dungeonLabel2);
            this.Controls.Add(this.hopeRadioButton1);
            this.Controls.Add(this.panel1);
            this.Name = "Grid_Select";
            this.Size = new System.Drawing.Size(359, 43);
            this.Load += new System.EventHandler(this.Grid_Select_Load);
            this.Click += new System.EventHandler(this.hopeRadioButton1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        public ReaLTaiizor.Controls.HopeRadioButton hopeRadioButton1;
    }
}
