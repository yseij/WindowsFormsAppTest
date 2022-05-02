using System;

namespace WindowsFormsAppTest
{
    public class Url : IBaseData
    {
        public Url()
        {

        }

        public Url(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Guid WebserviceId { get; set; }
    }
}
