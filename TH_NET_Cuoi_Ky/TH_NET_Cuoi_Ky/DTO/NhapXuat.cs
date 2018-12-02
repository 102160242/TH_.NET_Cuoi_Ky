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
        [Required]
        public int MaTS { get; set; }
        [Required]
        public int MaNhaCC { get; set; }
        [Required]
        public int MaPhong { get; set; }
        public Nullable<DateTime> NgayNhap { get; set; }
        public Nullable<int> SLNhap { get; set; }
        public Nullable<DateTime> NgayXuat { get; set; }
        public Nullable<int> SLXuat { get; set; }
        [Required]
        public double NguyenGia { get; set; }
        [Required]
        public Nullable<int> NamSD { get; set; }
        [StringLength(50)]
        [Required]
        public string TinhTrang { get; set; }
        [ForeignKey("MaTS")]
        public virtual TaiSan TaiSan { get; set; }
        [ForeignKey("MaNhaCC")]
        public virtual NhaCC NhaCC { get; set; }
        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }
    }
}
