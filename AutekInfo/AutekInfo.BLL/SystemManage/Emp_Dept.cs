using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//Emp_Dept
		public partial class Emp_Dept
	{
   		     
		private readonly AutekInfo.DAL.Emp_Dept dal=new AutekInfo.DAL.Emp_Dept();
		public Emp_Dept()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int dept_id)
		{
			return dal.Exists(dept_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(AutekInfo.Model.Emp_Dept model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.Emp_Dept model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int dept_id)
		{
			
			return dal.Delete(dept_id);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string dept_idlist )
		{
			return dal.DeleteList(dept_idlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.Emp_Dept GetModel(int dept_id)
		{
			
			return dal.GetModel(dept_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.Emp_Dept GetModelByCache(int dept_id)
		{
			
			string CacheKey = "Emp_DeptModel-" + dept_id;
			object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(dept_id);
					if (objModel != null)
					{
						int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
						AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AutekInfo.Model.Emp_Dept)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.Emp_Dept> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.Emp_Dept> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.Emp_Dept> modelList = new List<AutekInfo.Model.Emp_Dept>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.Emp_Dept model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.Emp_Dept();					
													if(dt.Rows[n]["dept_id"].ToString()!="")
				{
					model.dept_id=int.Parse(dt.Rows[n]["dept_id"].ToString());
				}
																																				model.dept_name= dt.Rows[n]["dept_name"].ToString();
																																model.dept_code= dt.Rows[n]["dept_code"].ToString();
																												if(dt.Rows[n]["dept_pid"].ToString()!="")
				{
					model.dept_pid=int.Parse(dt.Rows[n]["dept_pid"].ToString());
				}
																																if(dt.Rows[n]["dept_order"].ToString()!="")
				{
					model.dept_order=int.Parse(dt.Rows[n]["dept_order"].ToString());
				}
																										
				
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
#endregion

        #region extend
        public bool UpdateMany(Model.Emp_Dept m_dept, Model.Emp_Dept m_dept_target)
        {
            return dal.Update(m_dept, m_dept_target);
        }
        public Model.Emp_Dept GetModel(string dept_name)
        {
            return dal.GetModel(dept_name);
        }
        #endregion

        
    }
}