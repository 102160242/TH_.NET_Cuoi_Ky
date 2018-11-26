using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;

namespace TH_NET_Cuoi_Ky.BLL
{
    class Phong_BLL
    {
        QLCSVC db;
        public Phong_BLL()
        {
            db = new QLCSVC();
        }
        public List<string> loadCBB_BLL()
        {
            List<string> l = new List<string>();
            var data = db.Phongs.Select(p => new { p.TenPhong }).Distinct();
            foreach(var i in data)
            {
                l.Add(i.TenPhong);
            }
            return l;
        }
    }
}
