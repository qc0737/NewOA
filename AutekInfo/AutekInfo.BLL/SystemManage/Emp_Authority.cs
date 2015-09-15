using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//Emp_Authority
		public partial class Emp_Authority
	{
   		     
		private readonly AutekInfo.DAL.Emp_Authority dal=new AutekInfo.DAL.Emp_Authority();
		public Emp_Authority()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int auth_id)
		{
			return dal.Exists(auth_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(AutekInfo.Model.Emp_Authority model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.Emp_Authority model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int auth_id)
		{
			
			return dal.Delete(auth_id);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string auth_idlist )
		{
			return dal.DeleteList(auth_idlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.Emp_Authority GetModel(int auth_id)
		{
			
			return dal.GetModel(auth_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.Emp_Authority GetModelByCache(int auth_id)
		{
			
			string CacheKey = "Emp_AuthorityModel-" + auth_id;
			object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(auth_id);
					if (objModel != null)
					{
						int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
						AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AutekInfo.Model.Emp_Authority)objModel;
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
		public List<AutekInfo.Model.Emp_Authority> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.Emp_Authority> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.Emp_Authority> modelList = new List<AutekInfo.Model.Emp_Authority>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.Emp_Authority model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.Emp_Authority();					
													if(dt.Rows[n]["auth_id"].ToString()!="")
				{
					model.auth_id=int.Parse(dt.Rows[n]["auth_id"].ToString());
				}
																																				model.auth_code= dt.Rows[n]["auth_code"].ToString();
																																model.auth_name= dt.Rows[n]["auth_name"].ToString();
																																model.auth_remark= dt.Rows[n]["auth_remark"].ToString();
																						
				
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