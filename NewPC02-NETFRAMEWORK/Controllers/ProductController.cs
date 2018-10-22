using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewPC02_NETFRAMEWORK.Models;

namespace NewPC02_NETFRAMEWORK.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        PC02Entities bd = new PC02Entities();

        public ActionResult Index()
        {
            return View(bd.product.ToList());
        }

        public ActionResult CreateProduct()
        {
            var cat = bd.category;
            List<SelectListItem> list = new List<SelectListItem>();
            foreach(category item in cat)
            {
                list.Add(new SelectListItem
                {
                    Text = item.name,
                    Value = item.idCategory.ToString()
                });
            }
            //ViewBag.categories = new SelectList(cat,"idCategory","name");
            ViewBag.categories = list;
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(product item)
        {
            if (ModelState.IsValid)
            {
                bd.product.Add(item);
                |bd.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View(item);
            }
        }

        public ActionResult UpdateProduct(int id)
        {
            return View(bd.product.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateProduct(product item)
        {
            if (ModelState.IsValid)
            {
                bd.Entry(item).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return RedirectToAction("index");
            }
            return View(item);

        }

        public ActionResult DeleteProduct(int id)
        {
            product item = bd.product.Find(id);
            bd.product.Remove(item);
            bd.SaveChanges();
            return RedirectToAction("index");
        }
    }
}