using System;
using System.Collections.Generic;

namespace DemoSession26_MultiLoginPage.Models
{
    public partial class Account
    {
        public Account()
        {
            RoleAccount = new HashSet<RoleAccount>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<RoleAccount> RoleAccount { get; set; }
    }
}
