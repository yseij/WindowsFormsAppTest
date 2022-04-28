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

            //Configure color schema
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
            _krXml.MakeXmlFile(@"D:\\db.xml");
            Klant klant = new Klant("klant 4", "https://test4.be", "test4");
            _krXml.AddKlant(klant);
            WebService webService = new WebService("KraanSales", false);
            _krXml.AddWebservice(webService);
            KlantWebservice klantWebservice = new KlantWebservice(klant.Id, webService.Id, true, false);
            _krXml.AddKlantWebservice(klantWebservice);
            Application.Exit();
        }
    }
}
