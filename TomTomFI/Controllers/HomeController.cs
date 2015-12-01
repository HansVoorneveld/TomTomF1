using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TomTomFI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "TomTom file-info";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact pagina TTFI.";
            return View();
        }
    }
}
// hj