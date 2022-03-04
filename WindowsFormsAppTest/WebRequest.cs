﻿using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
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

        public string GetWebRequest(int id, string urlHttp, string url, string securityId = "")
        {
            string webRequestUrl = urlHttp + url + securityId;
            Uri uri = new Uri(webRequestUrl);
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(webRequestUrl) as HttpWebRequest;
                X509Certificate cert = request.ServicePoint.Certificate;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    int statusCode = (int)response.StatusCode;
                    if (statusCode >= 100 && statusCode < 400) //Good requests
                    {
                        string data = _wc.DownloadString(uri);
                        if (data.Count(d => d == '{') > 1)
                        {
                            int Pos1 = data.IndexOf('{');
                            int Pos2 = data.IndexOf("}");
                            data = data.Substring(Pos1 + 2, Pos2 - Pos1 - 1);
                        }
                        if (securityId != string.Empty)
                        {
                            int Pos1 = data.IndexOf('{');
                            int Pos2 = data.IndexOf('}');
                            data = data.Substring(Pos1 + 1, Pos2 - Pos1 - 1);
                            return "{" + data + ", id: '" + id + "', certVerValDatum: '" + cert.GetExpirationDateString().ToString() + "'}";
                        }
                        else
                        {
                            return getDataOfWebRequest(data);
                        }
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

        private string getDataOfWebRequest(string data)
        {
            positionKraanDll = data.IndexOf("KraanDLL");
            positionKraanIni = data.IndexOf("Kraan.ini");
            positionDatabaseConnect = data.IndexOf("Database connectie");
            positionDatabaseMelding = data.IndexOf("Database melding");

            webserviceVersie = data.Substring(0, positionKraanDll);
            kraanDll = data.Substring(positionKraanDll, positionKraanIni - positionKraanDll);
            kraanIni = data.Substring(positionKraanIni, positionDatabaseConnect - positionKraanIni);
            kraanDatabase = data.Substring(positionDatabaseConnect, positionDatabaseMelding - positionDatabaseConnect);

            return @"{ WebserviceVersie: '" + webserviceVersie + "', KraanDll: '" + kraanDll + "', KraanIni: '" + kraanIni + "', KraanDatabase: '" + kraanDatabase + "'}";
        }
    }
}
