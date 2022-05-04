using System;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    public class Url
    {
        public Url()
        {

        }

        public Url(string name, Guid klantId)
        {
            Id = Guid.NewGuid();
            Name = name;
            KlantId = klantId;
        }

        [XmlAttribute("Id")]
        public Guid Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlIgnore]
        public Guid WebserviceId { get; set; }

        [XmlAttribute("KlantId")]
        public Guid KlantId { get; set; }
    }
}
