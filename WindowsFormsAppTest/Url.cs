using System;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    public class Url
    {
        public Url()
        {

        }

        public Url(string name, Guid klantId, Guid webserviceId)
        {
            Id = Guid.NewGuid();
            Name = name;
            KlantId = klantId;
            WebserviceId = webserviceId;
        }

        [XmlAttribute("Id")]
        public Guid Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("KlantId")]
        public Guid KlantId { get; set; }

        [XmlAttribute("WebserviceId")]
        public Guid WebserviceId { get; set; }
    }
}
