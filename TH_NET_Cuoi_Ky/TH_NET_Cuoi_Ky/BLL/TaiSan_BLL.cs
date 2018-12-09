using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;

namespace TH_NET_Cuoi_Ky.BLL
{
    class TaiSan_BLL
    {
        QLCSVC db;
        public TaiSan_BLL()
        {
            db = new QLCSVC();
        }
        public dynamic ShowTS_BLL()
        {
            // Lay danh sach nhap TS
            var nhap = from p in db.NhapXuats
                       group p by p.MaTS into g
                       select new { MaTS = g.Key, SL = g.Sum(p => p.SLNhap) == null ? 0 : g.Sum(p => p.SLNhap) };
            // Lay danh sach xuat TS
            var xuat = from p in db.NhapXuats
                       group p by p.MaTS into g
                       select new { MaTS = g.Key, SL = g.Sum(p => p.SLXuat) == null ? 0 : g.Sum(p => p.SLXuat) };

            var data = from p in db.TaiSans
                       join T in 
                       (
                            // Join danh sach nhap va xuat de tinh so luong hien co
                            from p1 in nhap
                            join p2 in xuat
                            on p1.MaTS equals p2.MaTS
                            select new { p1.MaTS, SLHienCo = (p1.SL - p2.SL) }
                       )
                       on p.MaTS equals T.MaTS
                       into ps
                       from T in ps.DefaultIfEmpty()
                       select new
                       {
                           p.MaTS,
                           p.TenTS,
                           p.TSKT,
                           p.DVTinh,
                           SLHienCo = T.SLHienCo == null ? 0 : T.SLHienCo,
                           p.NamSX,
                           p.NuocSX.TenNuocSX,
                           p.LoaiTS.TenLoaiTS,
                           p.GhiChu,
                       };
            return data.ToList();
        }
        public dynamic SearchTS(Dictionary<String, String> s)
        {
            var data = from p in db.TaiSans                  
                       select new
                       {
                           p.MaTS,
                           p.TenTS,
                           p.TSKT,
                           p.DVTinh,
                           p.NamSX,
                           p.NuocSX.TenNuocSX,
                           p.LoaiTS.TenLoaiTS,
                           p.GhiChu,
                       };

            // Kiem tra filter Nuoc San Xuat
            if (s.ContainsKey("NuocSX") && s["NuocSX"] != "")
            {
                string t;
                s.TryGetValue("NuocSX", out t);

                data = from p in data
                        where p.TenNuocSX.Contains(t)
                        select p;
            }
            // Kiem tra filter Loai Tai San
            if (s.ContainsKey("LoaiTS") && s["LoaiTS"] != "")
            {
                string t;
                s.TryGetValue("LoaiTS", out t);

                data = from p in data
                        where p.TenLoaiTS.Contains(t)
                        select p;
            }
            // Kiem tra tu khoa tim kiem
            if (s.ContainsKey("TuKhoa") && s["TuKhoa"] != "")
            {
                string tuKhoa;
                s.TryGetValue("TuKhoa", out tuKhoa);
                data = from p in data
                        where p.TenTS.Contains(tuKhoa)
                        select p;
            }
            
            return data.ToList();
        }
        public List<DTO.TaiSan> getTSById(int id)
        {
            var data = from p in db.TaiSans
                       where p.MaTS == id
                       select p;
            return data.ToList<DTO.TaiSan>();
        }
        public (bool, string) updateTS(DTO.TaiSan TS)
        {
            try
            {
                var data = db.TaiSans.SingleOrDefault(p => p.MaTS == TS.MaTS);

                // Cap nhat du lieu moi
                data.TenTS = TS.TenTS;
                data.DVTinh = TS.DVTinh;
                data.TSKT = TS.TSKT;
                data.MaNuocSX = TS.MaNuocSX;
                data.NamSX = TS.NamSX;
                data.MaLoaiTS = TS.MaLoaiTS;
                data.GhiChu = TS.GhiChu;

                db.SaveChanges(); // Cap nhat thay doi vao DB
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            return (true, "Cập nhật thành công!");
        }
        public (bool, string) addTS(List<DTO.TaiSan> l)
        {
            try
            {
                foreach(DTO.TaiSan i in l)
                {
                    db.TaiSans.Add(i);
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
            return (true, "Thêm Tài Sản mới thành công!");
        }
        public (bool, string) deleteTS(List<int> l)
        {
            try
            {
                foreach(int maTS in l)
                {
                    //DTO.TaiSan t = new DTO.TaiSan { MaTS = maTS };
                    //db.TaiSans.Attach(t);
                    //db.TaiSans.Remove(t);
                    int count = db.NhapXuats.Where(p => p.MaTS == maTS).Count();
                    if (count > 0)
                    {
                        return (false, "Không thể xóa Tài Sản có mã số " + maTS + " do có trong danh sách Nhập/Xuất!");
                    }
                    db.TaiSans.Remove(db.TaiSans.Single(p => p.MaTS == maTS));
                }
                db.SaveChanges();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return (false, "Một (hoặc nhiều) Tài Sản đã không thể xóa do có lỗi xảy ra!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Một (hoặc nhiều) Tài Sản đã không thể xóa do có lỗi xảy ra!");
            }
            return (true, "Xóa thành công!");
        }

        public object ShowTSDetail(int maTS)
        {
            // Lay List Danh sach nhap va so luong
            var nhap = from p in db.NhapXuats
                       where p.NgayXuat == null
                       where p.MaTS == maTS
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
                       where p.MaTS == maTS
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
    }
}
