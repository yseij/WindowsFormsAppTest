using System;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    
    public class KlantWebservice
    {
        public KlantWebservice()
        {

        }

        public KlantWebservice(Guid klant, Guid webservice, bool basisUrl1, bool basisUrl2)
        {
            Id = Guid.NewGuid();
            Klant = klant;
            Webservice = webservice;
            BasisUrl1 = basisUrl1;
            BasisUrl2 = basisUrl2;
        }

        public KlantWebservice(Guid id, Guid klant, Guid webservice, bool basisUrl1, bool basisUrl2)
        {
            Id = id;
            Klant = klant;
            Webservice = webservice;
            BasisUrl1 = basisUrl1;
            BasisUrl2 = basisUrl2;
        }

        [XmlAttribute("id")]
        public Guid Id { get; set; }

        [XmlAttribute("klant")]
        public Guid Klant { get; set; }

        [XmlAttribute("webservice")]
        public Guid Webservice { get; set; }

        [XmlAttribute("basisUrl1")]
        public bool BasisUrl1 { get; set; }

        [XmlAttribute("basisUrl2")]
        public bool BasisUrl2 { get; set; }
    }
}
