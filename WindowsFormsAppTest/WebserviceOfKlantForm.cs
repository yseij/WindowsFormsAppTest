using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class WebserviceOfKlantForm : MaterialForm
    {
        private Guid _selectedWebserviceIdOfKlantId;
        private int _aantalLegeUrls;
        private int _node;

        private string _clipBoardText;
        private string _selectedWebserviceOfKlant;

        private bool _isKlant;
        private bool _isSoap;
        private bool _isAllesTest;

        dynamic _result = null;

        string[] kraan2Webservices = { "AuthService.svc",
                                      "CrmService.svc",
                                      "WorkflowService.svc",
                                      "MaterieelService.svc",
                                      "MaterieelbeheerService.svc",
                                      "UrenService.svc" };

        string[] kraanSalesService = { "MessageServiceSoap.svc",
                                       "MessageServiceSoap31.svc"};

        List<string> _urls = new List<string>();
        List<string> _results = new List<string>();
        List<string> _newUrls = new List<string>();
        List<string> _newResults = new List<string>();

        private List<Url> _urls2 = new List<Url>();
        private List<WebService> _webServices = new List<WebService>();
        private List<Klant> _klanten = new List<Klant>();
        private List<KlantWebservice> _klantWebservices = new List<KlantWebservice>();

        WebRequest _webRequest;
        TestRoute _testRoute;

        UrlXml _urlXml;
        WebserviceXml _webserviceXml;
        KlantXml _klantXml;
        KlantWebserviceXml _klantWebserviceXml;

        public WebserviceOfKlantForm(bool isKlant)
        {
            InitializeComponent();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();

            _urlXml = new UrlXml();
            _webserviceXml = new WebserviceXml();
            _klantXml = new KlantXml();
            _klantWebserviceXml = new KlantWebserviceXml();

            _isKlant = isKlant;

            AantalLegeUrlsTxtBx.Text = string.Empty;

            _webServices = _webserviceXml.GetAll();
            _klanten = _klantXml.GetKlanten();

            if (isKlant)
            {
                Text = "Per Klant testen";
                LblWebserviceOfKlant.Text = "Klanten";
                FillCmbxKlanten();
            }
            else
            {
                Text = "Per Webservice testen";
                LblWebserviceOfKlant.Text = "Webservice";
                FillCmbxWebServices();
            }
        }

        private void FillCmbxWebServices()
        {
            WebService webService = new WebService("Alles testen");
            _webServices.Add(webService);
            WebserviceOfKlantKrMaterialCmbx.FillCmbBoxWebservice(_webServices);
        }

        private void FillCmbxKlanten()
        {
            Klant klant = new Klant("Alles testen");
            _klanten.Add(klant);
            WebserviceOfKlantKrMaterialCmbx.FillCmbBoxKlant(_klanten);
        }

        private void TestAllBtn_Click(object sender, EventArgs e)
        {
            _result = null;
            _aantalLegeUrls = 0;
            AantalLegeUrlsTxtBx.Text = string.Empty;
            _isAllesTest = false;
            _node = 0;

            ClearBox();
            LogFile logFile = new LogFile();
            logFile.MakeLogFile(WebserviceOfKlantKrMaterialCmbx.Text);

            TrVwAll.Sorted = false;
            TrVwAll.TreeViewNodeSorter = null;
            TrVwAll.Nodes.Clear();
            TrVwAll.Controls.Clear();
            TrVwAll.BeginUpdate();

            _webServices = _webserviceXml.GetAll();
            if (_isKlant)
            {
                if (_selectedWebserviceIdOfKlantId == Guid.Empty)
                {
                    _klantWebservices = _klantWebserviceXml.GetAll();
                    _klantWebservices = _klantWebservices.OrderBy(x => x.Klant).ToList();
                    _urls2 = _urlXml.GetAll();
                }
                else
                {
                    _klantWebservices = _klantWebserviceXml.GetByKlant(_selectedWebserviceIdOfKlantId);
                    _urls2 = _urlXml.GetByKlantId(_selectedWebserviceIdOfKlantId);
                }
            }
            else
            {
                if (_selectedWebserviceIdOfKlantId == Guid.Empty)
                {
                    _klantWebservices = _klantWebserviceXml.GetAll();
                    _klantWebservices = _klantWebservices.OrderBy(x => x.Webservice).ToList();
                    _urls2 = _urlXml.GetAll();
                }
                else
                {
                    _klantWebservices = _klantWebserviceXml.GetByWebservice(_selectedWebserviceIdOfKlantId);
                    foreach (KlantWebservice klantWebservice in _klantWebservices)
                    {
                        List<Url> urlList = (_urlXml.GetByKlantWebserviceId(klantWebservice.Id));
                        foreach (Url url in urlList)
                        {
                            _urls2.Add(url);
                        }
                    }
                }
            }
            GetData(logFile);
            TrVwAll.EndUpdate();
            if (_isAllesTest)
            {
                TrVwAll.TreeViewNodeSorter = new NodeSorter2();
            }
            SetClipBoardText();
        }

        private void GetData(LogFile logFile)
        {
            string oldWebservice = string.Empty;
            string oldKlant = string.Empty;

            foreach (KlantWebservice klantWebservice in _klantWebservices)
            {
                string basisUrl = string.Empty;
                Url url = new Url();
                WebService webService = new WebService();
                Klant klant = _klanten.Find(k => k.Id == klantWebservice.Klant);
                if (_isKlant && _selectedWebserviceIdOfKlantId == Guid.Empty)
                {
                    SetTreeViewName(klant.Name, oldKlant);
                    oldKlant = klant.Name;
                    _isAllesTest = true;
                }
                foreach (WebService webservice in _webServices)
                {
                    if (webservice.Id == klantWebservice.Webservice)
                    {
                        webService = webservice;
                        _isSoap = webservice.Soap;
                        if (!_isKlant && _selectedWebserviceIdOfKlantId == Guid.Empty)
                        {
                            SetTreeViewName(webService.Name, oldWebservice);
                            oldWebservice = webservice.Name;
                            _isAllesTest = true;
                        }
                    }
                }
                if (klantWebservice.BasisUrl1 && klantWebservice.BasisUrl2)
                {
                    basisUrl = klant.BasisUrl1;
                    url.Name = basisUrl + webService.Name;
                    SoapOfRestTest(url, logFile, webService, klantWebservice);
                    basisUrl = klant.BasisUrl2;
                    url.Name = basisUrl + webService.Name;
                    SoapOfRestTest(url, logFile, webService, klantWebservice);
                }
                else if (klantWebservice.BasisUrl1)
                {
                    basisUrl = klant.BasisUrl1;
                    url.Name = basisUrl + webService.Name;
                    SoapOfRestTest(url, logFile, webService, klantWebservice);
                }
                else
                {
                    basisUrl = klant.BasisUrl2;
                    url.Name = basisUrl + webService.Name;
                    SoapOfRestTest(url, logFile, webService, klantWebservice);
                }
                logFile.AddTextToLogFile("\n");
                List<Url> urlDatas = _urlXml.GetByKlantWebserviceId(klantWebservice.Id);
                foreach (Url url1 in urlDatas)
                {
                    Url newUrl = new Url();
                    newUrl.Id = url1.Id;
                    newUrl.Name = basisUrl + webService.Name + "/" + url1.Name;
                    newUrl.KlantId = klant.Id;
                    newUrl.KlantWebserviceId = klantWebservice.Id;
                    GetResult(newUrl, false);
                    FillTreeView(newUrl, logFile, false, false);
                }
            }
        }

        private void SoapOfRestTest(Url url, LogFile logFile, WebService webService, KlantWebservice klantWebservice)
        {
            if (webService.Name == "KraanHomeDNA")
            {
                url.Name += "/HomeDna.svc/GetWebserviceVersion";
                GetResult(url, true);
                FillTreeView(url, logFile, true, false);
            }
            else if (webService.Name == "Kraan2Webservices")
            {
                UrlsTestKraan2Webservice(url, logFile);
            }
            else if (webService.Name == "KraanSalesService")
            {
                UrlsTestKraanSalesService(url, klantWebservice, logFile);
            }
            else if (webService.Name == "KraanWerkbonWebservice")
            {
                url.Name += "/Webservice.svc";
                GetResult(url, false);
                FillTreeView(url, logFile, true, false);
            }
            else if (webService.Name == "KraanHandheld")
            {
                url.Name += "/HandheldService.svc/rest/GetVersion";
                GetResult(url, false);
                FillTreeView(url, logFile, true, false);
            }
            else if (!_isSoap)
            {
                CheckUrlAndGetWebserviceVersion(url, logFile);
            }
            else
            {
                GetResult(url, false);
                FillTreeView(url, logFile, false, true);
            }
        }

        private void UrlsTestKraanSalesService(Url url, KlantWebservice klantWebservice, LogFile logFile)
        {
            for (int i = 0; i < kraanSalesService.Length; i++)
            {
                Url newUrl = new Url();
                newUrl.Name = url.Name + "/" + kraanSalesService[i];
                newUrl.KlantWebserviceId = klantWebservice.Id;
                GetResult(newUrl, false);
                FillTreeView(newUrl, logFile, false, true);
            }
        }

        private void CheckUrlAndGetWebserviceVersion(Url url, LogFile logFile)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    CheckUrl(url, logFile);
                }
                else
                {
                    Url url2 = new Url();
                    url2.Name = url.Name + "/GetWebserviceVersion";
                    GetResult(url2, true);
                    FillTreeView(url2, logFile, true, false);
                }
            }
        }

        private void UrlsTestKraan2Webservice(Url url, LogFile logFile)
        {
            for (int i = 0; i < kraan2Webservices.Length; i++)
            {
                Url newUrl = new Url();
                newUrl.Name = url.Name + "/" + kraan2Webservices[i];
                GetResult(newUrl, false);
                FillTreeView(newUrl, logFile, false, true);
                newUrl.Name = string.Empty;
            }
        }

        private void SetTreeViewName(string newName, string oldName)
        {
            TreeNode node = new TreeNode();
            if (newName != oldName)
            {
                _urls.Add("|---|" + newName + "|---|");
                _results.Add("");
                node.Text = "|---|" + newName + "|---|";
                node.ForeColor = Color.FromArgb(0, 0, 0, 255);
                TrVwAll.Nodes.Add(node);
                _node = TrVwAll.Nodes.Count - 1;
            }
        }

        private void CheckUrl(Url url, LogFile logFile)
        {
            string checkUrl = _webRequest.CheckUrl(url.Name);
            TreeNode node = new TreeNode();
            node.Text = url.Name;
            logFile.AddTextToLogFile("\n");
            _urls.Add(url.Name);
            if (checkUrl.StartsWith("false"))
            {
                _aantalLegeUrls++;
                node.ForeColor = Color.FromArgb(0, 255, 0, 0);
                node.Tag = "Webservice = " + checkUrl;
                logFile.AddTextToLogFile(url.Name + "--> Webservice = X" + checkUrl + "\n");
                _results.Add("Webservice = X");
            }
            else if (checkUrl.StartsWith("true"))
            {
                node.Tag = "Webservice = true";
                logFile.AddTextToLogFile(url.Name + " --> Webservice = true" + "\n");
                _results.Add("Webservice = ✓");
            }
            else
            {
                _aantalLegeUrls++;
                node.Tag = "ex = " + checkUrl;
                logFile.AddTextToLogFile(url.Name + " --> ex = " + checkUrl + "\n");
                _results.Add("ex = " + checkUrl);
            }
            if (_isAllesTest)
            {
                TrVwAll.Nodes[_node].Nodes.Add(node);
            }
            else
            {
                TrVwAll.Nodes.Add(node);
            }
        }

        private void WebserviceOfKlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceIdOfKlantId = (Guid)WebserviceOfKlantKrMaterialCmbx.SelectedValue;
            try
            {
                Klant klant = (Klant)WebserviceOfKlantKrMaterialCmbx.SelectedItem;
                _selectedWebserviceOfKlant = klant.Name;
            }
            catch
            {
                WebService webService = (WebService)WebserviceOfKlantKrMaterialCmbx.SelectedItem;
                _selectedWebserviceOfKlant = webService.Name;
            }
        }

        private void GetResult(Url urlData, bool isGetWebserviceVersion)
        {
            if (_isSoap && urlData.Name.EndsWith(".svc"))
            {
                if (urlData.Name.Contains("MessageServiceSoap31.svc"))
                {
                    var m = new Sales31CredentialsForm(urlData.Name, _selectedWebserviceOfKlant);
                    m.TopMost = true;
                    m.ShowDialog();
                    MaterialMaskedTextBox userName = m._usernameTxtBx;
                    MaterialMaskedTextBox password = m._passwordTxtBx;
                    try
                    {
                        _result = JObject.Parse(_webRequest.Get31SalesData(urlData.Name, userName, password));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Deze webservice kan niet getest worden, kijk of de webservice goed is ingesteld + foutmelding:" + ex.Message);
                    }
                    
                }
                else if (urlData.Name.Contains("MessageServiceSoap.svc"))
                {
                    try
                    {
                        _result = JObject.Parse(_webRequest.Get24SalesData(urlData.Name));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Deze webservice kan niet getest worden, kijk of de webservice goed is ingesteld + foutmelding:" + ex.Message);
                    }
                    
                }
                else
                {
                    int plaatsSlech = urlData.Name.LastIndexOf("/");
                    string service = urlData.Name.Substring(plaatsSlech + 1, urlData.Name.Length - plaatsSlech - 1);
                    try
                    {
                        _result = JObject.Parse(_webRequest.GetWebRequestSoap(urlData.Name, service)); ;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Deze webservice kan niet getest worden, kijk of de webservice goed is ingesteld + foutmelding:" + ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    _result = JObject.Parse(_webRequest.GetWebRequestRest(urlData.Name,
                                                        isGetWebserviceVersion));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deze webservice kan niet getest worden, kijk of de webservice goed is ingesteld + foutmelding:" + ex.Message);
                }
                
            }
        }

        private void TrVwAll_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode currentClkNode = e.Node;
            dynamic UrlData = currentClkNode.Tag;
            if (!ZetLogVastChkBx.Checked)
            {
                ClearBox();
                if (UrlData != null)
                {
                    if (currentClkNode.Text.Contains("MessageServiceSoap31.svc"))
                    {
                        CheckDataSoap(UrlData, 3.1);
                    }
                    else if (currentClkNode.Text.Contains("MessageServiceSoap.svc"))
                    {
                        CheckDataSoap(UrlData, 2.4);
                    }
                    else if (currentClkNode.Tag.ToString().Contains("true"))
                    {
                        ResponseTextBox.Text = currentClkNode.Tag.ToString();
                    }
                    else if (currentClkNode.Tag.ToString().Contains("false"))
                    {
                        ResponseTextBox.Text = currentClkNode.Tag.ToString();
                    }
                    else if (currentClkNode.Tag.ToString().Contains("ex"))
                    {
                        if (currentClkNode.Tag.ToString().Contains("{"))
                        {
                            foreach (JProperty item in UrlData)
                            {
                                ResponseTextBox.Text = item.Value.ToString();
                            }
                        }
                        else
                        {
                            ResponseTextBox.Text = currentClkNode.Tag.ToString().Replace("ex ", "");
                        }
                    }
                    else
                    {
                        CheckDataRest(UrlData);
                    }
                }
            }
        }

        private void CheckDataRest(dynamic UrlData)
        {
            foreach (JProperty item in UrlData)
            {
                if (item.Name != "id")
                {
                    ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                }
                switch (item.Name)
                {
                    case "WebserviceVersie":
                        TbCntrlRestApiEnSoap.SelectedTab = TbCntrlRestApiEnSoap.TabPages["RestPage"];
                        string[] strlist1 = item.Value.ToString().Split(':');
                        textBoxWebservice.Text = strlist1[1];
                        break;
                    case "certVerValDatum":
                        if (item.Value.ToString() != "")
                        {
                            SslChckBx.Checked = true;
                            SllCertificaatVervalDatumTxtBx.Text = item.Value.ToString();
                        }
                        break;
                    case "KraanDll":
                        checkBoxKraanDLL.Checked = item.Value.ToString().Contains("True");
                        break;
                    case "KraanIni":
                        checkBoxKraanIni.Checked = item.Value.ToString().Contains("True");
                        break;
                    case "KraanDatabase":
                        checkBoxKraanDatabase.Checked = item.Value.ToString().Contains("True");
                        break;
                    case "Webservice Versie":
                        TbCntrlRestApiEnSoap.SelectedTab = TbCntrlRestApiEnSoap.TabPages["SoapPage"];
                        TxtBxWebserviceVersie.Text = item.Value.ToString().Replace("{", "").Replace("}", "");
                        break;
                    case "DevExpress versie":
                        TxtBxDevExpressVersie.Text = item.Value.ToString().Replace("{", "").Replace("}", "");
                        break;
                    case "DatabaseVersie":
                        TxtBxDatabaseVersie.Text = item.Value.ToString().Replace("{", "").Replace("}", "");
                        break;
                }
            }
        }

        private void FillTreeView(Url url, LogFile logFile, bool isGetWebserviceVersion, bool isGetWebserviceVersionSoap)
        {
            TreeNode node = new TreeNode();
            node.Text = url.Name;
            logFile.AddTextToLogFile(url.Name + Environment.NewLine);
            node.Tag = _result;
            int teller = 0;
            string resultText = string.Empty;
            if (isGetWebserviceVersion || isGetWebserviceVersionSoap)
            {
                _urls.Add(url.Name);
            }
            foreach (JProperty item in _result)
            {
                if (teller == 0)
                {
                    if (_isAllesTest)
                    {
                        TrVwAll.Nodes[_node].Nodes.Add(node);
                    }
                    else
                    {
                        TrVwAll.Nodes.Add(node);
                    }
                    teller++;
                }
                if (item.Name == "ex")
                {
                    if (isGetWebserviceVersion || isGetWebserviceVersionSoap)
                    {
                        resultText += item.Value.ToString();
                    }
                    node.ForeColor = Color.FromArgb(0, 255, 0, 0);
                    ResponseTextBox.Text = item.Value.ToString();
                    _aantalLegeUrls = _aantalLegeUrls + 1;
                    AantalLegeUrlsTxtBx.Text = _aantalLegeUrls.ToString();
                    logFile.AddTextToLogFile("--> " + item.Value.ToString() + "\n");
                }
                else if (item.Name != "id")
                {
                    if (_isAllesTest)
                    {
                        TrVwAll.Nodes[TrVwAll.Nodes.Count - 1].Nodes[TrVwAll.Nodes[TrVwAll.Nodes.Count - 1].Nodes.Count - 1].Nodes.Add(item.Name + " = " + item.Value);
                    }
                    else
                    {
                        TrVwAll.Nodes[TrVwAll.Nodes.Count - 1].Nodes.Add(item.Name + " = " + item.Value);
                    }
                    if (isGetWebserviceVersion)
                    {
                        resultText += item.Value.ToString();
                    }
                    if (isGetWebserviceVersionSoap)
                    {
                        resultText += item.Name + " = " + item.Value.ToString();
                    }
                    logFile.AddTextToLogFile(item.Name + "--> " + item.Value.ToString() + "\n");
                }
            }
            _results.Add(resultText);
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            TrVwAll.TreeViewNodeSorter = new NodeSorter();
        }

        private void CheckBoxReadOnly_Click(object sender, EventArgs e)
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

        private void CheckDataSoap(dynamic result, double soort)
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

            foreach (JProperty item in result)
            {
                if (item.Name != "id")
                {
                    if (item.Name == "ex")
                    {
                        ResponseTextBox.Text = item.Value + Environment.NewLine;
                    }
                    else
                    {
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                    }
                }
                switch (item.Name)
                {
                    case "Versie MessageService":
                        TxtBxMessageVersie = item.Value.ToString().Split(':')[0];
                        break;
                    case " KraanDLL aanwezig":
                        ChkBxKraanDLL = item.Value.ToString().Contains("True");
                        TxtBxKraanDllVersie = item.Value.ToString().Split(':')[1];
                        break;
                    case " Kraan.ini aanwezig":
                        ChkBxKraanIni = item.Value.ToString().Contains("True");
                        break;
                    case " InterBase server":
                        TxtBxInterbaseVersie = item.Value.ToString().Split(':')[0];
                        break;
                    case " MSSQL server":
                        TxtBxMssqlServer = item.Value.ToString().Split(':')[0];
                        break;
                    case " MSSQL catalog":
                        TxtBxMssqlCatalog = item.Value.ToString().Split(':')[0];
                        break;
                    case " Databaseconnectie gelukt":
                        ChkBxKraanDatabase = item.Value.ToString().Contains("True");
                        break;
                    case " Kraan 1 databaseversie":
                        TxtBxKraan1DatabaseVersie = item.Value.ToString().Split(':')[0];
                        break;
                    case " Kraan 2 databaseversie":
                        TxtBxKraan2DatabaseVersie = item.Value.ToString().Split(':')[0];
                        break;
                }
            }
            if (soort == 2.4)
            {
                TbCntrlRestApiEnSoap.SelectedTab = TbCntrlRestApiEnSoap.TabPages["SalesPage2_4"];
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
                TbCntrlRestApiEnSoap.SelectedTab = TbCntrlRestApiEnSoap.TabPages["SalesPage3_1"];
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
        }

        private void SetClipBoardText()
        {
            if (_isAllesTest)
            {
                SortUrlsAndResults();
            }
            else
            {
                _newUrls = _urls;
                _newResults = _results;
            }
            
            int maxLengte = 0;
            foreach (string url in _newUrls)
            {
                if (url.Length > maxLengte)
                {
                    maxLengte = url.Length;
                }
            }
            maxLengte = maxLengte + 10;
            _clipBoardText = String.Format("{0,-" + maxLengte + "}" + "{1}\n\n", "Urls", "Results");
            for (int index = 0; index < _newUrls.Count; index++)
            {
                _clipBoardText += String.Format("{0,-" + maxLengte + "}" + "{1}\n", _newUrls[index], _newResults[index]);
            }
            Clipboard.SetText($"\n{_clipBoardText}");
            _clipBoardText = string.Empty;
            _urls.Clear();
            _results.Clear();
        }

        private void SortUrlsAndResults()
        {
            bool isDeZelfde = true;
            int teller = 0;
            List<string> matchedUrls = _urls.FindAll(u => u.Contains("|---|"));
            matchedUrls.Sort();
            for (int i = 0; i < matchedUrls.Count; i++)
            {
                isDeZelfde = true;
                int i2 = _urls.FindIndex(u => u.Equals(matchedUrls[i]));
                teller = i2;
                _newUrls.Add(matchedUrls[i]);
                _newResults.Add("");
                while (isDeZelfde)
                {
                    teller++;
                    if (teller >= _urls.Count)
                    {
                        isDeZelfde = false;
                    }
                    else
                    {
                        string findUrl = _urls.Find(u => u.Equals(_urls[teller]));
                        int findIndex = _urls.FindIndex(u => u.Equals(findUrl));
                        if (!findUrl.Contains("|---|") && findUrl != string.Empty)
                        {
                            _newUrls.Add(findUrl);
                            _newResults.Add(_results[findIndex]);
                        }
                        else
                        {
                            isDeZelfde = false;
                        }
                    }
                }
            }
        }
    }
}
