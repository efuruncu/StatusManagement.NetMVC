using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StatusManagement.NetMVC.Controllers
{
    public class HomeController : Controller
    {
        //Dakika cinsinden session temizleme süresi.
        //Web.config --> system.web in altında <sessionState timeout="30"></sessionState>

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string text)
        {
            //Session a değer atama.
            Session["deger"] = text; // Session obje alır.
            //Session.Add("deger",text);
            return RedirectToAction("Index2");
        }
        public ActionResult Index2()
        {
            if(Session["deger"] != null)
            {
                ViewBag.Deger = Session["deger"].ToString();
            }
            else
            {
                ViewBag.Deger = "Session Verisi Yoktur.";
            }
            return View();
        }

        public ActionResult Index3()
        {
            //Session.Clear();
            if(Session["deger"] != null)
            {
                Session.Remove("deger");
                
            }
            return RedirectToAction("Index2");
        }
    }
}