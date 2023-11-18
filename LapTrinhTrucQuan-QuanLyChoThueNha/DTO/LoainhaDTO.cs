using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLChoThueNha.DTO
{
    //
    public class LoainhaDTO
    {
        private string _maLoai;
        private string _tenLoai;

        public LoainhaDTO(string maLoai, string tenLoai)
        {
            this._maLoai = maLoai;
            this._tenLoai = tenLoai;
        }

        public string MaLoai { get => _maLoai; set => _maLoai = value; }
        public string TenLoai { get => _tenLoai; set => _tenLoai = value; }

        public LoainhaDTO(DataRow row)
        {
            this.MaLoai = row["MaLoai"].ToString();
            this.TenLoai = row["TenLoai"].ToString();
        }
    }
}
