
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Windows.Forms;
using System.Xml;


namespace WindowsFormsAppTest
{
    public partial class WebserviceTestFormSoap : MaterialForm
    {
        private string urlHttp = "";

        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();

        WebserviceTest _webserviceTest;

        public WebserviceTestFormSoap()
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
        }

        private void WebserviceTestForm_Load(object sender, EventArgs e)
        {
            FillCmbxWebServices();
            FillCmbxHtpp();
        }

        private void FillCmbxWebServices()
        {
            WebserviceKrMaterialCmbx.FillCmbBoxWebservice(_webServiceDatas);
        }

        private void FillCmbxHtpp()
        {
            List<string> listOfNames = new List<string>()
            {
                "https://wsdev.kraan.com/",
                "https://ws.kraan.com:444/",
                "https://wsdev.kraan.com:1234/release/MessageServiceSoap31.svc"
            };
            HttpKrMaterialCmbx.FillCmbBoxRest(listOfNames);
            HttpKrMaterialCmbx.SelectedItem = ConfigurationManager.AppSettings["http"];
            urlHttp = ConfigurationManager.AppSettings["http"];
        }

        private BasicHttpBinding CreateBinding(string bindingName)
        {
            BasicHttpBinding serviceBinding = new BasicHttpBinding();
            serviceBinding.Name = bindingName;
            serviceBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            serviceBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            return serviceBinding;
        }

        private EndpointAddress CreateEndpointAddress(string host, string endPointName)
        {
            string endPointString = host;
            if (host.ToLower().Contains("messageservicesoap.svc") || host.ToLower().Contains("messageservicesoap31.svc"))
            { return new EndpointAddress(host); }
            if (endPointString.Last() != '/')
            {
                endPointString += '/';
            }
            endPointString = endPointString + endPointName;

            EndpointAddress epa = new EndpointAddress(endPointString);
            return epa;
        }

        private Sales24.MessageServiceSoapClient NewSales24Client(string host)
        {

            BasicHttpBinding binding = CreateBinding("MessageServiceSoap");
            EndpointAddress epa = CreateEndpointAddress(host, "messageservicesoap.svc");

            return new Sales24.MessageServiceSoapClient(binding, epa);
        }

        private Sales31.MessageServiceSoapClient NewSales31Client(string host)
        {
            BasicHttpBinding bindings = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
            bindings.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;

            bindings.MaxReceivedMessageSize = 2147483647;
            var elements = bindings.CreateBindingElements();
            elements.Find<SecurityBindingElement>().EnableUnsecuredResponse = true;
            elements.Find<SecurityBindingElement>().IncludeTimestamp = false;
            CustomBinding cusbinding = new CustomBinding(elements);
            EndpointAddress epa = CreateEndpointAddress(host, "messageservicesoap31.svc");

            return new Sales31.MessageServiceSoapClient(cusbinding, epa);
        }

        private void BtnTestWebservice_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            txtTestResultaat.Text = "Verbinding wordt getest..." + Environment.NewLine + Environment.NewLine;
            txtTestResultaat.Refresh();

            string host = HttpKrMaterialCmbx.Text.Trim();
            //host += WebserviceKrMaterialCmbx.Text;

            if (string.IsNullOrWhiteSpace(host))
            {
                host = "localhost";
                HttpKrMaterialCmbx.Text = host;
            }

