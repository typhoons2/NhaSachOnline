using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NhaSachOnline.Models
{
    [Table("TheLoai")]
    public class TheLoai
    {
        [Key]
        public int MaTheLoai { get; set; }
        [MaxLength(50)]
        public string? TenTheLoai { set; get; }

        //public List<Sach> ListSach { get; set; }    
        public List<Sach> Saches { get; set; }
    }   
}


