using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TraNhaDAO
    {
        DataProvider Instance = new DataProvider();

        public TraNhaDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListTraNha()
        {
            return Instance.ExecuteQuery($"");
        }

        public bool InsertTraNha(string maSoThue, DateTime ngayTra, decimal tongTien)
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

        public bool UpdateTraNha(string maSoThue, DateTime ngayTra, decimal tongTien)
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

        public bool DeleteTraNha(string maSoThue)
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