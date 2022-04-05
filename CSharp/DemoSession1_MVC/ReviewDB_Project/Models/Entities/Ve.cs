using System;
using System.Collections.Generic;

namespace ReviewDB_Project.Models.Entities
{
    public partial class Ve
    {
        public int Mave { get; set; }
        public string HotenKh { get; set; }
        public string Cmnd { get; set; }
        public int? Macb { get; set; }
        public int? Loaighe { get; set; }
        public decimal? Giaghe { get; set; }

        public virtual ChuyenBay MacbNavigation { get; set; }
    }
}
