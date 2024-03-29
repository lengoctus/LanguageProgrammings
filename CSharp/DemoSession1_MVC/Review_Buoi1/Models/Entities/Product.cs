﻿using System;
using System.Collections.Generic;

namespace Review_Buoi1.Models.Entities
{
    public partial class Product
    {
        public Product()
        {
            InvoiceDetails = new HashSet<InvoiceDetails>();
            Photo = new HashSet<Photo>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public bool Featured { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual ICollection<Photo> Photo { get; set; }
    }
}
