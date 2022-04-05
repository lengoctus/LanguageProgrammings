using System;
using System.Collections.Generic;

namespace Review_Buoi1.Models.Entities
{
    public partial class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }
        public bool? Featured { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
