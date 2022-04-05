﻿using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int IdCategory { get; set; }
        public string NameCategory { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
