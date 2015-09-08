using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using AutekInfo;
namespace AutekInfoPortal.Controllers
{
    public class HRInfoController : Controller
    {
        //
        // GET: /HRInfo/

        public ViewResult Index()
        {
            return View();
        }
        public ContentResult GetEmpList()
        {
            int page = Convert.ToInt32(Request["page"]);
            int pagesize = Convert.ToInt32(Request["rows"]);
            string sort = Request["sort"];
            bool order = Request["order"]=="desc"?false:true;
            var b = new AutekInfo.BLL.View_Employee_Info();
            int tcount = 0;
            //if (sort != "emp_id")
            //{
            //    sort += ",emp_id";
            //}
            var list = b.GetModelListByPages("*",sort,pagesize,page," emp_isonworking='是' ",order, out tcount);
            string json = AutekInfo.Common.JsonHelper.GetGridJson(list, tcount,"yyyy'-'MM'-'dd");
            return Content(json);
        }

    }
}
