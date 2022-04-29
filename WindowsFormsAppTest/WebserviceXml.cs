using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
