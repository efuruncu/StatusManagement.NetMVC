using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StatusManagement.NetMVC.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            //Application State
            //Her kullanıcı için ortak
            //(Session da ise her kullanıcı için ayrıydı)//

            HttpContext.Application["sayac"] = 1;
           // HttpContext.Application.Add("sayac",1);

            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            ViewBag.Sayac = HttpContext.Application["sayac"].ToString();
            
            return View();
        }
        public ActionResult Index3()
        {
            if(HttpContext.Application["sayac"] != null)
            {
                int sayac = (int)HttpContext.Application["sayac"];
                sayac++; 
                HttpContext.Application["sayac"] = sayac;
            }
            else
            {
                return RedirectToAction("Index");
            }
          

            

           
            return RedirectToAction("Index2");
        }

        public ActionResult Index4()
        {
            // HttpContext.Application.Clear();
            // HttpContext.Application.RemoveAll();
            if (HttpContext.Application["sayac"] != null)
            {
                HttpContext.Application.Remove("sayac");
            }
            return View();
        }
    }
}