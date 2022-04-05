using System;
using System.Collections.Generic;

namespace Review_Buoi1.Models.Entities
{
    public partial class RoleAccount
    {
        public int RoleId { get; set; }
        public int AccountId { get; set; }
        public bool? Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
