using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocPhan
    {
        public string maLop { get; set; }
        public string maHocPhan { get; set; }
        public string maGV { get; set; }

        public LopHocPhan(string maLop,string maHocPhan,string maGV)
        {
            this.maLop = maLop;
            this.maHocPhan = maHocPhan;
            this.maGV = maGV;
        }

    }
}
