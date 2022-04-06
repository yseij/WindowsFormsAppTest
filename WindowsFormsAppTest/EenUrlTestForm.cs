using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;

namespace WindowsFormsAppTest
{
    public partial class EenUrlTestForm : MaterialForm
    {
        private string url;
        private string urlHttp = "";
        private string securityId = "";

        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<WebServiceData> _webserviceDatas = new List<WebServiceData>();
        private List<UrlData> _urlDatas = new List<UrlData>();

        HttpTest _httptest;
        WebserviceTest _webservicetest;
        UrlTest _urltest;
        WebRequest _webRequest;
        TestRoute _testRoute;

        public EenUrlTestForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();
            _httptest = new HttpTest();
            _webservicetest = new WebserviceTest();

            GetHttps();
            GetWebservices();
            GetUrls();

            FillCmbxUrls();
            FillCmbxWebservice();
            FillCmbxHtpp();
        }

        private void GetHttps()
        {
            _httpDatas = _httptest.GetHttpData();
        }

        private void GetWebservices()
        {
            _webserviceDatas = _webservicetest.GetWebServiceDatas(true);
        }

        private void GetUrls()
        {
            _urlDatas = _urltest.GetUrlDatas(true);
        }

        private void FillCmbxHtpp()
        {
            HttpKrMaterialCmbx.FillCmbBoxHttp(_httpDatas);
            HttpKrMaterialCmbx.SelectedItem = ConfigurationManager.AppSettings["http"];
            urlHttp = ConfigurationManager.AppSettings["http"];
        }

        private void FillCmbxWebservice()
        {
            WebserviceKrMaterialCmbx.FillCmbBoxWebservice(_webserviceDatas);
        }

        private void FillCmbxUrls()
        {
            UrlKrMaterialCmbx.FillCmbBoxUrl(_urlDatas);
        }

        private void TestRouteBtn_Click(object sender, EventArgs e)
        {
            ClearBox();
            bool isSoap = false;
            dynamic result = null;
            foreach (WebServiceData item in _webserviceDatas)
            {
                if (item.Id == (int)WebserviceKrMaterialCmbx.SelectedValue)
                {
                    isSoap = item.Soap;
                }
            }
            if (isSoap)
            {
                if (UrlKrMaterialCmbx.Text == "MessageServiceSoap31.svc")
                {
                    result = _webRequest.get31SalesData(HttpKrMaterialCmbx.Text + WebserviceKrMaterialCmbx.Text);
                    CheckData(result, WebserviceKrMaterialCmbx.Text, 3.1);
                }
                else if (UrlKrMaterialCmbx.Text == "MessageServiceSoap.svc")
                {
                    result = _webRequest.get24SalesData(HttpKrMaterialCmbx.Text + WebserviceKrMaterialCmbx.Text);
                    CheckData(result, WebserviceKrMaterialCmbx.Text, 2.4);
                }
                else
                {
                    string data = _webRequest.GetWebRequestSoap(HttpKrMaterialCmbx.Text, WebserviceKrMaterialCmbx.Text, UrlKrMaterialCmbx.Text);
                    ResponseTextBox.Text = data;
                }
            }
            else
            {
                var data = _webRequest.GetWebRequestRest((int)WebserviceKrMaterialCmbx.SelectedValue,
                                                     HttpKrMaterialCmbx.Text,
                                                     WebserviceKrMaterialCmbx.Text,
                                                     UrlKrMaterialCmbx.Text,
                                                     securityId);
                result = JObject.Parse(data);

                _testRoute.TestOneRoute(result,
                                    textBoxWebservice,
                                    SslChckBx,
                                    SllCertificaatVervalDatumTxtBx,
                                    checkBoxKraanDLL,
                                    checkBoxKraanIni,
                                    checkBoxKraanDatabase,
                                    ResponseTextBox,
                                    WebserviceKrMaterialCmbx.Text);
            }

        }

        private void UrlKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearBox();
            if (WebserviceKrMaterialCmbx.DataSource != null)
            {
                int idOfSelected = (int)UrlKrMaterialCmbx.SelectedValue;
                UrlData urlData = _urlDatas.Find(u => u.Id == idOfSelected);
                url = urlData.Name;
                securityId = urlData.SecurityId;
            }
        }

        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }

        private void ClearBox()
        {
            checkBoxKraanDatabase.Checked = false;
            checkBoxKraanDLL.Checked = false;
            checkBoxKraanIni.Checked = false;
            textBoxWebservice.Text = string.Empty;
            ResponseTextBox.Text = string.Empty;
            SslChckBx.Checked = false;
            SllCertificaatVervalDatumTxtBx.Text = string.Empty;
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
    }
}
