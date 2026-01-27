using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duanmauquanlybangiay.DAO
{
    internal class ChiTietHoaDon
    {
        public int MaHD { get; set; }       
        public string MaGiay { get; set; }   
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public ChiTietHoaDon() { }

        public ChiTietHoaDon(int maHD, string maGiay, int soLuong, decimal donGia)
        {
            MaHD = maHD;
            MaGiay = maGiay;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}
