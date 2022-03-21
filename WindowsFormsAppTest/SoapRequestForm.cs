using System;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class SoapRequestForm : Form
    {
        public SoapRequestForm()
        {
            InitializeComponent();
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
            if (host.ToLower().Contains("CrmService.svc"))
            { return new EndpointAddress(host); }
            if (endPointString.Last() != '/')
            {
                endPointString += '/';
            }
            endPointString = endPointString + endPointName;

            EndpointAddress epa = new EndpointAddress(endPointString);
            return epa;
        }

        private WebserviceYouri.CrmServiceClient NewCrmService(string host)
        {
            BasicHttpBinding binding = CreateBinding("CrmService");
            EndpointAddress epa = CreateEndpointAddress(host, "CrmService.svc");

            return new WebserviceYouri.CrmServiceClient(binding, epa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
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
                using (WebserviceYouri.CrmServiceClient client = NewCrmService(host))
                {
                    string testResultaat = "Geen verbinding mogelijk.";

                    try
                    {
                        client.Open();
                        WebserviceYouri.RequestSearch RequestSearch = new WebserviceYouri.RequestSearch();
                        RequestSearch.ZoekString = "a";
                        WebserviceYouri.RelatieLijstModel relatieLijstModel = client.GetFilterdListProject(RequestSearch);

                        //string result = client.GetVersion();

                        testResultaat = "Er is een beveiligde verbinding gemaakt met de Crmservice ..." + Environment.NewLine;
                        testResultaat += "\r\nURL: " + CreateEndpointAddress(host, "crmservice.svc").Uri + Environment.NewLine;
                        //testResultaat = testResultaat + Environment.NewLine + result;
                        testResultaat = testResultaat + Environment.NewLine + relatieLijstModel;

                        client.Close();
                    }
                    catch (Exception ex)
                    {
                        testResultaat = "Fout bij verbinden met server van http Crmservice , melding: " + Environment.NewLine + ex.Message;
                    }

                    txtTestResultaat.Text = txtTestResultaat.Text + testResultaat + Environment.NewLine;

                }
            }
            catch (UriFormatException exes)
            {
                Console.WriteLine(exes);
            }

            txtTestResultaat.Text = txtTestResultaat.Text.Replace("\n ", "\r\n");
        }
    }
}
