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

        public List<WebService> GetWebservicesByName(string name)
        {
            XDocument doc = XDocument.Load(_path);
            List<WebService> webservices = new List<WebService>();
            foreach (XElement element in doc.Descendants("Webservice").Where(k => k.Attribute("Name").Value == name))
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
                                                     new XElement("Id", webService.Id),
                                                     new XElement("Name", webService.Name),
                                                     new XElement("Soap", webService.Soap)));
            doc.Save(_path);
        }

        public void UpdateWebservice(Guid id, Klant klant)
        {
            XDocument doc = XDocument.Load(_path);
            XElement xmlKlant = doc.Element("DB").Element("Klanten").Elements("klant").FirstOrDefault(p => Guid.Parse(p.Attribute("Id").Value) == id);
            xmlKlant.Attribute("Name").Value = klant.Name;
            xmlKlant.Attribute("BasisUrl1").Value = klant.BasisUrl1;
            xmlKlant.Attribute("BasisUrl2").Value = klant.BasisUrl2;

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
