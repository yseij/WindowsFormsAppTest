using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest
{
    class KlantData
    {
        public KlantData()
        {
        }

        public KlantData(int id, string name)
            : this()
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; set; }
    }
}
