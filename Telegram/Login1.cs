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
        void login()
        {
            //делает запрос к серверу передавая данные для авторизации
            my.username = loginTextBox1.Text;
            my.password = loginTextBox2.Text;
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

        private void dungeonTextBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dungeonTextBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("leave");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("enter");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("leave");
        }

        private void loginTextBox1_Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ActiveControl = loginTextBox1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ActiveControl = loginTextBox2;
        }

        private void loginTextBox1_Leave(object sender, EventArgs e)
        {
            label1.Visible = loginTextBox1.Text == "";

        }

        private void loginTextBox2_Enter(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void loginTextBox2_Leave(object sender, EventArgs e)
        {
            label2.Visible = loginTextBox2.Text != "";
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            login();
        }
        
    }
}
