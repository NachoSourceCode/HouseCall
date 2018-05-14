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
            ViewBag.Message = "Please choose the type of user account you would like to set up.";
            return View();
        }
    }
}