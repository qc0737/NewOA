using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutekInfoPortal.Controllers
{
    public class _ErrorController : Controller
    {
        //
        // GET: /_Error/

        public string Index()
        {
            string msg = Request["errormsg"];
            return msg;
        }

    }
}
