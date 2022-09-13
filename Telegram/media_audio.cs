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
    public partial class media_audio : Form
    {
        public media_audio()
        {
            InitializeComponent();
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            /*
             * Открывает диалоговое окно в котором выбирает файл
             */
            if (Send.th.openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dungeonLabel3.Text = "Файл выбран";//Send.th.openFileDialog2.FileName;
                    my.получатели_файл_имя = Send.th.openFileDialog2.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
