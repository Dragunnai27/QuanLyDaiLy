using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyDaiLy.Models
{
    public class DonViTinh
    {
        [Key]
        public int MaDVT { get; set; }
        public string TenDVT { get; set; }
    }
}