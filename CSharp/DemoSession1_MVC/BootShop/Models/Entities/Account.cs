using System;
using System.Collections.Generic;

namespace BootShop.Models.Entities
{
    public partial class Account
    {
        public Account()
        {
            Invoice = new HashSet<Invoice>();
            RoleAccount = new HashSet<RoleAccount>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public bool Status { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<RoleAccount> RoleAccount { get; set; }
    }
}
