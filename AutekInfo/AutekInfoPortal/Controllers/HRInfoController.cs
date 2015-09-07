using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using AutekInfo;
namespace AutekInfoPortal.Controllers
{
    public class HRInfoController : Controller
    {
        //
        // GET: /HRInfo/

        public ActionResult Index()
        {
            var b = new AutekInfo.BLL.View_Employee_Info();
            int pcount=0;
            int tcount = 0;
            var list = b.GetModelListByPages("1=1", out pcount, out tcount);

            //var list = b.GetModelList(" emp_isonworking='是' ");
            //DataSet ds = b_v_t_f.GetList(" * ", sort, pagesize, page, isGetCount, (order == "desc") ? false : true, strWhere.ToString());
            //int count = b_v_t_f.GetList(strWhere.ToString()).Tables[0].Rows.Count;//获取总数
            
               
            return View();
        }

    }
}
