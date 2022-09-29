using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegram
{
    public partial class Login1 : Form
    {
        internal static Login1 th;
        internal static bool password_is_wrong = false;
        public Login1()
        {
            InitializeComponent();
            th = this;
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
            check();
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void dungeonLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.load_form(new Login2());
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
            label2.Visible = loginTextBox2.Text == "";
        }
        internal static void check(string text="")
        {
            Login1.th.Invoke(new Action(() =>
            {
                if (text == "")
                {
                    Login1.th.loginTextBox1.BorderColor = Color.FromArgb(60, 161, 210);
                    Login1.th.loginTextBox2.BorderColor = Color.FromArgb(60, 161, 210);
                    Login1.th.label3.Visible = false;
                    Login1.th.dungeonLinkLabel1.Location = new Point(Login1.th.dungeonLinkLabel1.Location.X, 300);
                    Login1.th.foreverButton1.Location = new Point(Login1.th.foreverButton1.Location.X, 330);
                }
                else
                {
                    Login1.th.label3.Text = text;
                    Login1.th.label3.Visible = true;
                    Login1.th.dungeonLinkLabel1.Location = new Point(Login1.th.dungeonLinkLabel1.Location.X, 325);
                    Login1.th.foreverButton1.Location = new Point(Login1.th.foreverButton1.Location.X, 355);
                    if(text== "Пароль введен неправильно")
                    {
                        Login1.th.loginTextBox2.BorderColor = Color.Red;
                    }
                    else
                    {
                        Login1.th.loginTextBox1.BorderColor = Color.Red;
                        Login1.th.loginTextBox2.BorderColor = Color.Red;
                    }
                }
            }));
            
        }
        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void Login1_Load(object sender, EventArgs e)
        {

        }

        private void loginTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dungeonLinkLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

      

        private void loginTextBox2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
