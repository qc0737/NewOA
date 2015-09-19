using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//M_Role_Auth
		public partial class M_Role_Auth
	{
   		     
		private readonly AutekInfo.DAL.M_Role_Auth dal=new AutekInfo.DAL.M_Role_Auth();
		public M_Role_Auth()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int m_role_auth_id)
		{
			return dal.Exists(m_role_auth_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(AutekInfo.Model.M_Role_Auth model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.M_Role_Auth model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int m_role_auth_id)
		{
			
			return dal.Delete(m_role_auth_id);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string m_role_auth_idlist )
		{
			return dal.DeleteList(m_role_auth_idlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.M_Role_Auth GetModel(int m_role_auth_id)
		{
			
			return dal.GetModel(m_role_auth_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.M_Role_Auth GetModelByCache(int m_role_auth_id)
		{
			
			string CacheKey = "M_Role_AuthModel-" + m_role_auth_id;
			object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(m_role_auth_id);
					if (objModel != null)
					{
						int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
						AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AutekInfo.Model.M_Role_Auth)objModel;
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
		public List<AutekInfo.Model.M_Role_Auth> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.M_Role_Auth> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.M_Role_Auth> modelList = new List<AutekInfo.Model.M_Role_Auth>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.M_Role_Auth model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.M_Role_Auth();					
													if(dt.Rows[n]["m_role_auth_id"].ToString()!="")
				{
					model.m_role_auth_id=int.Parse(dt.Rows[n]["m_role_auth_id"].ToString());
				}
																																if(dt.Rows[n]["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(dt.Rows[n]["role_id"].ToString());
				}
																																if(dt.Rows[n]["auth_id"].ToString()!="")
				{
					model.auth_id=int.Parse(dt.Rows[n]["auth_id"].ToString());
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


        public int DelAddModelList(List<Model.M_Role_Auth> list)
        {
            return dal.DelAddModelList(list);
        }
    }
}