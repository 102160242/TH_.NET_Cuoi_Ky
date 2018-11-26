using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH_NET_Cuoi_Ky.DTO
{
    [Table("NhapXuat")]
    public class NhapXuat
    {
        [Key]
        public int SoPhieu { get; set; }
        public int MaTS { get; set; }
        public int MaNhaCC { get; set; }
        public int MaPhong { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SLNhap { get; set; }
        public DateTime NgayXuat { get; set; }
        public int SLxuat { get; set; }
        public double NguyenGia { get; set; }
        public int NamSD { get; set; }
        [StringLength(50)]
        public string TinhTrang { get; set; }
        [ForeignKey("MaTS")]
        public virtual TaiSan TaiSan { get; set; }
        [ForeignKey("MaNhaCC")]
        public virtual NhaCC NhaCC { get; set; }
        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }
    }
}
