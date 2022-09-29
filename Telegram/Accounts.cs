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
    public partial class Accounts : Form
    {
        internal static Accounts th;
        public Accounts()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            headerLabel1.Text = "Аккаунтов: " + my.accounts.Count + " из " + my.accounts_count;

            hopeProgressBar1.ValueNumber = (my.accounts.Count * 100) / my.accounts_count;
            hopeProgressBar1.Text = hopeProgressBar1.ValueNumber + "%";
            /*
             * Заполняем таблицу аккаунтами
             */
            for (int i=0;i<my.accounts.Count;i++)
            {
                T_ACCOUNT account = my.accounts[i];
                Grid_Accounts acc = new Grid_Accounts();
                acc.acc= account;
                acc.set_account(i+1);
                flowLayoutPanel1.Controls.Add(acc);
            }
            th = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Войти в аккаунт телеграм используя код
            server.send("sign_in|" + dreamTextBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Войти в аккаунт с паролем
            server.send("sign_in_with_password|" + dreamTextBox3.Text);
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X, tPanel1.Location.Y + tPanel1.Height+20);
            tPanel1.Width = flowLayoutPanel1.Width+10;
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            var height = 10;
            height += (flowLayoutPanel1.Controls.Count+1) * 40;

            tPanel1.Height = height + 60;
            flowLayoutPanel1.Height = height;
        }

        private void hopeProgressBar1_TextChanged(object sender, EventArgs e)
        {
            headerLabel9.Text = hopeProgressBar1.Text;
        }

        private void bigLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void headerLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dungeonHeaderLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dungeonLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dungeonHeaderLabel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dungeonHeaderLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dungeonHeaderLabel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dreamTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dreamTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
