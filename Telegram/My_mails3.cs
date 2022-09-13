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
    public partial class My_mails3 : Form
    {
        public My_mails3()
        {
            InitializeComponent();
        }

        private void My_mails3_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < my.Mails.Count; i++)
            {
                Mail mail = my.Mails[i];
                dataGridView1.Rows.Add(mail.id,mail.status,mail.users_count,mail.accounts_count,mail.start_date,"Подробно");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //Если кликнута кнопка "Подробно", находит данную рассылку из массива рассылок и откроет диалоговое окно
                for(int i = 0; i < my.Mails.Count; i++)
                {
                    var mail = my.Mails[i];
                    if(mail.id == senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        Рассылка рассылка = new Рассылка(mail.id);
                        рассылка.ShowDialog();
                        break;
                    }
                    
                }
                

            }
        }
    }
}
