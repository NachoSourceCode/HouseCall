using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fixit.Domain.DAL;
using Fixit.Domain.Models;

namespace Fixit.WebUI.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();

        public ActionResult Index()
        {
            IEnumerable<Trade> tradeQuery = from Trade in db.Trades
                                            where Trade.Industry == "Electrical"
                                            select Trade;

            return View(tradeQuery);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If you need assistance please reach me using the following" +
                              " information:";

            
            return View();
        }
    }
}