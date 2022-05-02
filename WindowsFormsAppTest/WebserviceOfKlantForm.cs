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
        private int _selectedWebserviceIdOfKlantId;
        private int _aantalLegeUrls;
        private Guid _webserviceId;

        private bool _klant;
        private bool _isSoap;

        private string _webserviceName;
        private string _httpName;

        dynamic _result = null;

        private List<WebService> _webServiceDatas = new List<WebService>();
        private List<Klant> _klantenDatas = new List<Klant>();
        private List<HttpData> _httpDatas = new List<HttpData>();

        HttpTest _httptest;
        WebserviceTest _webserviceTest;
        KlantTest _klantTest;
        WebRequest _webRequest;
        TestRoute _testRoute;

        WebserviceXml webserviceXml;

        public WebserviceOfKlantForm(bool isKlant)
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _klantTest = new KlantTest();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();
            _httptest = new HttpTest();

            _klant = isKlant;

            AantalLegeUrlsTxtBx.Text = string.Empty;

            _webServiceDatas = webserviceXml.GetWebservices();
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
        }

        private void FillCmbxWebServices()
        {
            WebService webServiceData = new WebService("Alles testen", false, "");
            _webServiceDatas.Add(webServiceData);

            WebserviceOfKlantKrMaterialCmbx.FillCmbBoxWebservice(_webServiceDatas);
        }

        private void FillCmbxKlanten()
        {
            Klant klantData = new Klant("Alles testen", "", "");
            _klantenDatas.Add(klantData);

            WebserviceOfKlantKrMaterialCmbx.FillCmbBoxKlant(_klantenDatas);
        }

        private void TestAllBtn_Click(object sender, EventArgs e)
        {
            _aantalLegeUrls = 0;
            AantalLegeUrlsTxtBx.Text = string.Empty;
            LegeUrlsTxtBx.Text = string.Empty;

            ClearBox();
            LogFile logFile = new LogFile();
            logFile.MakeLogFile(WebserviceOfKlantKrMaterialCmbx.Text);

            TrVwAll.Nodes.Clear();
            TrVwAll.BeginUpdate();

            //foreach (UrlData urlData in _urlDatas)
            //{
            //    CheckWebservice(urlData);
            //    GetResult(urlData);
            //    if (_result != null)
            //    {
            //        FillTreeView(_result, urlData, logFile);
            //        _result = null;
            //    }
            //}
            TrVwAll.EndUpdate();
        }

        private void WebserviceOfKlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceIdOfKlantId = (int)WebserviceOfKlantKrMaterialCmbx.SelectedValue;
        }

        private void GetResult(Url urlData)
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
                    _result = JObject.Parse(_webRequest.GetWebRequestSoap(_webserviceName, urlData.Name));
                }
            }
            else
            {
                //_result = JObject.Parse(_webRequest.GetWebRequestRest(_webserviceId,
                //                                     _httpName,
                //                                     _webserviceName,
                //                                     urlData.Name,
                //                                     urlData.SecurityId));
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
                    if (currentClkNode.Text == "MessageServiceSoap.svc")
                    {
                        CheckDataSoap(UrlData, 2.4);
                    }
                    else if (currentClkNode.Text == "MessageServiceSoap31.svc")
                    {
                        CheckDataSoap(UrlData, 3.1);
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

        private void FillTreeView(dynamic _result, Url urlData, LogFile logFile)
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
                    node.ForeColor = Color.FromArgb(0, 255, 0, 0);
                    ResponseTextBox.Text = item.Value.ToString();
                    _aantalLegeUrls = _aantalLegeUrls + 1;
                    AantalLegeUrlsTxtBx.Text = _aantalLegeUrls.ToString();
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
                    ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                }
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
    }
}
