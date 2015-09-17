using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//Menu_Options
		public partial class Menu_Options
	{
   		     
		private readonly AutekInfo.DAL.Menu_Options dal=new AutekInfo.DAL.Menu_Options();
		public Menu_Options()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int option_id)
		{
			return dal.Exists(option_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(AutekInfo.Model.Menu_Options model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.Menu_Options model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int option_id)
		{
			
			return dal.Delete(option_id);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string option_idlist )
		{
			return dal.DeleteList(option_idlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.Menu_Options GetModel(int option_id)
		{
			
			return dal.GetModel(option_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.Menu_Options GetModelByCache(int option_id)
		{
			
			string CacheKey = "Menu_OptionsModel-" + option_id;
			object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(option_id);
					if (objModel != null)
					{
						int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
						AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AutekInfo.Model.Menu_Options)objModel;
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
		public List<AutekInfo.Model.Menu_Options> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.Menu_Options> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.Menu_Options> modelList = new List<AutekInfo.Model.Menu_Options>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.Menu_Options model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.Menu_Options();					
													if(dt.Rows[n]["option_id"].ToString()!="")
				{
					model.option_id=int.Parse(dt.Rows[n]["option_id"].ToString());
				}
																																if(dt.Rows[n]["menu_id"].ToString()!="")
				{
					model.menu_id=int.Parse(dt.Rows[n]["menu_id"].ToString());
				}
																																				model.option_code= dt.Rows[n]["option_code"].ToString();
																																model.option_name= dt.Rows[n]["option_name"].ToString();
																																model.option_desc= dt.Rows[n]["option_desc"].ToString();
																						
				
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
        public bool Remove(int menu_id)
        {
           return  dal.Remove(menu_id);
        }
#endregion
    }
}