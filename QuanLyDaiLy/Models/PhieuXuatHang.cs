using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyDaiLy.Models
{
    public class PhieuXuatHang
    {
        [Key]
        public int MaPXH { get; set; }

        // FK Hò sơ đại lý
        [ForeignKey("FKHoSoDaiLy")]
        public string MaHSDL { get; set; }
        public virtual HoSoDaiLy FKHoSoDaiLy { get; set; }

        public DateTime NgayLapPhieu { get; set; }
        public float TongTien { get; set; }
        public float SoTienTra { get; set; }
        public float ConLai { get; set; }
    }
}