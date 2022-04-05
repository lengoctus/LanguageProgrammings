using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class Hocky
    {
        public Hocky()
        {
            Diemthi = new HashSet<Diemthi>();
        }

        public string Hk { get; set; }
        public string Ghichu { get; set; }

        public virtual ICollection<Diemthi> Diemthi { get; set; }
    }
}
