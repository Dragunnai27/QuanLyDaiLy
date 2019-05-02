using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDaiLy.DatabaseFile;
using QuanLyDaiLy.Models;

namespace QuanLyDaiLy.Controllers
{
    public class HoSoController : Controller
    {
        private QLDLcontext db = new QLDLcontext();
        // GET: HoSo
        public ActionResult Index()
        {

            ViewBag.ListQuan = db.TbQuan.ToList();
            ViewBag.ListLDL = db.TbLoaiDaiLy.ToList();

            ViewBag.ListHSDL = db.TbHoSoDaiLy.ToList();
            return View();
        }

        public ActionResult AddHoSo(string MaHSDL, int MaQuan, int MaLDL,
            string Ten, int SDT, string DiaChi, string Email, float TienNo)
        {
            HoSoDaiLy newHoSo = new HoSoDaiLy
            {
                MaHSDL = MaHSDL,
                MaQuan = MaQuan,
                MaLDL = MaLDL,
                Ten = Ten,
                SDT = SDT,
                DiaChi = DiaChi,
                Email = Email,
                TienNo = TienNo,
                NgayTiepNhan = DateTime.Now
            };

            db.TbHoSoDaiLy.Add(newHoSo);
            db.SaveChanges();
            db.Dispose();

            return RedirectToAction("Index", "Hoso");
        }
        public ActionResult DeleteHoSo(string id)
        {

            var hoSoDaiLy = db.TbHoSoDaiLy.Find(id);

            db.TbHoSoDaiLy.Remove(hoSoDaiLy);
            db.SaveChanges();
            db.Dispose();

            return RedirectToAction("Index", "Hoso");
        }

        public ActionResult HoSoDetail(string id)
        {
            HoSoDaiLy hoSoDaiLy;

            hoSoDaiLy = db.TbHoSoDaiLy.Find(id);

            return View(hoSoDaiLy);
        }
    }
}