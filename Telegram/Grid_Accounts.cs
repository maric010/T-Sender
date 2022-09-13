using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Telegram
{
    public partial class Grid_Accounts : UserControl
    {
        
        public Grid_Accounts()
        {
            InitializeComponent();
        }
        internal T_ACCOUNT acc;
        int i = 0;
        public void set_account(int j)
        {
            i = j;
            dungeonLabel1.Text = i.ToString();
            dungeonLabel2.Text = acc.phone;
            dungeonLabel3.Text = acc.username;
            dungeonLabel4.Text = acc.first_name+" "+acc.last_name;
            dungeonLabel6.Text = acc.last_used;
            dungeonLabel7.Text = acc.status;
            if(i % 2 ==1)
                BackColor = Color.LightGray;
            else
                BackColor = Color.White;
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            //Если нажали кнопку "Проверить состояние"
            server.send("check_status_of_account|" + acc.phone);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Accounts.th.Invoke(new MethodInvoker(() =>
                {
                    GridAccountDel g = new GridAccountDel(acc.phone,i);
                    Accounts.th.flowLayoutPanel1.Controls.RemoveAt(i - 1);
                    Accounts.th.flowLayoutPanel1.Controls.Add(g);

                    Accounts.th.flowLayoutPanel1.Controls.SetChildIndex(g,i - 1);
                }));

        }

        private void Grid_Accounts_MouseHover(object sender, EventArgs e)
        {
            //BackColor = Color.Gray;
        }

        private void Grid_Accounts_MouseLeave(object sender, EventArgs e)
        {
            /*
            if (i % 2 == 1)
                BackColor = Color.LightGray;
            else
                BackColor = Color.White;
            */
        }
    }
}
