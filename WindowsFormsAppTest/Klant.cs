using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    public class Klant
    {
        public Klant()
        {

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

        [XmlAttribute("id")]
        public Guid Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("basisUrl1")]
        public string BasisUrl1 { get; set; }

        [XmlAttribute("basisUrl2")]
        public string BasisUrl2 { get; set; }
    }
}
