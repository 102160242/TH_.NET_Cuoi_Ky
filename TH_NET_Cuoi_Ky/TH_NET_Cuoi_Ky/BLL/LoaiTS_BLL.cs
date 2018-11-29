using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL; 

namespace TH_NET_Cuoi_Ky.BLL
{
    class LoaiTS_BLL
    {
        QLCSVC db;
        public LoaiTS_BLL()
        {
            db = new QLCSVC();
        }
        public List<String> loadCBB_BLL()
        {
            List<String> l = new List<string>();
            var data = db.LoaiTSs.Select(p => new { p.TenLoaiTS }).Distinct();
            foreach(var i in data)
            {
                l.Add(i.TenLoaiTS);
            }
            return l;
        }
    }
}
