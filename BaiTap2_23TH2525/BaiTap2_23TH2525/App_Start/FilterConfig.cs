﻿using System.Web;
using System.Web.Mvc;

namespace BaiTap2_23TH2525
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}