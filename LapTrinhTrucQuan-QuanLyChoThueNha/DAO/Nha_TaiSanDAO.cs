using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Nha_TaiSanDAO
    {
        DataProvider Instance = new DataProvider();

        public Nha_TaiSanDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListNha_TaiSan()
        {
            return Instance.ExecuteQuery($"");
        }

        public bool InsertNha_TaiSan(string maNha, string maTaisan, int soLuong, decimal? giaTri, string tinhTrang)
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

        public bool UpdateNha_TaiSan(string maNha, string maTaisan, int soLuong, decimal? giaTri, string tinhTrang)
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

        public bool DeleteNha_TaiSan(string maNha, string maTaiSan)
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
