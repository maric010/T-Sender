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
    public partial class Login2 : Form
    {
        internal static string email;
        internal static Login2 th;
        public Login2()
        {
            InitializeComponent();
            th = this;
        }
        bool IsValidEmail(string email)
        {
            /*
             * Проверяет является ли email валидным
             */
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            /*
             * Проверяем правильность email и отправляем серверу этот email
             * Сервер в свою очередь отправит код на указанный email
             */
            if (!IsValidEmail(dungeonTextBox1.Text))
            {
                MessageBox.Show("Указанный email не существует!");
            }
            email = dungeonTextBox1.Text;
            server.send("forget_password|" + dungeonTextBox1.Text);


        }

        private void dungeonLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
             * Вернемся назад к авторизации
             */
            Login.load_form(new Login1());
        }

        

        private void dungeonLinkLabel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
