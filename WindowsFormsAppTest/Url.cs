using System;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    public class Url
    {
        public Url()
        {

        }

        public Url(string name, Guid klantId, Guid klantWebserviceId)
        {
            Id = Guid.NewGuid();
            Name = name;
            KlantId = klantId;
            KlantWebserviceId = klantWebserviceId;
        }

        [XmlAttribute("Id")]
        public Guid Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlIgnore]
        public string MethodeName { get; set; }

        [XmlAttribute("KlantId")]
        public Guid KlantId { get; set; }

        [XmlAttribute("KlantWebserviceId")]
        public Guid KlantWebserviceId { get; set; }
    }
}
