using System;

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

        public UrlData(int id, string name, string securityId)
            : this(id, name)
        {
            SecurityId = securityId;
        }

        public int Id { get; }
        public string Name { get; set; }
        public string SecurityId { get; set; }
    }
}
