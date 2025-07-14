using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSupport
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public Customer() { }
        public Customer(string name, string email, string id)
        {
            Name = name;
            Email = email;
            Id = id;
        }
    }
}
