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
    }
}
