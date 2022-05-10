using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class EenUrlTestForm : MaterialForm
    {
        private string _webserviceName = string.Empty;
        private string _httpName = string.Empty;
        private string _urlHttp = string.Empty;
        private string _urlTest = string.Empty;

        private bool _isSoap = false;
        private bool _isSecurityId = false;

        private Guid _webserviceId;

        dynamic _result = null;

        private WebService _selectedWebservice = new WebService();
        private KlantWebservice _klantWebservice = new KlantWebservice();

        private List<WebService> _webserviceDatas = new List<WebService>();
        private List<Klant> _klantDatas = new List<Klant>();
        private List<KlantWebservice> _klantWebservicesDatas = new List<KlantWebservice>();

        WebRequest _webRequest;
        TestRoute _testRoute;

        UrlXml _urlXml;
        WebserviceXml _webserviceXml;
        KlantXml _klantXml;
        KlantWebserviceXml _klantWebserviceXml;

        public EenUrlTestForm()
        {
            InitializeComponent();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();

            _urlXml = new UrlXml();
            _klantXml = new KlantXml();
            _klantWebserviceXml = new KlantWebserviceXml();
            _webserviceXml = new WebserviceXml();

            GetWebservices();
            GetKlanten();
        }

        private void GetWebservices()
        {
            _webserviceDatas = _webserviceXml.GetWebservices();
        }

        private void GetKlanten()
        {
            _klantDatas = _klantXml.GetKlanten();
            KlantKrMaterialCmbx.FillCmbBoxKlant(_klantDatas);
        }

        private void KlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrlVoorTestTxtBx.Text = string.Empty;
            ClearBox();
            GetUrls();
        }

        private void AllUrlsKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Url url = (Url)AllUrlsKrLstBx.SelectedItem;
            ClearBox();

            if (url != null && url.KlantId != Guid.Empty)
            {
                if (url.WebserviceId != Guid.Empty)
                {
                    _selectedWebservice = _webserviceXml.GetWebserviceById(url.WebserviceId);
                    _webserviceId = _selectedWebservice.Id;
                }
                UrlVoorTestTxtBx.Text = url.Name;
                if (_selectedWebservice.SecurityId != string.Empty)
                {
                    _isSecurityId = true;
                    SecurityIdTxtBx.Text = _selectedWebservice.SecurityId;
                }
                SetSelectedTab(url);
            }
        }

        private void UrlOpslaanBtn_Click(object sender, EventArgs e)
        {
            int i = -1;

            Url newUrl = new Url(UrlVoorTestTxtBx.Text, (Guid)KlantKrMaterialCmbx.SelectedValue, _selectedWebservice.Id);
            Url url = _urlXml.GetByKlantAndName((Guid)KlantKrMaterialCmbx.SelectedValue, UrlVoorTestTxtBx.Text);
            i = AllUrlsKrLstBx.FindString(UrlVoorTestTxtBx.Text);
            if (url == null && i == -1)
            {
                _urlXml.AddUrl(newUrl);
            }
            else
            {
                MessageBox.Show("Deze url hoort al bij deze klant");
            }
            GetUrls();
        }

        private void UrlVoorTestTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (UrlVoorTestTxtBx.Text == string.Empty)
            {
                UrlOpslaanBtn.Enabled = false;
            }
            else
            {
                UrlOpslaanBtn.Enabled = true;
            }
            Url url = new Url();
            url.Name = UrlVoorTestTxtBx.Text;
            SetSelectedTab(url);
        }

        private void SetSelectedTab(Url url)
        {
            if (_selectedWebservice.Soap)
            {
                if (url.Name.EndsWith("MessageServiceSoap31.svc"))
                {
                    TbCntrlRestApiEnSoap.SelectTab(3);
                }
                else if(url.Name.EndsWith("MessageServiceSoap.svc"))
                {
                    TbCntrlRestApiEnSoap.SelectTab(2);
                }
                else
                {
                    TbCntrlRestApiEnSoap.SelectTab(1);
                }
            }
            else
            {
                TbCntrlRestApiEnSoap.SelectTab(0);
            }
        }

        private void GetUrls()
        {
            _klantWebservicesDatas = _klantWebserviceXml.GetByKlant((Guid)KlantKrMaterialCmbx.SelectedValue);
            Klant klant = _klantDatas.Find(k => k.Id == (Guid)KlantKrMaterialCmbx.SelectedValue);
            List<Url> urls = new List<Url>();
            foreach (KlantWebservice klantWebservice in _klantWebservicesDatas)
            {
                WebService webService = _webserviceXml.GetWebserviceById(klantWebservice.Webservice);
                Url url = new Url();
                if (klantWebservice.BasisUrl1)
                {
                    url.Name = klant.BasisUrl1 + webService.Name;
                }
                else
                {
                    url.Name = klant.BasisUrl2 + webService.Name;
                }
                url.WebserviceId = webService.Id;
                url.KlantId = (Guid)KlantKrMaterialCmbx.SelectedValue;
                urls.Add(url);
            }

            Url tussenUrl = new Url("|---Opgeslagen urls---|", Guid.Empty, Guid.Empty);
            urls.Add(tussenUrl);
            List<Url> urlDatas = _urlXml.GetByKlantId((Guid)KlantKrMaterialCmbx.SelectedValue);
            foreach (Url url in urlDatas)
            {
                urls.Add(url);
            }
            AllUrlsKrLstBx.FillListBoxUrls(urls);
        }

        private void TestWebserviceBtn_Click(object sender, EventArgs e)
        {
            string checkUrl = _webRequest.CheckUrl(UrlVoorTestTxtBx.Text);
            if (checkUrl == "true")
            {
                MLblCheckOfNiet.Text = "✓";
            }
            else
            {
                MLblCheckOfNiet.Text = "X";
                MessageBox.Show(checkUrl);
            }
        }

        private void GetWebserviceVersionBtn_Click(object sender, EventArgs e)
        {
            CheckWebservice();
            _urlTest = UrlVoorTestTxtBx.Text;
            if (!_isSoap)
            {
                _urlTest = UrlVoorTestTxtBx.Text + "/GetWebserviceVersion";
            }
            GetResult(true);
        }

        private void TestMethodeBtn_Click(object sender, EventArgs e)
        {
            CheckWebservice();
            _urlTest = UrlVoorTestTxtBx.Text;
            GetResult(false);
        }

        private void CheckWebservice()
        {
            foreach (WebService item in _webserviceDatas)
            {
                if (item.Id == _webserviceId)
                {
                    _isSoap = item.Soap;
                    _webserviceName = item.Name;
                }
            }
        }

        private void GetResult(bool isGetWebserviceVersion)
        {
            ClearBox();
            if (_isSoap && UrlVoorTestTxtBx.Text.EndsWith(".svc"))
            {
                if (UrlVoorTestTxtBx.Text.Contains("MessageServiceSoap31.svc"))
                {
                    var m = new Sales31CredentialsForm();
                    m.TopMost = true;
                    m.ShowDialog();
                    MaterialMaskedTextBox userName = m._usernameTxtBx;
                    MaterialMaskedTextBox password = m._passwordTxtBx;
                    _result = JObject.Parse(_webRequest.Get31SalesData(UrlVoorTestTxtBx.Text, userName, password));
                    if (_result != null)
                    {
                        CheckData(_result, _webserviceName, 3.1);
                    }
                }
                else if (UrlVoorTestTxtBx.Text.Contains("MessageServiceSoap.svc"))
                {
                    _result = JObject.Parse(_webRequest.Get24SalesData(UrlVoorTestTxtBx.Text));
                    
                    if (_result != null)
                    {
                        CheckData(_result, _webserviceName, 2.4);
                    }
                }
                else
                {
                    int plaatsSlech = UrlVoorTestTxtBx.Text.LastIndexOf("/");
                    string service = UrlVoorTestTxtBx.Text.Substring(plaatsSlech + 1, UrlVoorTestTxtBx.Text.Length - plaatsSlech - 1);
                    try
                    {
                        _result = JObject.Parse(_webRequest.GetWebRequestSoap(_urlTest, service));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dit is geen juiste methode die je kan testen");
                    }
                    
                    CheckDataSoap(_result);
                }
            }
            else
            {
                string data = _webRequest.GetWebRequestRest(_urlTest,
                                                        isGetWebserviceVersion);
                try
                {
                    _result = JObject.Parse(data);
                }
                catch (Exception)
                {
                    MessageBox.Show("Dit is geen juiste methode die je kan testen");
                }
                
                _testRoute.TestOneRoute(_result,
                                    textBoxWebservice,
                                    SslChckBx,
                                    SllCertificaatVervalDatumTxtBx,
                                    checkBoxKraanDLL,
                                    checkBoxKraanIni,
                                    checkBoxKraanDatabase,
                                    ResponseTextBox,
                                    _webserviceName);
            }
        }

        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }

        private void ClearBox()
        {
            clearGroupBox(GrpBxWebservice);
            clearGroupBox(GrpBxSsl);
            clearGroupBox(grpBxSales2_4);
            clearGroupBox(grpBxSales3_1);
            clearGroupBox(grpBxSoap);
            ResponseTextBox.Text = string.Empty;
        }

        private void clearGroupBox(GroupBox groupBox)
        {
            foreach (Control ctr in groupBox.Controls)
            {
                if (ctr is MaterialTextBox)
                {
                    ctr.Text = string.Empty;
                }
                else if (ctr is MaterialCheckbox)
                {
                    ((CheckBox)ctr).Checked = false;
                }
            }
        }

        private void CheckData(dynamic result, string webservice, double soort)
        {
            string TxtBxMessageVersie = "";
            bool ChkBxKraanDLL = false;
            bool ChkBxKraanIni = false;
            string TxtBxKraanDllVersie = "";
            string TxtBxInterbaseVersie = "";
            string TxtBxMssqlServer = "";
            string TxtBxMssqlCatalog = "";
            string TxtBxKraan1DatabaseVersie = "";
            string TxtBxKraan2DatabaseVersie = "";
            bool ChkBxKraanDatabase = false;

            LogFile logFile = new LogFile();
            logFile.MakeLogFile(webservice);
            foreach (JProperty item in result)
            {
                switch (item.Name)
                {
                    case "Versie MessageService":
                        TxtBxMessageVersie = item.Value.ToString().Split(':')[0];
                        break;
                    case "KraanDLL aanwezig":
                        ChkBxKraanDLL = item.Value.ToString().Contains("True");
                        TxtBxKraanDllVersie = item.Value.ToString().Split(':')[1];
                        break;
                    case "Kraan.ini aanwezig":
                        ChkBxKraanIni = item.Value.ToString().Contains("True");
                        break;
                    case "InterBase server":
                        TxtBxInterbaseVersie = item.Value.ToString().Split(':')[0];
                        break;
                    case "MSSQL server":
                        TxtBxMssqlServer = item.Value.ToString().Split(':')[0];
                        break;
                    case "MSSQL catalog":
                        TxtBxMssqlCatalog = item.Value.ToString().Split(':')[0];
                        break;
                    case "Databaseconnectie gelukt":
                        ChkBxKraanDatabase = item.Value.ToString().Contains("True");
                        break;
                    case "Kraan 1 databaseversie":
                        TxtBxKraan1DatabaseVersie = item.Value.ToString().Split(':')[0];
                        break;
                    case "Kraan 2 databaseversie":
                        TxtBxKraan2DatabaseVersie = item.Value.ToString().Split(':')[0];
                        break;
                    case "certVerValDatum":
                        if (item.Value.ToString() != "")
                        {
                            SslChckBx.Checked = true;
                            SllCertificaatVervalDatumTxtBx.Text = item.Value.ToString();
                            logFile.AddTextToLogFile("certVerValDatum = " + item.Value.ToString() + "\n");
                        }
                        break;
                    case "ex":
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Value;
                        break;
                }
            }
            if (soort == 2.4)
            {
                TxtBxMessageVersie2_4.Text = TxtBxMessageVersie;
                ChkBxKraanDLL2_4.Checked = ChkBxKraanDLL;
                TxtBxKraanDllVersie2_4.Text = TxtBxKraanDllVersie;
                ChkBxKraanIni2_4.Checked = ChkBxKraanIni;
                ChkBxKraanDatabase2_4.Checked = ChkBxKraanDatabase;
                TxtBxInterbaseVersie2_4.Text = TxtBxInterbaseVersie;
                TxtBxMssqlServer2_4.Text = TxtBxMssqlServer;
                TxtBxMssqlCatalog2_4.Text = TxtBxMssqlCatalog;
                TxtBxKraan1DatabaseVersie2_4.Text = TxtBxKraan1DatabaseVersie;
                TxtBxKraan2DatabaseVersie2_4.Text = TxtBxKraan2DatabaseVersie;
            }
            else if (soort == 3.1)
            {
                TxtBxMessageVersie3_1.Text = TxtBxMessageVersie;
                ChkBxKraanDLL3_1.Checked = ChkBxKraanDLL;
                TxtBxKraanDllVersie3_1.Text = TxtBxKraanDllVersie;
                ChkBxKraanIni3_1.Checked = ChkBxKraanIni;
                ChkBxKraanDatabase3_1.Checked = ChkBxKraanDatabase;
                TxtBxInterbaseVersie3_1.Text = TxtBxInterbaseVersie;
                TxtBxMssqlServer3_1.Text = TxtBxMssqlServer;
                TxtBxMssqlCatalog3_1.Text = TxtBxMssqlCatalog;
                TxtBxKraan1DatabaseVersie3_1.Text = TxtBxKraan1DatabaseVersie;
                TxtBxKraan2DatabaseVersie3_1.Text = TxtBxKraan2DatabaseVersie;
            }
            logFile.AddTextToLogFile("WebserviceVersie = " + TxtBxMessageVersie + "\n");
            logFile.AddTextToLogFile("KraanDLL aanwezig = " + ChkBxKraanDLL + " --> versie: " + TxtBxKraanDllVersie + "\n");
            logFile.AddTextToLogFile("Kraan.ini aanwezig = " + ChkBxKraanIni + "\n");
            logFile.AddTextToLogFile("Databaseconnectie gelukt = " + ChkBxKraanDatabase + "\n");
            logFile.AddTextToLogFile("InterBase server = " + TxtBxInterbaseVersie + "\n");
            logFile.AddTextToLogFile("MSSQL Server = " + TxtBxMssqlServer + "\n");
            logFile.AddTextToLogFile("MSSQL catalog = " + TxtBxMssqlCatalog + "\n");
            logFile.AddTextToLogFile("Kraan 1 databaseversie = " + TxtBxKraan1DatabaseVersie + "\n");
            logFile.AddTextToLogFile("Kraan 2 databaseversie = " + TxtBxKraan2DatabaseVersie + "\n");
        }

        private void CheckDataSoap(dynamic result)
        {
            foreach (JProperty item in result)
            {
                switch (item.Name)
                {
                    case "Webservice Versie":
                        TxtBxWebserviceVersie.Text = item.Value.ToString().Replace("{", "").Replace("}", "");
                        break;
                    case "DevExpress versie":
                        TxtBxDevExpressVersie.Text = item.Value.ToString().Replace("{", "").Replace("}", "");
                        break;
                    case "DatabaseVersie":
                        TxtBxDatabaseVersie.Text = item.Value.ToString().Replace("{", "").Replace("}", "");
                        break;
                }
                ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
            }
        }

        private void TbCntrlRestApiEnSoap_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrlVoorTestTxtBx.Select();
        }

        private void TbCntrlRestApiEnSoap_TabIndexChanged(object sender, EventArgs e)
        {
            UrlVoorTestTxtBx.Select();
        }
    }
}
