using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DanhMucNhaDAO
    {
        DataProvider Instance = new DataProvider();

        public DanhMucNhaDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListDanhMucNha(string maLoai = "")
        {
            return Instance.ExecuteQuery($"SELECT * FROM DanhMucNha WHERE MaHD = N'{maLoai}'"); // Day la cau truy van khi co dau vao
        }

        public DataTable GetListDanhMucNhaByDTSD(string maDTSD = "")
        {
            return Instance.ExecuteQuery($"SELECT * FROM DanhMucNha WHERE MaHD = N'{maDTSD}'"); // Day la cau truy van khi co dau vao
        }

        public DataTable GetListDanhMucNhaByDiaChi(string diaChi = "")
        {
            return Instance.ExecuteQuery($"SELECT * FROM DanhMucNha WHERE MaHD = N'{diaChi}'"); // Day la cau truy van khi co dau vao
        }

        public bool InsertDanhMucNha(string maNha, string tenChuNha, string dienThoai, string maLoai, string maDTSD, string diaChi, decimal? donGiaThue, string tinhTrang, int daThue, string ghiChu)
        {
            try
            {
                // Day la cau truy van khi co dau vao
                Instance.ExecuteNonQuery($"INSERT DanhMucNha (maNha, tenChuNha, dienThoai, maLoai, maDTSD, diaChi, donGiaThue, tinhTrang, daThue, ghiChu) " +
                $"VALUES (N'{maNha}', N'{tenChuNha}', N'{dienThoai}, N'{maLoai}, N'{maDTSD}, N'{diaChi}, {donGiaThue}, N'{tinhTrang}, {daThue}, N'{ghiChu})"); 
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateDanhMucNha(string maNha, string tenChuNha, string dienThoai, string maLoai,
            string maDTSD, string diaChi, decimal? donGiaThue, string tinhTrang, int daThue, string ghiChu)
        {
            try
            {
                // Day la cau truy van khi co dau vao
                Instance.ExecuteNonQuery($"UPDATE DanhMucNha SET maNha = N'{maNha}', tenChuNha = N'{tenChuNha}', dienThoai = N'{dienThoai}, maLoai = N'{maLoai}, maDTSD = N'{maDTSD}, diaChi = N'{diaChi}, donGiaThue = {donGiaThue}, tinhTrang = N'{tinhTrang}, daThue = {daThue}, ghiChu = N'{ghiChu} WHERE MaMA = N'{maNha}'");

            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteDanhMucNha(string maNha)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE DanhMucNha WHERE MaMA = N'{maNha}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
