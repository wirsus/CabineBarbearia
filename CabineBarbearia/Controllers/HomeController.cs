using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CabineBarbearia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Detalhes do local";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nos contate!";

            return View();
        }
    }
}