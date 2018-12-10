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
        public (bool, string) addPhong (List<DTO.Phong> l)
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
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            return (true, "Thêm Phòng mới thành công!");
        } 
        public int getIdByName (string s)
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
        public (bool, string) deletePhong(List<int> l)
        {
            try
            {
                foreach (int maPhong in l)
                {
                    int count = db.NhapXuats.Where(p => p.MaPhong == maPhong).Count();
                    if (count > 0)
                    {
                        return (false, "Không thể xóa Phòng có mã số " + maPhong + " do có trong danh sách Nhập/Xuất!");
                    }
                    db.Phongs.Remove(db.Phongs.Single(p => p.MaPhong == maPhong));
                }
                db.SaveChanges();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return (false, "Một (hoặc nhiều) Phòng đã không thể xóa do có lỗi xảy ra!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Một (hoặc nhiều) Phòng đã không thể xóa do có lỗi xảy ra!");
            }
            return (true, "Xóa thành công!");
        }
        public (bool, string) updatePhong(DTO.Phong phong)
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
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            return (true, "Cập nhật thành công!");
        }

        public List<DTO.Phong> getPhongById(int id)
        {
            var data = from p in db.Phongs
                       where p.MaPhong == id
                       select p;
            return data.ToList<DTO.Phong>();
        }
        public int GetIdByPhong(string Ph)
        {
            try
            {
                return db.Phongs.Where(p => p.TenPhong == Ph).Select(p => p.MaPhong).Single();
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
        public List<string> LoadCBB_Phong_AfterTenTSChose(string ts)
        {
            //var mats = db.TaiSans.Where(p => p.TenTS == ts).Select(p => p.MaTS).Single();
            //var data = db.NhapXuats.Where(p => p.MaTS == mats).Select(p => p.Phong.TenPhong);
            var data = db.NhapXuats.Where(p => p.TaiSan.TenTS == ts).Select(p => p.Phong.TenPhong);
            return data.ToList();
        }
    }
}
