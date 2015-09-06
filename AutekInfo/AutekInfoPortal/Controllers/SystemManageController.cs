using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
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
    }
}
