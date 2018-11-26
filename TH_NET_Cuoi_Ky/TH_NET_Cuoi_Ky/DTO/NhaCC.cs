using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH_NET_Cuoi_Ky.DTO
{
    [Table("NhaCC")]
    public class NhaCC
    {
        [Key]
        public int MaNhaCC { get; set; }
        [StringLength(50)]
        public string TenNhaCC { get; set; }
        public string DiaChi { get; set; }
        public ICollection<NhapXuat> NhapXuat { get; set; }
    }
}
