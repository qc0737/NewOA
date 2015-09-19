using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutekInfo.BLL;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AutekInfoPortal.Controllers
{
    [AutekInfoPortal.App_Start.Authorization]
    public class HomeController : Controller
    {
        public static List<AutekInfo.Model.Menu> list_all = new AutekInfo.BLL.Menu().GetModelList(" menu_isshow=1 ");
        public ActionResult Index()
        {

            return View();
        }
        /// <summary>
        /// 获取顶层菜单
        /// </summary>
        /// <returns></returns>
        public JsonResult GetTopMenu()
        {
            int pid =int.Parse( Request["id"].ToString());
            //var list = new AutekInfo.BLL.Menu().GetModelList(String.Format(" menu_pid = {0} ", menu_pid));
            var list = list_all.FindAll(menu => menu.menu_pid == pid);
            return Json(list, JsonRequestBehavior.DenyGet);
        }
        /// <summary>
        /// 获取次顶层菜单
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public ContentResult GetTreeMenu()
        {
            string menu_pid = Request["menu_pid"].ToString();
            StringBuilder sb = new StringBuilder();
            int pid = int.Parse(menu_pid);
            //所有的菜单
           // List<AutekInfo.Model.Menu> list_all = new AutekInfo.BLL.Menu().GetModelList(" menu_isshow=1 ");
            if (list_all.Count > 0)
            {
                sb.Append("[");

                List<AutekInfo.Model.Menu> list_filter = list_all.FindAll(menu => menu.menu_pid == pid);

                if (list_filter.Count > 0)
                {
                    foreach (AutekInfo.Model.Menu m in list_filter)
                    {
                        sb.Append("{\"id\":" + m.menu_id + ",\"text\":\"" + m.menu_name + "\",\"attributes\":\"" + m.menu_link + "\",\"state\":\"");
                        if (list_all.FindAll(menu => menu.menu_pid == m.menu_id).Count > 0)
                        {
                            sb.Append("closed\",\"iconCls\":\"" + m.menu_icon + "\"");
                            // sb.Append("closed\"");
                        }
                        else
                        {
                            //sb.Append("\"");
                            sb.Append("\",\"iconCls\":\"" + m.menu_icon + "\"");
                        }
                        sb.Append("},");
                    }
                    sb = sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
            }

            //var list = new AutekInfo.BLL.Menu().GetModelList(String.Format(" menu_pid = {0} ",menu_pid));
            return Content(sb.ToString());
        }
        
    }
}
