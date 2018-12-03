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

        public int getIDByName(string TenLoaiTS)
        {
            try
            {
                return db.LoaiTSs.Where(p => p.TenLoaiTS == TenLoaiTS).Select(p => p.MaLoaiTS).Single();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return -1;
        }
    }
}
