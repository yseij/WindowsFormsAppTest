using System.Collections.Generic;
using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    public class Klant
    {
        public Klant()
        {

        }

        public Klant(int id, string name, string basisUrl1, string basisUrl2)
        {
            Id = id;
            Name = name;
            BasisUrl1 = basisUrl1;
            BasisUrl2 = basisUrl2;
        }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("basisUrl1")]
        public string BasisUrl1 { get; set; }

        [XmlAttribute("basisUrl2")]
        public string BasisUrl2 { get; set; }
    }
}
