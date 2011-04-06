using System.Web.Mvc;
using System.Web.Routing;
using JustBuy.Web.Models.Account;

namespace JustBuy.Web.Controllers
{
    public class HomeController : Controller
    {
        //public IFormsAuthenticationService FormsService { get; set; }
        //public IMembershipService MembershipService { get; set; }

        //protected override void Initialize(RequestContext requestContext)
        //{
        //    if (FormsService == null) { FormsService = new FormsAuthenticationService(); }
        //    if (MembershipService == null) { MembershipService = new AccountMembershipService(); }

        //    base.Initialize(requestContext);
        //}

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
            return Redirect("/Profile");
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
