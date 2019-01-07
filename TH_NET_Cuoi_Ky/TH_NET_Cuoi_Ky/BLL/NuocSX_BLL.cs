using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;
using TH_NET_Cuoi_Ky.DTO;

namespace TH_NET_Cuoi_Ky.BLL
{
    class NuocSX_BLL
    {
        QLCSVC db;
        public NuocSX_BLL()
        {
            db = new QLCSVC();
        }
        public List<String> loadCBB_BLL()
        {
            List<String> l = new List<string>();
            var data = db.NuocSXs.Select(p => new { p.TenNuocSX }).Distinct();
            foreach(var i in data)
            {
                l.Add(i.TenNuocSX);
            }
            return l;
        }
        public dynamic Show_BLL(string s = "")
        {
            var data = from p in db.NuocSXs
                       select new { p.MaNuocSX, p.TenNuocSX };
            if(s != "")
            {
                data = data.Where(p => p.TenNuocSX.Contains(s));
            }
            return data.ToList();
        }

        public (bool, string) addNSX(List<DTO.NuocSX> l)
        {
            try
            {
                foreach (DTO.NuocSX i in l)
                {
                    db.NuocSXs.Add(i);
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
            return (true, "Thêm Nước Sản Xuất mới thành công!");
        }

        public int getIDByName(string TenNuocSX)
        {
            try
            {
                return db.NuocSXs.Where(p => p.TenNuocSX == TenNuocSX).Select(p => p.MaNuocSX).First();
            }
            //catch()
            catch(System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message);              
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            return -1;
        }
        public List<DTO.NuocSX> getNSXByID(int id)
        {
            var data = from p in db.NuocSXs
                       where p.MaNuocSX == id
                       select p;
            return data.ToList<DTO.NuocSX>();
        }

        public (bool, string) updateTS(DTO.NuocSX NSX)
        {
            try
            {
                var data = db.NuocSXs.SingleOrDefault(p => p.MaNuocSX == NSX.MaNuocSX);

                // Cap nhat du lieu moi
                data.TenNuocSX = NSX.TenNuocSX;

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

        public (bool, string) deleteTS(List<int> l)
        {
            try
            {
                foreach (int maNSX in l)
                {
                    int count = db.TaiSans.Where(p => p.MaNuocSX == maNSX).Count();
                    if(count > 0)
                    {
                        return (false, "Không thể xóa Nước sản xuất có mã số " + maNSX + " do có trong danh sách Tài Sản!");
                    }
                    db.NuocSXs.Remove(db.NuocSXs.Single(p => p.MaNuocSX == maNSX));
                    db.SaveChanges();
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.Write("Loi SQL: " + e.Message); // Ghi loi ra Console
                return (false, "Một (hoặc nhiều) Nước Sản Xuất đã không thể xóa do có lỗi xảy ra!");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return (false, "Một (hoặc nhiều) Nước Sản Xuất đã không thể xóa do có lỗi xảy ra!");
            }
            return (true, "Đã xóa thành công!");
        }
    }
}
