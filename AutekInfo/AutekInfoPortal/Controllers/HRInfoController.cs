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
            bool order = Request["order"] == "desc" ? true : false;
            var b = new AutekInfo.BLL.View_Employee_Info();
            int tcount = 0;           
            var list = b.GetModelListByPages("*","emp_id",sort,pagesize,page," emp_isonworking='是' ",order, out tcount);
            string json = AutekInfo.Common.JsonHelper.GetGridJson(list, tcount,"yyyy'-'MM'-'dd");
            return Content(json);
        }

        public ContentResult GetEmpListBySF()
        {
            string fields = Request["fields"];
            string top = Request["top"];
            string order = Request["order"];
            string emp_dept = Request["emp_dept"];
            string keyw = Request["keyw"];
            var b = new AutekInfo.BLL.View_Employee_Info();
            var list=new List<AutekInfo.Model.View_Employee_Info>();
            if (!String.IsNullOrEmpty(keyw))
            {
                list = b.GetModelList("-1", String.Format(" ( emp_cnname like '%{0}%' or emp_worknum like '%{0}% or emp_email like '{0}') and emp_isonworking = '是'", emp_dept), order);
            }
            else if (!String.IsNullOrEmpty(emp_dept))
            {
                list = b.GetModelList("-1", String.Format(" emp_dept='{0}' and emp_isonworking = '是'", emp_dept), order);
            }
            else
            {
                list = b.GetModelList(top, " emp_isonworking = '是'", order);
            }
            
            //var list = b.GetModelList(" emp_isonworking='是' ");
            string[] arr_f = fields.Split(',');
            string json = AutekInfo.Common.JsonHelper.GetPartAttr(list, arr_f);
            return Content(json);
        }

    }
}
