using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    class KrXml
    {
        private string _path = @"D://db.xml";
        public KrXml()
        {

        }

        public void MakeXmlFile(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DB));
            TextWriter writer = new StreamWriter(_path);
            DB db = new DB();

            Klant klant1 = new Klant("klant 1", "https://test.be", "test");
            Klant klant2 = new Klant("klant 2", "https://test.be", "test");
            Klant klant3 = new Klant("klant 3", "https://test.be", "test");
            List<Klant> klanten = new List<Klant>();
            klanten.Add(klant1);
            klanten.Add(klant2);
            klanten.Add(klant3);
            db.Klanten = klanten;

            WebService webService = new WebService("KraanHomeDna", false);
            List<WebService> webservices = new List<WebService>();
            webservices.Add(webService);
            db.Webservices = webservices;

            KlantWebservice klantWebservice1 = new KlantWebservice(klant1.Id, webService.Id, true, false);
            KlantWebservice klantWebservice2 = new KlantWebservice(klant2.Id, webService.Id, true, false);
            KlantWebservice klantWebservice3 = new KlantWebservice(klant3.Id, webService.Id, true, false);
            List<KlantWebservice> klantWebservices = new List<KlantWebservice>();
            klantWebservices.Add(klantWebservice1);
            klantWebservices.Add(klantWebservice2);
            klantWebservices.Add(klantWebservice3);
            db.KlantWebservices = klantWebservices;

            serializer.Serialize(writer, db);
            writer.Close();
        }

        public void AddKlant(Klant klant)
        {
            XDocument doc = XDocument.Load(_path);
            List<Klant> klanten = new List<Klant>();
            klanten.Add(klant);
            doc.Element("DB").Element("Klanten").Add(new XElement("Klant", 
                                                     new XAttribute("id", klant.Id), 
                                                     new XAttribute("Name", klant.Name),
                                                     new XAttribute("BasisUrl1", klant.BasisUrl1), 
                                                     new XAttribute("BasisUrl2", klant.BasisUrl2)));
            try
            {
                doc.Save(_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void AddWebservice(WebService webService)
        {
            XDocument doc = XDocument.Load(_path);
            List<WebService> webservices = new List<WebService>();
            webservices.Add(webService);
            doc.Element("DB").Element("Webservices").Add(new XElement("Webservice",
                                                     new XAttribute("id", webService.Id),
                                                     new XAttribute("Name", webService.Name),
                                                     new XAttribute("Soap", webService.Soap)));
            doc.Save(_path);
        }

        public void AddKlantWebservice(KlantWebservice klantWebservice)
        {
            XDocument doc = XDocument.Load(_path);;
            doc.Element("DB").Element("KlantWebservices").Add(new XElement("KlantWebservice",
                                                     new XAttribute("id", klantWebservice.Id),
                                                     new XAttribute("klant", klantWebservice.Klant),
                                                     new XAttribute("webservice", klantWebservice.Webservice),
                                                     new XAttribute("basisUrl1", klantWebservice.BasisUrl1),
                                                     new XAttribute("basisUrl2", klantWebservice.BasisUrl2)));
            doc.Save(_path);
        }



        public void UpdateXmlFile(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList aNodes = doc.SelectNodes("//*");

            foreach (XmlNode aNode in aNodes)
            {
                switch (aNode.Name)
                {
                    case "ServiceAanOfUit":
                        aNode.FirstChild.Value = Properties.Settings.Default.ServiceAanOfUit;
                        break;
                    case "TijdService":
                        aNode.FirstChild.Value = Properties.Settings.Default.TijdService;
                        break;
                    case "SaveLogFilePlace":
                        aNode.FirstChild.Value = Properties.Settings.Default.SaveLogFilePlace;
                        break;
                    case "Email":
                        aNode.FirstChild.Value = Properties.Settings.Default.Email;
                        break;
                    case "ServerNaam":
                        aNode.FirstChild.Value = Properties.Settings.Default.ServerNaam;
                        break;
                    default:
                        break;
                }
            }
            doc.Save(path);
        }
    }
}
