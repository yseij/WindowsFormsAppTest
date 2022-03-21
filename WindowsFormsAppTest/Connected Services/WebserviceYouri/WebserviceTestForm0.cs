
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Kraan.Sales.ConnectionTester
{
    public partial class WebserviceTestForm0 : Form
    {
        public WebserviceTestForm0()
        {
            InitializeComponent();

        }

        private void WebserviceTestForm_Load(object sender, EventArgs e)
        {

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



        private void buttonTestSecure_Click(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            txtTestResultaat.Text = "Verbinding wordt getest..." + Environment.NewLine + Environment.NewLine;
            txtTestResultaat.Refresh();

            string host = textBoxHost.Text.Trim();



            if (String.IsNullOrWhiteSpace(host))
            {
                host = "localhost";
                textBoxHost.Text = host;
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
                    if (!String.IsNullOrWhiteSpace(TextBoxUsername.Text.Trim()))
                    {
                        using (Sales31.MessageServiceSoapClient client = NewSales31Client(host))
                        {
                            string testResultaat = "Geen beveiligde verbinding mogelijk.\r\n";
                            client.ClientCredentials.UserName.UserName = TextBoxUsername.Text.Trim();
                            client.ClientCredentials.UserName.Password = textBoxPassword.Text.Trim();
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

        private void WebserviceTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {


            //Properties.Settings.Default.hostName = textBoxHost.Text;
            //    Properties.Settings.Default.Save();
        }

        private void labelHttpsText_Click(object sender, EventArgs e)
        {

        }
    }
}
