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
    public partial class Login : Form
    {
        internal static Login th;
        public Login()
        {
            InitializeComponent();
        }
        internal static void load_form(Form f)
        {
            // Функция которая меняет формы внутри формы авторизации
            Login.th.Invoke(new MethodInvoker(() =>
            {
                th.panel1.Controls.Clear();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                th.panel1.Controls.Add(f);
                th.panel1.Tag = f;
                f.Show();

            }));
            
        }

        
        private async void Login_Load(object sender, EventArgs e)
        {
            th = this;
            load_form(new Login1());
        }

    }
}
