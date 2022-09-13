using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegram
{
    public partial class Тех_Поддержка : Form
    {
        public Тех_Поддержка()
        {
            InitializeComponent();
        }

        private void my_Form1_Click(object sender, EventArgs e)
        {

        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            server.send("support|" + dungeonTextBox1.Text);
            dungeonTextBox1.Text = "";
            MessageBox.Show("Сообщение отправлена");
            this.Close();
        }

        private void dungeonButtonLeft2_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "http://t.me/maric000";
                myProcess.Start();
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
        }
    }
}
