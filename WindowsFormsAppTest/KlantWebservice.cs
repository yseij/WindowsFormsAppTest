using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    
    public class KlantWebservice
    {
        public KlantWebservice()
        {

        }

        public KlantWebservice(int id, int klant, int webservice, bool basisUrl1, bool basisUrl2)
        {
            Id = id;
            Klant = klant;
            Webservice = webservice;
            BasisUrl1 = basisUrl1;
            BasisUrl2 = basisUrl2;
        }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("klant")]
        public int Klant { get; set; }

        [XmlAttribute("webservice")]
        public int Webservice { get; set; }

        [XmlAttribute("basisUrl1")]
        public bool BasisUrl1 { get; set; }

        [XmlAttribute("basisUrl2")]
        public bool BasisUrl2 { get; set; }
    }
}
