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

        public WebService(string name, bool soap)
        {
            Id = Guid.NewGuid();
            Name = name;
            Soap = soap;
        }

        public WebService(Guid id, string name, bool soap)
        {
            Id = id;
            Name = name;
            Soap = soap;
        }

        [XmlAttribute("Id")]
        public Guid Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Soap")]
        public bool Soap { get; set; }
    }
}
