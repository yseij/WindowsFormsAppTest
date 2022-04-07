using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    class TestRoute
    {
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private string urlHttp = ConfigurationManager.AppSettings["http"];
        private dynamic _result;

        WebRequest _webRequest;
        WebserviceTest _webserviceTest;
        public TestRoute()
        {
            _webRequest = new WebRequest();
            _webserviceTest = new WebserviceTest();
        }
        public void TestOneRoute(dynamic result,
                              MaterialTextBox textBoxWebservice,
                              CheckBox sslChckBx,
                              MaterialTextBox sllCertificaatVervalDatumTxtBx,
                              CheckBox checkBoxKraanDLL,
                              CheckBox checkBoxKraanIni,
                              CheckBox checkBoxKraanDatabase,
                              MaterialMultiLineTextBox2 ResponseTextBox,
                              string selectedText)
        {
            LogFile logFile = new LogFile();
            logFile.MakeLogFile(selectedText);
            foreach (JProperty item in result)
            {
                switch (item.Name)
                {
                    case "WebserviceVersie":
                        string[] strlist = item.Value.ToString().Split(':');
                        textBoxWebservice.Text = strlist[1];
                        logFile.AddTextToLogFile("WebserviceVersie = " + strlist[1] + "\n");
                        break;
                    case "certVerValDatum":
                        if (item.Value.ToString() != "")
                        {
                            sslChckBx.Checked = true;
                            sllCertificaatVervalDatumTxtBx.Text = item.Value.ToString();
                            logFile.AddTextToLogFile("certVerValDatum = " + item.Value.ToString() + "\n");
                        }
                        break;
                    case "KraanDll":
                        checkBoxKraanDLL.Checked = item.Value.ToString().Contains("True");
                        logFile.AddTextToLogFile("KraanDll = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "KraanIni":
                        checkBoxKraanIni.Checked = item.Value.ToString().Contains("True");
                        logFile.AddTextToLogFile("KraanIni = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "KraanDatabase":
                        checkBoxKraanDatabase.Checked = item.Value.ToString().Contains("True");
                        logFile.AddTextToLogFile("KraanDatabase = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "id":
                        break;
                    case "ex":
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Value;
                        break;
                    default:
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                        break;
                }
            }
        }

        public void TestOneRouteSoap(string result,
                              MaterialTextBox webserviceVersie,
                              MaterialTextBox devExpressVersie,
                              MaterialTextBox databaseVersie,
                              string selectedText)
        {
            LogFile logFile = new LogFile();
            logFile.MakeLogFile(selectedText);
            Console.WriteLine(result);
            string data = result.Replace("----", "");
            int positionWebserviceVersie = data.IndexOf("Webservice versie");
            int positionDevExpressVersie = data.IndexOf("DevExpress versie");
            int positionDatabaseVersie = data.IndexOf("DatabaseVersie");
            int dataLengte = data.Length;
            webserviceVersie.Text = data.Substring(positionWebserviceVersie, positionDevExpressVersie - positionWebserviceVersie).Split(':')[1];
            devExpressVersie.Text = data.Substring(positionDevExpressVersie, positionDatabaseVersie - positionDevExpressVersie).Split(':')[1];
            databaseVersie.Text = data.Substring(positionDatabaseVersie, dataLengte - positionDatabaseVersie).Split(':')[1];
        }

        public void TestMoreRoutes(string selectedKlant,
                                   TreeView TrVwAll,
                                   int aantalLegeUrls,
                                   List<UrlData> urlDatas,
                                   MaterialMultiLineTextBox2 ResponseTextBox,
                                   MaterialTextBox AantalLegeUrlsTxtBx,
                                   MaterialMultiLineTextBox2 LegeUrlsTxtBx)
        {
            bool isSoap = false;
            string webservice = ""; ;
            int teller;
            GetWebservices();

            LogFile logFile = new LogFile();
            if (selectedKlant == string.Empty)
            {
                logFile.MakeLogFile("Alle_webservices_getest");
            }
            else
            {
                logFile.MakeLogFile(selectedKlant);
            }
            TrVwAll.Nodes.Clear();
            TrVwAll.BeginUpdate();
            aantalLegeUrls = 0;
            foreach (UrlData urlData in urlDatas)
            {
                foreach (WebServiceData webServiceData in _webServiceDatas)
                {
                    if (webServiceData.Id == urlData.WebServiceDataId)
                    {
                        isSoap = webServiceData.Soap;
                        webservice = webServiceData.Name;
                    }
                }
                TreeNode node = new TreeNode();
                node.Text = urlData.Name;
                logFile.AddTextToLogFile("\n");
                logFile.AddTextToLogFile(urlData.Name + "\n");
                _result = JObject.Parse(_webRequest.GetWebRequestRest(urlData.Id, urlHttp, webservice, urlData.Name, urlData.SecurityId));
                node.Tag = _result;
                teller = 0;
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
            TrVwAll.EndUpdate();
        }

        private void GetWebservices()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
        }
    }
}