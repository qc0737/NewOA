using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//M_Emp_Role
		public partial class M_Emp_Role
	{
   		     
		private readonly AutekInfo.DAL.M_Emp_Role dal=new AutekInfo.DAL.M_Emp_Role();
		public M_Emp_Role()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        //public bool Exists()
        //{
        //    return dal.Exists();
        //}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(AutekInfo.Model.M_Emp_Role model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.M_Emp_Role model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int m_emp_role_id)
		{
			
			return dal.Delete(m_emp_role_id);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string m_emp_role_idlist )
		{
			return dal.DeleteList(m_emp_role_idlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.M_Emp_Role GetModel(int m_emp_role_id)
		{
			
			return dal.GetModel(m_emp_role_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.M_Emp_Role GetModelByCache(int m_emp_role_id)
		{
			
			string CacheKey = "M_Emp_RoleModel-" + m_emp_role_id;
			object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(m_emp_role_id);
					if (objModel != null)
					{
						int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
						AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AutekInfo.Model.M_Emp_Role)objModel;
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
		public List<AutekInfo.Model.M_Emp_Role> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.M_Emp_Role> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.M_Emp_Role> modelList = new List<AutekInfo.Model.M_Emp_Role>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.M_Emp_Role model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.M_Emp_Role();					
													if(dt.Rows[n]["m_emp_role_id"].ToString()!="")
				{
					model.m_emp_role_id=int.Parse(dt.Rows[n]["m_emp_role_id"].ToString());
				}
																																if(dt.Rows[n]["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(dt.Rows[n]["emp_id"].ToString());
				}
																																if(dt.Rows[n]["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(dt.Rows[n]["role_id"].ToString());
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
   
	}
}