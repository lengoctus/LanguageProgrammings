using System;
using System.Collections.Generic;

namespace DemoConnectDb.Models
{
    public partial class Lop
    {
        public Lop()
        {
            Hocsinh = new HashSet<Hocsinh>();
        }

        public string Malop { get; set; }
        public string Tenlop { get; set; }

        public virtual ICollection<Hocsinh> Hocsinh { get; set; }
    }
}
