using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace WindowsFormsAppTest
{
    class KlantXml
    {
        private string _path = @"D://db.xml";

        public List<XElement> GetKlanten()
        {
            XDocument doc = XDocument.Load(_path);
            return doc.Descendants("Klant").ToList();
        }

        public void AddKlant(Klant klant)
        {
            XDocument doc = XDocument.Load(_path);
            List<Klant> klanten = new List<Klant>();
            klanten.Add(klant);
            doc.Element("DB").Element("Klanten").Add(new XElement("Klant",
                                                     new XAttribute("Id", klant.Id),
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
    }
}
