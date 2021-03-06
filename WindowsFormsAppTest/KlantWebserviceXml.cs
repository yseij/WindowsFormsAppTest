using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace WindowsFormsAppTest
{
    class KlantWebserviceXml
    {
        private string _path = Properties.Settings.Default["PlaceDb"].ToString();

        public List<KlantWebservice> GetAll()
        {
            List<KlantWebservice> klantWebservices = new List<KlantWebservice>();

            XDocument doc = XDocument.Load(_path);
            IEnumerable<XElement> elements = doc.Descendants("KlantWebservice");
            foreach (XElement element in elements)
            {
                KlantWebservice newKlantWebservice = new KlantWebservice();
                newKlantWebservice.Id = Guid.Parse(element.Attribute("Id").Value);
                newKlantWebservice.Klant = Guid.Parse(element.Attribute("Klant").Value);
                newKlantWebservice.Webservice = Guid.Parse(element.Attribute("Webservice").Value);
                newKlantWebservice.BasisUrl1 = bool.Parse(element.Attribute("BasisUrl1").Value);
                newKlantWebservice.BasisUrl2 = bool.Parse(element.Attribute("BasisUrl2").Value);
                klantWebservices.Add(newKlantWebservice);
            }
            return klantWebservices;
        }

        public KlantWebservice GetByKlantWebserviceId(Guid id)
        {
            XDocument doc = XDocument.Load(_path);
            XElement element = doc.Element("DB").Element("KlantWebservices").Elements("KlantWebservice")
            .FirstOrDefault(p => Guid.Parse(p.Attribute("Id").Value) == id);
            KlantWebservice newKlantWebservice = new KlantWebservice();
            newKlantWebservice.Id = Guid.Parse(element.Attribute("Id").Value);
            newKlantWebservice.Klant = Guid.Parse(element.Attribute("Klant").Value);
            newKlantWebservice.Webservice = Guid.Parse(element.Attribute("Webservice").Value);
            newKlantWebservice.BasisUrl1 = bool.Parse(element.Attribute("BasisUrl1").Value);
            newKlantWebservice.BasisUrl2 = bool.Parse(element.Attribute("BasisUrl2").Value);
            return newKlantWebservice;
        }

        public List<KlantWebservice> GetByKlant(Guid klantId)
        {
            List<KlantWebservice> klantWebservices = new List<KlantWebservice>();

            XDocument doc = XDocument.Load(_path);
            IEnumerable<XElement> elements = doc.Element("DB").Element("KlantWebservices").Elements("KlantWebservice")
                .Where(p => Guid.Parse(p.Attribute("Klant").Value) == klantId);
            foreach (XElement element in elements)
            {
                KlantWebservice newKlantWebservice = new KlantWebservice();
                newKlantWebservice.Id = Guid.Parse(element.Attribute("Id").Value);
                newKlantWebservice.Klant = Guid.Parse(element.Attribute("Klant").Value);
                newKlantWebservice.Webservice = Guid.Parse(element.Attribute("Webservice").Value);
                newKlantWebservice.BasisUrl1 = bool.Parse(element.Attribute("BasisUrl1").Value);
                newKlantWebservice.BasisUrl2 = bool.Parse(element.Attribute("BasisUrl2").Value);
                klantWebservices.Add(newKlantWebservice);
            }
            return klantWebservices;
        }

        public List<KlantWebservice> GetByWebservice(Guid webserviceId)
        {
            List<KlantWebservice> klantWebservices = new List<KlantWebservice>();

            XDocument doc = XDocument.Load(_path);
            IEnumerable<XElement> elements = doc.Element("DB").Element("KlantWebservices").Elements("KlantWebservice")
                .Where(p => Guid.Parse(p.Attribute("Webservice").Value) == webserviceId);
            foreach (XElement element in elements)
            {
                KlantWebservice newKlantWebservice = new KlantWebservice();
                newKlantWebservice.Id = Guid.Parse(element.Attribute("Id").Value);
                newKlantWebservice.Klant = Guid.Parse(element.Attribute("Klant").Value);
                newKlantWebservice.Webservice = Guid.Parse(element.Attribute("Webservice").Value);
                newKlantWebservice.BasisUrl1 = bool.Parse(element.Attribute("BasisUrl1").Value);
                newKlantWebservice.BasisUrl2 = bool.Parse(element.Attribute("BasisUrl2").Value);
                klantWebservices.Add(newKlantWebservice);
            }
            return klantWebservices;
        }

        public KlantWebservice GetByKlantAndByWebservice(Guid klantId, Guid webserviceId)
        {
            XDocument doc = XDocument.Load(_path);
            XElement element = doc.Element("DB").Element("KlantWebservices").Elements("KlantWebservice")
                .FirstOrDefault(p => Guid.Parse(p.Attribute("Klant").Value) == klantId && Guid.Parse(p.Attribute("Webservice").Value) == webserviceId);
            if (element != null)
            {
                KlantWebservice newKlantWebservice = new KlantWebservice();
                newKlantWebservice.Id = Guid.Parse(element.Attribute("Id").Value);
                newKlantWebservice.Klant = Guid.Parse(element.Attribute("Klant").Value);
                newKlantWebservice.Webservice = Guid.Parse(element.Attribute("Webservice").Value);
                newKlantWebservice.BasisUrl1 = bool.Parse(element.Attribute("BasisUrl1").Value);
                newKlantWebservice.BasisUrl2 = bool.Parse(element.Attribute("BasisUrl2").Value);
                return newKlantWebservice;
            }
            return null;
        }

        public void AddKlantWebservice(KlantWebservice klantWebservice)
        {
            XDocument doc = XDocument.Load(_path);
            doc.Element("DB").Element("KlantWebservices").Add(new XElement("KlantWebservice",
                                                     new XAttribute("Id", klantWebservice.Id),
                                                     new XAttribute("Klant", klantWebservice.Klant),
                                                     new XAttribute("Webservice", klantWebservice.Webservice),
                                                     new XAttribute("BasisUrl1", klantWebservice.BasisUrl1),
                                                     new XAttribute("BasisUrl2", klantWebservice.BasisUrl2)));
            SaveXmlFile(doc);
        }

        public void UpdateKlantWebservice(Guid klantId, Guid webserviceId, KlantWebservice klantWebservice)
        {
            XDocument doc = XDocument.Load(_path);
            XElement xmlKlant = doc.Element("DB").Element("KlantWebservices").Elements("KlantWebservice")
                .FirstOrDefault(p => Guid.Parse(p.Attribute("Klant").Value) == klantId && Guid.Parse(p.Attribute("Webservice").Value) == webserviceId);
            xmlKlant.Attribute("Klant").Value = klantWebservice.Klant.ToString();
            xmlKlant.Attribute("Webservice").Value = klantWebservice.Webservice.ToString();
            xmlKlant.Attribute("BasisUrl1").Value = klantWebservice.BasisUrl1.ToString();
            xmlKlant.Attribute("BasisUrl2").Value = klantWebservice.BasisUrl2.ToString();
            SaveXmlFile(doc);
        }

        public void DeleteByKlantWebservice(Guid id)
        {
            XDocument doc = XDocument.Load(_path);
            IEnumerable<XElement> xmlKlanten = doc.Element("DB").Element("KlantWebservices").Elements("KlantWebservice").Where(p => Guid.Parse(p.Attribute("Id").Value) == id);
            xmlKlanten.Remove();
            SaveXmlFile(doc);
        }

        public void DeleteByKlant(Guid id)
        {
            XDocument doc = XDocument.Load(_path);
            IEnumerable<XElement> xmlKlanten = doc.Element("DB").Element("KlantWebservices").Elements("KlantWebservice").Where(p => Guid.Parse(p.Attribute("Klant").Value) == id);
            xmlKlanten.Remove();
            SaveXmlFile(doc);
        }

        public void DeleteByWebservice(Guid id)
        {
            XDocument doc = XDocument.Load(_path);
            IEnumerable<XElement> xmlWebservice = doc.Element("DB").Element("KlantWebservices").Elements("KlantWebservice").Where(p => Guid.Parse(p.Attribute("Webservice").Value) == id);
            xmlWebservice.Remove();
            SaveXmlFile(doc);
        }

        public void DeleteByKlantAndByWebservice(Guid klantId, Guid webserviceId)
        {
            XDocument doc = XDocument.Load(_path);
            XElement xmlKlantAndWebservice = doc.Element("DB").Element("KlantWebservices").Elements("KlantWebservice")
                .FirstOrDefault(p => Guid.Parse(p.Attribute("Klant").Value) == klantId && Guid.Parse(p.Attribute("Webservice").Value) == webserviceId);
            xmlKlantAndWebservice.Remove();
            SaveXmlFile(doc);
        }

        private void SaveXmlFile(XDocument doc)
        {
            try
            {
                doc.Save(_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string sourcePath = Properties.Settings.Default.StartUpPathDb;
                string desPath = Properties.Settings.Default.PlaceSelfDb + "/db.xml";
                File.Copy(sourcePath, desPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
