using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Random rad = new Random();
            ViewBag.ClientName = "用户-" + rad.Next(1, 9);
            return View();
        }

    }
}
