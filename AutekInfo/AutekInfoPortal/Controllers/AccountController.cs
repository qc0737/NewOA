using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography; 


namespace AutekInfoPortal.Controllers
{
   
    public class AccountController : Controller
    {
        //
        // GET: /Account/
       
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Login()
        {
            Session["pwdErr"] = 0;
            
            return View();
        }
       
        public string CheckUser()
        {
           // System.Threading.Thread.Sleep(3000);
            string user_id = Request["userid"];
            string enrpwd = Request["enrpwd"];
            string vcode = Request["vcode"];
            if ((int)Session["pwdErr"] > 2)
            {
                if (vcode != Session["ValidateCode"].ToString())
                {
                    return "{\"msg\":\"验证码错误！\",\"count\":4}";
                }
            }
            var b = new AutekInfo.BLL.View_BaseAccount();
            var list = b.GetModelList(String.Format(" loginid='{0}'  ",user_id));
            if (list.Count==0)
            {
                return "{\"msg\":\"不存在此用户！\",\"count\":0}";
            }
            var m=list[0];
            if (m.sysstatus==1)
            {
                return "{\"msg\":\"该账号已禁用！\",\"count\":0 }";
            }
            if (m.pwd != enrpwd)
            {

               Session["pwdErr"] = (int)Session["pwdErr"] + 1;

               return "{\"msg\":\"密码错误！\",\"count\":" + Session["pwdErr"]+"}";
            }
            Session["LoginedUser"] = m.emp_cnname;
            Session["emp_dept"] = m.emp_dept;
            Session["role"] = m.role_name;
            
            return "true";

        }
        public ActionResult GetValidateCode()
        {
            AutekInfo.Common.Assistant assit = new AutekInfo.Common.Assistant();
            string code = assit.CreateValidateCode(5);
            Session["ValidateCode"] = code;
            byte[] bytes = assit.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }

        public void Logout()
        {
            Session["LoginedUser"] = null;
            Response.Redirect("/Account/Login");
        }
    }
}
