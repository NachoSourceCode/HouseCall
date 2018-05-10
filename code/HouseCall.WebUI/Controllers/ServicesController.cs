using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyGreatCourseProject.WebUI.Models;

namespace MyGreatCourseProject.WebUI.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Sevices
        public ActionResult Services()
        {
            ViewBag.Message = "This is text from the services controller and the page layout comes from the view.";
            return View();
            
        }
    }
}