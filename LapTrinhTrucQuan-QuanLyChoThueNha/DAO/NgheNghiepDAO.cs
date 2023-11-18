using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NgheNghiepDAO
    {
        DataProvider Instance = new DataProvider();

        public NgheNghiepDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListNgheNghiep()
        {
            return Instance.ExecuteQuery($"");
        }

        public bool InsertNgheNghiep(string maNghe, string tenNghe)
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
