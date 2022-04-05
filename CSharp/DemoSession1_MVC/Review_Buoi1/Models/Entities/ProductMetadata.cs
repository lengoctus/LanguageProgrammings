using Microsoft.AspNetCore.Mvc;
using Review_Buoi1.Models.EFCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Review_Buoi1.Models.Entities
{
    
    public class ProductMetadata
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
        [Range(1, 100)]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public bool Featured { get; set; }
    }

    [ModelMetadataType(typeof(ProductMetadata))]
    public partial class Product : IEntity
    {
        
    }
}
