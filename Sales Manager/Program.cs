using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;


namespace Sales_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain formMain = new FormMain();
            SingleInstanceApplication.Run(formMain, StartupHandler);
        }

        private static void StartupHandler(object sender, StartupNextInstanceEventArgs startupNextInstanceEventArgs)
        {
            startupNextInstanceEventArgs.BringToForeground = true;
        }


        private class SingleInstanceApplication : WindowsFormsApplicationBase
        {
            private SingleInstanceApplication()
            {
                IsSingleInstance = true;
            }

            public static void Run(Form form, StartupNextInstanceEventHandler startupHandler)
            {
                SingleInstanceApplication app = new SingleInstanceApplication { MainForm = form };
                app.StartupNextInstance += startupHandler;
                app.Run(Environment.GetCommandLineArgs());
            }
        }

    }
}
