using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyDaiLy.Models
{
    public class LoaiDaiLy
    {
        [Key]
        public int MaLDL { get; set; }
        public string TenLDL { get; set; }
    }
}