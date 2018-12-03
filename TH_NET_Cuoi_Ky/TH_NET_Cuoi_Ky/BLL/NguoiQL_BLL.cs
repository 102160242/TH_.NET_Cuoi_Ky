using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;

namespace TH_NET_Cuoi_Ky.BLL
{
    class NguoiQL_BLL
    {
        QLCSVC db;
        // Test change on Laptop
        public NguoiQL_BLL()
        {
            db = new QLCSVC();
        }
        public dynamic ShowNguoiQL_BLL()
        {
            var person = db.NguoiQLs.Select(p => new { p.MaNguoiQL, p.TenNguoiQL, p.NgaySinh, p.SoDT, p.GioiTinh });
            return person.ToList();
        }
        public List<DTO.NguoiQL> GetNguoiQLById(int id)
        {
            var person = from p in db.NguoiQLs where p.MaNguoiQL == id select p;
            return person.ToList<DTO.NguoiQL>();
        }
    }
}
