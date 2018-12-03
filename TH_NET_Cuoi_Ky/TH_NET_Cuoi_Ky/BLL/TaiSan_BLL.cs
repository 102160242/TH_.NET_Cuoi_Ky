using System;
using System.Collections.Generic;
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
            //var data = db.TaiSans.Select(p => new { p.MaTS, p.TenTS, p.Tskt, p.DvTinh, p.NamSx, p.NuocSX.TenNuocSX, p.LoaiT.TenLoaiTS, p.GhiChu});
            //IEnumerable<TaiSan> data = from p in db.TaiSans
            //                           select new TaiSan { p.MaTS};
            var data = from p in db.TaiSans
                       join T in
                       (
                            from p1 in (from nhap in db.NhapXuats group nhap by nhap.MaTS into g select new { MaTS = g.Key, SL = g.Sum(nhap => nhap.SLNhap) == null ? 0 : g.Sum(nhap => nhap.SLNhap) })
                            join p2 in (from xuat in db.NhapXuats group xuat by xuat.MaTS into g select new { MaTS = g.Key, SL = g.Sum(xuat => xuat.SLXuat) == null ? 0 : g.Sum(xuat => xuat.SLXuat) })
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
                           NamSX = p.NamSX.Year,
                           p.NuocSX.TenNuocSX,
                           p.LoaiTS.TenLoaiTS,
                           p.GhiChu,
                       };
            return data.ToList();
        }
        public List<DTO.TaiSan> getTSById(int id)
        {
            var data = from p in db.TaiSans
                       where p.MaTS == id
                       select p;
            return data.ToList<DTO.TaiSan>();
        }
        public Boolean updateTS(DTO.TaiSan TS)
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
                return false;
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
            return true;
        }
        public Boolean addTS(DTO.TaiSan TS)
        {
            try
            {
                db.TaiSans.Add(TS);
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
        public Boolean deleteTS(List<int> l)
        {
            try
            {
                foreach(int maTS in l)
                {
                    //DTO.TaiSan t = new DTO.TaiSan { MaTS = maTS };
                    //db.TaiSans.Attach(t);
                    //db.TaiSans.Remove(t);
                    db.TaiSans.Remove(db.TaiSans.Single(p => p.MaTS == maTS));
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
