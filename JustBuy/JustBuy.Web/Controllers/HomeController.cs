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

        [HttpPost]
        public ActionResult Categories()
        {
            return PartialView("Categories");
        }

        [HttpPost]
        public ActionResult Manufacturers()
        {
            return PartialView("Manufacturers");
        }

        [HttpPost]
        public ActionResult PopularTags()
        {
            return PartialView("PopularTags");
        }

        [HttpPost]
        public ActionResult Information()
        {
            return PartialView("Information");
        }

        [HttpPost]
        public ActionResult ShoppingCart()
        {
            return PartialView("ShoppingCart");
        }

        [HttpPost]
        public ActionResult RecentlyViewed()
        {
            return PartialView("RecentlyViewed");
        }

      
    }
}
