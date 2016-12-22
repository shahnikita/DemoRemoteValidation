using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoRemoteValidation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult IsAnwerText(string Answer)
        {
            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}
