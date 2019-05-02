using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using QuanLyDaiLy.Models;

namespace QuanLyDaiLy.DatabaseFile
{
    public class QLDLcontext : DbContext
    {
        public QLDLcontext() : base()
        {
            string databasename = "QuanLyDaiLy";
            this.Database.Connection.ConnectionString = "Data Source=TAM\\SQLEXPRESS;Initial Catalog=" + databasename + ";Trusted_Connection=Yes";
        }
        public DbSet<LoaiDaiLy> TbLoaiDaiLy { get; set; }
        public DbSet<Quan> TbQuan { get; set; }

        public DbSet<HoSoDaiLy> TbHoSoDaiLy { get; set; }
        public DbSet<BackUpHoSo> TbBackUpHoSo { get; set; }

        public DbSet<PhieuThuTien> TbPhieuThuTien { get; set; }

        public DbSet<DonViTinh> TbDonViTinh { get; set; }
        public DbSet<MatHang> TbMatHang { get; set; }
        public DbSet<CT_PhieuXuatHang> TbCT_PXH {get;set;}
        public DbSet<PhieuXuatHang> TbPhieuXuatHang { get; set; }

        public DbSet<User> TbUser { get; set; }
    }
}