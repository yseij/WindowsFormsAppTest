using System.Collections.Generic;

namespace WindowsFormsAppTest
{
    public class UrlData
    {
        public UrlData()
        {
        }

        public UrlData(int id, string name)
            : this()
        {
            Id = id;
            Name = name;
        }

        public UrlData(int id, string name, string securityId, int webServiceDataId)
            : this(id, name)
        {
            SecurityId = securityId;
            WebServiceDataId = webServiceDataId;
        }

        public int Id { get; }
        public string Name { get; set; }
        public string SecurityId { get; set; }
        public int WebServiceDataId { get; set; }
    }
}
