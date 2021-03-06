using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace WindowsFormsAppTest
{
    class WebserviceXml
    {
        private string _path = Properties.Settings.Default["PlaceDb"].ToString();
        public List<WebService> GetAll()
        {
            XDocument doc = XDocument.Load(_path);
            List<WebService> webservices = new List<WebService>();

            foreach (XElement element in doc.Descendants("Webservice"))
            {
                WebService newWebservice = new WebService();
                newWebservice.Id = Guid.Parse(element.Attribute("Id").Value);
                newWebservice.Name = element.Attribute("Name").Value;
                newWebservice.Soap = bool.Parse(element.Attribute("Soap").Value);
                newWebservice.SecurityId = element.Attribute("SecurityId").Value;
                webservices.Add(newWebservice);
            }
            return webservices;
        }

        public List<WebService> GetWebservicesByName(string naam)
        {
            List<WebService> AlleKWebservices = GetAll();
            return AlleKWebservices.FindAll(w => w.Name.Contains(naam));
        }

        public WebService GetKlantenByTheSameName(string naam)
        {
            List<WebService> AlleKWebservices = GetAll();
            return AlleKWebservices.Find(w => w.Name.Equals(naam));
        }

        public WebService GetWebserviceById(Guid id)
        {
            XDocument doc = XDocument.Load(_path);
            WebService webservice = new WebService();
            XElement element = doc.Descendants("Webservice").FirstOrDefault(k => Guid.Parse(k.Attribute("Id").Value) == id);
            WebService newWebservice = new WebService();
            newWebservice.Id = Guid.Parse(element.Attribute("Id").Value);
            newWebservice.Name = element.Attribute("Name").Value;
            newWebservice.Soap = bool.Parse(element.Attribute("Soap").Value);
            newWebservice.SecurityId = element.Attribute("SecurityId").Value;
            return newWebservice;
        }

        public void AddWebservice(WebService webService)
        {
            XDocument doc = XDocument.Load(_path);
            List<WebService> webservices = new List<WebService>();
            webservices.Add(webService);
            doc.Element("DB").Element("Webservices").Add(new XElement("Webservice",
                                                     new XAttribute("Id", webService.Id),
                                                     new XAttribute("Name", webService.Name),
                                                     new XAttribute("Soap", webService.Soap),
                                                     new XAttribute("SecurityId", webService.SecurityId)));
            SaveXmlFile(doc);
        }

        public void UpdateWebservice(Guid id, WebService webService)
        {
            XDocument doc = XDocument.Load(_path);
            XElement xmlKlant = doc.Element("DB").Element("Webservices").Elements("Webservice").FirstOrDefault(p => Guid.Parse(p.Attribute("Id").Value) == id);
            xmlKlant.Attribute("Name").Value = webService.Name;
            xmlKlant.Attribute("Soap").Value = webService.Soap.ToString();
            xmlKlant.Attribute("SecurityId").Value = webService.SecurityId.ToString();
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
