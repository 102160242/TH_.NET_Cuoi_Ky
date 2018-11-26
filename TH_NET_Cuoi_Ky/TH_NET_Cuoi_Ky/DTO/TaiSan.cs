using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH_NET_Cuoi_Ky.DTO
{
    [Table("TaiSan")]
    public class TaiSan
    {
        [Key]
        public int MaTS { get; set; }
        [Required]
        public string TenTS { get; set; }
        [StringLength(50)]
        [Required]
        public string TSKT { get; set; }
        [StringLength(50)]
        [Required]
        public string DVTinh { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime NamSX { get; set; }
        [Required]
        public int MaNuocSX { get; set; }
        [Required]
        public int MaLoaiTS { get; set; }
        public string GhiChu { get; set; }
        [ForeignKey("MaNuocSX")]
        public virtual NuocSX NuocSX { get; set; }
        [ForeignKey("MaLoaiTS")]
        public virtual LoaiTS LoaiTS { get; set; }
        public virtual ICollection<NhapXuat> NhapXuat { get; set; }
    }
}
