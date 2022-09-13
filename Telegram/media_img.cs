using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegram
{
    public partial class media_img : Form
    {
        internal static media_img th;
        public media_img()
        {
            InitializeComponent();
            th = this;
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            //Открывает диалоговое окно в котором выбирает файл изображения
            //и показывает его внутри picturebox1
            if (Send.th.openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dungeonLabel3.Text = "Файл выбран";
                    my.получатели_файл_имя = Send.th.openFileDialog2.FileName;
                    Send.th.pictureBox1.Visible = true;
                    Send.th.pictureBox1.ImageLocation = my.получатели_файл_имя;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
