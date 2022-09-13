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
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            login();
        }
        void login()
        {
            //делает запрос к серверу передавая данные для авторизации
            my.username = dungeonTextBox1.Text;
            my.password = dungeonTextBox2.Text;
            server.send("login|" + my.username + "|" + my.password);
        }

        private void Login1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void dungeonLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.load_form(new Login2());
        }
    }
}
