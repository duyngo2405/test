using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucHanhKiemThuPhanMem.Model.EF;

namespace ThucHanhKiemThuPhanMem.Model.DAO
{
    class LopDAO
    {
        MyDbContext db;
        List<Lop> lops;
        public LopDAO()
        {
            db = new MyDbContext();
        }
        public List<Lop> GetLops()
        {
            
            if (lops == null)
            {
                db = new MyDbContext();
                lops = db.Lop.ToList();
                return lops;
            }
            
            return lops;
        }
        public List<Lop> GetLops(string mamonhoc)
        {
            List<Lop> list = new List<Lop>() ;
            db = new MyDbContext();
            var obj = db.Lop.Where(x => x.MaMonHoc == mamonhoc);
            foreach (var item in obj)
            {
                Lop lop = item as Lop;
                list.Add(lop);
            }
            return list;
        }
    }
}
