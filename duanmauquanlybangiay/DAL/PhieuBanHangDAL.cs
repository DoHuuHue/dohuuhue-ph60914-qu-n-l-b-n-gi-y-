using duanmauquanlybangiay.DAO;
using duanmauquanlybangiay.Utils;
using System.Data;

namespace duanmauquanlybangiay.DAL
{
    public static class PhieuBanHangDAL
    {
        public static DataTable SelectAll()
        {
         DbUtils.OpenConnection();
            DataTable tmp = DbUtils.ExecuteQueryTable("SELECT * FROM Hoa_Don", null);
            DbUtils.CloseConnection();
            return tmp;
        }

        public static void TaoMoi(HoaDon hoaDon)
        {
            DbUtils.OpenConnection();
            DbUtils.ExecuteNonQuery(
                "INSERT INTO Hoa_Don (ma_hoa_don, ngay_tao, trang_thai) VALUES (@0, @1, @2)",
                [
                    hoaDon.MaHD,
                    hoaDon.NgayLap,
                    hoaDon.TrangThai ? 1 : 0
                ]
            );
            DbUtils.CloseConnection();
        }

        public static void CapNhat(HoaDon hoaDon)
        {
            DbUtils.OpenConnection();
            DbUtils.ExecuteNonQuery(
                "UPDATE Hoa_Don SET ngay_tao=@0, trang_thai=@1 WHERE ma_hoa_don=@2",
                [
                    hoaDon.NgayLap,
                    hoaDon. TrangThai ? 1 : 0,
                    hoaDon.MaHD
                ]
            );
            DbUtils.CloseConnection();
        }

        public static void ThanhToan(string maHoaDon)
        {
            DbUtils.OpenConnection();
            DbUtils.ExecuteNonQuery(
                "UPDATE Hoa_Don SET trang_thai=1 WHERE ma_hoa_don=@0",
                [maHoaDon]
            );
            DbUtils.CloseConnection();
        }

        public static void Xoa(string maHoaDon)
        {
            DbUtils.OpenConnection();
            DbUtils.ExecuteNonQuery(
                "DELETE Hoa_Don WHERE ma_hoa_don=@0",
                [maHoaDon]
            );
            DbUtils.ExecuteNonQuery(
                "DELETE Chi_Tiet_Hoa_Don WHERE ma_hd=@0",
                [maHoaDon]
            );
            DbUtils.CloseConnection();
        }
    }


}

