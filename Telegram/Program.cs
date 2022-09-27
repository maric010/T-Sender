using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Telegram
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Соеденимся к серверу
            server.connect();
            //Откроем форму авторизации
            Application.Run(new Login());
            //Если пользователь авторизовался. запускаем основную форму
            if(my.login)
                Application.Run(new Form1());
            //После завершения основной формы отключаемся от сервера
            server.close();
            server.is_connected = false;

        }
    }
}