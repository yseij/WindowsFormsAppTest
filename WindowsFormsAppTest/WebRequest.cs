using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

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

        WebClient _wc;

        public WebRequest()
        {
            _wc = new WebClient();
        }

        public class DataObject
        {
            public string Name { get; set; }
        }

        public string GetWebRequest(int id, string urlHttp, string url, string securityId = "")
        {
            string webRequestUrl = urlHttp + url + securityId;
            //string webRequestUrl = "http://www.djseyo.be";
            Uri uri = new Uri(webRequestUrl);
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(webRequestUrl) as HttpWebRequest;
                //request.ServerCertificateValidationCallback += ServerCertificateValidationCallback;
                X509Certificate cert = request.ServicePoint.Certificate;
                HttpClient client = new HttpClient();
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
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
                                if (cert != null)
                                {
                                    return getDataOfWebRequest(data, cert.GetExpirationDateString().ToString());
                                }
                                else
                                {
                                    return getDataOfWebRequest(data, "");
                                }
                            }
                            int Pos1 = data.IndexOf('{');
                            int Pos2 = data.IndexOf('}');
                            data = data.Substring(Pos1 + 1, Pos2 - Pos1 - 1);
                            if (cert != null)
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

        private string getDataOfWebRequest(string data, string verValDatum = "")
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

        private static bool ServerCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            //see: https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509certificate.getexpirationdatestring?view=netcore-3.1#remarks
            //Make sure we parse the DateTime.Parse(expirationdate) the same as GetExpirationDateString() does.
            Console.WriteLine("test");
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var expirationDate = DateTime.Parse(certificate.GetExpirationDateString(), CultureInfo.InvariantCulture);
            if (expirationDate - DateTime.Today < TimeSpan.FromDays(30))
            {
                throw new Exception("Time to renew the certificate!");
            }
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                return true;
            }
            else
            {
                throw new Exception("Cert policy errors: " + sslPolicyErrors.ToString());
            }
        }
    }
}
