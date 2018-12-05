using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;

namespace TH_NET_Cuoi_Ky.BLL
{
    class NhaCC_BLL
    {
        QLCSVC db;
        public NhaCC_BLL()
        {
            db = new QLCSVC();
        }
        public List<string> loadCBBTenNCC()
        {
            List<string> l = new List<string>();
            var data = db.NhaCCs.Select(p => new { p.TenNhaCC }).Distinct();
            foreach(var i in data)
            {
                l.Add(i.TenNhaCC);
            }
            return l;
        }
        public List<string> loadCBBDiaChiNCC()
        {
            List<string> l = new List<string>();
            var data = db.NhaCCs.Select(p => new { p.DiaChi }).Distinct();
            foreach (var i in data)
            {
                l.Add(i.DiaChi);
            }
            return l;
        }
        public dynamic ShowNhaCC_BLL(string tuKhoa = "")
        {
            var nha = db.NhaCCs.Select(p => new { p.MaNhaCC, p.TenNhaCC, p.DiaChi });
            if (tuKhoa != "")
            {
               nha = nha.Where(p => p.TenNhaCC.Contains(tuKhoa));
            }
            return nha.ToList();
        }
        public List<DTO.NhaCC> GetNhaCCById(int id)
        {
            var nha = from p in db.NhaCCs where p.MaNhaCC == id select p;
            return nha.ToList<DTO.NhaCC>();
        }
        public Boolean addNhaCC(DTO.NhaCC nhaCC)
        {
            try
            {
                db.NhaCCs.Add(nhaCC);
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
        public Boolean updateNhaCC(DTO.NhaCC nhaCC)
        {
            try
            {
                var data = db.NhaCCs.SingleOrDefault(p => p.MaNhaCC == nhaCC.MaNhaCC);

                // Cap nhat du lieu moi
                data.TenNhaCC = nhaCC.TenNhaCC;
                data.DiaChi = nhaCC.DiaChi;
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
        public Boolean deleteNhaCC(List<int> l)
        {
            try
            {
                foreach (int maNhaCC in l)
                {
                    db.NhaCCs.Remove(db.NhaCCs.Single(p => p.MaNhaCC == maNhaCC));
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
