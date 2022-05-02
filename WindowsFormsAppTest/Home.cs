using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Home : MaterialForm
    {
        private string _webserviceKeuzeNaam;
        private string _klantKeuzeNaam;
        private string _keuzeNaam;
        private string _httpName;
        private string _webserviceName;

        private int _httpKeuzeId;
        private int _webserviceKeuzeId;
        private int _klantKeuzeId;

        private bool _isSoap = false;

        private dynamic _result;

        private string _xmlUserName = @"D:\user.xml";
        private string _xmlDb = @"D:\db.xml";

        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<Klant> _klantDatas = new List<Klant>();
        private List<WebService> _webServiceDatas = new List<WebService>();
        private List<UrlData> _urlDatas = new List<UrlData>();

        HttpTest _httptest;
        KlantTest _klantTest;
        WebserviceTest _webserviceTest;
        WebRequest _webRequest;
        KrXml _krXml;

        WebserviceXml _webserviceXml;

        Timer _MyTimer = new Timer();

        public Home()
        {
            InitializeComponent();
            _httptest = new HttpTest();
            _klantTest = new KlantTest();
            _webserviceTest = new WebserviceTest();
            _webRequest = new WebRequest();
            _krXml = new KrXml();

            menuStrip.ForeColor = Color.FromArgb(0, 0, 0);

            ToolStripMenuItem1.Enabled = false;

            //FillKlantenDropDown();
            //FillWebserviceDropDown();

            GetSettings();

            TijdCheck();
            TijdCheckService();
            AanOfUitCheck();
            AanOfUitCheckService();

            _krXml.MakeXmlFile(_xmlDb);
        }

        private void GetSettings()
        {
            ConfigurationManager.AppSettings["Tijd"] = Properties.Settings.Default.Tijd;
            ConfigurationManager.AppSettings["TestAanOfUit"] = Properties.Settings.Default.TestAanOfUit;
            ConfigurationManager.AppSettings["SaveLogFilePlace"] = Properties.Settings.Default.SaveLogFilePlace;
            ConfigurationManager.AppSettings["TijdService"] = Properties.Settings.Default.TijdService;
            ConfigurationManager.AppSettings["ServiceAanOfUit"] = Properties.Settings.Default.ServiceAanOfUit;

            int klantKeuze = Properties.Settings.Default.KlantKeuze;
            if (klantKeuze != 0)
            {
                WebserviceKeuzeToolStripMenuItem.Enabled = false;
                ToolStripMenuItem1.Enabled = true;
                foreach (ToolStripMenuItem toolStripMenuItem in KlantKeuzeToolStripMenuItem.DropDownItems)
                {
                    if ((int)toolStripMenuItem.Tag == klantKeuze)
                    {
                        toolStripMenuItem.Checked = true;
                        _klantKeuzeId = (int)toolStripMenuItem.Tag;
                        _klantKeuzeNaam = toolStripMenuItem.Text;
                    }
                    else
                    {
                        toolStripMenuItem.Checked = false;
                    }
                }
            }

            int webserviceKeuze = Properties.Settings.Default.WebserviceKeuze;
            if (webserviceKeuze != 0)
            {
                ToolStripMenuItem1.Enabled = true;
                KlantKeuzeToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem toolStripMenuItem in WebserviceKeuzeToolStripMenuItem.DropDownItems)
                {
                    if ((int)toolStripMenuItem.Tag == webserviceKeuze)
                    {
                        toolStripMenuItem.Checked = true;
                        _webserviceKeuzeId = (int)toolStripMenuItem.Tag;
                        _webserviceKeuzeNaam = toolStripMenuItem.Text;
                    }
                    else
                    {
                        toolStripMenuItem.Checked = false;
                    }
                }
            }
            ToolStripMenuItem1.Enabled = (_klantKeuzeId != 0 || _webserviceKeuzeId != 0) && Properties.Settings.Default.Email != "";

            CheckEmail();
        }

        private void BttnUrl_Click(object sender, EventArgs e)
        {
            var m = new EenUrlTestForm();
            m.ShowDialog();
        }

        private void BttnWebservice_Click(object sender, EventArgs e)
        {
            var m = new WebserviceOfKlantForm(false);
            m.ShowDialog();
        }

        private void BtnKlant_Click(object sender, EventArgs e)
        {
            var m = new WebserviceOfKlantForm(true);
            m.ShowDialog();
        }

        private void BtnShowWebservices_Click(object sender, EventArgs e)
        {
            var m = new AllWebserviceForm();
            m.ShowDialog();
        }

        private void BtnShowKlanten_Click(object sender, EventArgs e)
        {
            var m = new AllKlantenForm();
            m.ShowDialog();
        }

        private void EmailTlStrpMnItm_Click_1(object sender, EventArgs e)
        {
            var m = new UserForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingSetEmail);
            m.ShowDialog();
        }

        private void ChildFormClosingSetEmail(object sender, FormClosingEventArgs e)
        {
            ToolStripMenuItem1.Enabled = (_klantKeuzeId != 0 || _webserviceKeuzeId != 0) && Properties.Settings.Default.Email != "";
            CheckEmail();
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
            _krXml.UpdateXmlFile(_xmlUserName);
        }

        private void min30ByServiceTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("TijdService", "30000");
            TijdCheckService();
            _krXml.UpdateXmlFile(_xmlUserName);
        }

        private void min60ByServiceTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("TijdService", "60000");
            TijdCheckService();
            _krXml.UpdateXmlFile(_xmlUserName);
        }

        private void AanByServiceTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("ServiceAanOfUit", "aan");
            AanOfUitCheckService();
            _krXml.UpdateXmlFile(_xmlUserName);
        }

        private void UitByServiceTlStrpMnItm_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("ServiceAanOfUit", "uit");
            AanOfUitCheckService();
            _krXml.UpdateXmlFile(_xmlUserName);
        }

        private void ZetConfEnProp(string name, string waarde)
        {
            ConfigurationManager.AppSettings[name] = waarde;
            Properties.Settings.Default[name] = waarde;
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
            _klantDatas = _klantTest.GetKlantData();
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
            if (_klantKeuzeId == (int)item.Tag)
            {
                _klantKeuzeId = 0;

                WebserviceKeuzeToolStripMenuItem.Enabled = true;
                ToolStripMenuItem1.Enabled = false;
            }
            else
            {

                _klantKeuzeId = (int)item.Tag;
                _klantKeuzeNaam = item.Text;
                item.Checked = true;

                WebserviceKeuzeToolStripMenuItem.Enabled = false;

                if (Properties.Settings.Default.Email != "")
                {
                    ToolStripMenuItem1.Enabled = true;
                }
            }
            Properties.Settings.Default.KlantKeuze = _klantKeuzeId;
        }

        private void FillWebserviceDropDown()
        {
            _webServiceDatas = _webserviceXml.GetWebservices();
            foreach (WebService webServiceData in _webServiceDatas)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Tag = webServiceData.Id;
                item.Text = webServiceData.Name;
                WebserviceKeuzeToolStripMenuItem.DropDownItems.Add(item);

                item.Click += new EventHandler(ClickItemDropdownWebservice);
            }
        }

        private void ClickItemDropdownWebservice(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem toolStripMenuItem in WebserviceKeuzeToolStripMenuItem.DropDownItems)
            {
                toolStripMenuItem.Checked = false;
            }

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (_webserviceKeuzeId == (int)item.Tag)
            {
                _webserviceKeuzeId = 0;

                KlantKeuzeToolStripMenuItem.Enabled = true;
                ToolStripMenuItem1.Enabled = false;
            }
            else
            {
                _webserviceKeuzeId = (int)item.Tag;
                _webserviceKeuzeNaam = item.Text;
                item.Checked = true;

                KlantKeuzeToolStripMenuItem.Enabled = false;

                if (Properties.Settings.Default.Email != "")
                {
                    ToolStripMenuItem1.Enabled = true;
                }
            }
            Properties.Settings.Default.WebserviceKeuze = _webserviceKeuzeId;
        }

        public void RouteTest()
        {
            if (ConfigurationManager.AppSettings["TestAanOfUit"] == "aan")
            {
                if (_webserviceKeuzeId != 0)
                {
                    _keuzeNaam = _webserviceKeuzeNaam;
                }
                else if (_klantKeuzeId != 0)
                {
                    _keuzeNaam = _klantKeuzeNaam;
                }
                RouteTestAfterKeuze(_urlDatas, _keuzeNaam);
            }
        }

        private void RouteTestAfterKeuze(List<UrlData> urlDatas, string keuzeNaam)
        {
            int teller = 0;
            string text = "";
            LogFile logFile = new LogFile();
            foreach (UrlData urlData in urlDatas)
            {
                CheckWebservice(urlData);
                GetResult(urlData);
                foreach (JProperty item in _result)
                {
                    if (item.Name == "ex")
                    {
                        if (teller == 0)
                        {
                            teller = teller + 1;
                            text += keuzeNaam + Environment.NewLine + Environment.NewLine;
                            logFile.MakeLogFile(keuzeNaam);
                        }
                        text += urlData.Name + " --> " + item.Value.ToString() + Environment.NewLine;
                        logFile.AddTextToLogFile(urlData.Name + " --> " + item.Value.ToString() + Environment.NewLine);
                    }
                }
            }
            if (text != "")
            {
                MailClient.TestMail(keuzeNaam, text, logFile.FilePath);
            }
        }

        private void CheckWebservice(UrlData urlData)
        {
            foreach (WebService item in _webServiceDatas)
            {
                if (item.Id == urlData.WebServiceDataId)
                {
                    _isSoap = item.Soap;
                    _webserviceName = item.Name;
                }
            }
        }

        private void GetResult(UrlData urlData)
        {
            if (_isSoap && urlData.Name.EndsWith(".svc"))
            {
                if (urlData.Name == "MessageServiceSoap31.svc")
                {
                    var m = new Sales31CredentialsForm();
                    m.TopMost = true;
                    m.ShowDialog();
                    MaterialMaskedTextBox userName = m._usernameTxtBx;
                    MaterialMaskedTextBox password = m._passwordTxtBx;
                    _result = JObject.Parse(_webRequest.Get31SalesData(_httpName + _webserviceName, userName, password));
                }
                else if (urlData.Name == "MessageServiceSoap.svc")
                {
                    _result = JObject.Parse(_webRequest.Get24SalesData(_httpName + _webserviceName));

                }
                else
                {
                    string data = _webRequest.GetWebRequestSoap(_httpName, _webserviceName, urlData.Name);
                    _result = JObject.Parse(data);
                }
            }
            else
            {
                var data = _webRequest.GetWebRequestRest(urlData.WebServiceDataId,
                                                     _httpName,
                                                     _webserviceName,
                                                     urlData.Name,
                                                     urlData.SecurityId);
                _result = JObject.Parse(data);
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDatabase createDatabase = new CreateDatabase();
            createDatabase.MakeDb(true);
        }

        private void CheckEmail()
        {
            if (Properties.Settings.Default.Email != string.Empty)
            {
                StripMenuItemTestTijd.Enabled = true;
                ServiceTlStrpMnItm.Enabled = true;
            }
            else
            {
                StripMenuItemTestTijd.Enabled = false;
                ServiceTlStrpMnItm.Enabled = false;
            }
        }
    }
}
