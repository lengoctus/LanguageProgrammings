using System;
using System.Collections.Generic;

namespace BootShop.Models.Entities
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
