using System;
using System.Collections.Generic;

namespace BootShop.Models.Entities
{
    public partial class RoleAccount
    {
        public int AccountId { get; set; }
        public int RoleId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
