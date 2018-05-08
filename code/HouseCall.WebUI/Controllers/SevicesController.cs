using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyGreatCourseProject.WebUI.Models;

namespace MyGreatCourseProject.WebUI.Controllers
{
    public class SevicesController : Controller
    {
        // GET: Sevices
        public ViewResult Random()
        {
            var service = new Services();
            return View();
            //return HttpNotFoundResult();
        }
    }
}