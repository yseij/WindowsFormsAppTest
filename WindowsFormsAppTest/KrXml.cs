using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsAppTest
{
    class KrXml
    {
        private string _xmlName = "user.xml"; 
        public KrXml()
        {

        }

        public void MakeXmlFile()
        {
            string path = @"" + Properties.Settings.Default.SaveXmlFile;
            path = checkPath(path);
            if (!File.Exists(path))
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Kies de map waar je persoonlijke instelligen opgeslagen moeten worden voor de service";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string SelectedPath = fbd.SelectedPath;
                    ConfigurationManager.AppSettings["SaveXmlFile"] = SelectedPath;
                    Properties.Settings.Default["SaveXmlFile"] = SelectedPath;
                    path = checkPath(SelectedPath);
                }
                ChoseSavePlace(path);
            }
        }

        private void ChoseSavePlace(string path)
        {
            if (!File.Exists(path))
            {
                try
                {
                    using (XmlWriter writer = XmlWriter.Create(path))
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
                    var m = new ErrorForm(ex.Message);
                    m.FormClosing += new FormClosingEventHandler(ChildFormClosingChoseSavePlaceXml);
                    m.ShowDialog();
                }
            }
        }

        private void ChildFormClosingChoseSavePlaceXml(object sender, FormClosingEventArgs e)
        {
            MakeXmlFile();
        }

        public void UpdateXmlFile()
        {
            string path = @"" + Properties.Settings.Default.SaveXmlFile;
            path = checkPath(path);

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
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
                    default:
                        break;
                }
            }
            doc.Save(path);
        }

        private string checkPath(string path)
        {
            if (path.EndsWith("\\"))
            {
                path = @"" + Properties.Settings.Default.SaveXmlFile + _xmlName;
            }
            else
            {
                path = @"" + Properties.Settings.Default.SaveXmlFile + "/" + _xmlName;
            }
            return path;
        }
    }
}
