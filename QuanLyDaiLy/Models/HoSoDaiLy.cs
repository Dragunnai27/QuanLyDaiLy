using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyDaiLy.Models
{
    public class HoSoDaiLy
    {
        [Key]
        public string MaHSDL { get; set; }

        [ForeignKey("FKLoaiDaiLy")]
        public int MaLDL { get; set; }
        public virtual LoaiDaiLy FKLoaiDaiLy { get; set; }

        [ForeignKey("FKQuan")]
        public int MaQuan { get; set; }
        public virtual Quan FKQuan { get; set; }

        [Required]
        public string Ten { get; set; }
        public int? SDT { get; set; }
        public string DiaChi { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public float TienNo { get; set; }
        public DateTime NgayTiepNhan { get; set; }
    }
}