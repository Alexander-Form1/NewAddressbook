﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Alexanders kommentar
            ViewBag.Message = "";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description";

            return View();
        }

        public ActionResult Contact()
        {
            //AKs kommentar
            ViewBag.Message = "Contact";

            return View();
        }
    }
}
