﻿using BaiTap1_23TH2525.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap1_23TH2525.Controllers
{
    public class PhepToan_23TH2525Controller : Controller
    {
        // GET: PhepToan_23TH2525
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalModels cal)
        {
            switch (cal.pt)
            {
                case "+": ViewBag.KQ = cal.a + cal.b; break;
                case "-": ViewBag.KQ = cal.a - cal.b; break;
                case "*": ViewBag.KQ = cal.a * cal.b; break;
                case "/":
                    if (cal.b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = cal.a / cal.b; break;
            }

            return View();
        }

        public ActionResult UseRequest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseRequest(string pt)
        {
            double a = double.Parse(Request["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(Request["b"]);
            pt = Request["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }
        public ActionResult UseArguments()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseArguments(double a, double b, string pt = "+")
        {
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }
        public ActionResult UseFormCollection()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseFormCollection(FormCollection f)
        {
            double a = double.Parse(f["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(f["b"]);
            string pt = f["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }

    }
}