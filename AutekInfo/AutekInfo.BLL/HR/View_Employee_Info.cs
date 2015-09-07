using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//View_Employee_Info
		public partial class View_Employee_Info
	{
   		     
		private readonly AutekInfo.DAL.View_Employee_Info dal=new AutekInfo.DAL.View_Employee_Info();
		public View_Employee_Info()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int emp_id)
		{
            return dal.Exists(emp_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(AutekInfo.Model.View_Employee_Info model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.View_Employee_Info model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int emp_id)
		{
			
			return dal.Delete(emp_id);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string emp_idlist )
		{
			return dal.DeleteList(emp_idlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.View_Employee_Info GetModel(int emp_id)
		{
			
			return dal.GetModel(emp_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.View_Employee_Info GetModelByCache(int emp_id)
		{
			
			string CacheKey = "View_Employee_InfoModel-" + emp_id;
			object objModel = AutekInfo.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(emp_id);
					if (objModel != null)
					{
						int ModelCache = AutekInfo.Common.ConfigHelper.GetConfigInt("ModelCache");
						AutekInfo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AutekInfo.Model.View_Employee_Info)objModel;
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
		public List<AutekInfo.Model.View_Employee_Info> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.View_Employee_Info> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.View_Employee_Info> modelList = new List<AutekInfo.Model.View_Employee_Info>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.View_Employee_Info model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.View_Employee_Info();					
													if(dt.Rows[n]["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(dt.Rows[n]["emp_id"].ToString());
				}
																																				model.emp_dept= dt.Rows[n]["emp_dept"].ToString();
																																model.emp_insti= dt.Rows[n]["emp_insti"].ToString();
																																model.emp_comp= dt.Rows[n]["emp_comp"].ToString();
																																model.emp_worknum= dt.Rows[n]["emp_worknum"].ToString();
																																model.emp_cnname= dt.Rows[n]["emp_cnname"].ToString();
																												if(dt.Rows[n]["emp_entrydate"].ToString()!="")
				{
					model.emp_entrydate=DateTime.Parse(dt.Rows[n]["emp_entrydate"].ToString());
				}
																																				model.emp_email= dt.Rows[n]["emp_email"].ToString();
																																model.emp_age= dt.Rows[n]["emp_age"].ToString();
																																model.emp_identity= dt.Rows[n]["emp_identity"].ToString();
																																model.emp_workarea= dt.Rows[n]["emp_workarea"].ToString();
																																model.emp_phone= dt.Rows[n]["emp_phone"].ToString();
																																model.emp_title= dt.Rows[n]["emp_title"].ToString();
																																model.emp_sex= dt.Rows[n]["emp_sex"].ToString();
																						
				
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

        public List<AutekInfo.Model.View_Employee_Info> GetModelListByPages(string strWhere,out int pcount,out int tcount)
        {
            DataSet ds = dal.GetModelListByPages(strWhere,out pcount,out tcount);
            return DataTableToList(ds.Tables[0]);
        }
        #endregion

    }
}