using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StatusManagement.NetMVC.Controllers
{
    public class Home4Controller : Controller
    {
        //Cookie
        //Bilgisayar spesific

        // GET: Home4
        public ActionResult Index()
        {
            HttpCookie cookie = new HttpCookie("username","Elif Furuncu");
            cookie.Expires = DateTime.Now.AddDays(1); // 1 gün sonra silinsin
            HttpContext.Response.Cookies.Add(cookie);
            //kullanıcıya yanıt olarak olarak, bunu kaydet
            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            //HttpCookie ler string döndürür
            //Cookie var mı?
            if(HttpContext.Request.Cookies["username"] != null)
            {
                ViewBag.UserName = HttpContext.Request.Cookies["username"].Value;
            }
            else
            {
                ViewBag.UserName = "Cookie tanımlanmamıştır.";
            }
            return View();
        }
        public ActionResult Index3()
        {
            // Cookie yi sil
            //HttpContext.Request.Cookies.Remove("username");
            HttpContext.Response.Cookies["username"].Expires = DateTime.Now.AddSeconds(2);
            return RedirectToAction("Index2");
        }
    }
}