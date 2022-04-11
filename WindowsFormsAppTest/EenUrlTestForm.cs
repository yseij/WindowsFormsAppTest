using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class EenUrlTestForm : MaterialForm
    {
        private string url;
        private string securityId;

        private string urlHttp = string.Empty;

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
        }

        private void GetHttps()
        {
            _httpDatas = _httptest.GetHttpData();
        }

        private void GetWebservices()
        {
            _webserviceDatas = _webservicetest.GetWebServiceData();
        }

        private void GetUrls()
        {
            _urlDatas = _urltest.GetUrlData();
        }

        private void FillCmbxUrls()
        {
            UrlKrMaterialCmbx.FillCmbBoxUrl(_urlDatas);
        }

        private void TestRouteBtn_Click(object sender, EventArgs e)
        {
            ClearBox();
            bool isSoap = false;
            int webserviceId = 0;
            int httpId = 0;
            string webserviceName = string.Empty;
            string httpName = string.Empty;
            dynamic result = null;
            foreach (UrlData urlData in _urlDatas)
            {
                if ((int)UrlKrMaterialCmbx.SelectedValue == urlData.Id)
                {
                    webserviceId = urlData.WebServiceDataId;
                    httpId = urlData.HttpDataId;
                }
            }
            foreach (WebServiceData item in _webserviceDatas)
            {
                if (item.Id == webserviceId)
                {
                    isSoap = item.Soap;
                    webserviceName = item.Name;
                }
            }
            foreach (HttpData item in _httpDatas)
            {
                if (item.Id == httpId)
                {
                    httpName = item.Name;
                }
            }
            if (isSoap && UrlKrMaterialCmbx.Text.EndsWith(".svc"))
            {
                if (UrlKrMaterialCmbx.Text == "MessageServiceSoap31.svc")
                {
                    result = _webRequest.Get31SalesData(httpName + webserviceName, TxtBxUsername, TxtBxPassword, ResponseTextBox);
                    if (result != null)
                    {
                        CheckData(result, webserviceName, 3.1);
                    }
                }
                else if (UrlKrMaterialCmbx.Text == "MessageServiceSoap.svc")
                {
                    result = _webRequest.Get24SalesData(httpName + webserviceName, ResponseTextBox);
                    if (result != null)
                    {
                        CheckData(result, webserviceName, 2.4);
                    }
                }
                else
                {
                    string data = _webRequest.GetWebRequestSoap(httpName, webserviceName, UrlKrMaterialCmbx.Text);
                    
                    if (data == "Niet goed")
                    {
                        ResponseTextBox.Text = "Deze service bestaat niet";
                    }
                    else
                    {
                        ResponseTextBox.Text = data;
                        CheckDataSoap(JObject.Parse(data));
                    }
                }
            }
            else
            {
                var data = _webRequest.GetWebRequestRest((int)UrlKrMaterialCmbx.SelectedValue,
                                                     httpName,
                                                     webserviceName,
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
                                    webserviceName);
            }

        }

        private void UrlKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearBox();
            int idOfSelected = (int)UrlKrMaterialCmbx.SelectedValue;
            UrlData urlData = _urlDatas.Find(u => u.Id == idOfSelected);
            url = urlData.Name;
            securityId = urlData.SecurityId;
            foreach (WebServiceData item in _webserviceDatas)
            {
                if (item.Id == urlData.WebServiceDataId)
                {
                    if ((item.Soap && item.Name == "KraanSalesService") || (item.Soap && item.Name == "release"))
                    {
                        TbCntrlRestApiEnSoap.SelectedTab = TbCntrlRestApiEnSoap.TabPages["SalesPage"];
                        //TbCntrlRestApiEnSoap.Size = new Size(851, 638);
                        //ActiveForm.Height = 1061;
                        //Console.WriteLine("1");
                    }
                    else if ((item.Soap && item.Name != "KraanSalesService") || (item.Soap && item.Name != "release"))
                    {
                        TbCntrlRestApiEnSoap.SelectedTab = TbCntrlRestApiEnSoap.TabPages["SoapPage"];
                        //TbCntrlRestApiEnSoap.Size = new Size(851, 360);
                        //ActiveForm.Height = 660;
                        //Console.WriteLine("2");
                    }
                    else if(!item.Soap)
                    {
                        TbCntrlRestApiEnSoap.SelectedTab = TbCntrlRestApiEnSoap.TabPages["RestPage"];
                        //TbCntrlRestApiEnSoap.Size = new Size(851, 364);
                        //ActiveForm.Height = 781;
                        //Console.WriteLine("3");
                    }
                }
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
            }
        }
    }
}
