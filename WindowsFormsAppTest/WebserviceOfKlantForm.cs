using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class WebserviceOfKlantForm : MaterialForm
    {
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<KlantData> _klantenDatas = new List<KlantData>();
        private List<UrlData> _urlDatas = new List<UrlData>();
        private List<HttpData> _httpDatas = new List<HttpData>();

        private int selectedWebserviceIdOfKlantId;
        private int aantalLegeUrls;

        private bool _klant;
        bool _isSoap = false;
        int _webserviceId = 0;
        int _httpId = 0;
        string _webserviceName = "";
        string _httpName = "";
        string httpName = "";
        dynamic result = null;

        HttpTest _httptest;
        WebserviceTest _webserviceTest;
        UrlTest _urltest;
        KlantTest _klantTest;
        WebRequest _webRequest;
        TestRoute _testRoute;

        public WebserviceOfKlantForm(bool isKlant)
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _urltest = new UrlTest();
            _klantTest = new KlantTest();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();
            _httptest = new HttpTest();

            _klant = isKlant;

            GetHttps();
            AantalLegeUrlsTxtBx.Text = string.Empty;

            if (isKlant)
            {
                Text = "Per Klant testen";
                LblWebserviceOfKlant.Text = "Klanten";
                _klantenDatas = _klantTest.GetKlantData();
                FillCmbxKlanten();
            }
            else
            {
                Text = "Per Webservice testen";
                LblWebserviceOfKlant.Text = "Webservice";
                FillCmbxWebServices();
            }
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
        }

        private void GetHttps()
        {
            _httpDatas = _httptest.GetHttpData();
        }

        private void FillCmbxWebServices()
        {
            WebserviceOfKlantKrMaterialCmbx.FillCmbBoxWebservice(_webServiceDatas);
        }

        private void FillCmbxKlanten()
        {
            WebserviceOfKlantKrMaterialCmbx.FillCmbBoxKlant(_klantenDatas);
        }

        private void TestAllBtn_Click_1(object sender, EventArgs e)
        {
            ClearBox();
            AantalLegeUrlsTxtBx.Text = string.Empty;
            LegeUrlsTxtBx.Text = string.Empty;
            LogFile logFile = new LogFile();
            if (_klant)
            {
                _urlDatas = _urltest.GetAllUrlsByForeignKeyKlant(selectedWebserviceIdOfKlantId);
            }
            else
            {
                _urlDatas = _urltest.GetAllUrlsByForeignKeyWebservice(selectedWebserviceIdOfKlantId);
            }
            aantalLegeUrls = 0;
            logFile.MakeLogFile(WebserviceOfKlantKrMaterialCmbx.Text);
            TrVwAll.Nodes.Clear();
            TrVwAll.BeginUpdate();
            foreach (UrlData urlData in _urlDatas)
            {
                Console.WriteLine(_webServiceDatas);
                foreach (WebServiceData item in _webServiceDatas)
                {
                    Console.WriteLine(item);
                    if (item.Id == urlData.WebServiceDataId)
                    {
                        _isSoap = item.Soap;
                        _webserviceName = item.Name;
                    }
                }
                foreach (HttpData item in _httpDatas)
                {
                    if (item.Id == urlData.HttpDataId)
                    {
                        httpName = item.Name;
                    }
                }
                if (_isSoap && urlData.Name.EndsWith(".svc"))
                {
                    if (urlData.Name == "MessageServiceSoap31.svc")
                    {
                        var m = new Sales31CredentialsForm();
                        m.ShowDialog();
                        MaterialMaskedTextBox userName = m._usernameTxtBx;
                        MaterialMaskedTextBox password = m._passwordTxtBx;
                        Test31Sales(userName, password);
                    }
                    else if (urlData.Name == "MessageServiceSoap.svc")
                    {
                        result = JObject.Parse(_webRequest.get24SalesData(httpName + _webserviceName, ResponseTextBox));
                        if (result != null)
                        {
                            CheckData(result, _webserviceName, 2.4);
                        }
                    }
                    else
                    {
                        string data = _webRequest.GetWebRequestSoap(httpName, _webserviceName, urlData.Name);
                        result = JObject.Parse(data);
                    }
                }
                else
                {
                    var data = _webRequest.GetWebRequestRest(_webserviceId,
                                                         httpName,
                                                         _webserviceName,
                                                         urlData.Name,
                                                         urlData.SecurityId);
                    result = JObject.Parse(data);
                }
                if (result != null)
                {
                    FillTreeView(result, urlData, logFile);
                    result = null;
                }
            }
            TrVwAll.EndUpdate();
        }

        private void Test31Sales(MaterialMaskedTextBox userName, MaterialMaskedTextBox password)
        {
            dynamic result = _webRequest.get31SalesData(httpName + _webserviceName, userName, password, ResponseTextBox);
            if (result != null)
            {
                CheckData(result, _webserviceName, 3.1);
            }
        }

        private void WebserviceOfKlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWebserviceIdOfKlantId = (int)WebserviceOfKlantKrMaterialCmbx.SelectedValue;
        }

        private void TrVwAll_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode currentClkNode = e.Node;
            dynamic UrlData = currentClkNode.Tag;
            if (UrlData != null)
            {
                if (!ZetLogVastChkBx.Checked)
                {
                    ClearBox();
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
            }
            
        }

        private void FillTreeView(dynamic _result, UrlData urlData, LogFile logFile)
        {
            TreeNode node = new TreeNode();
            node.Text = urlData.Name;
            logFile.AddTextToLogFile("\n");
            logFile.AddTextToLogFile(urlData.Name + "\n");
            node.Tag = _result;
            int teller = 0;
            foreach (JProperty item in _result)
            {
                if (teller == 0)
                {
                    TrVwAll.Nodes.Add(node);
                    teller = teller + 1;
                }
                if (item.Name == "ex")
                {
                    node.ForeColor = Color.FromArgb(255, 0, 0);
                    ResponseTextBox.Text = item.Value.ToString();
                    aantalLegeUrls = aantalLegeUrls + 1;
                    AantalLegeUrlsTxtBx.Text = aantalLegeUrls.ToString();
                    LegeUrlsTxtBx.Text = LegeUrlsTxtBx.Text + urlData.Name + Environment.NewLine;
                    logFile.AddTextToLogFile(item.Name + " = " + item.Value.ToString() + "\n");
                }
                else if (item.Name != "id")
                {
                    TrVwAll.Nodes[TrVwAll.Nodes.Count - 1].Nodes.Add(item.Name + " = " + item.Value);
                    logFile.AddTextToLogFile(item.Name + " = " + item.Value.ToString() + "\n");
                }
            }
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
                }
            }
            //if (soort == 2.4)
            //{
            //    TxtBxMessageVersie2_4.Text = TxtBxMessageVersie;
            //    ChkBxKraanDLL2_4.Checked = ChkBxKraanDLL;
            //    TxtBxKraanDllVersie2_4.Text = TxtBxKraanDllVersie;
            //    ChkBxKraanIni2_4.Checked = ChkBxKraanIni;
            //    ChkBxKraanDatabase2_4.Checked = ChkBxKraanDatabase;
            //    TxtBxInterbaseVersie2_4.Text = TxtBxInterbaseVersie;
            //    TxtBxMssqlServer2_4.Text = TxtBxMssqlServer;
            //    TxtBxMssqlCatalog2_4.Text = TxtBxMssqlCatalog;
            //    TxtBxKraan1DatabaseVersie2_4.Text = TxtBxKraan1DatabaseVersie;
            //    TxtBxKraan2DatabaseVersie2_4.Text = TxtBxKraan2DatabaseVersie;
            //}
            //else if (soort == 3.1)
            //{
            //    TxtBxMessageVersie3_1.Text = TxtBxMessageVersie;
            //    ChkBxKraanDLL3_1.Checked = ChkBxKraanDLL;
            //    TxtBxKraanDllVersie3_1.Text = TxtBxKraanDllVersie;
            //    ChkBxKraanIni3_1.Checked = ChkBxKraanIni;
            //    ChkBxKraanDatabase3_1.Checked = ChkBxKraanDatabase;
            //    TxtBxInterbaseVersie3_1.Text = TxtBxInterbaseVersie;
            //    TxtBxMssqlServer3_1.Text = TxtBxMssqlServer;
            //    TxtBxMssqlCatalog3_1.Text = TxtBxMssqlCatalog;
            //    TxtBxKraan1DatabaseVersie3_1.Text = TxtBxKraan1DatabaseVersie;
            //    TxtBxKraan2DatabaseVersie3_1.Text = TxtBxKraan2DatabaseVersie;
            //}
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
    }
}
