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
        private string urlHttp = ConfigurationManager.AppSettings["http"];
        private dynamic _result;

        WebRequest _webRequest;
        public TestRoute()
        {
            _webRequest = new WebRequest();
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
            logFile.makeLogFile(selectedText);
            foreach (JProperty item in result)
            {
                switch (item.Name)
                {
                    case "WebserviceVersie":
                        string[] strlist = item.Value.ToString().Split(':');
                        textBoxWebservice.Text = strlist[1];
                        logFile.addTextToLogFile("WebserviceVersie = " + strlist[1] + "\n");
                        break;
                    case "certVerValDatum":
                        if (item.Value != null)
                        {
                            sslChckBx.Checked = true;
                            sllCertificaatVervalDatumTxtBx.Text = item.Value.ToString();
                            logFile.addTextToLogFile("certVerValDatum = " + item.Value.ToString() + "\n");
                        }
                        break;
                    case "KraanDll":
                        checkBoxKraanDLL.Checked = item.Value.ToString().Contains("True");
                        logFile.addTextToLogFile("KraanDll = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "KraanIni":
                        checkBoxKraanIni.Checked = item.Value.ToString().Contains("True");
                        logFile.addTextToLogFile("KraanIni = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "KraanDatabase":
                        checkBoxKraanDatabase.Checked = item.Value.ToString().Contains("True");
                        logFile.addTextToLogFile("KraanDatabase = " + item.Value.ToString().Contains("True") + "\n");
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

        public void TestMoreRoutes(string selectedKlant,
                                   TreeView TrVwAll,
                                   int aantalLegeUrls,
                                   List<UrlData> urlDatas,
                                   MaterialMultiLineTextBox2 ResponseTextBox,
                                   MaterialTextBox AantalLegeUrlsTxtBx,
                                   MaterialMultiLineTextBox2 LegeUrlsTxtBx)
        {
            int teller = 0;

            LogFile logFile = new LogFile();
            logFile.makeLogFile(selectedKlant);
            TrVwAll.Nodes.Clear();
            TrVwAll.BeginUpdate();
            aantalLegeUrls = 0;
            foreach (UrlData urlData in urlDatas)
            {
                TreeNode node = new TreeNode();
                node.Text = urlData.Name;
                logFile.addTextToLogFile("\n");
                logFile.addTextToLogFile(urlData.Name + "\n");
                var data = _webRequest.GetWebRequest(urlData.Id, urlHttp, urlData.Name, urlData.SecurityId);
                _result = JObject.Parse(data);
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
                        logFile.addTextToLogFile(item.Name + " = " + item.Value.ToString() + "\n");
                    }
                    else if (item.Name != "id")
                    {
                        TrVwAll.Nodes[TrVwAll.Nodes.Count - 1].Nodes.Add(item.Name + " = " + item.Value);
                        logFile.addTextToLogFile(item.Name + " = " + item.Value.ToString() + "\n");
                    }
                }
            }
            TrVwAll.EndUpdate();
        }
    }
}
