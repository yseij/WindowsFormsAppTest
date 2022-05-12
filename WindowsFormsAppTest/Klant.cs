using System;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    public class Klant
    {
        public Klant()
        {

        }

        public Klant(string name)
        {
            Id = Guid.Empty;
            Name = name;
        }

        public Klant(string name, string basisUrl1, string basisUrl2)
        {
            Id = Guid.NewGuid();
            Name = name;
            BasisUrl1 = basisUrl1;
            BasisUrl2 = basisUrl2;
        }

        public Klant(Guid id, string name, string basisUrl1, string basisUrl2)
        {
            Id = id;
            Name = name;
            BasisUrl1 = basisUrl1;
            BasisUrl2 = basisUrl2;
        }

        [XmlAttribute("Id")]
        public Guid Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("BasisUrl1")]
        public string BasisUrl1 { get; set; }

        [XmlAttribute("BasisUrl2")]
        public string BasisUrl2 { get; set; }
    }
}
