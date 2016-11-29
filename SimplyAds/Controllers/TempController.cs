using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyAds.Controllers
{
    public class TempController : Controller
    {
        private static int count;

        public TempController()
        {
            if (count < 1500)
                count++;

            else
                throw new Exception("trial period has expired ! Please contact 'wale ALASHE");
        }

        // GET: Temp
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}