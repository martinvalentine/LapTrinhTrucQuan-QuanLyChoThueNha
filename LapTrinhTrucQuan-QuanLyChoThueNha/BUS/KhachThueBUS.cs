﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KhachThueBUS
    {
        private KhachThueDAO khachThueDAO;
        public KhachThueBUS()
        {
            khachThueDAO = new KhachThueDAO();
        }
        public List<KhachThueDTO> GetListKhachThue(string tenKhach = "")
        {
            List<KhachThueDTO> list = new List<KhachThueDTO>();
            DataTable data = khachThueDAO.GetListKhachThue(tenKhach);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new KhachThueDTO(item));
            }
            return list;
        }
        public List<KhachThueDTO> GetListKhachThueByDiaChi(string diaChiThuongTru = "")
        {
            List<KhachThueDTO> list = new List<KhachThueDTO>();
            DataTable data = khachThueDAO.GetListKhachThueByDiaChi(diaChiThuongTru);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new KhachThueDTO(item));
            }
            return list;
        }
        public List<KhachThueDTO> GetListKhachThueByNghe(string maNghe = "")
        {
            List<KhachThueDTO> list = new List<KhachThueDTO>();
            DataTable data = khachThueDAO.GetListKhachThueByNghe(maNghe);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new KhachThueDTO(item));
            }
            return list;
        }
        public bool InsertKhachThue(string maKhach, string tenKhach, DateTime ngaySinh, int gioiTinh,
            string soCMND, string diaChiThuongTru, string maNghe, string maCQ)
        {
            return khachThueDAO.InsertKhachThue(maKhach, tenKhach, ngaySinh, gioiTinh,
            soCMND, diaChiThuongTru, maNghe, maCQ);
        }
        public bool UpdateKhachThue(string maKhach, string tenKhach, DateTime ngaySinh, int gioiTinh,
            string soCMND, string diaChiThuongTru, string maNghe, string maCQ)
        {
            return khachThueDAO.UpdateKhachThue(maKhach, tenKhach, ngaySinh, gioiTinh,
            soCMND, diaChiThuongTru, maNghe, maCQ);
        }
        public bool DeleteKhachThue(string maKhach)
        {
            return khachThueDAO.DeleteKhachThue(maKhach);
        }
    }
}
