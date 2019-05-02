using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyDaiLy.Models
{
    public class Quan
    {
        [Key]
        public int MaQuan { get; set; }
        public string TenQuan { get; set; }
    }
}