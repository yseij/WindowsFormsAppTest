using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsAppTest
{
    class WebserviceXml
    {
        private string _path = @"D://db.xml";
        public List<XElement> GetWebservices()
        {
            XDocument doc = XDocument.Load(_path);
            return doc.Descendants("Webservice").ToList();
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
            doc.Save(_path);
        }
    }
}
