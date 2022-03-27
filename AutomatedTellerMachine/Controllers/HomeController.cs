using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw new StackOverflowException();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.TheMessage = "YHaving trouble? Send us a message.";

            return View();
        }

        //[ActionName("about-this-atm")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = $"We've got your message: {message}";
            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
            //return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
            //return RedirectToAction("index");
        }
    }
}