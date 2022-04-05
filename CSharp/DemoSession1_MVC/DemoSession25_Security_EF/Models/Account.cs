using System;
using System.Collections.Generic;

namespace DemoSession25_Security_EF.Models
{
    public partial class Account
    {
        public Account()
        {
            RoleDetails = new HashSet<RoleDetails>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<RoleDetails> RoleDetails { get; set; }
    }
}
