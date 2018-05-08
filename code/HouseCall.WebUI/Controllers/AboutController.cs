using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGreatCourseProject.WebUI.Controllers
{
    public class AboutController : Controller
    {
        // GET: About | Action Name.
        public ViewResult About()
        {
            ViewBag.Message = "Your application description page. TEST TEST :)";

            return View();
        }
    }
}