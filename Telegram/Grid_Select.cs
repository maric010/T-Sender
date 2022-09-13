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
    public partial class Grid_Select : UserControl
    {
        internal T_ACCOUNT account;
        public Grid_Select()
        {
            InitializeComponent();
        }
        public void init_account()
        {
            dungeonLabel1.Text = "@"+account.username;
            dungeonLabel2.Text = "+"+account.phone;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        internal bool isChecked = false;
        private void hopeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = hopeRadioButton1.Checked;
            if (isChecked)
            {
                dungeonLabel1.Font = new Font(dungeonLabel1.Font, FontStyle.Bold);
                dungeonLabel2.Font = new Font(dungeonLabel2.Font, FontStyle.Bold);
            }
            else
            {
                dungeonLabel1.Font = new Font(dungeonLabel1.Font, FontStyle.Regular);
                dungeonLabel2.Font = new Font(dungeonLabel2.Font, FontStyle.Regular);
            }
        }

        private void hopeRadioButton1_Click(object sender, EventArgs e)
        {
            if (hopeRadioButton1.Checked && !isChecked)
                hopeRadioButton1.Checked = false;
            else
            {
                hopeRadioButton1.Checked = true;
                isChecked = false;
            }
        }
    }
}
