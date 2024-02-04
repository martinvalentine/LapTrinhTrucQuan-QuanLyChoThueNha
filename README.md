## Quy tắc đặt tên biến:
```
private: _thisIsAnExample
public {get; set}: ThisIsAnExample
```
### Code mẫu 
```
namespace QLChoThueNha.DTO 
{ 
    public class DanhMucNhaDTO 
    { 
        private string _maNha; 
        private string _tenChuNha;

        public string MaNha { get => _maNha; set => _maNha = value; }
        public string TenChuNha { get => _tenChuNha; set => _tenChuNha = value; }

        public DanhMucNhaDTO(string maNha, string tenChuNha)
        {
            this._maNha = maNha;
            this._tenChuNha = tenChuNha;
        }

        public DanhMucNhaDTO(DataRow row)
        {
            this.MaNha = row["MaNha"].ToString();
            this.TenChuNha = row["TenChuNha"].ToString();
        }
    }
}

```
