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
                return db.LoaiTSs.Where(p => p.TenLoaiTS == TenLoaiTS).Select(p => p.MaLoaiTS).First();
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
            return data.AsEnumerable().Select((p, index) => new { STT = index + 1, p.MaLoaiTS, p.TenLoaiTS }).ToList();
        }

        public (bool, string) addLoaiTS(List<DTO.LoaiTS> l)
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
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            return (true, "Đã thêm thành công!");
        }
        
        public List<DTO.LoaiTS> getLoaiTSByID(int id)
        {
            var data = from p in db.LoaiTSs
                       where p.MaLoaiTS == id
                       select p;
            return data.ToList<DTO.LoaiTS>();
        }

        public (bool, string) updateLoaiTS(DTO.LoaiTS loaiTS)
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
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            return (true, "Update thành công!");
        }

        public (bool, string) deleteLoaiTS(List<int> l)
        {
            try
            {
                foreach (int maLoaiTS in l)
                {
                    // Kiem tra xem con Tai San nao thuoc Loai Tai San nay hay khong
                    int count = db.TaiSans.Where(p => p.MaLoaiTS == maLoaiTS).Count();
                    if (count > 0)
                    {
                        return (false, "Không thể xóa Loại tài sản có mã số " + maLoaiTS + " do còn Tài sản nào thuộc loại này!");
                    }
                    db.LoaiTSs.Remove(db.LoaiTSs.Single(p => p.MaLoaiTS == maLoaiTS));
                }
                db.SaveChanges();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return (false, "Đã có lỗi xảy ra, một (hoặc nhiều) Loại Tài Sản đã không thể được xóa. Vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Đã có lỗi xảy ra, một (hoặc nhiều) Loại Tài Sản đã không thể được xóa. Vui lòng thử lại sau!");
            }
            return (true, "Xóa thành công");
        }
    }
}
