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

            int pid = 0;//int.Parse(Request["id"].ToString());
            List<AutekInfo.Model.Emp_Dept> list = new AutekInfo.BLL.Emp_Dept().GetModelList("").OrderBy(dept => dept.dept_order).ThenBy(dept => dept.dept_name).ToList();
            JsonHelper js = new JsonHelper();
            string json = new JsonHelper().GetOcharTree<AutekInfo.Model.Emp_Dept>(list, "dept_id", "dept_pid", "dept_name", pid);
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
       
        #endregion
    }
}
