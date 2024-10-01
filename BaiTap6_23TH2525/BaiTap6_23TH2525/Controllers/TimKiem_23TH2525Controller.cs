using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap6_23TH2525.Controllers
{
    public class TimKiem_23TH2525Controller : Controller
    {
        private QLNV_23TH2525Entities db = new QLNV_23TH2525Entities();

        public ActionResult Index(string searchString, string gender, string department, decimal? minSalary, decimal? maxSalary)
        {
            var nhanViens = db.NhanViens.AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                nhanViens = nhanViens.Where(s => s.HoNV.Contains(searchString) || s.TenNV.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(gender))
            {
                nhanViens = nhanViens.Where(s => s.GioiTinh == gender);
            }

            if (!String.IsNullOrEmpty(department))
            {
                nhanViens = nhanViens.Where(s => s.PhongBan.TenPB.Contains(department));
            }

            if (minSalary.HasValue)
            {
                nhanViens = nhanViens.Where(s => s.Luong >= minSalary);
            }

            if (maxSalary.HasValue)
            {
                nhanViens = nhanViens.Where(s => s.Luong <= maxSalary);
            }

            return View(nhanViens.ToList());
        }
    }

}