using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class Monhoc
    {
        public Monhoc()
        {
            Diemthi = new HashSet<Diemthi>();
        }

        public string Mamon { get; set; }
        public string Tenmon { get; set; }
        public int? Sotiet { get; set; }

        public virtual ICollection<Diemthi> Diemthi { get; set; }
    }
}
