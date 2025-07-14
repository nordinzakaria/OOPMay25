using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSupport
{
    internal class Staff
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }

        public Staff() { }
        public Staff(string name, string description, string Id)
        {
            Name = name;
            Description = description;
            Id = Id;
        }
    }
}
