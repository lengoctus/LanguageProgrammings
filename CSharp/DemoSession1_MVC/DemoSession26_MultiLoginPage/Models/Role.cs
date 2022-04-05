using System;
using System.Collections.Generic;

namespace DemoSession26_MultiLoginPage.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleAccount = new HashSet<RoleAccount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RoleAccount> RoleAccount { get; set; }
    }
}
