using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;
using TH_NET_Cuoi_Ky.DTO;

namespace TH_NET_Cuoi_Ky.BLL
{
    class Phong_BLL
    {
        QLCSVC db;
        public Phong_BLL()
        {
            db = new QLCSVC();
        }
        public List<string> loadCBBTenPhong_BLL()
        {
            List<string> l = new List<string>();
            var data = db.Phongs.Select(p => new { p.TenPhong }).Distinct();
            foreach(var i in data)
            {
                l.Add(i.TenPhong);
            }
            return l;
        }
        public dynamic ShowPhong_BLL(string tukhoa = "")
        {
            var phong = db.Phongs.Select(p => new { p.MaPhong, p.TenPhong, p.NguoiQL.TenNguoiQL });
            if(tukhoa != "")
            {
                phong = phong.Where(p => p.TenPhong.Contains(tukhoa));
            }
            return phong.ToList();
        }
        public Boolean AddPhong (List<DTO.Phong> l)
        {
            try
            {
                foreach (DTO.Phong phong in l)
                {
                    db.Phongs.Add(phong);
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
        public int GetMaNQL (string s)
        {
            try
            {
                return db.NguoiQLs.Where(p => p.TenNguoiQL == s).Select(p => p.MaNguoiQL).Single();
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
        public Boolean DeletePhong(List<int> l)
        {
            try
            {
                foreach (int Maphong in l)
                {
                    db.Phongs.Remove(db.Phongs.Single(p => p.MaPhong == Maphong));
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
        public Boolean UpdatePhong (DTO.Phong phong)
        {
            try
            {
                var data = db.Phongs.SingleOrDefault(p => p.MaPhong == phong.MaPhong);

                // Cap nhat du lieu moi
                data.TenPhong = phong.TenPhong;
                data.MaNguoiQL = phong.MaNguoiQL;
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

        internal List<Phong> getPhongById(int id)
        {
            var data = from p in db.Phongs
                       where p.MaPhong == id
                       select p;
            return data.ToList<DTO.Phong>();
        }
    }
}
