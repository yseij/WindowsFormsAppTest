using MaterialSkin;
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

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            KrXml _krXml = new KrXml();
            _krXml.MakeXmlFile(@"D:\\db.xml");

            Home home = new Home();
            //home.HomeTest();
            Application.Run(home);
            Application.Exit();
        }
    }
}
