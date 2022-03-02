using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest
{
    class ComboboxItem
    {
        public string Text { get; set; }
        public Guid ValueMember { get; set; }
        public string SecurityId { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
