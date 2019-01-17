using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return Content("Welcome " + name + " Number Of times = " + ID);
        }
    }
}