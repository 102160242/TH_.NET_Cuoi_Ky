using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;

namespace TH_NET_Cuoi_Ky.BLL
{
    class NhapXuat_BLL
    {
        QLCSVC db;
        public NhapXuat_BLL()
        {
            db = new QLCSVC();
        }
        public dynamic ShowNhap_BLL()
        {
            var data = db.NhapXuats.Where(p => p.NgayNhap != null)
                                   .OrderBy(p => new { p.SoPhieu, p.TaiSan.TenTS, p.NgayNhap, p.Phong.TenPhong })
                                   .Select(p => new {
                                                         p.SoPhieu,
                                                         p.TaiSan.TenTS,
                                                         p.NhaCC.TenNhaCC,
                                                         p.Phong.TenPhong,
                                                         p.NgayNhap, p.SLNhap,
                                                         p.NguyenGia,
                                                         NamSD = p.NamSD == null ? 0 : p.NamSD,
                                                         p.TinhTrang
                                                     });
            return data.ToList();
        }
        public dynamic ShowXuat_BLL()
        {
            var data = db.NhapXuats.Where(p => p.NgayXuat != null)
                                   .OrderBy(p => new { p.SoPhieu, p.TaiSan.TenTS, p.NgayNhap, p.Phong.TenPhong })
                                   .Select(p => new {
                                                       p.SoPhieu,
                                                       p.TaiSan.TenTS,
                                                       p.NhaCC.TenNhaCC,
                                                       p.Phong.TenPhong,
                                                       p.NgayXuat,
                                                       p.SLXuat,
                                                       p.NguyenGia,
                                                       NamSD = p.NamSD == null ? 0 : p.NamSD,
                                                       p.TinhTrang
                                                   });
            return data.ToList();
        }
        public (bool, string) AddNhapXuat(List<DTO.NhapXuat> l)
        {
            try
            {
                foreach (DTO.NhapXuat i in l)
                {
                    db.NhapXuats.Add(i);
                }
                db.SaveChanges();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return (false, "Có lỗi xảy ra, vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return(false, "Có lỗi xảy ra, vui lòng thử lại sau!");
            }
            return (true, "Thành công!");
        }
        public (bool , string) Update_Nhap (DTO.NhapXuat NX)
        {
            try
            {
                var data = db.NhapXuats.SingleOrDefault(p => p.SoPhieu == NX.SoPhieu);
                data.MaTS = NX.MaTS;
                data.MaNhaCC = NX.MaNhaCC;
                data.MaPhong = NX.MaPhong;
                data.NgayNhap = NX.NgayNhap;
                data.SLNhap = NX.SLNhap;
                data.NguyenGia = NX.NguyenGia;
                data.TinhTrang = NX.TinhTrang;
                db.SaveChanges();
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
            return(true, "Cập nhật thành công!");
        }
        public(bool ,string) Update_Xuat(DTO.NhapXuat NX)
        {
            try
            {
                var data = db.NhapXuats.SingleOrDefault(p => p.SoPhieu == NX.SoPhieu);
                data.MaTS = NX.MaTS;
                data.MaNhaCC = NX.MaNhaCC;
                data.MaPhong = NX.MaPhong;
                data.NgayXuat = NX.NgayXuat;
                data.SLXuat = NX.SLXuat;
                data.NguyenGia = NX.NguyenGia;
                data.TinhTrang = NX.TinhTrang;
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
            return (true, "Cập nhật thành công!");
        }
        public(bool,string) deleteNX(List<int>l)
        {
            try
            {
                foreach(int i in l)
                {
                    db.NhapXuats.Remove(db.NhapXuats.Single(p => p.SoPhieu == i));
                }
                db.SaveChanges();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return (false, "Một (hoặc nhiều) Phiếu đã không thể xóa do có lỗi xảy ra!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Một (hoặc nhiều) Phiếu đã không thể xóa do có lỗi xảy ra!");
            }
            return (true, "Xóa thành công!");
        }
        public int check_Nhap(int sp)
        {
            var getinfo = db.NhapXuats.Where(p => p.SoPhieu == sp)
                                      .Select(p => new { p.MaTS, p.MaNhaCC, p.MaPhong }).SingleOrDefault();

            var getslnhap = (from p in db.NhapXuats
                             where p.SoPhieu != sp
                             where p.MaNhaCC == getinfo.MaNhaCC
                             where p.MaTS == getinfo.MaTS
                             where p.MaPhong == getinfo.MaPhong
                             select new { p.SLNhap }).Sum(p => p.SLNhap).GetValueOrDefault();

            var getslxuat = (from p in db.NhapXuats
                             where p.MaNhaCC == getinfo.MaNhaCC
                             where p.MaTS == getinfo.MaTS
                             where p.MaPhong == getinfo.MaPhong
                             select new { p.SLXuat }).Sum(p => p.SLXuat).GetValueOrDefault();

            return getslnhap - getslxuat;
        }
        public int Check_Xuat(int sp)
        {
            var getinfo = db.NhapXuats.Where(p => p.SoPhieu == sp)
                                      .Select(p => new { p.MaTS, p.MaNhaCC, p.MaPhong }).SingleOrDefault();

            int tongNhap = (from p in db.NhapXuats
                            where p.MaNhaCC == getinfo.MaNhaCC
                            where p.MaPhong == getinfo.MaPhong
                            where p.MaTS == getinfo.MaTS
                            select new { p.SLNhap }).Sum(p => p.SLNhap).GetValueOrDefault();

            int tongXuat = (from p in db.NhapXuats
                            where p.SoPhieu != sp
                            where p.MaNhaCC == getinfo.MaNhaCC
                            where p.MaPhong == getinfo.MaPhong
                            where p.MaTS == getinfo.MaTS
                            select new { p.SLXuat }).Sum(p => p.SLXuat).GetValueOrDefault();

            return tongNhap - tongXuat;

        }
        //biet dc so luong toi da co the xuat 
        public int getSLNhap (int mats , int maphong , int manhacc)
        {
            int tongnhap = (from p in db.NhapXuats
                            where p.MaTS == mats
                            where p.MaPhong == maphong
                            where p.MaNhaCC == manhacc
                            select new { p.SLNhap }).Sum(p => p.SLNhap).GetValueOrDefault();
            int tongxuat = (from p in db.NhapXuats
                            where p.MaTS == mats
                            where p.MaPhong == maphong
                            where p.MaNhaCC == manhacc
                            select new { p.SLXuat }).Sum(p => p.SLXuat).GetValueOrDefault();
            return tongnhap - tongxuat;
        }
    }
}
