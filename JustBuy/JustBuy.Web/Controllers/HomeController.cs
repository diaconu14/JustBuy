using System.Web.Mvc;

namespace JustBuy.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }

        [Authorize]
        public ActionResult Profile()
        {
            return View();
        }

    }
}
