using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucHanhKiemThuPhanMem.Model.EF;

namespace ThucHanhKiemThuPhanMem.Model.DAO
{
    class SinhVienDAO
    {
        MyDbContext db;
        List<SinhVien> sv;
        List<SinhVien> svNganh;
        public SinhVienDAO()
        {
            db = new MyDbContext();
        }
        public List<SinhVien> GetSinhViens()
        {
            if (sv == null)
            {
                db = new MyDbContext();
                sv = db.SinhVien.OrderBy(x=>x.TenSinhVien).ToList();
                return sv;
            }
            return sv;
        }
        public List<SinhVien> GetSinhViens(string maNganh)
        {
            if (svNganh == null)
            {
                db = new MyDbContext();
                svNganh = db.SinhVien.Where(x=>x.MaNganh==maNganh).ToList();
                return svNganh;
            }
            return svNganh;
        }
    }
}
