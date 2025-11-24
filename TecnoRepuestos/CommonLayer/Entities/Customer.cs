using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string DUI { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string NRC { get; set; }
        public string CustomerType { get; set; } = "Contribuidor";
    }
}
