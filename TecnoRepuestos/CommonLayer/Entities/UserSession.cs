using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }

        public static void Clear()
        {
            UserId = 0;
            Username = null;
            FullName = null;
        }
    }
}
