﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGreatCourseProject.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. TEST TEST :)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If you need assistance please reach me using the following" +
                              " information:";

            return View();
        }
    }
}