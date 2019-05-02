using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDaiLy.DatabaseFile;
using QuanLyDaiLy.Models;

namespace QuanLyDaiLy.Controllers
{
    public class BaoCaoController : Controller
    {
        private QLDLcontext db = new QLDLcontext();
        // GET: BaoCao
        public ActionResult Index()
        {
            ViewBag.ListThang = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            return View();
        }
        public ActionResult BCDS(int thangBaoCao)
        {
            return new Rotativa.ActionAsPdf("BCDoanhSo", new { thang = thangBaoCao });
        }
        public ActionResult BCDoanhSo(int thang)
        {
            // Danh sách báo cáo doanh sô sẽ xuất ra 
            var baoCaoDoanhSo  = new List<BaoCaoDoanhSo>();
            var hoSo = db.TbHoSoDaiLy.ToList();

            foreach(var item in hoSo)
            {
                // Số phiếu xuất
                var phieuXuat = db.TbPhieuXuatHang.Where
                    (px => px.MaHSDL == item.MaHSDL).ToList();
                int soPhieu = phieuXuat.Count;

                // Tổng trị giá
                float tongTriGia = 0;
                foreach(var px in phieuXuat)
                {
                    tongTriGia += px.TongTien;
                }

                // Thêm vào class báo cáo
                baoCaoDoanhSo.Add(new BaoCaoDoanhSo
                {
                    DaiLy = item.Ten,
                    SoPhieuXuat = soPhieu,
                    TongGiaTri = tongTriGia,
                    TiLe = 0
                });
            }

            // Viewbag
            ViewBag.ListBCDS = baoCaoDoanhSo;
            ViewBag.Thang = thang;

            return View();
        }
        public ActionResult BCCN(int thangBaoCao)
        {
            return new Rotativa.ActionAsPdf("BCCongNo", new { thang = thangBaoCao });
        }
        public ActionResult BCCongNo(int thang)
        {
            var hoSo = db.TbHoSoDaiLy.ToList();
            ViewBag.ListHoSo = hoSo;
            ViewBag.Thang = thang;

            float tongNo = 0;
            foreach (var item in hoSo)
            {
                tongNo += item.TienNo;
            }
            ViewBag.TongTienNo = tongNo;

            return View();
        }
    }
}