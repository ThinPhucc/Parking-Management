using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Info_Xe
    {
        public string TenXe { get; set; }
        public string BienSoXe { get; set; }
        public DateTime ThoiGianGui { get; set; }

        public Info_Xe() { }

        public Info_Xe(string tenxe, string bienso, DateTime datetime)
        {
            this.TenXe = tenxe;
            this.BienSoXe = bienso;
            this.ThoiGianGui = datetime;
        }
    }
}
