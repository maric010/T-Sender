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
    public partial class Login3 : Form
    {
        public Login3()
        {
            InitializeComponent();
        }

        private void dungeonLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
             * Вернемся к вводу email
             */
            Login.load_form(new Login2());
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            /*
             * Отправляем серверу email и код
             */
            server.send("restore_password|"+Login2.email+"|"+dungeonTextBox1.Text);
        }
    }
}
