using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JustBuy.Web.Models;

namespace JustBuy.Web.Controllers
{
    public class ProfileController : Controller
    {
        //
        // GET: /Profile/

        public ActionResult Profile()
        {
            string userName = System.Web.HttpContext.Current.User.Identity.Name;
            var user = GetUserDataFor(userName);

            return View();
        }

        private ProfileModel GetUserDataFor(string userName)
        {
            return new ProfileModel { FirstName = userName, LastName = "test", Gender = true, Telephone = "24546546" };
        }

        public ActionResult Index()
        {
            return RedirectToAction("Profile");
        }


        //
        // GET: /Profile/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Profile/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Profile/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Profile/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Profile/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Profile/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Profile/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
