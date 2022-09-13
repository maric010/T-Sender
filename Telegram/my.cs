using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    internal class my
    {
        //Здесь хранятся глобальные переменные
        internal static string save_file_path;
        internal static string получатели_файл_имя { get; set; }
        internal static bool login { get; set; }
        internal static bool type_message { get; set; } = true;
        internal static string username { get; set; }
        internal static string password { get; set; }
        internal static string balance { get; set; }

        internal static string phone { get; set; }
        internal static string tarif { get; set; }
        internal static int accounts_count = 10;
        internal static string tarif_time { get; set; }

        internal static string lang { get; set; }
        internal static string firstname { get; set; }
        internal static string lastname { get; set; }
        internal static List<T_ACCOUNT> accounts = new List<T_ACCOUNT>();
        internal static List<Mail> Mails = new List<Mail>();
        internal static string email { get; set; }
        internal static string telegram_accounts
        {
            get { return _telegram_accounts; }
            set
            {
                //Если изменилась переменная telegram_accounts, то обрабатываем её, добавив все телеграм аккаунты в массив аккаунтов
                _telegram_accounts = value;
                accounts.Clear();
                var sp = _telegram_accounts.Split(";");
                for(int i=0;i<sp.Length; i++)
                {
                    var sp2  =sp[i].Split("/");
                    T_ACCOUNT t_account = new T_ACCOUNT();
                    t_account.phone = sp2[0];
                    t_account.username = sp2[1];
                    t_account.first_name = sp2[2];
                    t_account.last_name = sp2[3];
                    t_account.status = sp2[4];
                    t_account.last_used = sp2[5];
                    accounts.Add(t_account);
                }
            }
        }
        private static string _telegram_accounts { get; set; }
        
        internal static string mails
        {
            get { return _mails; }
            set
            {
                //Если изменилась переменная mails, то обрабатываем её, добавив все телеграм рассылки в массив рассылок
                _mails = value;
                Mails.Clear();
                var sp = _mails.Split(";");
                for (int i = 0; i < sp.Length; i++)
                {
                    var sp2 = sp[i].Split("/");
                    Mail mail = new Mail();
                    mail.id = sp2[0];
                    mail.status = sp2[1];
                    mail.users_count = sp2[2];
                    mail.start_date = sp2[3];
                    mail.stop_date = sp2[4];
                    mail.accounts_count = sp2[5];
                    mail.success_count = sp2[6];
                    mail.failed_count = sp2[7];

                    Mails.Add(mail);
                }
            }
        }
        private static string _mails;
        internal static string получатели { get; set; }
        internal static string получатели_файл { get; set; }
        internal static int получатели_количество { get; set; }
        internal static int media { get; set; }
        internal static bool is_text { get; set; } = true;

        internal static string получатели_текст { get; set; }
        internal static FontFamily montserrat_bold, montserrat_regular;
        internal static void init_fonts()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            PrivateFontCollection pfc2 = new PrivateFontCollection();
            //Выбираем шрифты из ресурсов
            int fontLength = Properties.Resources.Montserrat_Bold.Length;
            int fontLength2 = Properties.Resources.Montserrat_Regular.Length;
            byte[] fontdata = Properties.Resources.Montserrat_Bold;
            byte[] fontdata2 = Properties.Resources.Montserrat_Regular;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            System.IntPtr data2 = Marshal.AllocCoTaskMem(fontLength2);

            Marshal.Copy(fontdata, 0, data, fontLength);
            Marshal.Copy(fontdata2, 0, data2, fontLength2);

            pfc.AddMemoryFont(data, fontLength);
            pfc2.AddMemoryFont(data2, fontLength2);
            montserrat_bold = pfc.Families[0];
            montserrat_regular = pfc2.Families[0];
        }
    }

}
