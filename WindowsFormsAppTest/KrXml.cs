using System;
using System.IO;
using System.Xml;

namespace WindowsFormsAppTest
{
    class KrXml
    {
        private string _xmlUrlId = "Id";
        private string _xmlUrlName = "Name";
        private string _xmlUrlSecurityId = "SecurityId";
        private string _xmlUrlHttpDataId = "HttpDataId";
        private string _xmlUrlWebserviceDataId = "WebserviceDataId";
        private string _xmlUrlKlantDataId = "KlantDataId";
        public KrXml()
        {

        }

        public void MakeXmlFile(string path)
        {
            if (!File.Exists(path))
            {
                using (XmlWriter writer = XmlWriter.Create(path))
                {
                    writer.WriteStartElement("db");
                    writer.WriteStartElement("Klanten");
                    writer.WriteEndElement();
                    writer.WriteStartElement("Webservices");
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }


        public void AddUrl(string path, UrlData urlData)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode aNode = doc.SelectSingleNode("descendant::db");
            XmlNode bNode = doc.CreateNode("element", "Urls", "");
            XmlNode cNode = doc.CreateNode("element", "", "");
            aNode.AppendChild(bNode);
            aNode.AppendChild(cNode);

            //XmlNode bNode = doc.CreateNode("element", "Url", "");
            //aNode.AppendChild(bNode);

            //string newId = GetLatestNode(aNode).ToString();

            //MakeElem(doc, bNode, _xmlUrlId, newId);
            //MakeElem(doc, bNode, _xmlUrlName, urlData.Name);
            //MakeElem(doc, bNode, _xmlUrlSecurityId, urlData.SecurityId);
            //MakeElem(doc, bNode, _xmlUrlHttpDataId, urlData.HttpDataId.ToString());
            //MakeElem(doc, bNode, _xmlUrlWebserviceDataId, urlData.WebServiceDataId.ToString());
            //MakeElem(doc, bNode, _xmlUrlKlantDataId, urlData.KlantDataId.ToString());
            //doc.Save(path);
        }

        public void AddWebservice(string path, WebServiceData webServiceData)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode aNode = doc.SelectSingleNode("Webservices");

            XmlElement elem = doc.CreateElement("Webservice");
            aNode.AppendChild(elem);

            string newId = GetLatestNode(aNode).ToString();

            MakeElem(doc, elem, _xmlUrlId, newId);
            MakeElem(doc, elem, _xmlUrlName, webServiceData.Name);
            MakeElem(doc, elem, _xmlUrlSecurityId, webServiceData.Soap.ToString());
        }

        public void AddKlant(string path, UrlData urlData)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode aNode = doc.SelectSingleNode("Klanten");

            XmlElement elem = doc.CreateElement("Klant");
            aNode.AppendChild(elem);

            string newId = GetLatestNode(aNode).ToString();

            MakeElem(doc, elem, _xmlUrlName, newId);
            MakeElem(doc, elem, _xmlUrlName, urlData.Name);
            MakeElem(doc, elem, _xmlUrlSecurityId, urlData.SecurityId);
            MakeElem(doc, elem, _xmlUrlHttpDataId, urlData.HttpDataId.ToString());
            MakeElem(doc, elem, _xmlUrlWebserviceDataId, urlData.WebServiceDataId.ToString());
            MakeElem(doc, elem, _xmlUrlKlantDataId, urlData.KlantDataId.ToString());
        }

        private void MakeElem(XmlDocument doc, XmlNode aNode, string soort, string waarde)
        {
            XmlElement elem = doc.CreateElement(soort);
            elem.InnerText = waarde;
            aNode.AppendChild(elem);
        }

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
