using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
   public class CookieDemoController : Controller
    {
        // GET: CookieDemo
        public ActionResult Index()
        {
            int count = 1;

            var cookie = Request.Cookies["count"];
            if (cookie == null)
            {
                Response.Cookies.Add(new HttpCookie("count", "1"));
            }
            else
            {
                count = int.Parse(cookie.Value) + 1;
                var newcookie = new HttpCookie("count", count.ToString());
                //newcookie.Expires = DateTime.Now.AddDays(7);
                newcookie.Expires = DateTime.Now.AddMinutes(5);
                Response.Cookies.Add(newcookie);
            }

            ViewBag.count = count;
            return View();
        }
    }
} 
