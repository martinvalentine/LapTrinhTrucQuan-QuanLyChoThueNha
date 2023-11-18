using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        DataProvider Instance = new DataProvider();

        public TaiKhoanDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable CheckLogin(string userName, string passWord)
        {
            return Instance.ExecuteQuery($"");
        }

        public DataTable GetAccountByUserName(string userName)
        {
            DataTable data = Instance.ExecuteQuery($"");
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            return data;
        }

        public DataTable GetListTK()
        {
            return Instance.ExecuteQuery($"");
        }
        public bool InsertTK(string userName, string passWord, string displayName, int phanQuyen)
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
        public bool UpdateTK(string userName, string passWord, string displayName, int phanQuyen)
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
        public bool DeleteTK(string userName)
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