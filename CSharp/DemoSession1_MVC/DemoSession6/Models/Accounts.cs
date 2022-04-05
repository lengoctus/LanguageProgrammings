using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool Gender { get; set; }
        public string Role { get; set; }
        public string Photo { get; set; }
    }
}
