using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewPC02_NETFRAMEWORK.Models;

namespace NewPC02_NETFRAMEWORK.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        PC02Entities bd = new PC02Entities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Validate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validate(string access,string password)
        {
            users user = bd.users.FirstOrDefault(d => d.access == access & d.password == password);
            if(user != null)
            {
                //1st nameofFunction || 2nd nameOfController 
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return RedirectToAction("NotFound", "User");
            }
        }

        public ActionResult NotFound()
        {
            ViewBag.Error = "The user or the password is bad formed";
            return View();
        }
    }
}