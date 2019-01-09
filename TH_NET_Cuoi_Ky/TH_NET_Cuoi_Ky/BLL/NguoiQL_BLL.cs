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
            var person = db.NguoiQLs.Select(p => new { p.MaNguoiQL, p.TenNguoiQL, p.NgaySinh, p.SoDT, GioiTinh = (p.GioiTinh) ? "Nam" : "Nữ" });
            if (tuKhoa != "")
            {
                person = person.Where(p => p.TenNguoiQL.Contains(tuKhoa));
            }
            return person.AsEnumerable().Select(
                                            (p, index) => new { STT = index + 1, p.MaNguoiQL, p.TenNguoiQL, p.NgaySinh, p.SoDT, p.GioiTinh }
                                        ).ToList();
        }
        public List<DTO.NguoiQL> GetNguoiQLById(int id)
        {
            var person = from p in db.NguoiQLs where p.MaNguoiQL == id select p;
            return person.ToList<DTO.NguoiQL>();
        }
        public (bool, string) addNguoiQL(List<DTO.NguoiQL> l)
        {
            try
            {
                foreach(DTO.NguoiQL nguoiQL in l)
                {
                    db.NguoiQLs.Add(nguoiQL);
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
            return (true, "Thêm Người Quản Lý mới thành công!");
        }
        public (bool, string) updateNguoiQL(DTO.NguoiQL nguoiQL)
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
                return (false, "Cập nhật thất bại, vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Cập nhật thất bại, vui lòng thử lại sau!");
            }
            return (true, "Cập nhật thành công!");
        }
        public (bool, string) deleteNguoiQL(List<int> l)
        {
            try
            {
                foreach (int maNguoiQL in l)
                {
                    int count = db.Phongs.Where(p => p.MaNguoiQL == maNguoiQL).Count();
                    if(count > 0)
                    {
                        return (false, "Không thể xóa Người quản lý có mã số " + maNguoiQL + " do có trong danh sách Phòng!");
                    }
                    db.NguoiQLs.Remove(db.NguoiQLs.Single(p => p.MaNguoiQL == maNguoiQL));
                    db.SaveChanges();
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return (false, "Xóa thất bại, vui lòng thử lại sau!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Xóa thất bại, vui lòng thử lại sau!");
            }
            return (true, "Đã xóa thành công");
        }
        public List<string> loadcbb()
        {
            List<string> l = new List<string>();
            var data = db.NguoiQLs.Select(p => p.TenNguoiQL).Distinct();
            foreach(var i in data)
            {
                l.Add(i);
            }
            return l;
        }
    }
}
