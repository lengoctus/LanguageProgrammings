using System;
using System.Collections.Generic;

namespace ReviewDB_Project.Models.Entities
{
    public partial class ChuyenBay
    {
        public ChuyenBay()
        {
            Ve = new HashSet<Ve>();
        }

        public int Macb { get; set; }
        public string Tencb { get; set; }
        public DateTime? Ngaydi { get; set; }
        public int? Sogheloai1 { get; set; }
        public decimal? Giagheloai1 { get; set; }
        public int? Sogheloai2 { get; set; }
        public decimal? Giagheloai2 { get; set; }

        public virtual ICollection<Ve> Ve { get; set; }
    }
}
