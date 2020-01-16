using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StatusManagement.NetMVC.Controllers
{
    public class Home3Controller : Controller
    {
        //Cache-State

        // GET: Home3
        public ActionResult Index()
        {
            //Ötelemelerde SlidingExpiration(TimeSpan)
            //Şu tarihte ölsün istiyorsak absoluteExpiration(DateTime)
            // HttpContext.Cache["ad"] = "Elif Furuncu";
            //onRemoveCallBack ,cache öldüğünde çağrılması gerekn method

            //HttpContext.Cache.Add("ad", "Elif Furuncu",null,System.Web.Caching.Cache.NoAbsoluteExpiration,new TimeSpan(0,0,10),System.Web.Caching.CacheItemPriority.Normal,null);
            HttpContext.Cache.Add("ad", "Elif Furuncu", null, new DateTime(2020,1,16,16,15,0), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);

            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
    }
}