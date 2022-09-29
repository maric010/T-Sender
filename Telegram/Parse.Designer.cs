namespace Telegram
{
    partial class Parse
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
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.foreverButton1 = new Telegram.ForeverButton();
            this.tPanel1 = new Telegram.TPanel();
            this.dungeonTextBox1 = new ReaLTaiizor.Controls.DreamTextBox();
            this.tPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(35, 116);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(337, 22);
            this.dungeonHeaderLabel1.TabIndex = 3;
            this.dungeonHeaderLabel1.Text = "Введите ссылку или username группы";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 24.0928F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(35, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(635, 45);
            this.label6.TabIndex = 32;
            this.label6.Text = "Парсинг групп";
            // 
            // foreverButton1
            // 
            this.foreverButton1.BackColor = System.Drawing.Color.Transparent;
            this.foreverButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.foreverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButton1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverButton1.Location = new System.Drawing.Point(580, 150);
            this.foreverButton1.Name = "foreverButton1";
            this.foreverButton1.Rounded = true;
            this.foreverButton1.Size = new System.Drawing.Size(193, 45);
            this.foreverButton1.TabIndex = 85;
            this.foreverButton1.Text = "Получить xlsx файл";
            this.foreverButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButton1.Click += new System.EventHandler(this.dungeonButtonLeft1_Click);
            // 
            // tPanel1
            // 
            this.tPanel1.BackColor = System.Drawing.Color.White;
            this.tPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(212)))), ((int)(((byte)(235)))));
            this.tPanel1.Controls.Add(this.dungeonTextBox1);
            this.tPanel1.Location = new System.Drawing.Point(386, 111);
            this.tPanel1.Name = "tPanel1";
            this.tPanel1.Radius = 20;
            this.tPanel1.Size = new System.Drawing.Size(387, 33);
            this.tPanel1.TabIndex = 86;
            this.tPanel1.Thickness = 1F;
            // 
            // dungeonTextBox1
            // 
            this.dungeonTextBox1.BackColor = System.Drawing.Color.White;
            this.dungeonTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dungeonTextBox1.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dungeonTextBox1.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dungeonTextBox1.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dungeonTextBox1.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dungeonTextBox1.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dungeonTextBox1.ColorF = System.Drawing.Color.Black;
            this.dungeonTextBox1.Font = new System.Drawing.Font("Montserrat", 11.2935F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dungeonTextBox1.Location = new System.Drawing.Point(5, 5);
            this.dungeonTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dungeonTextBox1.Multiline = true;
            this.dungeonTextBox1.Name = "dungeonTextBox1";
            this.dungeonTextBox1.PlaceholderText = "Пример: @telchat";
            this.dungeonTextBox1.Size = new System.Drawing.Size(378, 23);
            this.dungeonTextBox1.TabIndex = 47;
            // 
            // Parse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.tPanel1);
            this.Controls.Add(this.foreverButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Parse";
            this.Text = "Parse";
            this.tPanel1.ResumeLayout(false);
            this.tPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        public SaveFileDialog saveFileDialog1;
        private Label label6;
        private ForeverButton foreverButton1;
        private TPanel tPanel1;
        public ReaLTaiizor.Controls.DreamTextBox dungeonTextBox1;
    }
}