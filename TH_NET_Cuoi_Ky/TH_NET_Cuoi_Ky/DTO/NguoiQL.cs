using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH_NET_Cuoi_Ky.DTO
{
    [Table("NguoiQL")]
    public class NguoiQL
    {
        [Key]
        public int MaNguoiQL { get; set; }
        [StringLength(50)]
        public string TenNguoiQL { get; set; }
    }
}
