using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class Hocsinh
    {
        public Hocsinh()
        {
            Diemthi = new HashSet<Diemthi>();
        }

        public string Mahs { get; set; }
        public string Hohs { get; set; }
        public string Tenhs { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Noisinh { get; set; }
        public string Malop { get; set; }
        public bool? Gender { get; set; }

        public virtual Lop MalopNavigation { get; set; }
        public virtual ICollection<Diemthi> Diemthi { get; set; }
    }
}
