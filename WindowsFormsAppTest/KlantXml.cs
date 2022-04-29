using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    class KlantXml
    {
        private string _path = @"D://db.xml";

        public List<Klant> GetKlanten()
        {
            XDocument doc = XDocument.Load(_path);
            List<Klant> klanten = new List<Klant>();
            var serializer = new XmlSerializer(typeof(Klant));
            foreach (XElement element in doc.Descendants("Klant").ToList())
            {
                klanten.Add((Klant)serializer.Deserialize(element.CreateReader()));
            }
            return klanten;
        }

        public List<Klant> GetKlantenByName(string naam)
        {
            List<Klant> AlleKlanten = GetKlanten();
            return AlleKlanten.FindAll(k => k.Name.Contains(naam));
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
