﻿using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml;

namespace WindowsFormsAppTest
{
    class WebRequest
    {
        private string webserviceVersie;
        private string kraanDll;
        private string kraanIni;
        private string kraanDatabase;

        private int positionKraanDll;
        private int positionKraanIni;
        private int positionDatabaseConnect;
        private int positionDatabaseMelding;

        private bool certIsGoed = false;

        WebClient _wc;

        public WebRequest()
        {
            _wc = new WebClient();
        }

        //REST
        public string GetWebRequestRest(int id, string http, string webservice, string url, string securityId = "")
        {
            string webRequestUrl = http + webservice + '/' + url + securityId;
            Uri uri = new Uri(webRequestUrl);
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(webRequestUrl) as HttpWebRequest;
                HttpClient client = new HttpClient();
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    X509Certificate cert = request.ServicePoint.Certificate;
                    X509Certificate2 cert2 = null;
                    if (cert != null)
                    {
                        cert2 = new X509Certificate2(cert);
                        certIsGoed = cert2.Verify();
                    }
                    int statusCode = (int)response.StatusCode;
                    if (statusCode >= 100 && statusCode < 400) //Good requests
                    {
                        client.BaseAddress = uri;
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        // List data response.
                        HttpResponseMessage response1 = client.GetAsync(uri).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                        if (response1.IsSuccessStatusCode)
                        {
                            //Parse the response body.
                            string data = response1.Content.ReadAsStringAsync().Result; //Make sure to add a reference to System.Net.Http.Formatting.dll
                            if (securityId == string.Empty)
                            {
                                if (certIsGoed)
                                {
                                    return GetDataOfWebRequest(data, cert.GetExpirationDateString().ToString());
                                }
                                else
                                {
                                    return GetDataOfWebRequest(data, "");
                                }
                            }
                            int Pos1 = data.IndexOf('{');
                            int Pos2 = data.IndexOf('}');
                            data = data.Substring(Pos1 + 1, Pos2 - Pos1 - 1);
                            if (certIsGoed)
                            {
                                return "{" + data + ", id: '" + id + "', certVerValDatum: '" + cert.GetExpirationDateString().ToString() + "'}";
                            }
                            return "{" + data + ", id: '" + id + "'}";

                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (WebException ex)
            {
                return @"{ ex: '" + ex.Message.ToString() + ex.Response.ToString() + "'}";
            }
        }

        private string GetDataOfWebRequest(string data, string verValDatum = "")
        {
            positionKraanDll = data.IndexOf("KraanDLL");
            positionKraanIni = data.IndexOf("Kraan.ini");
            positionDatabaseConnect = data.IndexOf("Database connectie");
            positionDatabaseMelding = data.IndexOf("Database melding");

            webserviceVersie = data.Substring(0, positionKraanDll);
            kraanDll = data.Substring(positionKraanDll, positionKraanIni - positionKraanDll);
            kraanIni = data.Substring(positionKraanIni, positionDatabaseConnect - positionKraanIni);
            kraanDatabase = data.Substring(positionDatabaseConnect, positionDatabaseMelding - positionDatabaseConnect);

            return @"{ WebserviceVersie: '" + webserviceVersie + "', KraanDll: '" + kraanDll + "', KraanIni: '" + kraanIni + "', KraanDatabase: '" + kraanDatabase + "', certVerValDatum: '" + verValDatum + "'}";
        }

        //SOAP
        public string GetWebRequestSoap(string http, string webservice, string service)
        {
            string host = http + webservice + "/";
            string result = "";

            //YouriWebserviceCrm.CrmServiceClient clientAuth;
            YouriWebserviceCrm.CrmServiceClient clientCrm;
            YouriWebserviceWorkFlow.WorkflowServiceClient clientWorkflow;
            YouriWebserviceUren.UrenServiceClient clientUren;
            YouriWebserviceMaterieel.MaterieelServiceClient clientMaterieel;

            switch (service)
            {
                //case "AuthService.svc":
                //    clientAuth = NewAuthService(host);
                //    clientAuth.Open();
                //    result = clientAuth.GetVersion().ToString();
                //    clientAuth.Close();
                //    break;
                case "CrmService.svc":
                    clientCrm = NewCrmService(host);
                    clientCrm.Open();
                    result = clientCrm.GetVersion().ToString();
                    clientCrm.Close();
                    break;
                case "WorkflowService.svc":
                    clientWorkflow = NewWorkFlowService(host);
                    clientWorkflow.Open();
                    result = clientWorkflow.GetVersion().ToString();
                    clientWorkflow.Close();
                    break;
                case "UrenService.svc":
                    clientUren = NewUrenService(host);
                    clientUren.Open();
                    result = clientUren.GetVersion().ToString();
                    clientUren.Close();
                    break;
                case "MaterieelService.svc":
                    clientMaterieel = NewMateriaalService(host);
                    clientMaterieel.Open();
                    result = clientMaterieel.GetVersion().ToString();
                    clientMaterieel.Close();
                    break;
                default:
                    break;
            }
            return result;
        }

        //private YouriWebserviceAuth.AuthServiceClient NewAuthService(string host)
        //{
        //    BasicHttpBinding binding = CreateBinding("AuthService");
        //    EndpointAddress epa = CreateEndpointAddress(host, "AuthService.svc");

        //    return new YouriWebserviceAuth.AuthServiceClient(binding, epa);
        //}

        private YouriWebserviceCrm.CrmServiceClient NewCrmService(string host)
        {
            BasicHttpBinding binding = CreateBinding("CrmService");
            EndpointAddress epa = CreateEndpointAddress(host, "CrmService.svc");

            return new YouriWebserviceCrm.CrmServiceClient(binding, epa);
        }

        private YouriWebserviceMaterieel.MaterieelServiceClient NewMateriaalService(string host)
        {
            BasicHttpBinding binding = CreateBinding("MaterieelService");
            EndpointAddress epa = CreateEndpointAddress(host, "MaterieelService.svc");

            return new YouriWebserviceMaterieel.MaterieelServiceClient(binding, epa);
        }

        private YouriWebserviceUren.UrenServiceClient NewUrenService(string host)
        {
            BasicHttpBinding binding = CreateBinding("UrenService");
            EndpointAddress epa = CreateEndpointAddress(host, "UrenService.svc");

            return new YouriWebserviceUren.UrenServiceClient(binding, epa);
        }

        private YouriWebserviceWorkFlow.WorkflowServiceClient NewWorkFlowService(string host)
        {
            BasicHttpBinding binding = CreateBinding("WorkflowService");
            EndpointAddress epa = CreateEndpointAddress(host, "WorkflowService.svc");

            return new YouriWebserviceWorkFlow.WorkflowServiceClient(binding, epa);
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

        private BasicHttpBinding CreateBinding(string bindingName)
        {
            BasicHttpBinding serviceBinding = new BasicHttpBinding();
            serviceBinding.Name = bindingName;
            serviceBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            serviceBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            return serviceBinding;
        }

        private EndpointAddress CreateEndpointAddress(string host, string endPointName = "")
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

        public dynamic get24SalesData(string host)
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
                    //testResultaat += "\r\nURL: " + CreateEndpointAddress(host, "messageservicesoap.svc").Uri + Environment.NewLine;
                    testResultaat += "\r\nURL: " + CreateEndpointAddress(host).Uri + Environment.NewLine;
                    testResultaat = testResultaat + message.Text[0];

                    var data = "{\"" + message.Text[0]
                        .Replace("\r\n", "\",\"")
                        .Replace(": ", "\": \"")
                        .Replace(@"\", " ")
                        .Replace("Versie\": \"", "Versie: ") + "\"}";

                    client.Close();
                    return JObject.Parse(data);
                }
                catch (Exception ex)
                {
                    testResultaat = "Fout bij verbinden met server van http Sales 2.4 , melding: " + Environment.NewLine + ex.Message;
                }
                return null;
            }
        }

        public dynamic get31SalesData(string host)
        {
            using (Sales31.MessageServiceSoapClient client = NewSales31Client(host))
            {
                string testResultaat = "Geen beveiligde verbinding mogelijk.\r\n";
                //client.ClientCredentials.UserName.UserName = TxtBxUsername.Text.Trim();
                //client.ClientCredentials.UserName.Password = TxtBxPassword.Text.Trim();
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
                        client.Close();
                        return JObject.Parse(data);
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
                return null;
            }
        }
    }
}
