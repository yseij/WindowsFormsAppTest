using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace WindowsFormsAppTest
{
    class KlantXml
    {
        private string _path = Properties.Settings.Default["PlaceDb"].ToString();

        public List<Klant> GetKlanten()
        {
            XDocument doc = XDocument.Load(_path);
            List<Klant> klanten = new List<Klant>();

            foreach (XElement element in doc.Descendants("Klant"))
            {
                Klant newKlant = new Klant();
                newKlant.Id = Guid.Parse(element.Attribute("Id").Value);
                newKlant.Name = element.Attribute("Name").Value;
                newKlant.BasisUrl1 = element.Attribute("BasisUrl1").Value;
                newKlant.BasisUrl2 = element.Attribute("BasisUrl2").Value;
                klanten.Add(newKlant);
            }
            return klanten;
        }

        public List<Klant> GetKlantenByName(string naam)
        {
            List<Klant> AlleKlanten = GetKlanten();
            return AlleKlanten.FindAll(k => k.Name.Contains(naam));
        }

        public Klant GetKlantenByTheSameName(string naam)
        {
            List<Klant> AlleKlanten = GetKlanten();
            return AlleKlanten.Find(k => k.Name.Equals(naam));
        }

        public Klant GetKlantenById(Guid id)
        {
            List<Klant> AlleKlanten = GetKlanten();
            return AlleKlanten.Find(k => k.Id == id);
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
            SaveXmlFile(doc);
        }

        public void UpdateKlant(Guid id, Klant klant)
        {
            XDocument doc = XDocument.Load(_path);
            XElement xmlKlant = doc.Element("DB").Element("Klanten").Elements("Klant").FirstOrDefault(p => Guid.Parse(p.Attribute("Id").Value) == id);
            xmlKlant.Attribute("Name").Value = klant.Name;
            xmlKlant.Attribute("BasisUrl1").Value = klant.BasisUrl1;
            xmlKlant.Attribute("BasisUrl2").Value = klant.BasisUrl2;
            SaveXmlFile(doc);
        }

        public void DeleteKlant(Guid id)
        {
            XDocument doc = XDocument.Load(_path);
            XElement xmlKlant = doc.Element("DB").Element("Klanten").Elements("Klant").FirstOrDefault(p => Guid.Parse(p.Attribute("Id").Value) == id);
            xmlKlant.Remove();
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