            try
            {
                if (!host.ToLower().EndsWith("messageservicesoap31.svc"))
                {
                    using (Sales24.MessageServiceSoapClient client = NewSales24Client(host))
                    {
                        string testResultaat = "Geen verbinding mogelijk.";

                        try
                        {
                            client.Open();
                            Sales24.MessageServiceMessage message = new Sales24.MessageServiceMessage();
                            message.MsgType = "CST_KRAAN_VERSION";
                            bool succes = client.PostMessage(null, null, ref message);


                            testResultaat = "Er is een beveiligde verbinding gemaakt met de Sales Messageservice ..." + Environment.NewLine;
                            testResultaat += "\r\nURL: " + CreateEndpointAddress(host, "messageservicesoap.svc").Uri + Environment.NewLine;
                            testResultaat = testResultaat + message.Text[0];

                            var data = "{\"" + message.Text[0]
                                .Replace("\r\n", "\",\"")
                                .Replace(": ", "\": \"")
                                .Replace(@"\", " ")
                                .Replace("Versie\": \"", "Versie: ") + "\"}";

                            dynamic result = JObject.Parse(data);

                            CheckData(result, WebserviceKrMaterialCmbx.Text + "_2_4", 2.4);

                            client.Close();
                        }
                        catch (Exception ex)
                        {
                            testResultaat = "Fout bij verbinden met server van http Sales 2.4 , melding: " + Environment.NewLine + ex.Message;
                        }

                        txtTestResultaat.Text = txtTestResultaat.Text + testResultaat + Environment.NewLine;

                    }
                }
                if (!host.ToLower().EndsWith("messageservicesoap.svc"))
                {
                    if (!String.IsNullOrWhiteSpace(TxtBxUsername.Text.Trim()))
                    {
                        using (Sales31.MessageServiceSoapClient client = NewSales31Client(host))
                        {
                            string testResultaat = "Geen beveiligde verbinding mogelijk.\r\n";
                            client.ClientCredentials.UserName.UserName = TxtBxUsername.Text.Trim();
                            client.ClientCredentials.UserName.Password = TxtBxPassword.Text.Trim();
                            try
                            {
                                client.Open();
                                Sales31.MessageType message = new Sales31.MessageType();
                                message.MsgProperties = new Sales31.MessagePropertiesType();
                                message.MsgProperties.MsgType = "CST_KRAAN_VERSION";

                                Sales31.MessageResponseType antwoord = client.PostMessage(null, message);
                                if (antwoord.Message.MsgContent != null)
                                {
                                    testResultaat = "Er is een beveiligde verbinding gemaakt met de Sales Messageservice ..." + Environment.NewLine;
                                    testResultaat += "\r\nURL: " + CreateEndpointAddress(host, "messageservicesoap31.svc").Uri;
                                    testResultaat = testResultaat + antwoord.Message.MsgContent;
                                    testResultaat = antwoord.Message.MsgContent;

                                    var data = "{\""
                                        + antwoord.Message.MsgContent.Trim()
                                        .Replace("\r\n", "\", \"")
                                        .Replace(": ", "\": \"")
                                        .Replace(@"\", " ")
                                        .Replace("application\": \"", "application: ")
                                        .Replace("Versie\": \"", "Versie: ")
                                        + "\"}";

                                    dynamic result = JObject.Parse(data);

                                    CheckData(result, WebserviceKrMaterialCmbx.Text, 3.1);
                                }
                                else
                                {
                                    MessageBox.Show("Fout bij beveiligd verbinden met Sales 3.1.");
                                }

                                client.Close();
                            }
                            catch (FaultException fex)
                            {
                                var msgFault = fex.CreateMessageFault();
                                if (msgFault.HasDetail)
                                {
                                    var detailNode = msgFault.GetDetail<XmlElement>();
                                    testResultaat += "Fout bij beveiligd verbinden met Sales 3.1. \r\nFoutcode " + detailNode.GetElementsByTagName("ErrorCode", detailNode.NamespaceURI)[0].InnerText + " : " + detailNode.GetElementsByTagName("Message", detailNode.NamespaceURI)[0].InnerText;
                                }
                                else
                                {
                                    if (fex.Code.Name == "Server" && fex.Message == "Server error")
                                    {
                                        testResultaat += "Fout bij beveiligd verbinden met Sales 3.1. Credentials incorrect.";
                                    }
                                    else
                                    {
                                        testResultaat += "Fout bij beveiligd verbinden met Sales 3.1. \r\nFoutmelding: " + fex.Message;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                testResultaat = "Fout bij beveiligd verbinden met Sales 3.1, melding: " + Environment.NewLine + ex.Message;
                            }

                            txtTestResultaat.Text = txtTestResultaat.Text + Environment.NewLine + testResultaat;
                        }
                    }
                    else
                    { txtTestResultaat.Text = txtTestResultaat.Text + Environment.NewLine + "Credenials om versie 3.1 te testen zijn niet gevuld"; }
                }

            }
            catch (UriFormatException exes)
            {
                txtTestResultaat.Text = "Deze URL is ongeldig.";
            }

            txtTestResultaat.Text = txtTestResultaat.Text.Replace("\n ", "\r\n");
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

        private void HttpKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            urlHttp = HttpKrMaterialCmbx.SelectedText;
        }
    }
}
