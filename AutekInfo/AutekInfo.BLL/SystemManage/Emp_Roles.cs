using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//Emp_Roles
		public partial class Emp_Roles
	{
   		     
		private readonly AutekInfo.DAL.Emp_Roles dal=new AutekInfo.DAL.Emp_Roles();
		public Emp_Roles()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int role_id)
		{
			return dal.Exists(role_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(AutekInfo.Model.Emp_Roles model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.Emp_Roles model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int role_id)
		{
			
			return dal.Delete(role_id);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string role_idlist )
		{
			return dal.DeleteList(role_idlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.Emp_Roles GetModel(int role_id)
		{
			
			return dal.GetModel(role_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.Emp_Roles GetModelByCache(int role_id)
		{
			
			string CacheKey = "Emp_RolesModel-" + role_id;
			object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(role_id);
					if (objModel != null)
					{
						int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
						AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AutekInfo.Model.Emp_Roles)objModel;
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
		public List<AutekInfo.Model.Emp_Roles> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.Emp_Roles> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.Emp_Roles> modelList = new List<AutekInfo.Model.Emp_Roles>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.Emp_Roles model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.Emp_Roles();					
													if(dt.Rows[n]["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(dt.Rows[n]["role_id"].ToString());
				}
																																				model.role_code= dt.Rows[n]["role_code"].ToString();
																																model.role_name= dt.Rows[n]["role_name"].ToString();
																																model.role_describe= dt.Rows[n]["role_describe"].ToString();
																						
				
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