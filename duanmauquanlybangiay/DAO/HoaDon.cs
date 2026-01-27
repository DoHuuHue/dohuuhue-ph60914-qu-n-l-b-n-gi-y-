using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duanmauquanlybangiay.DAO
{
    internal class HoaDon
    {
        public int MaHD { get; set; }        
        public string MaNV { get; set; }    
        public string MaKH { get; set; }     
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }

        public HoaDon() { }
        public HoaDon(int maHD, string maNV, string maKH, DateTime ngayLap, decimal tongTien)
        {
            MaHD = maHD;
            MaNV = maNV;
            MaKH = maKH;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }
    }
}
