using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using AutekInfo.BLL;
using AutekInfo.Model;
using AutekInfo.Common;

namespace AutekInfoPortal.Controllers
{
    public class SystemManageController : Controller
    {
        //
        // GET: /SystemManage/

        public ActionResult Index()
        {
            return View();
        }
        #region Dept
        public string GetO()
        {
            string opennode = Request["node"];
            int pid = 0;//int.Parse(Request["id"].ToString());
            List<AutekInfo.Model.Emp_Dept> list = new AutekInfo.BLL.Emp_Dept().GetModelList("").OrderBy(dept => dept.dept_order).ThenBy(dept => dept.dept_name).ToList();
            JsonHelper js = new JsonHelper();
            string json = new JsonHelper().GetOcharTree<AutekInfo.Model.Emp_Dept>(list, "dept_id", "dept_pid", "dept_name", pid);
            if (!String.IsNullOrEmpty(opennode))
            {
                json=json.Replace("\"text\":\"公司\",\"state\":\"closed\"", "\"text\":\"公司\",\"state\":\"open\"");
            }
            return json;
        }
        public string ChangeDeptOchar()
        {
            int sourceid = int.Parse(Request["sourceid"].ToString());
            int targetid = int.Parse(Request["targetid"].ToString());
            string point = Request["point"].ToString();
            var b_dept = new AutekInfo.BLL.Emp_Dept();
            var m_dept = b_dept.GetModel(sourceid);
            bool flag = true;
            if (point == "append")
            {
                m_dept.dept_pid = targetid;
                flag = b_dept.Update(m_dept);
            }
            else if (point == "top")
            {
                m_dept.dept_order--;
                var m_dept_target = b_dept.GetModel(targetid);
                m_dept_target.dept_order++;
                flag = b_dept.UpdateMany(m_dept, m_dept_target);
            }
            else if (point == "bottom")
            {
                m_dept.dept_order++;
                var m_dept_target = b_dept.GetModel(targetid);
                m_dept_target.dept_order--;
                flag = b_dept.UpdateMany(m_dept, m_dept_target);
            }

            if (flag)
            {
                return GetO();
            }
            else
            {
                return "";
            }
        }

        public string GetAllDept()
        {
           
            var b_dept = new AutekInfo.BLL.Emp_Dept();
            
            var list = b_dept.GetModelList("").OrderBy(dept => dept.dept_order).ThenBy(dept => dept.dept_name).ToList();
            return JsonConvert.SerializeObject(list);
        }

        public string GetDept()
        {
            string dept_id = Request["dept_id"] == null ? "" : Request["dept_id"].ToString();
            string dept_name = Request["dept_name"] == null ? "" : Request["dept_name"].ToString(); ;
            var b_dept = new AutekInfo.BLL.Emp_Dept();
            var m =new AutekInfo.Model.Emp_Dept();
            if(!String.IsNullOrEmpty(dept_id)){
                 m = b_dept.GetModel(int.Parse(dept_id));
            }else{
                 m = b_dept.GetModel(dept_name);
            }
            return JsonConvert.SerializeObject(m);

        }
        
