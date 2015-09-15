using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//View_Menu_Option
		public partial class View_Menu_Option
	{
   		     
		private readonly AutekInfo.DAL.View_Menu_Option dal=new AutekInfo.DAL.View_Menu_Option();
		public View_Menu_Option()
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
		public void  Add(AutekInfo.Model.View_Menu_Option model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.View_Menu_Option model)
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
		public AutekInfo.Model.View_Menu_Option GetModel()
		{
			
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public AutekInfo.Model.View_Menu_Option GetModelByCache()
        //{
			
        //    string CacheKey = "View_Menu_OptionModel-" + ;
        //    object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel();
        //            if (objModel != null)
        //            {
        //                int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (AutekInfo.Model.View_Menu_Option)objModel;
        //}

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
		public List<AutekInfo.Model.View_Menu_Option> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.View_Menu_Option> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.View_Menu_Option> modelList = new List<AutekInfo.Model.View_Menu_Option>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.View_Menu_Option model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.View_Menu_Option();					
																	model.menu_name= dt.Rows[n]["menu_name"].ToString();
																																model.option_code= dt.Rows[n]["option_code"].ToString();
																																model.option_name= dt.Rows[n]["option_name"].ToString();
																																model.option_desc= dt.Rows[n]["option_desc"].ToString();
																												if(dt.Rows[n]["option_id"].ToString()!="")
				{
					model.option_id=int.Parse(dt.Rows[n]["option_id"].ToString());
				}
																																if(dt.Rows[n]["menu_id"].ToString()!="")
				{
					model.menu_id=int.Parse(dt.Rows[n]["menu_id"].ToString());
				}
																																																if(dt.Rows[n]["menu_isshow"].ToString()!="")
				{
					if((dt.Rows[n]["menu_isshow"].ToString()=="1")||(dt.Rows[n]["menu_isshow"].ToString().ToLower()=="true"))
					{
					model.menu_isshow= true;
					}
					else
					{
					model.menu_isshow= false;
					}
				}
																if(dt.Rows[n]["menu_pid"].ToString()!="")
				{
					model.menu_pid=int.Parse(dt.Rows[n]["menu_pid"].ToString());
				}
																																if(dt.Rows[n]["menu_sort"].ToString()!="")
				{
					model.menu_sort=int.Parse(dt.Rows[n]["menu_sort"].ToString());
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