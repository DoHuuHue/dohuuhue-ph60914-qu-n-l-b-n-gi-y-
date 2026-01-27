using duanmauquanlybangiay.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duanmauquanlybangiay.DAL
{
    public  class GiayDAL
    {
           public static DataTable SelectHangHoa(string MaGiay)
        {
            DbUtils.OpenConnection();
            DataTable tmp = DbUtils.ExecuteQueryTable("SELECT * FROM Hang_Hoa WHERE ma_hang_hoa=@0",
                [MaGiay]
            );
            DbUtils.CloseConnection();
            return tmp;
        }
    }
    }

