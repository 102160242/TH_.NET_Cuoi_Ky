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
        public dynamic ShowNguoiQL_BLL(string tuKhoa = "")
        {
            var person = db.NguoiQLs.Select(p => new { p.MaNguoiQL, p.TenNguoiQL, p.NgaySinh, p.SoDT, p.GioiTinh });
            if(tuKhoa != "")
            {
                person = person.Where(p => p.TenNguoiQL.Contains(tuKhoa));
            }
            return person.ToList();
        }
        public List<DTO.NguoiQL> GetNguoiQLById(int id)
        {
            var person = from p in db.NguoiQLs where p.MaNguoiQL == id select p;
            return person.ToList<DTO.NguoiQL>();
        }
        public Boolean addNguoiQL(DTO.NguoiQL nguoiQL)
        {
            try
            {
                db.NguoiQLs.Add(nguoiQL);
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
        public Boolean updateNguoiQL(DTO.NguoiQL nguoiQL)
        {
            try
            {
                var data = db.NguoiQLs.SingleOrDefault(p => p.MaNguoiQL == nguoiQL.MaNguoiQL);

                // Cap nhat du lieu moi
                data.TenNguoiQL = nguoiQL.TenNguoiQL;
                data.NgaySinh = nguoiQL.NgaySinh;
                data.SoDT = nguoiQL.SoDT;
                data.GioiTinh = nguoiQL.GioiTinh;
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
        public Boolean deleteNguoiQL(List<int> l)
        {
            try
            {
                foreach (int maNguoiQL in l)
                {
                    db.NguoiQLs.Remove(db.NguoiQLs.Single(p => p.MaNguoiQL == maNguoiQL));
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
