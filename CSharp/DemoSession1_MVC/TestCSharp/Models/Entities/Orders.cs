using System;
using System.Collections.Generic;

namespace TestCSharp.Models.Entities
{
    public partial class Orders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreation { get; set; }
        public bool? Status { get; set; }
        public string Payments { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
