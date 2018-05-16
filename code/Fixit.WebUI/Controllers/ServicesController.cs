using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fixit.WebUI.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Sevices
        public ActionResult Services()
        {
            ViewBag.Message = "Select from a wide range of service professionals.";
            return View();
            
        }
    }
}