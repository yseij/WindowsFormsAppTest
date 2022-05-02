using System;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    [XmlRoot(ElementName = "WebService")]
    public class WebService
    {
        public WebService()
        {

        }

        public WebService(string name, bool soap, string securityId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Soap = soap;
            SecurityId = securityId;
        }

        public WebService(Guid id, string name, bool soap, string securityId)
        {
            Id = id;
            Name = name;
            Soap = soap;
            SecurityId = securityId;
        }

        [XmlAttribute("Id")]
        public Guid Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Soap")]
        public bool Soap { get; set; }

        [XmlAttribute("SecurityId")]
        public string SecurityId { get; set; }
    }
}
