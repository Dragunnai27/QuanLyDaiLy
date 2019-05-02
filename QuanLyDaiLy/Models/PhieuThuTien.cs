using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyDaiLy.Models
{
    public class PhieuThuTien
    {
        [Key]
        public int MaPTT { get; set; }

        [ForeignKey("FKHoSoDaiLy")]
        public string MaHSDL { get; set; }
        public virtual HoSoDaiLy FKHoSoDaiLy { get; set; }

        public float SoTienThu { get; set; }
        public DateTime NgayThuTien { get; set; }
    }
}