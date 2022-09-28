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
        public Login2()
        {
            InitializeComponent();
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

        }

        private void dungeonLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
             * Вернемся назад к авторизации
             */
            Login.load_form(new Login1());
        }

        private void dungeonLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dungeonLinkLabel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
