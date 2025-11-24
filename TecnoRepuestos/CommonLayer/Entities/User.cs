using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class User
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string DUI { get; set; }

    }
}
