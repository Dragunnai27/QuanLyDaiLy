using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDaiLy.DatabaseFile;
using QuanLyDaiLy.Models;

namespace QuanLyDaiLy.Controllers
{
    public class PhieuXuatController : Controller
    {
        private QLDLcontext db = new QLDLcontext();

        public ActionResult Index()
        {
            ViewBag.ListHoSo = db.TbHoSoDaiLy.ToList();
            ViewBag.ListPhieuXuat = db.TbPhieuXuatHang.ToList();

            return View();
        }

        // Thêm Phiếu xuất hàng
        public ActionResult AddPhieuXuat(string MaHSDL, string NgayLapPhieu)
        {
            var phieuXuat = new PhieuXuatHang
            {
                MaHSDL = MaHSDL,
                NgayLapPhieu = Convert.ToDateTime(NgayLapPhieu),
                TongTien = 0,
                SoTienTra = 0,
                ConLai = 0
            };

            db.TbPhieuXuatHang.Add(phieuXuat);
            db.SaveChanges();
            db.Dispose();

            return RedirectToAction("Index", "PhieuXuat");
        }
        public ActionResult PhieuXuatDetail(int id)
        {
            var phieuXuatHang = db.TbPhieuXuatHang.Find(id);

            ViewBag.ListDVT = db.TbDonViTinh.ToList();
            ViewBag.ListMH = db.TbMatHang.ToList();
            ViewBag.ListCTPXH = db.TbCT_PXH.ToList();

            return View(phieuXuatHang);
        }
        public ActionResult AddChiTietPhieuXuat(int MaPXH, int MaMH, int MaDVT, int SoLuong)
        {
            // Thêm chi tiết phiếu xuất
            var ctPXH = new CT_PhieuXuatHang
            {
                MaPXH = MaPXH,
                MaMH = MaMH,
                MaDVT = MaDVT,
                SoLuong = SoLuong,
                ThanhTien = db.TbMatHang.Find(MaMH).DonGia * SoLuong
            };
            db.TbCT_PXH.Add(ctPXH);

            // Thay đổi tổng tiền phiếu xuát
            var phieuXuat = db.TbPhieuXuatHang.Find(MaPXH);
            phieuXuat.TongTien += ctPXH.ThanhTien;
            db.Entry(phieuXuat).State = System.Data.Entity.EntityState.Modified;

            // Save database
            db.SaveChanges();

            return RedirectToAction("PhieuXuatDetail", "PhieuXuat", new { id = MaPXH });
        }
    }
}