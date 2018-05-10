using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGreatCourseProject.WebUI.Controllers
{
    public class BookingsController : Controller
    {
        // GET: Bookings
        public ActionResult Bookings()
        {
            ViewBag.Messages = "This is displayed from the BookingsController.cs file.";
            return View();
        }
    }
}