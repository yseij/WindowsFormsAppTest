using System;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
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
            CreateDatabase createDatabase = new CreateDatabase();
            bool IsDb = createDatabase.MakeDb(false);
            if (IsDb)
            {
                Home home = new Home();
                home.HomeTest();
                Application.Run(home);
            }
            Application.Exit();
        }
    }
}
