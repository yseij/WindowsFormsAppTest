using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace WindowsFormsAppTest
{
    class KlantWebserviceXml
    {
        private string _path = @"D://db.xml";

        public void AddKlantWebservice(KlantWebservice klantWebservice)
        {
            XDocument doc = XDocument.Load(_path); ;
            doc.Element("DB").Element("KlantWebservices").Add(new XElement("KlantWebservice",
                                                     new XAttribute("Id", klantWebservice.Id),
                                                     new XAttribute("Klant", klantWebservice.Klant),
                                                     new XAttribute("Webservice", klantWebservice.Webservice),
                                                     new XAttribute("BasisUrl1", klantWebservice.BasisUrl1),
                                                     new XAttribute("BasisUrl2", klantWebservice.BasisUrl2)));
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
