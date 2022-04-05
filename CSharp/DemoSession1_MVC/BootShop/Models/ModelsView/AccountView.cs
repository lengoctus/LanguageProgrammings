using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop.Models.ModelsView
{
    public class AccountView
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public bool Status { get; set; }
        public string FullName { get; set; }
    }
}
