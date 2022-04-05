using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Review_Buoi1.Models.Entities
{
    [ModelMetadataType(typeof(CategoryValidation))]
    public partial class Category
    {

    }

    public class CategoryValidation
    {
        [Required]
        public string Name { get; set; }
    }
}
