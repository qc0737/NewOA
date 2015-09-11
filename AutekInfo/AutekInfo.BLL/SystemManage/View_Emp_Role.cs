using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//View_Emp_Role
		public partial class View_Emp_Role
	{
   		     
		private readonly AutekInfo.DAL.View_Emp_Role dal=new AutekInfo.DAL.View_Emp_Role();
		public View_Emp_Role()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			return dal.Exists();
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(AutekInfo.Model.View_Emp_Role model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.View_Emp_Role model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			
			return dal.Delete();
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.View_Emp_Role GetModel()
		{
			
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.View_Emp_Role GetModelByCache()
		{
			
			string CacheKey = "View_Emp_RoleModel-" ;
			object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
						AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AutekInfo.Model.View_Emp_Role)objModel;
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
		public List<AutekInfo.Model.View_Emp_Role> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.View_Emp_Role> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.View_Emp_Role> modelList = new List<AutekInfo.Model.View_Emp_Role>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.View_Emp_Role model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.View_Emp_Role();					
																	model.role_code= dt.Rows[n]["role_code"].ToString();
																																model.role_name= dt.Rows[n]["role_name"].ToString();
																																model.role_describe= dt.Rows[n]["role_describe"].ToString();
																												if(dt.Rows[n]["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(dt.Rows[n]["emp_id"].ToString());
				}
																																				model.emp_cnname= dt.Rows[n]["emp_cnname"].ToString();
																						
				
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