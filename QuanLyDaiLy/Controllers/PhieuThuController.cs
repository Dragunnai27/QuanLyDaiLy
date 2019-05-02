using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDaiLy.DatabaseFile;
using QuanLyDaiLy.Models;

namespace QuanLyDaiLy.Controllers
{
    public class PhieuThuController : Controller
    {
        private QLDLcontext db = new QLDLcontext();

        public ActionResult Index()
        {
            ViewBag.ListHoSo = db.TbHoSoDaiLy.ToList();
            ViewBag.ListPhieuThu = db.TbPhieuThuTien.ToList();
            return View();
        }
        public ActionResult AddPhieuThu(string MaHSDL, float SoTienThu, string NgayThuTien)
        {
            var phieuThu = new PhieuThuTien
            {
                MaHSDL = MaHSDL,
                SoTienThu = SoTienThu,
                NgayThuTien = Convert.ToDateTime(NgayThuTien)
            };

            db.TbPhieuThuTien.Add(phieuThu);
            db.SaveChanges();
            db.Dispose();

            return RedirectToAction("Index", "PhieuThu");
        }
        public ActionResult DeletePhieuThu(int id)
        {
            var phieuThu = db.TbPhieuThuTien.Find(id);

            db.TbPhieuThuTien.Remove(phieuThu);
            db.SaveChanges();

            return RedirectToAction("Index", "PhieuThu");
        }
        public ActionResult PhieuThuDetail(int id)
        {
            var phieuThu = db.TbPhieuThuTien.Find(id);
            return View(phieuThu);
        }
    }
}