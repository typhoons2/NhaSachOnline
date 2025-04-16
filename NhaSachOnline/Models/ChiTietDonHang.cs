using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaSachOnline.Models
{
    [Table("ChiTietDonHang")]
    public class ChiTietDonHang
    {
        [Key]
        public int MaChiTietDonHang { get; set; }
        [Required]
        public int MaDonHang { get; set; }
        [Required]
        public int MaSach { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public double DongGia { get; set; }
        public Sach Sach { get; set; }
        public DonHang DonHang { get; set; }


    }
}
