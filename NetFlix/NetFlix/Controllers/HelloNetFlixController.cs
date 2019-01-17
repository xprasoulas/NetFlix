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
            ViewBag.Message = "This is my name " + name;
            ViewBag.Number = ID;
            return View();
        }
    }
}