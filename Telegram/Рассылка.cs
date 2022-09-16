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
    public partial class Рассылка : Form
    {
        Mail mail;
        internal static Рассылка th;
        public Рассылка(string mail_id)
        {

            for(int i = 0; i < my.Mails.Count; i++)
            {
                if(my.Mails[i].id == mail_id)
                {
                    mail = my.Mails[i];
                    break;
                }
            }
            InitializeComponent();
        }

        private void my_Form1_Click(object sender, EventArgs e)
        {

        }

        private async void Рассылка_Load(object sender, EventArgs e)
        {
            th = this;
            Text += mail.id;
            dungeonLabel2.Text = mail.status;
            dataGridView1.Rows.Add("Количество получателей", mail.users_count);
            dataGridView1.Rows.Add("Дата начало", mail.start_date);
            dataGridView1.Rows.Add("Дата окончания", mail.stop_date);
            dataGridView1.Rows.Add("Количество аккаунтов",mail.accounts_count);
            dataGridView1.Rows.Add("Успешно отправлена",mail.success_count);
            dataGridView1.Rows.Add("Не удалось отправить",mail.failed_count);
            int sc = 0, fc = 0, uc = 1;
            if (mail.success_count != null)
                sc = Convert.ToInt32(mail.success_count);
            if (mail.failed_count != null)
                fc = Convert.ToInt32(mail.failed_count);
            if (uc != null)
                uc = Convert.ToInt32(mail.users_count);
            my_ProgressBar1.ValueNumber = ((100*(sc+ fc))/uc);
            while (mail.status != "finished" && stop==false)
            {
                server.send("mail|" + mail.id);
                await Task.Delay(1000);
                if(mail.status!= dungeonLabel2.Text)
                    dungeonLabel2.Text = mail.status;
                dataGridView1.Rows[4].Cells[1].Value = mail.success_count;
                dataGridView1.Rows[5].Cells[1].Value = mail.failed_count;
                if (mail.success_count != null)
                    sc = Convert.ToInt32(mail.success_count);
                if (mail.failed_count != null)
                    fc = Convert.ToInt32(mail.failed_count);
                if (uc != null)
                    uc = Convert.ToInt32(mail.users_count);
                my_ProgressBar1.ValueNumber = ((100 * (sc + fc)) / uc);
                await Task.Delay(1000);

            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
           
            // Открывает диалоговое окно для сохранения файла результата рассылки
            saveFileDialog1.FileName = mail.id + "_result.xlsx";
            saveFileDialog1.Filter = "Xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                my.save_file_path = saveFileDialog1.FileName;
                server.send("mail_file|" + mail.id);
            }
        }
        bool stop=false;
        private void Рассылка_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop = true;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {

        }

        private void dungeonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dungeonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void my_ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
