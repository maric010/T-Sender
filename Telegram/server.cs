using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegram
{
    internal class server
    {
        internal static bool is_connected = false;
        internal static bool server_is_busy = false;
        internal static TcpClient client = new TcpClient();
        internal static NetworkStream stream = null;

        internal static int TCP_port = 8888;
        internal static string server_ip = "188.120.251.80";
        private static bool get_is_started;
        internal static void new_message(string message)
        {
            //Получение новых сообщений из сервера
            var sp = message.Replace("None","").Split("|");
            switch (sp[0])
            {
                case "login_success":
                    {
                        my.login = true;
                        my.firstname = sp[1];
                        my.lastname = sp[2];
                        my.email = sp[3];
                        my.balance = sp[4];
                        try
                        {
                            my.telegram_accounts = sp[5];
                        }
                        catch { }
                        try
                        {
                            my.mails = sp[6];
                        }
                        catch { }

                        my.phone = sp[7];
                        my.tarif = sp[8];
                        Login.th.Invoke(new MethodInvoker(() =>
                        {
                            Login.th.Close();
                        }));
                        break;
                    }
                case "refresh_mails":
                    sp = sp[1].Split(";");
                    for (int i = 0; i < sp.Length; i++)
                    {
                        var sp2 = sp[i].Split("/");
                        foreach(Mail m in my.Mails)
                        {
                            if (m.id == sp2[0])
                            {
                                m.status = sp2[1];
                                m.users_count = sp2[2];
                                m.start_date = sp2[3];
                                m.stop_date = sp2[4];
                                m.accounts_count = sp2[5];
                                m.success_count = sp2[6];
                                m.failed_count = sp2[7];
                            }
                        }
                        

                    }
                    break;
                case "login_code":
                    {
                        my.login = true;
                        my.firstname = sp[1];
                        my.lastname = sp[2];
                        my.email = sp[3];
                        my.balance = sp[4];
                        try
                        {
                            my.telegram_accounts = sp[5];
                        }
                        catch { }
                        try
                        {
                            my.mails = sp[6];
                        }
                        catch { }

                        my.phone = sp[7];
                        my.tarif = sp[8];
                        Login.load_form(new Login4());
                        break;
                    }
                case "email_code_sended":
                    MessageBox.Show("Код вышлен на почту");
                    Login.load_form(new Login3());
                    return;
                case "email_is_invalid":
                    MessageBox.Show("Указанный email не существует!");
                    return;
                case "status_of_account":
                    for(int i = 0; i < my.accounts.Count; i++)
                    {
                        if(my.accounts[i].phone == sp[1])
                        {
                            my.accounts[i].status = sp[2];
                            my.accounts[i].last_used = sp[3].Split(".")[0];
                            //MessageBox.Show("");
                            if (Accounts.th != null)
                            {
                                Accounts.th.Invoke(new MethodInvoker(() =>
                                {
                                    for (int j = 0; j < Accounts.th.flowLayoutPanel1.Controls.Count; j++)
                                    {
                                        ((Grid_Accounts)Accounts.th.flowLayoutPanel1.Controls[j]).set_account(j + 1);
                                    }
                                }));
                            }
                            break;
                        }
                        
                    }
                    break;
                case "code_error":
                    MessageBox.Show("Неверный код");
                    break;
                case "login_failed":
                    if (sp[1] == "password_is_wrong")
                        MessageBox.Show("Пароль введен неправильно");
                    else if(sp[1]== "username_is_not_found")
                        MessageBox.Show("Имя пользователя не существует");
                    break;
                case "account_added_successfully":
                    T_ACCOUNT new_account = new T_ACCOUNT();
                    new_account.phone = sp[1];
                    new_account.first_name = sp[2];
                    new_account.last_name = sp[3];
                    new_account.username = sp[4];
                    new_account.last_used = "";
                    new_account.status = "ready";
                    my.accounts.Add(new_account);
                    if (Accounts.th != null)
                    {
                        Accounts.th.Invoke(new MethodInvoker(() =>
                        {
                            Grid_Accounts acc = new Grid_Accounts();
                            acc.acc = new_account;
                            acc.set_account(my.accounts.Count + 1);
                            Accounts.th.flowLayoutPanel1.Controls.Add(acc);
                            
                        }));
                    }
                    break;
                case "account_deleted":
                    for (int i = 0; i < my.accounts.Count; i++)
                    {
                        if (my.accounts[i].phone == sp[1])
                        {
                            
                            if (Accounts.th != null)
                            {
                                Accounts.th.Invoke(new MethodInvoker(() =>
                                {
                                    
                                    for (int j = 0; j < Accounts.th.flowLayoutPanel1.Controls.Count; j++)
                                    {
                                        if (((Grid_Accounts)Accounts.th.flowLayoutPanel1.Controls[j]).acc.phone == sp[1])
                                        {
                                            Accounts.th.flowLayoutPanel1.Controls.RemoveAt(j);
                                            break;
                                        }
                                    }
                                    
                                }));
                            }
                            my.accounts.Remove(my.accounts[i]);
                            break;
                        }
                    }
                    MessageBox.Show("Аккаунт успешно удален");
                    break;
                case "enter_password":
                    if(Accounts.th!=null)
                        Accounts.th.Invoke(new MethodInvoker(() =>
                        {
                            Accounts.th.dungeonButtonLeft3.Visible = true;
                            Accounts.th.dreamTextBox3.Visible = true;
                        }));
                    
                    break;
                case "code_sended":
                    if (Accounts.th != null)
                        Accounts.th.Invoke(new MethodInvoker(() =>
                        {
                            Accounts.th.dreamTextBox2.Visible = true;
                            Accounts.th.dungeonButtonLeft2.Visible = true;
                        }));
                    break;
                case "new_mail_success":
                    Mail mail = new Mail();
                    mail.id = sp[1];
                    mail.users_count = sp[2];
                    mail.accounts_count = sp[3];
                    my.Mails.Add(mail);
                    MessageBox.Show("Рассылка успешно создана");
                    break;
                case "mail":
                    for(int i = 0; i < my.Mails.Count; i++)
                    {
                        if(my.Mails[i].id == sp[1])
                        {
                            my.Mails[i].success_count = sp[2];
                            my.Mails[i].failed_count = sp[3];
                            my.Mails[i].status = sp[4];
                            break;
                        }
                    }
                    break;

                case "new_mail_fail":
                    MessageBox.Show("Не удалось создать рассылку: " + sp[1]);
                    break;
                case "info":
                    MessageBox.Show(sp[1]);
                    break;
                case "file":
                    try
                    {
                        using (var output = File.Create(my.save_file_path))
                        {
                            var buffer = new byte[1024];
                            int bytesRead;
                            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                output.Write(buffer, 0, bytesRead);
                            }
                        }   
                    }
                    catch (SocketException e)
                    {
                        Console.WriteLine("SocketException: {0}", e);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: {0}", e.Message);
                    }
                    break;

            }
        }
        internal static string send(string message)
        {
            //функция получает строку и добавляет конец строки и
            //преобразовывает его в массив байтов и отправит его серверу
            while (true)
            {
                try
                {
                    byte[] data = Encoding.UTF8.GetBytes(message + "\n");
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }
            }
            return "ok";
        }
        internal static string send_bytes(byte[] data)
        {
            //Функция принимает массив байтов и отправляет серверу
            while (true)
            {
                try
                {
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }
            }
            return "ok";
        }

        internal static void get()
        {
            get_is_started = true;
            int ii = 0;
            StreamReader streamReader = new StreamReader(stream);
            //Пока есть подключение получаем ответы от сервера
            //и каждые х секунд отправляем обновить рассылки
            while (is_connected)
            {
                try
                {
                    ii++;
                    if (my.login && ii>4)
                        try
                        {
                            ii = 0;
                        byte[] data2 = Encoding.UTF8.GetBytes("refresh_mails\n");
                        stream.Write(data2, 0, data2.Length);
                        stream.Flush();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connect();
                        continue;
                    }
                    
                    string st = streamReader.ReadLine();
                    
                    if (st != null)
                    {
                        new_message(st);
                    }
                    else
                    {
                        connect();
                    }
                }
                catch(Exception e) { streamReader = new StreamReader(stream); };
                Thread.Sleep(1000);
            }
            get_is_started = false;
        }
      
    
        internal static async void refreshAsync()
        {
            if(my.login)
                send("login|" + my.username + "|" + my.password);
        }

        internal static void connect()
        {
            /*
             * Закроет соеденение с сервером и создает новое соеденение
             */
            while (true)
            {
                try
                {
                    try
                    {
                        if (client != null)
                            client.Close();


                    }
                    catch { }
                    try
                    {
                        if (stream != null)
                            stream.Close();
                    }
                    catch { }
                    client = new TcpClient();
                    client.ReceiveTimeout = 5000;
                    client.SendTimeout = 5000;
                    client.Connect(server_ip, TCP_port);
                    stream = client.GetStream();
                    break;
                }
                catch
                {
                    Thread.Sleep(1000);
                }
            }
            is_connected = true;
            //Если поток получения новых сообщений не запущен то запускает
            if (!get_is_started)
            {
                Thread myThread = new Thread(get);
                myThread.Start();
            }
            
            refreshAsync();



        }
        internal static void close()
        {
            send("c");
            is_connected = false;
            if (client != null)
                client.Close();
            if (stream != null)
                stream.Close();
        }

    }
}
