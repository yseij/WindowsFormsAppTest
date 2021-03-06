using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Home : MaterialForm
    {
        private string _klantKeuzeNaam;
        private string _keuzeNaam;
        private string _text = string.Empty;
        private string _https = "https:";
        private string _http = "http:";

        private Guid _klantKeuzeId;

        private bool _isSoap = false;

        private dynamic _result;

        private int _teller;

        string[] kraan2Webservices = { "AuthService.svc",
                                      "CrmService.svc",
                                      "WorkflowService.svc",
                                      "MaterieelService.svc",
                                      "MaterieelbeheerService.svc",
                                      "UrenService.svc" };

        string[] kraanSalesService = { "MessageServiceSoap.svc",
                                       "MessageServiceSoap31.svc"};

        private List<Klant> _klantDatas = new List<Klant>();

        WebRequest _webRequest;
        KrXml _krXml;

        UrlXml _urlXml;
        WebserviceXml _webserviceXml;
        KlantXml _klantXml;
        KlantWebserviceXml _klantWebserviceXml;

        Timer _MyTimer = new Timer();
        LogFile _logFile = new LogFile();

        public Home()
        {
            InitializeComponent();
            _webRequest = new WebRequest();
            _krXml = new KrXml();
            _urlXml = new UrlXml();
            _webserviceXml = new WebserviceXml();
            _klantXml = new KlantXml();
            _klantWebserviceXml = new KlantWebserviceXml();

            menuStrip.ForeColor = Color.FromArgb(0, 0, 0);

            ToolStripMenuItem1.Enabled = false;
            Properties.Settings.Default.StartUpPathDb = Path.Combine(Application.StartupPath, "db.xml");

            _krXml.SetDbXml();
            _krXml.MakeXmlFileUser();
            //_krXml.MakeXmlFileDb();

            FillKlantenDropDown();

            GetSettings();

            TijdCheck();
            TijdCheckService();
            AanOfUitCheck();
            AanOfUitCheckService();
        }

        private void GetSettings()
        {
            bool isChecked = false;
            ConfigurationManager.AppSettings["Tijd"] = Properties.Settings.Default.Tijd;
            ConfigurationManager.AppSettings["TestAanOfUit"] = Properties.Settings.Default.TestAanOfUit;
            ConfigurationManager.AppSettings["SaveLogFilePlace"] = Properties.Settings.Default.SaveLogFilePlace;
            ConfigurationManager.AppSettings["TijdService"] = Properties.Settings.Default.TijdService;
            ConfigurationManager.AppSettings["ServiceAanOfUit"] = Properties.Settings.Default.ServiceAanOfUit;

            Guid klantKeuze = Properties.Settings.Default.KlantKeuze;
            if (klantKeuze != Guid.Empty)
            {
                ToolStripMenuItem1.Enabled = true;
                foreach (ToolStripMenuItem toolStripMenuItem in KlantKeuzeToolStripMenuItem.DropDownItems)
                {
                    if ((Guid)toolStripMenuItem.Tag == klantKeuze)
                    {
                        toolStripMenuItem.Checked = true;
                        _klantKeuzeId = (Guid)toolStripMenuItem.Tag;
                        _klantKeuzeNaam = toolStripMenuItem.Text;
                        isChecked = true;
                    }
                    else
                    {
                        toolStripMenuItem.Checked = false;
                    }
                }
            }
            if (!isChecked)
            {
                AanToolStripMenuItem.Checked = false;
                UitToolStripMenuItem.Checked = true;
                ConfigurationManager.AppSettings["TestAanOfUit"] = "uit";
            }
            ToolStripMenuItem1.Enabled = _klantKeuzeId != Guid.Empty && Properties.Settings.Default.Email != "";

            CheckEmail();
        }

        private void BttnUrl_Click(object sender, EventArgs e)
        {
            var m = new EenUrlTestForm();
            m.TopMost = false;
            m.ShowDialog();
        }

        private void BttnWebservice_Click(object sender, EventArgs e)
        {
            var m = new WebserviceOfKlantForm(false);
            m.TopMost = false;
            m.ShowDialog();
        }

        private void BtnKlant_Click(object sender, EventArgs e)
        {
            var m = new WebserviceOfKlantForm(true);
            m.TopMost = false;
            m.ShowDialog();
        }

        private void BtnShowWebservices_Click(object sender, EventArgs e)
        {
            var m = new AllWebserviceForm();
            m.TopMost = false;
            m.ShowDialog();
        }

        private void BtnShowKlanten_Click(object sender, EventArgs e)
        {
            var m = new AllKlantenForm();
            m.TopMost = false;
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingSetShowKlanten);
            m.ShowDialog();
        }

        private void ChildFormClosingSetShowKlanten(object sender, FormClosingEventArgs e)
        {
            FillKlantenDropDown();
        }

        private void BtnShowUrlsPerKlant_Click(object sender, EventArgs e)
        {
            var m = new AllUrlPerKlantForm();
            m.TopMost = false;
            m.ShowDialog();
        }

        private void ChildFormClosingSetEmail(object sender, FormClosingEventArgs e)
        {
            ToolStripMenuItem1.Enabled = _klantKeuzeId != Guid.Empty && Properties.Settings.Default.Email != "";
            CheckEmail();
        }

        private void serverInstellenTlStrpMnItm_Click(object sender, EventArgs e)
        {
            var m = new MailServerForm();
            m.TopMost = false;
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingSetMailServer);
            m.ShowDialog();
        }

        private void ChildFormClosingSetMailServer(object sender, FormClosingEventArgs e)
        {
            CheckEmail();
        }

        private void eigenEmailTlStrpMnItm_Click(object sender, EventArgs e)
        {
            var m = new UserForm();
            m.TopMost = false;
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingSetEmail);
            m.ShowDialog();
        }

        private void PlaatsOpslaanLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";
            fbd.SelectedPath = Properties.Settings.Default.SaveLogFilePlace;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = fbd.SelectedPath;
                ZetConfEnProp("SaveLogFilePlace", SelectedPath);
            }
        }

        private void MinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("Tijd", "15000");
            TijdCheck();
        }

        private void MinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("Tijd", "30000");
            TijdCheck();
        }

        private void MinToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("Tijd", "60000");
            TijdCheck();
        }

        private void uurTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("Tijd", "3600000");
            TijdCheck();
        }

        private void AanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("TestAanOfUit", "aan");
            AanOfUitCheck();
        }

        private void UitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("TestAanOfUit", "uit");
            AanOfUitCheck();
        }

        private void min15ByServiceTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("TijdService", "15000");
            TijdCheckService();
            _krXml.UpdateXmlFile();
        }

        private void min30ByServiceTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("TijdService", "30000");
            TijdCheckService();
            _krXml.UpdateXmlFile();
        }

        private void min60ByServiceTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("TijdService", "60000");
            TijdCheckService();
            _krXml.UpdateXmlFile();
        }

        private void AanByServiceTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("ServiceAanOfUit", "aan");
            AanOfUitCheckService();
            _krXml.UpdateXmlFile();
        }

        private void UitByServiceTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("ServiceAanOfUit", "uit");
            AanOfUitCheckService();
            _krXml.UpdateXmlFile();
        }

        private void ZetConfEnProp(string name, string waarde)
        {
            ConfigurationManager.AppSettings[name] = waarde;
            Properties.Settings.Default[name] = waarde;
            Properties.Settings.Default.Save();
        }

        private void PlaatsOpslaanLogFileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            plaatsOpslaanLogFileToolStripMenuItem.ToolTipText = ConfigurationManager.AppSettings["SaveLogFilePlace"];
        }

        private void TijdCheck()
        {
            _MyTimer.Stop();
            switch (ConfigurationManager.AppSettings["Tijd"])
            {
                case "15000":
                    MinToolStripMenuItem.Checked = true;
                    MinToolStripMenuItem1.Checked = false;
                    MinToolStripMenuItem2.Checked = false;
                    UurTlStrpMnItm.Checked = false;
                    _MyTimer.Interval = 15000;
                    break;
                case "30000":
                    MinToolStripMenuItem.Checked = false;
                    MinToolStripMenuItem1.Checked = true;
                    MinToolStripMenuItem2.Checked = false;
                    UurTlStrpMnItm.Checked = false;
                    _MyTimer.Interval = 30000;
                    break;
                case "60000":
                    MinToolStripMenuItem.Checked = false;
                    MinToolStripMenuItem1.Checked = false;
                    MinToolStripMenuItem2.Checked = true;
                    UurTlStrpMnItm.Checked = false;
                    _MyTimer.Interval = 60000;
                    break;
                case "3600000":
                    MinToolStripMenuItem.Checked = false;
                    MinToolStripMenuItem1.Checked = false;
                    MinToolStripMenuItem2.Checked = false;
                    UurTlStrpMnItm.Checked = true;
                    _MyTimer.Interval = 3600000;
                    break;
                default:
                    break;
            }
            _MyTimer.Start();
        }

        private void TijdCheckService()
        {
            switch (ConfigurationManager.AppSettings["TijdService"])
            {
                case "15000":
                    min15ByServiceTlStrpMnItm.Checked = true;
                    min30ByServiceTlStrpMnItm.Checked = false;
                    min60ByServiceTlStrpMnItm.Checked = false;
                    break;
                case "30000":
                    min15ByServiceTlStrpMnItm.Checked = false;
                    min30ByServiceTlStrpMnItm.Checked = true;
                    min60ByServiceTlStrpMnItm.Checked = false;
                    break;
                case "60000":
                    min15ByServiceTlStrpMnItm.Checked = false;
                    min30ByServiceTlStrpMnItm.Checked = false;
                    min60ByServiceTlStrpMnItm.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void AanOfUitCheck()
        {
            switch (ConfigurationManager.AppSettings["TestAanOfUit"])
            {
                case "aan":
                    AanToolStripMenuItem.Checked = true;
                    UitToolStripMenuItem.Checked = false;
                    break;
                case "uit":
                    AanToolStripMenuItem.Checked = false;
                    UitToolStripMenuItem.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void AanOfUitCheckService()
        {
            switch (ConfigurationManager.AppSettings["ServiceAanOfUit"])
            {
                case "aan":
                    AanByServiceTlStrpMnItm.Checked = true;
                    UitByServiceTlStrpMnItm.Checked = false;
                    break;
                case "uit":
                    AanByServiceTlStrpMnItm.Checked = false;
                    UitByServiceTlStrpMnItm.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void FillKlantenDropDown()
        {
            KlantKeuzeToolStripMenuItem.DropDownItems.Clear();
            _klantDatas = _klantXml.GetKlanten();
            foreach (Klant klantData in _klantDatas)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Tag = klantData.Id;
                item.Text = klantData.Name;
                KlantKeuzeToolStripMenuItem.DropDownItems.Add(item);

                item.Click += new EventHandler(ClickItemDropdownKlant);
            }
        }

        private void ClickItemDropdownKlant(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem toolStripMenuItem in KlantKeuzeToolStripMenuItem.DropDownItems)
            {
                toolStripMenuItem.Checked = false;
            }

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (_klantKeuzeId == (Guid)item.Tag)
            {
                _klantKeuzeId = Guid.Empty;
                ToolStripMenuItem1.Enabled = false;
            }
            else
            {
                _klantKeuzeId = (Guid)item.Tag;
                _klantKeuzeNaam = item.Text;
                item.Checked = true;

                if (Properties.Settings.Default.Email != "")
                {
                    ToolStripMenuItem1.Enabled = true;
                }
            }
            Properties.Settings.Default.KlantKeuze = _klantKeuzeId;
        }

        public void RouteTest()
        {
            if (ConfigurationManager.AppSettings["TestAanOfUit"] == "aan")
            {
                if (_klantKeuzeId != Guid.Empty)
                {
                    _keuzeNaam = _klantKeuzeNaam;
                }
                RouteTestAfterKeuze(_keuzeNaam, _klantKeuzeId);
            }
        }

        private void RouteTestAfterKeuze(string keuzeNaam, Guid klantKeuzeId)
        {
            _teller = 0;
            _text = string.Empty;
            _logFile = new LogFile();
            
            List<KlantWebservice> klantWebservices = _klantWebserviceXml.GetByKlant(klantKeuzeId);
            List<Url> urls = _urlXml.GetByKlantId(klantKeuzeId);
            if (klantWebservices.Count != 0 || urls.Count != 0)
            {
                _logFile.MakeLogFile(keuzeNaam);
                _text += keuzeNaam + Environment.NewLine + Environment.NewLine;
            }
            foreach (KlantWebservice klantWebservice in klantWebservices)
            {
                string basisUrl = string.Empty;
                Url url = new Url();
                Klant klant = _klantDatas.Find(k => k.Id == klantWebservice.Klant);
                WebService webService = FindWebservice(klantWebservice);
                if (klantWebservice.BasisUrl1 && klantWebservice.BasisUrl2)
                {
                    basisUrl = klant.BasisUrl1;
                    url.Name = basisUrl + webService.Name;
                    SoapOfRestTest(url, webService, klantWebservice);
                    basisUrl = klant.BasisUrl2;
                    url.Name = basisUrl + webService.Name;
                    SoapOfRestTest(url,  webService, klantWebservice);
                }
                else if (klantWebservice.BasisUrl1)
                {
                    basisUrl = klant.BasisUrl1;
                    url.Name = basisUrl + webService.Name;
                    SoapOfRestTest(url, webService, klantWebservice);
                }
                else
                {
                    basisUrl = klant.BasisUrl2;
                    url.Name = basisUrl + webService.Name;
                    SoapOfRestTest(url, webService, klantWebservice);
                }
            }
            foreach (Url url1 in urls)
            {
                KlantWebservice klantWebservice = _klantWebserviceXml.GetByKlantWebserviceId(url1.KlantWebserviceId);
                Klant klant = _klantDatas.Find(k => k.Id == klantWebservice.Klant);
                string basisUrl = FindBasisUrl(klantWebservice, klant);
                WebService webService = FindWebservice(klantWebservice);

                Url newUrl = new Url();
                newUrl.Id = url1.Id;
                newUrl.Name = basisUrl + webService.Name + "/" + url1.Name;
                newUrl.KlantId = klantKeuzeId;
                newUrl.KlantWebserviceId = klantWebservice.Id;
                GetUrl(newUrl);
            }
            if (_teller == 0)
            {
                _logFile.AddTextToLogFile("Er is niks fout gegaan tijdens de testen van de klant" + keuzeNaam + Environment.NewLine);
            }
            if (_text != "")
            {
                MailClient.SendMail(keuzeNaam, _text, _logFile.FilePath);
            }
        }

        private void SoapOfRestTest(Url url, WebService webService, KlantWebservice klantWebservice)
        {
            if (webService.Name == "KraanHomeDNA")
            {
                url.Name += "/HomeDna.svc";
                GetWebserviceVersion(url);
            }
            else if (webService.Name == "Kraan2Webservices")
            {
                UrlsTestKraan2Webservice(url, klantWebservice);
            }
            else if (webService.Name == "KraanSalesService")
            {
                UrlsTestKraanSalesService(url, klantWebservice);
            }
            else if (webService.Name == "KraanWerkbonWebservice")
            {
                url.Name += "/Webservice.svc";
                GetUrl(url);
            }
            else if (webService.Name == "KraanHandheld")
            {
                url.Name += "/HandheldService.svc/rest/GetVersion";
                GetUrl(url);
            }
            else if (!_isSoap)
            {
                CheckUrlAndGetWebserviceVersion(url);
            }
            else
            {
                GetResult(url, false);
            }
        }

        private void UrlsTestKraanSalesService(Url url, KlantWebservice klantWebservice)
        {
            for (int i = 0; i < kraanSalesService.Length; i++)
            {
                Url newUrl = new Url();
                newUrl.Name = url.Name + "/" + kraanSalesService[i];
                newUrl.KlantWebserviceId = klantWebservice.Id;
                GetUrl(newUrl);
            }
        }

        private void UrlsTestKraan2Webservice(Url url, KlantWebservice klantWebservice)
        {
            for (int i = 0; i < kraan2Webservices.Length; i++)
            {
                Url newUrl = new Url();
                newUrl.Name = url.Name + "/" + kraan2Webservices[i];
                GetUrl(newUrl);
                newUrl.Name = string.Empty;
            }
        }

        private string FindBasisUrl(KlantWebservice klantWebservice, Klant klant)
        {
            if (klantWebservice.BasisUrl1)
            {
                return klant.BasisUrl1;
            }
            else
            {
                return klant.BasisUrl2;
            }
        }

        private WebService FindWebservice(KlantWebservice klantWebservice)
        {
            List<WebService> webServices = _webserviceXml.GetAll();
            foreach (WebService webservice in webServices)
            {
                if (webservice.Id == klantWebservice.Webservice)
                {
                    _isSoap = webservice.Soap;
                    return webservice;
                }
            }
            return null;
        }

        private void CheckUrlAndGetWebserviceVersion(Url url)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    CheckUrl(url);
                }
                else
                {
                    Url url2 = new Url();
                    url2.Name = url.Name;
                    GetWebserviceVersion(url2);
                }
            }
        }

        private void CheckUrl(Url url)
        {
            string checkUrl = _webRequest.CheckUrl(url.Name);
            if (checkUrl != "true")
            {
                _teller++;
                _text += url.Name.Replace(_https, "").Replace(_http, "")  + "--> " + checkUrl + Environment.NewLine;
                _logFile.AddTextToLogFile(url.Name + " --> " + checkUrl + Environment.NewLine);
            }
        }

        private void GetWebserviceVersion(Url url)
        {
            url.Name += "/GetWebserviceVersion";
            GetResult(url, true);
            TestGetWebserviceVersion(url);
        }

        private void GetUrl(Url url)
        {
            GetResult(url, false);
            foreach (JProperty item in _result)
            {
                if (item.Name == "ex")
                {
                    _teller++;
                    _text += url.Name.Replace(_https, "").Replace(_http, "") + " --> " + item.Value.ToString() + Environment.NewLine;
                    _logFile.AddTextToLogFile(url.Name + " --> " + item.Value.ToString() + Environment.NewLine);
                    _logFile.AddTextToLogFile(Environment.NewLine);
                }
            }
        }

        private void TestGetWebserviceVersion(Url url)
        {
            foreach (JProperty item in _result)
            {
                if (item.Value.ToString().Contains("False") || item.Name.ToString() == "ex")
                {
                    _teller++;
                    _text += url.Name.Replace(_https, "").Replace(_http, "") + " --> " + item.Value.ToString() + Environment.NewLine;
                    _logFile.AddTextToLogFile(url.Name + " --> " + item.Value.ToString() + Environment.NewLine);
                    _logFile.AddTextToLogFile(Environment.NewLine);
                }
            }
        }

        private void GetResult(Url url, bool isGetWebserviceVersion)
        {
            if (_isSoap && url.Name.EndsWith(".svc"))
            {
                if (url.Name.Contains("MessageServiceSoap31.svc"))
                {
                    _result = JObject.Parse(@"{ ex: '" + "Deze service heeft een inlog nodig dus die moet je appart testen" + "'}");
                }
                else if (url.Name.Contains("MessageServiceSoap.svc"))
                {
                    _result = JObject.Parse(_webRequest.Get24SalesData(url.Name));
                }
                else
                {
                    int plaatsSlech = url.Name.LastIndexOf("/");
                    string service = url.Name.Substring(plaatsSlech + 1, url.Name.Length - plaatsSlech - 1);
                    string data = _webRequest.GetWebRequestSoap(url.Name, service);
                    _result = JObject.Parse(data);
                }
            }
            else
            {
                var data = _webRequest.GetWebRequestRest(url.Name,
                                                         isGetWebserviceVersion);
                _result = JObject.Parse(data);
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string sourcePath = Properties.Settings.Default.StartUpPathDb;
                string desPath = Properties.Settings.Default.PlaceSelfDb + "/db.xml";
                File.Copy(sourcePath, desPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Properties.Settings.Default.Save();
        }

        public void HomeTest()
        {
            _MyTimer.Interval = int.Parse(Properties.Settings.Default.Tijd);
            _MyTimer.Tick += new EventHandler(MyTimer_Tick);
            _MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            RouteTest();
        }

        private void CheckEmail()
        {
            if (Properties.Settings.Default.Email != "///" &&
                Properties.Settings.Default.MailServerNaam != "///" &&
                Properties.Settings.Default.MailServerPoort != 0 &&
                Properties.Settings.Default.MailVerzendenVanuitEmail != "///")
            {
                StripMenuItemTestTijd.Enabled = true;
                ServiceTlStrpMnItm.Enabled = true;
            }
            else
            {
                StripMenuItemTestTijd.Enabled = false;
                ServiceTlStrpMnItm.Enabled = false;
                ConfigurationManager.AppSettings["TestAanOfUit"] = "uit";
            }
        }

        private void plaatsOphalenDbxmlTlStrpMnItm_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";
            fbd.SelectedPath = Properties.Settings.Default.SaveDbPlace;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = fbd.SelectedPath;
                ZetConfEnProp("SaveDbPlace", SelectedPath);
                dbxmlLadenTlStrpMnItm.Enabled = true;
            }
        }

        private void dbxmlLadenTlStrpMnItm_Click(object sender, EventArgs e)
        {
            try
            {
                string desPath = Path.Combine(Application.StartupPath, "db.xml");
                string sourcePath = Properties.Settings.Default.SaveDbPlace + "/db.xml";
                File.Copy(sourcePath, desPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void plaatsOpslaanDbxmlTlStrpMnItm_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";
            fbd.SelectedPath = Properties.Settings.Default.PlaceSelfDb;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = fbd.SelectedPath;
                ZetConfEnProp("PlaceSelfDb", SelectedPath);
            }
        }
    }
}
