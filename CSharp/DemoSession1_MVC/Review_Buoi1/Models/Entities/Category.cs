using System;
using System.Collections.Generic;

namespace Review_Buoi1.Models.Entities
{
    public partial class Category
    {
        public Category()
        {
            InverseParent = new HashSet<Category>();
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int? ParentId { get; set; }

        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> InverseParent { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
