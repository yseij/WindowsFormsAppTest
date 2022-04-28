using System.Collections.Generic;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    [XmlRoot(ElementName = "DB")]
    public class DB
    {
        public DB()
        {

        }

        [XmlArray("Webservices")]
        [XmlArrayItem("Webservice")]
        public List<WebService> Webservices { get; set; }

        [XmlArray("Klanten")]
        [XmlArrayItem("Klant")]
        public List<Klant> Klanten { get; set; }

        [XmlArray("KlantWebservices")]
        [XmlArrayItem("KlantWebservice")]
        public List<KlantWebservice> KlantWebservices { get; set; }
    }
}
