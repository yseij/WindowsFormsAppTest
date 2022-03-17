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
            Home home = new Home();
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["testTijd"]));

            var timer = new System.Threading.Timer((e) =>
            {
                home.routeTest();
            }, null, startTimeSpan, periodTimeSpan);

            Application.Run(home);
        }
    }
}
