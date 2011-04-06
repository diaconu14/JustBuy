using System;
using System.Web.Mvc;
using JustBuy.Web.Models;

namespace JustBuy.Web.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/
        [Authorize]
        public ActionResult Blog()
        {
            BlogModel model = new BlogModel();

            
            return View(model);
        }

        //
        // GET: /Blog/BlogPost/5
        [Authorize]
        public ActionResult BlogPost(int id)
        {
            var blogPost = new BlogPost { Content = "", Created = DateTime.Now, CreatedBy = "", Title = "" };
            return PartialView(blogPost);
        }

        //
        // GET: /Blog/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Blog/Create

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
        // GET: /Blog/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Blog/Edit/5

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
        // GET: /Blog/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Blog/Delete/5

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
