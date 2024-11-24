using System;
using System.Windows;

namespace WPFApplication
{
    public class MainAppConfig : Application
    {
        [STAThread]
        public static void Main()
        {
            MainAppConfig app = new MainAppConfig();
            var mainWindow = new MainWindow();

            app.Run(mainWindow);
        }
    }
}
