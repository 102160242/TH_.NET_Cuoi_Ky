using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;
using TH_NET_Cuoi_Ky.DTO;

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
        public dynamic Show_BLL(string s = "")
        {
            var data = from p in db.NuocSXs
                       select new { p.MaNuocSX, p.TenNuocSX };
            if(s != "")
            {
                data = data.Where(p => p.TenNuocSX.Contains(s));
            }
            return data.ToList();
        }

        internal bool addNSX(List<NuocSX> l)
        {
            try
            {
                foreach (DTO.NuocSX i in l)
                {
                    db.NuocSXs.Add(i);
                }
                db.SaveChanges();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return false;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
            return true;
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
        public List<DTO.NuocSX> getNSXByID(int id)
        {
            var data = from p in db.NuocSXs
                       where p.MaNuocSX == id
                       select p;
            return data.ToList<DTO.NuocSX>();
        }

        internal bool updateTS(DTO.NuocSX NSX)
        {
            try
            {
                var data = db.NuocSXs.SingleOrDefault(p => p.MaNuocSX == NSX.MaNuocSX);

                // Cap nhat du lieu moi
                data.TenNuocSX = NSX.TenNuocSX;

                db.SaveChanges(); // Cap nhat thay doi vao DB
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return false;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
            return true;
        }

        internal bool deleteTS(List<int> l)
        {
            try
            {
                foreach (int maNSX in l)
                {
                    //if (db.NuocSXs.Single(p => p.MaNuocSX == maNSX).TaiSan.Count > 0) return false;
                    db.NuocSXs.Remove(db.NuocSXs.Single(p => p.MaNuocSX == maNSX));
                }
                db.SaveChanges();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return false;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
            return true;
        }
    }
}
