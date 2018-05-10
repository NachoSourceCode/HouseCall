using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGreatCourseProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            ViewBag.Message = "This is message is from the register controller.";
            return View();
        }
    }
}