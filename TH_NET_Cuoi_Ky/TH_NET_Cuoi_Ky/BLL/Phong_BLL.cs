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

        public dynamic ShowPhongDetail(int maPhong)
        {
            // Lay List Danh sach nhap va so luong
            var nhap = from p in db.NhapXuats
                       where p.NgayXuat == null
                       where p.MaPhong == maPhong
                       group p by new { p.MaTS, p.MaNhaCC, p.MaPhong } into g
                       select new
                       {
                           MaTS = g.Key.MaTS,
                           MaNhaCC = g.Key.MaNhaCC,
                           MaPhong = g.Key.MaPhong,
                           SL = g.Sum(p => p.SLNhap) == null ? 0 : g.Sum(p => p.SLNhap)
                       };
            // Lay List Danh sach xuat va so luong
            var xuat = from p in db.NhapXuats
                       where p.NgayNhap == null
                       where p.MaPhong == maPhong
                       group p by new { p.MaTS, p.MaNhaCC, p.MaPhong } into g
                       select new
                       {
                           MaTS = g.Key.MaTS,
                           MaNhaCC = g.Key.MaNhaCC,
                           MaPhong = g.Key.MaPhong,
                           SL = g.Sum(p => p.SLXuat) == null ? 0 : g.Sum(p => p.SLXuat)
                       };
            // Join list nhap va xuat lai
            var list = from p in nhap
                       join p2 in xuat
                       on new { p.MaTS, p.MaNhaCC, p.MaPhong } equals new { p2.MaTS, p2.MaNhaCC, p2.MaPhong }
                       into ps
                       from T in ps.DefaultIfEmpty()
                       select new
                       {
                           p.MaTS,
                           p.MaNhaCC,
                           p.MaPhong,
                           SL = p.SL - (T.SL == null ? 0 : T.SL),
                       };
            // Join voi cac bang khac de lay ten Tai San, ten Phong, ten Nha Cung Cap
            var data = from nx in list
                       join ts in
                       (
                            from p in db.TaiSans select new { p.MaTS, p.TenTS }
                       )
                       on nx.MaTS equals ts.MaTS
                       join ncc in
                       (
                            from p in db.NhaCCs select new { p.MaNhaCC, p.TenNhaCC }
                       )
                       on nx.MaNhaCC equals ncc.MaNhaCC
                       join p in
                       (
                            from p in db.Phongs select new { p.MaPhong, p.TenPhong }
                       )
                       on nx.MaPhong equals p.MaPhong
                       where nx.SL != 0
                       select new
                       {
                           nx.MaTS,
                           ts.TenTS,
                           ncc.TenNhaCC,
                           p.TenPhong,
                           nx.SL,
                       };
            return data.ToList();
        }

        public dynamic ShowPhong_BLL()
        {
            // Lay danh sach nhap TS
            var nhap = from p in db.NhapXuats
                       group p by p.MaPhong into g
                       select new { MaPhong = g.Key, SL = g.Sum(p => p.SLNhap) == null ? 0 : g.Sum(p => p.SLNhap) };
            // Lay danh sach xuat TS
            var xuat = from p in db.NhapXuats
                       group p by p.MaPhong into g
                       select new { MaPhong = g.Key, SL = g.Sum(p => p.SLXuat) == null ? 0 : g.Sum(p => p.SLXuat) };

            var data = from p in db.Phongs
                       join T in
                       (
                            // Join danh sach nhap va xuat de tinh so luong hien co
                            from p1 in nhap
                            join p2 in xuat
                            on p1.MaPhong equals p2.MaPhong
                            select new { p1.MaPhong, SLHienCo = (p1.SL - p2.SL) }
                       )
                       on p.MaPhong equals T.MaPhong
                       into ps
                       from T in ps.DefaultIfEmpty()
                       orderby p.MaPhong
                       select new
                       {
                           p.MaPhong,
                           p.TenPhong,
                           p.NguoiQL.TenNguoiQL,
                           SLHienCo = T.SLHienCo == null ? 0 : T.SLHienCo,
                       };
            return data.AsEnumerable().Select(
                                            (p, index) => new { STT = index + 1, p.MaPhong, p.TenPhong, p.TenNguoiQL, p.SLHienCo }
                                        ).ToList();
        }
        public dynamic SearhPhong_BLL(string tukhoa = "")
        {
            var phong = db.Phongs.Where(p => p.TenPhong.Contains(tukhoa)).Select(p => new { p.MaPhong, p.TenPhong, p.NguoiQL.TenNguoiQL });
            return phong.AsEnumerable().Select(
                                            (p, index) => new { STT = index + 1, p.MaPhong, p.TenPhong, p.TenNguoiQL }
                                        ).ToList();
        }
        public (bool, string) addPhong(List<DTO.Phong> l)
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
        public int getIdByName(string s)
        {
            try
            {
                return db.NguoiQLs.Where(p => p.TenNguoiQL == s).Select(p => p.MaNguoiQL).First();
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
        public int getIDByName(string Ph)
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