        public int AddDept()
        {
            string deptname = Request["d_name"].ToString().Trim();
            string deptcode = Request["d_code"].ToString().Trim();
            int deptpid = int.Parse(Request["d_pid"].ToString());
            int deptorder = int.Parse(Request["d_order"].ToString());
            var b_dept = new AutekInfo.BLL.Emp_Dept();
            var _list = b_dept.GetModelList(String.Format(" dept_name='{0}' or dept_code='(1)' ", deptname, deptcode));
            if (_list.Count > 0)
            {
                return -1;
            }
            var m_dept = new AutekInfo.Model.Emp_Dept();
            m_dept.dept_name = deptname;
            m_dept.dept_code = deptcode;
            m_dept.dept_pid = deptpid;
            m_dept.dept_order = deptorder;
            return b_dept.Add(m_dept);
        }
        public bool DelDept()
        {
            int dept_id = int.Parse(Request["dept_id"].ToString());
            var b_dept = new AutekInfo.BLL.Emp_Dept();
            var _list = b_dept.GetModelList(String.Format(" dept_pid={0} ", dept_id));
            if (_list.Count > 0)
            {
                return false;
            }

            return b_dept.Delete(dept_id);
        }
        public bool ChgDept()
        {
            int deptid = int.Parse(Request["dept_id"].ToString());
            string deptname = Request["d_name"].ToString().Trim();
            string deptcode = Request["d_code"].ToString().Trim();
            int deptpid = int.Parse(Request["d_pid"].ToString());
            int deptorder = int.Parse(Request["d_order"].ToString());
            var b_dept = new AutekInfo.BLL.Emp_Dept();
            var m_dept = b_dept.GetModel(deptid);
            if (m_dept.dept_name != deptname || m_dept.dept_code != deptcode)
            {
                var _list = b_dept.GetModelList(String.Format(" dept_name='{0}' or dept_code='(1)' ", deptname, deptcode));
                if (_list.Count > 0)
                {
                    return false;
                }
            }
            m_dept.dept_name = deptname;
            m_dept.dept_code = deptcode;
            m_dept.dept_pid = deptpid;
            m_dept.dept_order = deptorder;
            return b_dept.Update(m_dept);
        }
        #endregion
        #region Role
        public ActionResult RoleManage()
        {
            return View();
        }
        public string GetRoles()
        {
            var b_role =new  AutekInfo.BLL.Emp_Roles();
            var list = b_role.GetModelList("");
            return JsonConvert.SerializeObject(list);
        }
        public string AddRoles()
        {
            string role_code=Request["role_code"].Trim();
            string role_name=Request["role_name"].Trim();
            string role_describe=Request["role_describe"].Trim();
            var b_role = new AutekInfo.BLL.Emp_Roles();
            var list = b_role.GetModelList(String.Format("role_code='{0}' or role_name='{1}'",role_code,role_name));
            if(list.Count>0){
                return "该角色已存在！";
            }
            var m = new AutekInfo.Model.Emp_Roles();
            m.role_code = role_code;
            m.role_name = role_name;
            m.role_describe = role_describe;
            return b_role.Add(m).ToString();
        }
        public string EditRoles()
        {
            int role_id = int.Parse(Request["role_id"].ToString());
            string role_code = Request["role_code"].ToString().Trim();
            string role_name = Request["role_name"].ToString().Trim();
            string role_describe = Request["role_describe"].ToString().Trim();
            var b_role = new AutekInfo.BLL.Emp_Roles();
            var m_role = b_role.GetModel(role_id);
            if (m_role.role_code != role_code || m_role.role_name != role_name)
            {
                var _list = b_role.GetModelList(String.Format(" role_name='{0}' or role_code='(1)' ", role_name, role_code));
                if (_list.Count > 0)
                {
                    return "角色名或代码重复！";
                }
            }
            m_role.role_code = role_code;
            m_role.role_name = role_name;
            m_role.role_describe = role_describe;
            return b_role.Update(m_role).ToString().ToLower();
        }
        public string DelRoles()
        {
            string ids = Request.QueryString["ids"];
            var b_role = new AutekInfo.BLL.Emp_Roles();
            return b_role.DeleteList(ids).ToString().ToLower();
        }
        public ActionResult OutPutRoles()
        {
            List<AutekInfo.Common.ExcTitvsFeilds> list_excelTitle = new List<AutekInfo.Common.ExcTitvsFeilds>();


            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "ID", feild = "role_id" });
            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "角色代码", feild = "role_code" });
            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "角色描述", feild = "role_describe" });
            //list_excelTitle.Add("角色代码");
            //list_excelTitle.Add("角色名称");
            //list_excelTitle.Add("角色描述");            
            var b_role = new AutekInfo.BLL.Emp_Roles();
            List<AutekInfo.Model.Emp_Roles> list_m = b_role.GetModelList("");            
           // return b_role.DeleteList(ids).ToString().ToLower();
           string temp_filepath= AutekInfo.Common.ExcelHelper.OutputList(list_excelTitle, list_m);
           return File(temp_filepath, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "导出roles.xlsx");
        }

        #endregion
        #region Role2Emp
        public ActionResult Role2Emp()
        {
            return View();
        }
        public string GetEmp2Roles()
        {
            string sort = Request["sort"];
            bool order = Request["order"] == "desc" ? true : false;
            var b = new AutekInfo.BLL.View_Emp_Role();
            var list = new List<AutekInfo.Model.View_Emp_Role>();
            if (order)
            {
                list = b.GetModelList("").OrderByDescending(o => o.GetType().GetProperty(sort).GetValue(o, null)).ToList();
            }
            else
            {
                list = b.GetModelList("").OrderBy(o => o.GetType().GetProperty(sort).GetValue(o, null)).ToList();
            }
            return JsonConvert.SerializeObject(list);
        }
        public int AddEmp2Roles()
        {
            int role_id = int.Parse(Request["role_id"].Trim());
            string emp_ids = Request["emp_ids"].Trim();
            var b = new AutekInfo.BLL.M_Emp_Role();
            emp_ids = emp_ids.Remove(emp_ids.Length-1,1);//去掉最后一个逗号
            string[] arr_ids = emp_ids.Split(',');
            foreach (string id in arr_ids)
            {
                var l = b.GetModelList(String.Format(" emp_id={0} and role_id={1}",id,role_id));
                if (l.Count < 1)
                {
                    var m = new AutekInfo.Model.M_Emp_Role();
                    m.emp_id = int.Parse(id);
                    m.role_id = role_id;
                    b.Add(m);
                }                
            }           
            return 1;
        }
        public string DelEmp2Roles()
        {
            string ids = Request.QueryString["ids"];
            var b = new AutekInfo.BLL.M_Emp_Role();
            return b.DeleteList(ids).ToString().ToLower();
        }
        public ActionResult OutPutEmp2Roles()
        {
            List<AutekInfo.Common.ExcTitvsFeilds> list_excelTitle = new List<AutekInfo.Common.ExcTitvsFeilds>();
            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "ID", feild = "m_emp_role_id" });
            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "姓名", feild = "emp_cnname" });
            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "角色代码", feild = "role_code" });
            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "角色名称", feild = "role_name" });
            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "角色描述", feild = "role_describe" });
            var b = new AutekInfo.BLL.View_Emp_Role();
            List<AutekInfo.Model.View_Emp_Role> list_m = b.GetModelList("");
            string temp_filepath = AutekInfo.Common.ExcelHelper.OutputList(list_excelTitle, list_m);
            return File(temp_filepath, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "导出role2emp.xlsx");
        }       
        #endregion
        #region chsoe
                public ActionResult SelectEmps()
                {
                    return View();
                }
                public ActionResult GetEmps()
                {
                    return View();
                }
        #endregion
        #region Authority
        public ActionResult AuthorityManage()
        {
            return View();
        }
        public string GetAuthoritys()
        {
            var b_Authority = new AutekInfo.BLL.Emp_Authority();
            var list = b_Authority.GetModelList("");
            return JsonConvert.SerializeObject(list);
        }
        public string AddAuthoritys()
        {
            string auth_code = Request["auth_code"].Trim();
            string auth_name = Request["auth_name"].Trim();
            string auth_remark = Request["auth_remark"].Trim();
            var b_Authority = new AutekInfo.BLL.Emp_Authority();
            var list = b_Authority.GetModelList(String.Format("auth_code='{0}' or auth_name='{1}'", auth_code, auth_name));
            if (list.Count > 0)
            {
                return "该权限已存在！";
            }
            var m = new AutekInfo.Model.Emp_Authority();
            m.auth_code = auth_code;
            m.auth_name = auth_name;
            m.auth_remark = auth_remark;
            return b_Authority.Add(m).ToString();
        }
        public string EditAuthoritys()
        {
            int auth_id = int.Parse(Request["auth_id"].ToString());
            string auth_code = Request["auth_code"].ToString().Trim();
            string auth_name = Request["auth_name"].ToString().Trim();
            string auth_remark = Request["auth_remark"].ToString().Trim();
            var b_Authority = new AutekInfo.BLL.Emp_Authority();
            var m_Authority = b_Authority.GetModel(auth_id);
            if (m_Authority.auth_code != auth_code || m_Authority.auth_name != auth_name)
            {
                var _list = b_Authority.GetModelList(String.Format(" auth_name='{0}' or auth_code='(1)' ", auth_name, auth_code));
                if (_list.Count > 0)
                {
                    return "权限名或代码重复！";
                }
            }
            m_Authority.auth_code = auth_code;
            m_Authority.auth_name = auth_name;
            m_Authority.auth_remark = auth_remark;
            return b_Authority.Update(m_Authority).ToString().ToLower();
        }
        public string DelAuthoritys()
        {
            string ids = Request.QueryString["ids"];
            var b_Authority = new AutekInfo.BLL.Emp_Authority();
            return b_Authority.DeleteList(ids).ToString().ToLower();
        }
        public ActionResult OutPutAuthoritys()
        {
            List<AutekInfo.Common.ExcTitvsFeilds> list_excelTitle = new List<AutekInfo.Common.ExcTitvsFeilds>();


            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "ID", feild = "auth_id" });
            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "权限代码", feild = "auth_code" });
            list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "权限描述", feild = "auth_remark" });
                               
            var b_Authority = new AutekInfo.BLL.Emp_Authority();
            List<AutekInfo.Model.Emp_Authority> list_m = b_Authority.GetModelList("");
            // return b_Authority.DeleteList(ids).ToString().ToLower();
            string temp_filepath = AutekInfo.Common.ExcelHelper.OutputList(list_excelTitle, list_m);
            return File(temp_filepath, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "导出Authoritys.xlsx");
        }

        #endregion
        #region Menu2Auth
        public ActionResult Menu2Auth()
        {
            return View();
        }
        public string GetMenu2Auth()
        {

            var all_m = HomeController.list_all;
            StringBuilder sb = new StringBuilder();
            string id = Request["id"];
            var b = new AutekInfo.BLL.Menu();
            var b_Menu_Option = new AutekInfo.BLL.View_Menu_Option();
            sb.Append("[");
            if (String.IsNullOrEmpty(id))//没有传id,则是默认顶级目录
            {

                List<AutekInfo.Model.Menu> list_menu = all_m.FindAll(menu => menu.menu_pid == 0);
                
                foreach (var menu in list_menu)
                {
                    sb.Append("{");
                    sb.Append("\"id\":\"" + menu.menu_id + "\",");
                    sb.Append("\"menu_id\":\"" + menu.menu_id + "\",");
                    sb.Append("\"menu_name\":\"" + menu.menu_name + "\",");
                    sb.Append("\"menu_option\":\"\",");
                    sb.Append("\"state\":\"closed\"},");
                   
                }
                sb.Remove(sb.Length - 1, 1);
            }
            else//传了id  
            {
                List<AutekInfo.Model.Menu> list_menu_hasid = all_m.FindAll(menu => menu.menu_pid == int.Parse(id));
                var list_option = new List<AutekInfo.Model.View_Menu_Option>();
                StringBuilder cbox = new StringBuilder();
                foreach (var m in list_menu_hasid)
                {
                    cbox.Clear();
                    sb.Append("{");
                    sb.Append("\"id\":\"" + m.menu_id + "\",");
                    sb.Append("\"menu_id\":\"" + m.menu_id + "\",");
                    sb.Append("\"menu_name\":\"" + m.menu_name + "\",");
                    if (all_m.FindAll(menu => menu.menu_pid == m.menu_id).Count > 0)
                    {
                        sb.Append("\"state\":\"closed\"},");
                    }
                    else
                    {
                        list_option = b_Menu_Option.GetModelList(String.Format(" menu_id={0} and option_id is not null ", m.menu_id));
                        if (list_option.Count > 0)
                        {
                            foreach(AutekInfo.Model.View_Menu_Option s in list_option)
                            {
                                cbox.Append(String.Format("<input type='checkbox' id='ck_{1}_{2}_{3})' name='ck_{1}_{2}_{3}' />{0}", s.option_name, m.menu_id, s.option_code,s.option_id));
                            }                            
                        }
                        sb.Append("\"menu_option\":\"" + cbox.ToString()+"\",");
                        
                        sb.Append("\"state\":\"open\"},");
                        
                    }
                }

                if (sb.Length > 1)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
            }
            sb.Append("]");
            return sb.ToString();
        }
        //public int AddEmp2Roles()
        //{
        //    int role_id = int.Parse(Request["role_id"].Trim());
        //    string emp_ids = Request["emp_ids"].Trim();
        //    var b = new AutekInfo.BLL.M_Emp_Role();
        //    emp_ids = emp_ids.Remove(emp_ids.Length - 1, 1);//去掉最后一个逗号
        //    string[] arr_ids = emp_ids.Split(',');
        //    foreach (string id in arr_ids)
        //    {
        //        var l = b.GetModelList(String.Format(" emp_id={0} and role_id={1}", id, role_id));
        //        if (l.Count < 1)
        //        {
        //            var m = new AutekInfo.Model.M_Emp_Role();
        //            m.emp_id = int.Parse(id);
        //            m.role_id = role_id;
        //            b.Add(m);
        //        }
        //    }
        //    return 1;
        //}
        //public string DelEmp2Roles()
        //{
        //    string ids = Request.QueryString["ids"];
        //    var b = new AutekInfo.BLL.M_Emp_Role();
        //    return b.DeleteList(ids).ToString().ToLower();
        //}
        //public ActionResult OutPutEmp2Roles()
        //{
        //    List<AutekInfo.Common.ExcTitvsFeilds> list_excelTitle = new List<AutekInfo.Common.ExcTitvsFeilds>();
        //    list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "ID", feild = "m_emp_role_id" });
        //    list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "姓名", feild = "emp_cnname" });
        //    list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "角色代码", feild = "role_code" });
        //    list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "角色名称", feild = "role_name" });
        //    list_excelTitle.Add(new AutekInfo.Common.ExcTitvsFeilds() { title = "角色描述", feild = "role_describe" });
        //    var b = new AutekInfo.BLL.View_Emp_Role();
        //    List<AutekInfo.Model.View_Emp_Role> list_m = b.GetModelList("");
        //    string temp_filepath = AutekInfo.Common.ExcelHelper.OutputList(list_excelTitle, list_m);
        //    return File(temp_filepath, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "导出role2emp.xlsx");
        //}
        #endregion
    }
}
