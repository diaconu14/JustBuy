using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JustBuy.Web.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult NewProducts()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FeaturedProducts()
        {
            return PartialView("FeaturedProducts");
        }

     
    }
}
