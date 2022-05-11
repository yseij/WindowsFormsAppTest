using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace WindowsFormsAppTest
{
    class UrlXml
    {
        private string _path = Properties.Settings.Default["PlaceDb"].ToString();

        public List<Url> GetAll()
        {
            List<Url> urls = new List<Url>();

            XDocument doc = XDocument.Load(_path);
            IEnumerable<XElement> elements = doc.Descendants("Url");
            foreach (XElement element in elements)
            {
                Url newUrl = new Url();
                newUrl.Id = Guid.Parse(element.Attribute("Id").Value);
                newUrl.Name = element.Attribute("Name").Value;
                newUrl.KlantId = Guid.Parse(element.Attribute("KlantId").Value);
                newUrl.WebserviceId = Guid.Parse(element.Attribute("WebserviceId").Value);
                urls.Add(newUrl);
            }
            return urls;
        }
        public List<Url> GetByKlantId(Guid klantId)
        {
            List<Url> urls = new List<Url>();

            XDocument doc = XDocument.Load(_path);
            IEnumerable<XElement> elements = doc.Element("DB").Element("Urls").Elements("Url")
                .Where(p => Guid.Parse(p.Attribute("KlantId").Value) == klantId);
            foreach (XElement element in elements)
            {
                Url newUrl = new Url();
                newUrl.Id = Guid.Parse(element.Attribute("Id").Value);
                newUrl.Name = element.Attribute("Name").Value;
                newUrl.KlantId = Guid.Parse(element.Attribute("KlantId").Value);
                newUrl.WebserviceId = Guid.Parse(element.Attribute("WebserviceId").Value);
                urls.Add(newUrl);
            }
            return urls;
        }

        public List<Url> GetByWebserviceId(Guid webserviceId)
        {
            List<Url> urls = new List<Url>();

            XDocument doc = XDocument.Load(_path);
            IEnumerable<XElement> elements = doc.Element("DB").Element("Urls").Elements("Url")
                .Where(p => Guid.Parse(p.Attribute("WebserviceId").Value) == webserviceId);
            foreach (XElement element in elements)
            {
                Url newUrl = new Url();
                newUrl.Id = Guid.Parse(element.Attribute("Id").Value);
                newUrl.Name = element.Attribute("Name").Value;
                newUrl.KlantId = Guid.Parse(element.Attribute("KlantId").Value);
                newUrl.WebserviceId = Guid.Parse(element.Attribute("WebserviceId").Value);
                urls.Add(newUrl);
            }
            return urls;
        }

        public Url GetByKlantAndName(Guid klantId, string name)
        {
            XDocument doc = XDocument.Load(_path);
            XElement element = doc.Element("DB").Element("Urls").Elements("Url")
                .FirstOrDefault(p => Guid.Parse(p.Attribute("KlantId").Value) == klantId && p.Attribute("Name").Value == name);
            Url newUrl = new Url();
            if (element != null)
            {
                newUrl.Id = Guid.Parse(element.Attribute("Id").Value);
                newUrl.Name = element.Attribute("Name").Value;
                newUrl.KlantId = Guid.Parse(element.Attribute("KlantId").Value);
                newUrl.WebserviceId = Guid.Parse(element.Attribute("WebserviceId").Value);
                return newUrl;
            }
            return null;
        }

        public void AddUrl(Url url)
        {
            XDocument doc = XDocument.Load(_path);
            doc.Element("DB").Element("Urls").Add(new XElement("Url",
                                                  new XAttribute("Id", url.Id),
                                                  new XAttribute("Name", url.Name),
                                                  new XAttribute("KlantId", url.KlantId),
                                                  new XAttribute("WebserviceId", url.WebserviceId)));
            SaveXmlFile(doc);
        }

        public void DeleteUrl(Guid id)
        {
            XDocument doc = XDocument.Load(_path);
            XElement xmlUrl = doc.Element("DB").Element("Urls").Elements("Url").FirstOrDefault(p => Guid.Parse(p.Attribute("Id").Value) == id);
            xmlUrl.Remove();
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
        }
    }
}
