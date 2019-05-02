using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyDaiLy.Models
{
    public class MatHang
    {
        [Key]
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public float DonGia { get; set; }
    }
}