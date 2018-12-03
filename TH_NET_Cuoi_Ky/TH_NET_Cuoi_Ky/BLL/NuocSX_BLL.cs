using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;

namespace TH_NET_Cuoi_Ky.BLL
{
    class NuocSX_BLL
    {
        QLCSVC db;
        public NuocSX_BLL()
        {
            db = new QLCSVC();
        }
        public List<String> loadCBB_BLL()
        {
            List<String> l = new List<string>();
            var data = db.NuocSXs.Select(p => new { p.TenNuocSX }).Distinct();
            foreach(var i in data)
            {
                l.Add(i.TenNuocSX);
            }
            return l;
        }
        public int getIDByName(string TenNuocSX)
        {
            try
            {
                return db.NuocSXs.Where(p => p.TenNuocSX == TenNuocSX).Select(p => p.MaNuocSX).Single();
            }
            //catch()
            catch(System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message);              
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            return -1;
        }
    }
}
