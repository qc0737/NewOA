using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//Emp_Account
		public partial class Emp_Account
	{
   		     
		private readonly AutekInfo.DAL.Emp_Account dal=new AutekInfo.DAL.Emp_Account();
		public Emp_Account()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string loginid)
		{
			return dal.Exists(loginid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(AutekInfo.Model.Emp_Account model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.Emp_Account model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string loginid)
		{
			
			return dal.Delete(loginid);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.Emp_Account GetModel(string loginid)
		{
			
			return dal.GetModel(loginid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.Emp_Account GetModelByCache(string loginid)
		{
			
			string CacheKey = "Emp_AccountModel-" + loginid;
			object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(loginid);
					if (objModel != null)
					{
						int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
						AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AutekInfo.Model.Emp_Account)objModel;
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
		public List<AutekInfo.Model.Emp_Account> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.Emp_Account> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.Emp_Account> modelList = new List<AutekInfo.Model.Emp_Account>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.Emp_Account model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.Emp_Account();					
																	model.loginid= dt.Rows[n]["loginid"].ToString();
																																model.pwd= dt.Rows[n]["pwd"].ToString();
																																model.status= dt.Rows[n]["status"].ToString();
																																model.lastloginip= dt.Rows[n]["lastloginip"].ToString();
																												if(dt.Rows[n]["lastlogindate"].ToString()!="")
				{
					model.lastlogindate=DateTime.Parse(dt.Rows[n]["lastlogindate"].ToString());
				}
																																if(dt.Rows[n]["sysstatus"].ToString()!="")
				{
					model.sysstatus=int.Parse(dt.Rows[n]["sysstatus"].ToString());
				}
																																if(dt.Rows[n]["updater"].ToString()!="")
				{
					model.updater=int.Parse(dt.Rows[n]["updater"].ToString());
				}
																																if(dt.Rows[n]["updatedata"].ToString()!="")
				{
					model.updatedata=DateTime.Parse(dt.Rows[n]["updatedata"].ToString());
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