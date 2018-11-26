using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH_NET_Cuoi_Ky.DTO
{
    [Table("Phong")]
    public class Phong
    {
        [Key]
        public int MaPhong { get; set; }
        [StringLength(50)]
        [Required]
        public string TenPhong { get; set; }
        [Required]
        public int MaNguoiQL { get; set; }
        [ForeignKey("MaNguoiQL")]
        public virtual NguoiQL NguoiQL { get; set; }
        public ICollection<NhapXuat> NhapXuat { get; set; }
    }
}
