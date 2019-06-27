using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTestDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Sum(int a, int b)
        {
            var result = CalculateLib.CalCulate.Sum(a, b);

            return Json(new { success = true, data = result }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Div(int a, int b)
        {
            var result = CalculateLib.CalCulate.Div(a, b);
            return Json(new { success = true, data = result }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}