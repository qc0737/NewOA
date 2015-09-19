using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//View_Role_Auths
		public partial class View_Role_Auths
	{
   		     
		private readonly AutekInfo.DAL.View_Role_Auths dal=new AutekInfo.DAL.View_Role_Auths();
		public View_Role_Auths()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(AutekInfo.Model.View_Role_Auths model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.View_Role_Auths model)
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
		public AutekInfo.Model.View_Role_Auths GetModel(int role_id)
		{
			
			return dal.GetModel(role_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.View_Role_Auths GetModelByCache(int role_id)
		{
			
			string CacheKey = "View_Role_AuthsModel-" + role_id;
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
			return (AutekInfo.Model.View_Role_Auths)objModel;
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
		public List<AutekInfo.Model.View_Role_Auths> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.View_Role_Auths> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.View_Role_Auths> modelList = new List<AutekInfo.Model.View_Role_Auths>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.View_Role_Auths model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.View_Role_Auths();					
													if(dt.Rows[n]["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(dt.Rows[n]["role_id"].ToString());
				}
																																				model.role_code= dt.Rows[n]["role_code"].ToString();
																																model.role_name= dt.Rows[n]["role_name"].ToString();
																																model.role_describe= dt.Rows[n]["role_describe"].ToString();
																																model.authids= dt.Rows[n]["authids"].ToString();
																																model.authnames= dt.Rows[n]["authnames"].ToString();
																						
				
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