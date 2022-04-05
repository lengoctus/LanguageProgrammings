using System;
using System.Collections.Generic;

namespace DemoSession25_Security_EF.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleDetails = new HashSet<RoleDetails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RoleDetails> RoleDetails { get; set; }
    }
}
