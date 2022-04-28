using System.Xml.Serialization;

namespace WindowsFormsAppTest
{
    class WebService : IBaseData
    {
        public WebService(int id, string name, bool soap)
        {
            Id = id;
            Name = name;
            Soap = soap;
        }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("soap")]
        public bool Soap { get; set; }

        [XmlAttribute("klantWebserviceId")]
        public KlantWebservice KlantWebserviceId { get; set; }
    }
}
