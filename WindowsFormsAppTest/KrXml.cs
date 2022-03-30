using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsAppTest
{
    class KrXml
    {
        public KrXml()
        {

        }

        public void MakeXmlFile()
        {
            using (XmlWriter writer = XmlWriter.Create(@"D:\user.xml"))
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

        public void UpdateXmlFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\user.xml");
            XmlNodeList aNodes = doc.SelectNodes("//*");

            foreach (XmlNode aNode in aNodes)
            {
                Console.WriteLine(aNode.Name);
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
                    default:
                        break;
                }
            }
            doc.Save(@"D:\user.xml");
        }
    }
}
