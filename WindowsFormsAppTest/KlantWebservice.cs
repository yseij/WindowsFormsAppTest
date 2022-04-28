using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    class KlantWebservice
    {
        public KlantWebservice()
        {

        }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("klantId")]
        public Klant KlantId { get; set; }

        [XmlAttribute("webserviceId")]
        public WebService WebserviceId { get; set; }

        [XmlAttribute("basisUrl1")]
        public bool BasisUrl1 { get; set; }

        [XmlAttribute("basisUrl2")]
        public bool BasisUrl2 { get; set; }
    }
}
