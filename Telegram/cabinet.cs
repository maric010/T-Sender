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
    public partial class cabinet : Form
    {
        public cabinet()
        {
            InitializeComponent();
            hopeTextBox4.Text = my.firstname;
            if(my.lastname!=null)
                hopeTextBox3.Text = my.lastname;
            hopeTextBox5.Text = my.phone;
        }

        private void dungeonButtonLeft2_Click(object sender, EventArgs e)
        {
            server.send("change_info|" + hopeTextBox4.Text + "|" + hopeTextBox3.Text + "|" + hopeTextBox5.Text);
            MessageBox.Show("Данные успешно сохранены");
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            string passwd = hopeTextBox1.Text;
            if (hopeTextBox1.Text == hopeTextBox2.Text)
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
            
                server.send("change_password|" + hopeTextBox1.Text);
                MessageBox.Show("Пароль успешно изменен");
            
        }

        private void dungeonHeaderLabel2_Paint(object sender, PaintEventArgs e)
        {
            dungeonHeaderLabel2.Font = new Font(my.montserrat_regular, dungeonHeaderLabel2.Font.Size);
        }

        private void dungeonHeaderLabel1_Paint(object sender, PaintEventArgs e)
        {
            dungeonHeaderLabel1.Font = new Font(my.montserrat_regular, dungeonHeaderLabel1.Font.Size);
        }
    }
}
