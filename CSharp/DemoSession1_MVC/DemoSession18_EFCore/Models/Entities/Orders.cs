using System;
using System.Collections.Generic;

namespace DemoSession18_EFCore.Models.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrdersDetail = new HashSet<OrdersDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Payment { get; set; }
        public bool? Status { get; set; }
        public int? AccountId { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrdersDetail> OrdersDetail { get; set; }
    }
}
