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
    public partial class Login4 : Form
    {
        public Login4()
        {
            InitializeComponent();
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            /*
             * Кнопка которая проверяет новый пароль на правильность и отправляет 
             * серверу сообщение об изменение пароля и после завершает форму авторизации
             * 
             */
            string passwd = dungeonTextBox1.Text;
            if (dungeonTextBox1.Text != dungeonTextBox2.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            if (passwd.Length < 8 || passwd.Length > 14)
            {
                MessageBox.Show("Длина пароля должен состоять из 8 до 14 символов");
                return;
            }
            if (passwd.Contains(" "))
            {
                MessageBox.Show("Пароль не должен содержать пробелы!");
                return;
            }
            string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialChArray = specialCh.ToCharArray();
            foreach (char ch in specialChArray)
            {
                if (passwd.Contains(ch))
                {
                    MessageBox.Show("Пароль не должен содержать символы!");
                    return;
                }
            }
            server.send("change_password|" + dungeonTextBox1.Text);
                MessageBox.Show("Пароль успешно изменен");
            //Закрываем форму авторизации
                Login.th.Invoke(new Action(() =>
                {
                    Login.th.Close();
                }));
            
        }
    }
}
