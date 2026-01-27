using duanmauquanlybangiay.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duanmauquanlybangiay.BLL
{
    internal class PhieuBanHangBLL
    {
        public static decimal TongHoaDon(string maHoaDon)
        {
            DbUtils.OpenConnection();
            DataTable tbData = DbUtils.ExecuteQueryTable(
                "SELECT SUM(don_gia * so_luong_xuat) AS tong_tien FROM Chi_Tiet_Hoa_Don WHERE ma_hd=@0",
                [maHoaDon]
            );
            DbUtils.CloseConnection();

            return Convert.ToDecimal(tbData.Rows[0][0]);
        }
    }
}
