using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThueNhaDAO
    {
        DataProvider Instance = new DataProvider();

        public ThueNhaDAO()
        {
            Instance = new DataProvider();
        }

        public bool InsertThueNha(string maSoThue, string maKhach, string maNha, string maMucdichSD, DateTime ngayBD, DateTime ngayKT, decimal tienDatCoc, string maHinhthucTT)
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

        public bool UpdateThueNha(string maSoThue, string maKhach, string maNha, string maMucdichSD, DateTime ngayBD, DateTime ngayKT, decimal tienDatCoc, string maHinhthucTT)
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

        public bool DeleteThueNha(string maSoThue)
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
