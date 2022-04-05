using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession16_EF6.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool  Gender { get; set; }
        public string Email { get; set; }
        public DateTime  Birthday { get; set; }
    }
}
