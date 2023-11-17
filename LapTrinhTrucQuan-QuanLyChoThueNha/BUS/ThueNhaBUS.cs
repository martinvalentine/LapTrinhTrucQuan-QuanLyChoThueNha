using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ThueNhaBUS
    {
        private ThueNhaDAO thueNhaDAO;
        public ThueNhaBUS()
        {
            thueNhaDAO = new ThueNhaDAO();
        }
        //public List<ThueNhaDTO> LayDanhSachNhaChuaDuocThue()
        //{
        //    // Lấy danh sách các danh mục nhà có trạng thái "Chưa thuê."
        //    List<ThueNhaDTO> danhSachNhaChuaDuocThue = thueNhaDAO.DanhMucNhaDTO
        //        .Where(n => n.TinhTrang == "Chưa thuê")
        //        .ToList();

        //    return danhSachNhaChuaDuocThue;
        //}
        public bool InsertThueNha(string maSoThue, string maKhach, string maNha, string maMucdichSD, DateTime ngayBD, DateTime ngayKT, decimal tienDatCoc, string maHinhthucTT)
        {
            return thueNhaDAO.InsertThueNha(maSoThue, maKhach, maNha, maMucdichSD, ngayBD, ngayKT, tienDatCoc, maHinhthucTT);
        }
        public bool UpdateThueNha(string maSoThue, string maKhach, string maNha, string maMucdichSD, DateTime ngayBD, DateTime ngayKT, decimal tienDatCoc, string maHinhthucTT)
        {
            return thueNhaDAO.UpdateThueNha(maSoThue, maKhach, maNha, maMucdichSD, ngayBD, ngayKT, tienDatCoc, maHinhthucTT);
        }
        public bool DeleteThueNha(string maSoThue)
        {
            return thueNhaDAO.DeleteThueNha(maSoThue);
        }
    }
}
