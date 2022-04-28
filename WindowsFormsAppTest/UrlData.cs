using System;

namespace WindowsFormsAppTest
{
    public class UrlData : IBaseData
    {
        public UrlData()
        {

        }

        public UrlData(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public UrlData(int id, string name, string securityId, Guid webServiceDataId, Guid klantDataId)
            : this(id, name)
        {
            SecurityId = securityId;
            WebServiceDataId = webServiceDataId;
            KlantDataId = klantDataId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SecurityId { get; set; }
        public Guid WebServiceDataId { get; set; }
        public Guid KlantDataId { get; set; }
    }
}
