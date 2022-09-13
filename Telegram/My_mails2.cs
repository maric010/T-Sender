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
    public partial class My_mails2 : Form
    {
        public My_mails2()
        {
            InitializeComponent();
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            
        }

        private void dungeonButtonLeft1_Click_1(object sender, EventArgs e)
        {
            Form1.th.Invoke(new MethodInvoker(() =>
            {
                Form1.th.tButton6_Click(null, null);
            }));
        }
    }
}
