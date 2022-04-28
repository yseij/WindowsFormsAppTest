using System;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
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

        [XmlAttribute("id")]
        public Guid Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("soap")]
        public bool Soap { get; set; }
    }
}
