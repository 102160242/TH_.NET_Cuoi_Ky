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
        public (bool, string) addNhaCC(List<DTO.NhaCC> l)
        {
            try
            {
                foreach(DTO.NhaCC nhaCC in l)
                {
                    db.NhaCCs.Add(nhaCC);
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
            return (true, "Thêm Nhà Cung Cấp mới thành công!");
        }
        public (bool, string) updateNhaCC(DTO.NhaCC nhaCC)
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
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
            return (true, "Update thành công!");
        }
        public (bool, string) deleteNhaCC(List<int> l)
        {
            try
            {
                foreach (int maNhaCC in l)
                {
                    // Kiem tra xem con Tai San nao thuoc Loai Tai San nay hay khong
                    int count = db.NhapXuats.Where(p => p.MaNhaCC == maNhaCC).Count();
                    if (count > 0)
                    {
                        return (false, "Không thể xóa Nhà cung cấp có mã số " + maNhaCC + " do có trong danh sách Nhập/Xuất!");
                    }
                    db.NhaCCs.Remove(db.NhaCCs.Single(p => p.MaNhaCC == maNhaCC));
                    db.SaveChanges();
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return (false, "Đã có lỗi xảy ra, một (hoặc nhiều) Nhà Cung Cấp đã không thể được xóa. Vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Đã có lỗi xảy ra, một (hoặc nhiều) Nhà Cung Cấp đã không thể được xóa. Vui lòng thử lại sau!");
            }
            return (true, "Xóa thành công");
        }
        public int GetIdByNhaCC (string NCC)
        {
            try
            {
                return db.NhaCCs.Where(p => p.TenNhaCC == NCC).Select(p => p.MaNhaCC).Single();
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
    }
}
