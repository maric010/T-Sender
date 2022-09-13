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
    public partial class GridAccountDel : UserControl
    {
        bool del = true;
        string phone = "";
        int i;
        public GridAccountDel(string ph,int j)
        {
            i = j;
            phone = ph;

            InitializeComponent();

            dungeonLabel2.Text += " " + ph;
            l();
        }

        private void dungeonLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            del = false;
        }
        async void l()
        {
            for (int i = 100; i > -1; i--)
            {
                if (!del)
                    break;
                circleProgressBar1.Value = i;
                await Task.Delay(50);
            }
            Accounts.th.Invoke(new MethodInvoker(() =>
            {
                Accounts.th.flowLayoutPanel1.Controls.RemoveAt(i - 1);
            }));
            if (del)
            {
                server.send("delete_account|" + phone);

                foreach(T_ACCOUNT acc in my.accounts)
                {
                    if (acc.phone == phone)
                    {

                        my.accounts.Remove(acc);
                        break;
                    }

                }
                
                for (int n = 0; n < Accounts.th.flowLayoutPanel1.Controls.Count; n++)
                {
                    Accounts.th.Invoke(new MethodInvoker(() =>
                    {
                        ((Grid_Accounts)Accounts.th.flowLayoutPanel1.Controls[n]).set_account(n + 1);
                    }));
                }
            }
            else
            {
                Accounts.th.Invoke(new MethodInvoker(() =>
                {
                    Grid_Accounts g = new Grid_Accounts();
                    foreach(var acc in my.accounts)
                    {
                        if(acc.phone==phone)
                        {
                            g.acc = acc;
                            break;
                        }
                    }
                    g.set_account(i);
                    Accounts.th.flowLayoutPanel1.Controls.Add(g);
                    Accounts.th.flowLayoutPanel1.Controls.SetChildIndex(g,i-1);
                }));
            }
        }

        private void circleProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
