using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH_NET_Cuoi_Ky.DTO
{
    [Table("LoaiTS")]
    public class LoaiTS
    {
        [Key]
        public int MaLoaiTS { get; set; }
        [StringLength(50)]
        [Required]
        public string TenLoaiTS { get; set; }
        public ICollection<TaiSan> TaiSan { get; set; }
    }
}
