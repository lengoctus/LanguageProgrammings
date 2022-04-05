using System;
using System.Collections.Generic;

namespace Review_Buoi1.Models.Entities
{
    public partial class Role
    {
        public Role()
        {
            RoleAccount = new HashSet<RoleAccount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<RoleAccount> RoleAccount { get; set; }
    }
}
