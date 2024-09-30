using BaiTap2_23TH2525.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2_23TH2525.Controllers
{
    public class SinhVien_23TH2525Controller : Controller
    {
        // GET: SinhVien_23TH2525
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register1()
        {
            // Fetching data using the Request object
            ViewBag.Id = Request["Id"];
            ViewBag.Name = Request["Name"];
            ViewBag.Marks = Request["Marks"];

            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register2(string Id, string Name, string Marks)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Marks = Marks;

            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register3(FormCollection field)
        {
            ViewBag.Id = field["Id"];
            ViewBag.Name = field["Name"];
            ViewBag.Marks = field["Marks"];

            return View(ViewBag);
        }
        public ActionResult Index4()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register4(SinhVien sinhVien)
        {
            ViewBag.Id = sinhVien.Id;
            ViewBag.Name = sinhVien.Name;
            ViewBag.Marks = sinhVien.Marks;

            return View();
        }


    }
}