﻿using System;
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
                                   .Select(p => new {
                                                         p.TaiSan.TenTS,
                                                         p.NhaCC.TenNhaCC,
                                                         p.Phong.TenPhong,
                                                         p.NgayNhap, p.SLNhap,
                                                         p.NguyenGia,
                                                         NamSD = p.NamSD == null ? 0 : p.NamSD,
                                                         p.TinhTrang
                                                     });
            /*var data = from p in db.NhapXuats
                       join t in db.TaiSans*/
            return data.ToList();
        }
        public dynamic ShowXuat_BLL()
        {
            var data = db.NhapXuats.Where(p => p.NgayXuat != null)
                                   .Select(p => new {
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
        public Boolean AddNhapXuat(List<DTO.NhapXuat> l)
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
