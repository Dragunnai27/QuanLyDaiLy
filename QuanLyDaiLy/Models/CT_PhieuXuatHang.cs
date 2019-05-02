using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyDaiLy.Models
{
    public class CT_PhieuXuatHang
    {
        [Key]
        public int MaCTPXH { get; set; }

        [ForeignKey("FKPhieuXuat")]
        public int MaPXH { get; set; }
        public virtual PhieuXuatHang FKPhieuXuat { get; set; }


        [ForeignKey("FKDonViTinh")]
        public int MaDVT { get; set; }
        public virtual DonViTinh FKDonViTinh { get; set; }


        [ForeignKey("FKMatHang")]
        public int MaMH { get; set; }
        public virtual MatHang FKMatHang { get; set; }

        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }
    }
}