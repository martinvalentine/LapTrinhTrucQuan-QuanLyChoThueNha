using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThuTienNhaDAO
    {
        DataProvider Instance = new DataProvider();

        public ThuTienNhaDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListThuTienNha()
        {
            return Instance.ExecuteQuery($"");
        }

        public bool InsertThuTienNha(string maSoThu, string maSoThue, string thang, string nam, decimal tongTien, string nguoiThu, DateTime ngayThu, string ghiChu)
        {
            try
            {
                Instance.ExecuteNonQuery($"");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateThuTienNha(string maSoThu, string maSoThue, string thang, string nam, decimal tongTien, string nguoiThu, DateTime ngayThu, string ghiChu)
        {
            try
            {
                Instance.ExecuteNonQuery($"");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteThuTienNha(string maSoThu)
        {
            try
            {
                Instance.ExecuteNonQuery($"");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
