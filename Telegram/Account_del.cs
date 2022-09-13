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
    public partial class Account_del : Form
    {
        bool del=true;
        string phone = "";
        public Account_del(string ph)
        {
            phone = ph;
            
            InitializeComponent();
            my_Form1.Text += " " + ph;
        }

        private void my_Form1_Click(object sender, EventArgs e)
        {

        }

        private async void Account_del_Load(object sender, EventArgs e)
        {
            

        }

        private void lostCancelButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
