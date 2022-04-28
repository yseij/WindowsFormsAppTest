using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    class KrXml
    {
        public KrXml()
        {

        }

        public void MakeXmlFile(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DB));
            TextWriter writer = new StreamWriter("D://db.xml");
            DB db = new DB();

            Klant klant = new Klant(2, "klant 1", "https://test.be", "test");
            List<Klant> klanten = new List<Klant>();
            klanten.Add(klant);
            db.Klanten = klanten;

            WebService webService = new WebService(3, "KraanHomeDna", false);
            List<WebService> webservices = new List<WebService>();
            webservices.Add(webService);
            db.Webservices = webservices;

            KlantWebservice klantWebservice = new KlantWebservice(4, klant.Id, webService.Id, true, false);
            List<KlantWebservice> klantWebservices = new List<KlantWebservice>();
            klantWebservices.Add(klantWebservice);
            db.KlantWebservices = klantWebservices;

            serializer.Serialize(writer, db);
        }

        //public void AddUrl(string path, UrlData urlData)
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(path);
        //    XmlNode aNode = doc.SelectSingleNode("descendant::db[Urls]");
        //    XmlNode cNode = doc.CreateNode("element", "Url", "");
        //    aNode.AppendChild(cNode);

        //    string newId = GetLatestNode(aNode).ToString();

        //    MakeElem(doc, cNode, _xmlUrlId, newId);
        //    MakeElem(doc, cNode, _xmlUrlName, urlData.Name);
        //    MakeElem(doc, cNode, _xmlUrlSecurityId, urlData.SecurityId);
        //    doc.Save(path);
        //}

        //public void AddWebservice(string path, WebService webServiceData)
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(path);
        //    XmlNode aNode = doc.SelectSingleNode("Webservices");

        //    XmlElement elem = doc.CreateElement("Webservice");
        //    aNode.AppendChild(elem);

        //    string newId = GetLatestNode(aNode).ToString();

        //    MakeElem(doc, elem, _xmlUrlId, newId);
        //    MakeElem(doc, elem, _xmlUrlName, webServiceData.Name);
        //    MakeElem(doc, elem, _xmlUrlSecurityId, webServiceData.Soap.ToString());
        //}

        //public void AddKlant(string path, UrlData urlData)
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(path);
        //    XmlNode aNode = doc.SelectSingleNode("Klanten");

        //    XmlElement elem = doc.CreateElement("Klant");
        //    aNode.AppendChild(elem);

        //    string newId = GetLatestNode(aNode).ToString();

        //    MakeElem(doc, elem, _xmlUrlName, newId);
        //    MakeElem(doc, elem, _xmlUrlName, urlData.Name);
        //    MakeElem(doc, elem, _xmlUrlSecurityId, urlData.SecurityId);
        //}

        //private void MakeElem(XmlDocument doc, XmlNode aNode, string soort, string waarde)
        //{
        //    XmlElement elem = doc.CreateElement(soort);
        //    elem.InnerText = waarde;
        //    aNode.AppendChild(elem);
        //}

        //private void MakeElemWebservice(XmlDocument doc, XmlNode aNode, string soort, string waarde)
        //{
        //    XmlElement elem = doc.CreateElement(soort);
        //    elem.InnerText = waarde
        //    aNode.AppendChild(elem);
        //}

        //private void MakeElemKlant(XmlDocument doc, XmlNode aNode, string soort, bool soap, string naam = "")
        //{
        //    XmlElement elem = doc.CreateElement(soort);
        //    elem.InnerText = naam ?? soap.ToString();
        //    aNode.AppendChild(elem);
        //}

        private int GetLatestNode(XmlNode aNode)
        {
            XmlNodeList bNodes = aNode.ChildNodes[aNode.ChildNodes.Count - 1].ChildNodes;
            foreach (XmlNode bNode in bNodes)
            {
                if (bNode.Name == "Id")
                {
                    return Int32.Parse(bNode.InnerText) + 1;
                }
            }
            return 0 + 1;
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
