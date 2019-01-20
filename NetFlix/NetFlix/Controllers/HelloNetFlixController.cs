﻿using System.Web.Mvc;

namespace NetFlix.Controllers
{
    public class HelloNetFlixController : Controller
    {
        // GET: HelloNetFlix
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int ID = 1)
        {
            ViewBag.Message = "This is my name " + name;
            ViewBag.Number = ID;
            return View();
        }

        [Route("HelloNetflix/released/{year:range(2015, 2016)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "-" + month);
        }
    }
}