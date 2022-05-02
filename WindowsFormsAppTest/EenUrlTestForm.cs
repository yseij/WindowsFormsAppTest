using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class EenUrlTestForm : MaterialForm
    {
        private string _url;
        private string _securityId;
        private string _webserviceName = string.Empty;
        private string _httpName = string.Empty;
        private string _urlHttp = string.Empty;

        private bool _isSoap = false;

        private Guid _webserviceId;
        private Guid _httpId;

        dynamic _result = null;

        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<WebService> _webserviceDatas = new List<WebService>();

        HttpTest _httptest;
        WebserviceTest _webservicetest;
        WebRequest _webRequest;
        TestRoute _testRoute;

        WebserviceXml _webserviceXml;

        public EenUrlTestForm()
        {
            InitializeComponent();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();
            _httptest = new HttpTest();
            _webservicetest = new WebserviceTest();

            GetWebservices();
        }

        private void GetWebservices()
        {
            _webserviceDatas = _webserviceXml.GetWebservices();
        }

        private void TestRouteBtn_Click(object sender, EventArgs e)
        {
            ClearBox();

            CheckWebservice();

            GetResult();
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

        private void GetResult()
        {
            if (_isSoap && UrlKrMaterialCmbx.Text.EndsWith(".svc"))
            {
                if (UrlKrMaterialCmbx.Text == "MessageServiceSoap31.svc")
                {
                    _result = JObject.Parse(_webRequest.Get31SalesData(_httpName + _webserviceName, TxtBxUsername, TxtBxPassword));
                    if (_result != null)
                    {
                        CheckData(_result, _webserviceName, 3.1);
                    }
                }
                else if (UrlKrMaterialCmbx.Text == "MessageServiceSoap.svc")
                {
                    _result = JObject.Parse(_webRequest.Get24SalesData(_httpName + _webserviceName));
                    if (_result != null)
                    {
                        CheckData(_result, _webserviceName, 2.4);
                    }
                }
                else
                {
                    dynamic data = JObject.Parse(_webRequest.GetWebRequestSoap(_httpName, _webserviceName, UrlKrMaterialCmbx.Text));
                    CheckDataSoap(data);
                }
            }
            else
            {
                var data = _webRequest.GetWebRequestRest((Guid)UrlKrMaterialCmbx.SelectedValue,
                                                     _httpName,
                                                     _webserviceName,
                                                     UrlKrMaterialCmbx.Text,
                                                     _securityId);
                _result = JObject.Parse(data);

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
    }
}
