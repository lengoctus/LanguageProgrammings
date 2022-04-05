using System;
using System.Collections.Generic;

namespace DemoSession17_EFCore.Models.Entities
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Created { get; set; }
        public string Payment { get; set; }
        public decimal? Total { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
