using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fixit.WebUI.Controllers
{
    public class AboutController : Controller
    {
        // GET: About | Action Name.
        public ViewResult About()
        {
            ViewBag.Message = "A Little About us:";

            return View();
        }
    }
}