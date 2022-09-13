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
            //���������� ���� ������
            my.init_fonts();
            //���������� � �������
            server.connect();
            //������� ����� �����������
            Application.Run(new Login());
            //���� ������������ �������������. ��������� �������� �����
            if(my.login)
                Application.Run(new Form1());
            //����� ���������� �������� ����� ����������� �� �������
            server.close();
            server.is_connected = false;

        }
    }
}