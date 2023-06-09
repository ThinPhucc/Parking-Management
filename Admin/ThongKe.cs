using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admin
{
    class ThongKe
    {
        public string TinhTrang { get; set; }
        public string TenXe { get; set; }
        public string BienSoXe { get; set; }
        public string ThoiGianGui { get; set; }
        public string ThoiGianNhan { get; set; }
        public string SoTien { get; set; }

        public ThongKe(string tinhTrang, string tenXe, string bienSoXe, string thoiGianGui, string thoiGianNhan, string soTien)
        {
            TinhTrang = tinhTrang;
            TenXe = tenXe;
            BienSoXe = bienSoXe;
            ThoiGianGui = thoiGianGui;
            ThoiGianNhan = thoiGianNhan;
            SoTien = soTien;
        }
    }
}
