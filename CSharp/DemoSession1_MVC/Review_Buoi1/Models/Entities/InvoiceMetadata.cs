using Microsoft.AspNetCore.Mvc;
using Review_Buoi1.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review_Buoi1.Models.Entities
{
    public class InvoiceMetadata
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
        public int AccountId { get; set; }
    }

    [ModelMetadataType(typeof(InvoiceMetadata))]
    public partial class Invoice : IEntity
    {

    }
}
