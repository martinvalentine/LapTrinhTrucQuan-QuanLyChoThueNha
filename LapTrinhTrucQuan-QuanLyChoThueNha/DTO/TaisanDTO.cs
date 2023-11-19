using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiSanDTO
    {
        private string _maTaiSan;
        private string _tenTaiSan;

        public TaiSanDTO(string maTaisan, string tenTaisan)
        {
            this._maTaiSan = maTaisan;
            this._tenTaiSan = tenTaisan;
        }

        public string MaTaiSan { get => _maTaiSan; set => _maTaiSan = value; }
        public string TenTaiSan { get => _tenTaiSan; set => _tenTaiSan = value; }

        public TaiSanDTO(DataRow row)
        {
            this.MaTaiSan = row["Mataisan"].ToString();
            this.TenTaiSan = row["Tentaisan"].ToString();
        }
    }
}
