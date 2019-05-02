using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using QuanLyDaiLy.Models;

namespace QuanLyDaiLy.DatabaseFile
{
    public class QLDLSeedData : DropCreateDatabaseAlways<QLDLcontext>
    {
        protected override void Seed(QLDLcontext context)
        {
            context.TbUser.Add(new User { UserName = "Tam", Password = "tam123", Role = "admin" });

            context.TbQuan.Add(new Quan { TenQuan = "Quận 1" });
            context.TbQuan.Add(new Quan { TenQuan = "Quận 2" });
            context.TbQuan.Add(new Quan { TenQuan = "Quận 3" });
            context.TbQuan.Add(new Quan { TenQuan = "Quận 4" });
            context.TbQuan.Add(new Quan { TenQuan = "Quận 5" });
            context.TbQuan.Add(new Quan { TenQuan = "Quận 6" });
            context.TbQuan.Add(new Quan { TenQuan = "Quận 7" });
            context.TbQuan.Add(new Quan { TenQuan = "Quận 8" });
            context.TbQuan.Add(new Quan { TenQuan = "Quận 9" });
            context.TbQuan.Add(new Quan { TenQuan = "Quận 10" });

            context.TbLoaiDaiLy.Add(new LoaiDaiLy { TenLDL = "Loại đại lý 1" });
            context.TbLoaiDaiLy.Add(new LoaiDaiLy { TenLDL = "Loại đại lý 2" });

            context.TbDonViTinh.Add(new DonViTinh { TenDVT = "USD"});
            context.TbDonViTinh.Add(new DonViTinh { TenDVT = "VND"});
            context.TbDonViTinh.Add(new DonViTinh { TenDVT = "JPY"});

            context.TbMatHang.Add(new MatHang { TenMH = "Mặt hàng 1", DonGia = 100 });
            context.TbMatHang.Add(new MatHang { TenMH = "Mặt hàng 2", DonGia = 200 });
            context.TbMatHang.Add(new MatHang { TenMH = "Mặt hàng 3", DonGia = 300 });
            context.TbMatHang.Add(new MatHang { TenMH = "Mặt hàng 4", DonGia = 400 });
            context.TbMatHang.Add(new MatHang { TenMH = "Mặt hàng 5", DonGia = 500 });
        }
    }
}