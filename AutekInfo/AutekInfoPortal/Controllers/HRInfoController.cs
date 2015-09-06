using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutekInfoPortal.Controllers
{
    public class HRInfoController : Controller
    {
        //
        // GET: /HRInfo/

        public ActionResult Index()
        {
            Session["name"] = "aa";
            return View();
        }

    }
}
