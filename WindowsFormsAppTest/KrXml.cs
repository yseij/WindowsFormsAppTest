using System.IO;
using System.Xml;

namespace WindowsFormsAppTest
{
    class KrXml
    {
        private string _path = @"D:\user.xml";
        public KrXml()
        {

        }

        public void MakeXmlFile()
        {
            if (!File.Exists(_path))
            {
                using (XmlWriter writer = XmlWriter.Create(_path))
                {
                    writer.WriteStartElement("Settings");
                    writer.WriteElementString("ServiceAanOfUit", Properties.Settings.Default.ServiceAanOfUit);
                    writer.WriteElementString("TijdService", Properties.Settings.Default.TijdService);
                    writer.WriteElementString("SaveLogFilePlace", Properties.Settings.Default.SaveLogFilePlace);
                    writer.WriteElementString("Email", Properties.Settings.Default.Email);
                    writer.WriteElementString("ServerNaam", Properties.Settings.Default.ServerNaam);
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }

        public void UpdateXmlFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_path);
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
            doc.Save(_path);
        }
    }
}
