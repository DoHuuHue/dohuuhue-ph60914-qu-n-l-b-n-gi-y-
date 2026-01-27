using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duanmauquanlybangiay.DAO
{
    public class HoaDon
    {
        public  string MaHD  { get; set; }        
        public string MaNV { get; set; }    
        public string MaKH { get; set; }     
        public DateTime NgayLap { get; set; }
        public bool TrangThai { get; set; }

        public HoaDon() { }
        public HoaDon(string   maHD, string maNV, string maKH, DateTime ngayLap, bool trangthai)
        {
            MaHD = maHD;
            MaNV = maNV;
            MaKH = maKH;
            NgayLap = ngayLap;
            TrangThai = trangthai;
        }
    }
}
