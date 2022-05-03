﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    class KrXml
    {
        private string _dbPath = @"D:\\db.xml";
        private string _userPath = @"D:\\user.xml";
        public KrXml()
        {

        }

        public void MakeXmlFileDb()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DB));
            TextWriter writer = new StreamWriter(_dbPath);
            DB db = new DB();

            Klant klant1 = new Klant("klant 1", "https://ws.kraan.com:444/", "https://wsdev.kraan.com/test1");
            Klant klant2 = new Klant("klant 2", "https://wsdev.kraan.com/", "https://wsdev.kraan.com/test2");
            Klant klant3 = new Klant("klant 3", "https://wsdev.kraan.com:1234/", "https://wsdev.kraan.com/test3");
            List<Klant> klanten = new List<Klant>();
            klanten.Add(klant1);
            klanten.Add(klant2);
            klanten.Add(klant3);
            db.Klanten = klanten;

            WebService webService1 = new WebService("KraanHomeDna", false, "TEST");
            WebService webService2 = new WebService("KraanSalesService", false, "");
            WebService webService3 = new WebService("Kraan2Webservice", false, "");
            WebService webService4 = new WebService("KraanHomeDNARelease", false, "");
            WebService webService5 = new WebService("KraanHomeDNARelease/HomeDna.svc", false, "");
            List<WebService> webservices = new List<WebService>();
            webservices.Add(webService1);
            webservices.Add(webService2);
            webservices.Add(webService3);
            webservices.Add(webService4);
            webservices.Add(webService5);
            db.Webservices = webservices;

            KlantWebservice klantWebservice1 = new KlantWebservice(klant1.Id, webService1.Id, true, false);
            KlantWebservice klantWebservice2 = new KlantWebservice(klant2.Id, webService1.Id, false, true);
            KlantWebservice klantWebservice3 = new KlantWebservice(klant3.Id, webService2.Id, true, false);
            KlantWebservice klantWebservice4 = new KlantWebservice(klant2.Id, webService4.Id, true, false);
            KlantWebservice klantWebservice5 = new KlantWebservice(klant2.Id, webService5.Id, true, false);
            List<KlantWebservice> klantWebservices = new List<KlantWebservice>();
            klantWebservices.Add(klantWebservice1);
            klantWebservices.Add(klantWebservice2);
            klantWebservices.Add(klantWebservice3);
            klantWebservices.Add(klantWebservice4);
            klantWebservices.Add(klantWebservice5);
            db.KlantWebservices = klantWebservices;

            serializer.Serialize(writer, db);
            writer.Close();
        }

        public void MakeXmlFileUser()
        {
            if (!File.Exists(_userPath))
            {
                try
                {
                    using (XmlWriter writer = XmlWriter.Create(_userPath))
                    {
                        writer.WriteStartElement("Settings");
                        writer.WriteElementString("ServiceAanOfUit", Properties.Settings.Default.ServiceAanOfUit);
                        writer.WriteElementString("TijdService", Properties.Settings.Default.TijdService);
                        writer.WriteElementString("SaveLogFilePlace", Properties.Settings.Default.SaveLogFilePlace);
                        writer.WriteElementString("Email", Properties.Settings.Default.Email);
                        writer.WriteEndElement();
                        writer.Flush();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void UpdateXmlFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_userPath);
            XmlNodeList aNodes = doc.SelectNodes("//*");

            foreach (XmlNode aNode in aNodes)
            {
                switch (aNode.Name)
                {
                    case "ServiceAanOfUit":
                        aNode.FirstChild.Value = Properties.Settings.Default.ServiceAanOfUit;
                        break;
                    case "TijdService":
                        aNode.FirstChild.Value = Properties.Settings.Default.TijdService;
                        break;
                    case "SaveLogFilePlace":
                        aNode.FirstChild.Value = Properties.Settings.Default.SaveLogFilePlace;
                        break;
                    case "Email":
                        aNode.FirstChild.Value = Properties.Settings.Default.Email;
                        break;
                    case "ServerNaam":
                        aNode.FirstChild.Value = Properties.Settings.Default.ServerNaam;
                        break;
                    default:
                        break;
                }
            }
            doc.Save(_userPath);
        }
    }
}
