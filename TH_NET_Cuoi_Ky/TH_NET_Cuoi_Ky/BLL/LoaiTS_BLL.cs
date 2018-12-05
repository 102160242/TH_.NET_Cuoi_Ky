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

        public dynamic Show_BLL(string s = "")
        {
            var data = from p in db.LoaiTSs
                       select new { p.MaLoaiTS, p.TenLoaiTS };
            if (s != "")
            {
                data = data.Where(p => p.TenLoaiTS.Contains(s));
            }
            return data.ToList();
        }

        internal bool addLoaiTS(List<DTO.LoaiTS> l)
        {
            try
            {
                foreach (DTO.LoaiTS i in l)
                {
                    db.LoaiTSs.Add(i);
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
        
        public List<DTO.LoaiTS> getLoaiTSByID(int id)
        {
            var data = from p in db.LoaiTSs
                       where p.MaLoaiTS == id
                       select p;
            return data.ToList<DTO.LoaiTS>();
        }

        internal bool updateLoaiTS(DTO.LoaiTS loaiTS)
        {
            try
            {
                var data = db.LoaiTSs.SingleOrDefault(p => p.MaLoaiTS == loaiTS.MaLoaiTS);

                // Cap nhat du lieu moi
                data.TenLoaiTS = loaiTS.TenLoaiTS;

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

        internal bool deleteLoaiTS(List<int> l)
        {
            try
            {
                foreach (int maLoaiTS in l)
                {
                    db.LoaiTSs.Remove(db.LoaiTSs.Single(p => p.MaLoaiTS == maLoaiTS));
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
