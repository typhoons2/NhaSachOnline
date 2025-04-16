using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaSachOnline.Models
{
    [Table("GioHang")]
    public class GioHang
    {
        [Key]
        public int MaGioHang { get; set; }
        [Required]
        public string MaNguoiDung { get; set; }

        public bool DaXoa { get; set; } = false;
        public ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
    }
}
