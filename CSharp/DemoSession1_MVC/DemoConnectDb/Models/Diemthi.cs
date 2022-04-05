using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class Diemthi
    {
        public string Mahs { get; set; }
        public string Mamon { get; set; }
        public string Hk { get; set; }
        public int? Diemlan1 { get; set; }
        public string Ghichu { get; set; }
        public int? Diemlan2 { get; set; }

        public virtual Hocky HkNavigation { get; set; }
        public virtual Hocsinh MahsNavigation { get; set; }
        public virtual Monhoc MamonNavigation { get; set; }
    }
}
