using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    class WebserviceXml
    {
        private string _path = @"D://db.xml";
        public List<WebService> GetWebservices()
        {
            XDocument doc = XDocument.Load(_path);
            List<WebService> webservices = new List<WebService>();

            foreach (XElement element in doc.Descendants("Webservice"))
            {
                WebService newWebservice = new WebService();
                newWebservice.Id = Guid.Parse(element.Attribute("Id").Value);
                newWebservice.Name = element.Attribute("Name").Value;
                newWebservice.Soap = bool.Parse(element.Attribute("Soap").Value);
                webservices.Add(newWebservice);
            }
            return webservices;
        }

        public List<WebService> GetWebservicesByName(string naam)
        {
            List<WebService> AlleKWebservices = GetWebservices();
            return AlleKWebservices.FindAll(w => w.Name.Contains(naam));
        }

        public WebService GetKlantenByTheSameName(string naam)
        {
            List<WebService> AlleKWebservices = GetWebservices();
            return AlleKWebservices.Find(w => w.Name.Equals(naam));
        }

        public List<WebService> GetWebservicesById(Guid id)
        {
            XDocument doc = XDocument.Load(_path);
            List<WebService> webservices = new List<WebService>();
            foreach (XElement element in doc.Descendants("Webservice").Where(k => Guid.Parse(k.Attribute("Id").Value) == id))
            {
                WebService newWebservice = new WebService();
                newWebservice.Id = Guid.Parse(element.Attribute("Id").Value);
                newWebservice.Name = element.Attribute("Name").Value;
                newWebservice.Soap = bool.Parse(element.Attribute("Soap").Value);
                webservices.Add(newWebservice);
            }
            return webservices;
        }

        public void AddWebservice(WebService webService)
        {
            XDocument doc = XDocument.Load(_path);
            List<WebService> webservices = new List<WebService>();
            webservices.Add(webService);
            doc.Element("DB").Element("Webservices").Add(new XElement("Webservice",
                                                     new XAttribute("Id", webService.Id),
                                                     new XAttribute("Name", webService.Name),
                                                     new XAttribute("Soap", webService.Soap)));
            SaveXmlFile(doc);
        }

        public void UpdateWebservice(Guid id, WebService webService)
        {
            XDocument doc = XDocument.Load(_path);
            XElement xmlKlant = doc.Element("DB").Element("Webservices").Elements("Webservice").FirstOrDefault(p => Guid.Parse(p.Attribute("Id").Value) == id);
            xmlKlant.Attribute("Name").Value = webService.Name;
            xmlKlant.Attribute("Soap").Value = webService.Soap.ToString();
            SaveXmlFile(doc);
        }

        public void DeleteWebservice(Guid id)
        {
            XDocument doc = XDocument.Load(_path);
            XElement xmlWebservice = doc.Element("DB").Element("Webservices").Elements("Webservice").FirstOrDefault(p => Guid.Parse(p.Attribute("Id").Value) == id);
            xmlWebservice.Remove();
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
