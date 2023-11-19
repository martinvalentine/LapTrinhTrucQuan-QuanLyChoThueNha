using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TraNhaBUS
    {
        private TraNhaDAO traNhaDAO;
        public TraNhaBUS()
        {
            traNhaDAO = new TraNhaDAO();
        }
        public List<TraNhaDTO> GetListTraNha()
        {
            List<TraNhaDTO> list = new List<TraNhaDTO>();
            DataTable data = traNhaDAO.GetListTraNha();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new TraNhaDTO(item));
            }

            return list;
        }
        public bool InsertTraNha(string maSoThue, DateTime ngayTra, decimal tongTien)
        {
            return traNhaDAO.InsertTraNha(maSoThue, ngayTra, tongTien);
        }
        public bool UpdateTraNha(string maSoThue, DateTime ngayTra)
        {
            return traNhaDAO.UpdateTraNha(maSoThue, ngayTra);
        }
        public bool DeleteTraNha(string maSoThue)
        {
            return traNhaDAO.DeleteTraNha(maSoThue);
        }
    }
}