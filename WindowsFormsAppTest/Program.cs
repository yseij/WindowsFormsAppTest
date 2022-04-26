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

            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue400, Primary.Blue500,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE
            //);

            //if (Properties.Settings.Default.ServerNaam == "///")
            //{
            //    var m = new ServerEnDbForm();
            //    m.ShowDialog();
            //}
            //CreateDatabase createDatabase = new CreateDatabase();
            //bool IsDb = createDatabase.MakeDb(false);
            //ConfigurationManager.AppSettings["connectieString"] = @"data source=" + Properties.Settings.Default.ServerNaam + "; Initial Catalog=KraanTestTool; Integrated Security=True";
            //if (IsDb)
            //{
            //    Home home = new Home();
            //    home.HomeTest();
            //    Application.Run(home);
            //}


            KrXml _krXml = new KrXml();
            _krXml.MakeXmlFile("D://db.xml");
            UrlData urlData = new UrlData();
            urlData.Name = "test";
            urlData.SecurityId = "test";
            urlData.HttpDataId = 1;
            _krXml.AddUrl("D://db.xml", urlData);
            Application.Exit();
        }
    }
}
