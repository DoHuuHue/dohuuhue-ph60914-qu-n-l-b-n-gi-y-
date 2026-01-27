using duanmauquanlybangiay.DAO;
using duanmauquanlybangiay.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duanmauquanlybangiay.DAL
{
    internal class ChiTietPhieuBanHangDAL
    {
        public static DataTable SelectAll(string maHoaDon)
        {
            DbUtils.OpenConnection();
            DataTable tmp = DbUtils.ExecuteQueryTable(
                "SELECT * FROM Chi_Tiet_Hoa_Don WHERE ma_hd=@0",
                [maHoaDon]
            );
            DbUtils.CloseConnection();
            return tmp;
        }

        public static void TaoMoi(ChiTietHoaDon chiTietHoaDon)
        {
            DbUtils.OpenConnection();
            DbUtils.ExecuteNonQuery(
                "INSERT INTO Chi_Tiet_Hoa_Don (ma_hd, ma_hh, don_gia, so_luong_xuat) VALUES (@0, @1, @2, @3)",
                [
                    chiTietHoaDon.MaHD,
                    chiTietHoaDon.MaGiay,
                    chiTietHoaDon.DonGia,
                    chiTietHoaDon.SoLuong
                ]
            );
            DbUtils.CloseConnection();
        }

        public static void CapNhat(ChiTietHoaDon chiTietHoaDon)
        {
            DbUtils.OpenConnection();
            DbUtils.ExecuteNonQuery(
                "UPDATE Chi_Tiet_Hoa_Don SET don_gia=@0, so_luong_xuat=@1 WHERE ma_hd=@2 AND ma_hh=@3",
                [
                    chiTietHoaDon.DonGia,
                    chiTietHoaDon.SoLuong,
                    chiTietHoaDon.MaHD,
                    chiTietHoaDon.MaGiay
                ]
            );
            DbUtils.CloseConnection();
        }

        public static void Xoa(string maHoaDon, string maHangHoa)
        {
            DbUtils.OpenConnection();
            DbUtils.ExecuteNonQuery(
                "DELETE Chi_Tiet_Hoa_Don WHERE ma_hd=@0 AND ma_hh=@1",
                [
                    maHoaDon,
                    maHangHoa
                ]
            );
            DbUtils.CloseConnection();
        }
    }
}
