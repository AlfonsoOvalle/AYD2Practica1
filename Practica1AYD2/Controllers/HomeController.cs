﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1AYD2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "ASP.NET MVC";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
