using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachThueDAO
    {
        private DataProvider Instance;

        public KhachThueDAO()
        {
            Instance = new DataProvider();
        }

        // Lấy thông tin khách thuê theo tên 
        public DataTable GetListKhachThue(string tenKhach = "")
        {
            return Instance.ExecuteQuery($"");
        }

        // Lấy thông tin khách thuê theo địa chỉ thường trú
        public DataTable GetListKhachThueByDiaChi(string diaChiThuongTru = "")
        {
            return Instance.ExecuteQuery($"");
        }

        // Lấy thông tin khách thuê theo nghề
        public DataTable GetListKhachThueByNghe(string maNghe = "")
        {
            return Instance.ExecuteQuery($"");
        }

        // Nhập thông tin khách thuê
        public bool InsertKhachThue(string maKhach, string tenKhach, DateTime ngaySinh, int gioiTinh,
            string soCMND, string diaChiThuongTru, string maNghe, string maCQ)
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

        //Update thông tin khách hàng
        public bool UpdateKhachThue(string maKhach, string tenKhach, DateTime ngaySinh, int gioiTinh,
            string soCMND, string diaChiThuongTru, string maNghe, string maCQ)
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

        // Xóa khách thuê
        public bool DeleteKhachThue(string maKhach)
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
