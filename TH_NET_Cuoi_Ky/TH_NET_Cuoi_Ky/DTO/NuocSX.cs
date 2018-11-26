using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH_NET_Cuoi_Ky.DTO
{
    [Table("NuocSX")]
    public class NuocSX
    {
        [Key]
        public int MaNuocSX { get; set; }
        [StringLength(50)]
        [Required]
        public string TenNuocSX { get; set; }
        public ICollection<TaiSan> TaiSan { get; set; }
    }
}
