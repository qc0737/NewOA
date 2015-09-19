using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//View_BaseAccount
		public partial class View_BaseAccount
	{
   		     
		private readonly AutekInfo.DAL.View_BaseAccount dal=new AutekInfo.DAL.View_BaseAccount();
		public View_BaseAccount()
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
		public void  Add(AutekInfo.Model.View_BaseAccount model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.View_BaseAccount model)
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
		public AutekInfo.Model.View_BaseAccount GetModel()
		{
			
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
	

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
		public List<AutekInfo.Model.View_BaseAccount> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.View_BaseAccount> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.View_BaseAccount> modelList = new List<AutekInfo.Model.View_BaseAccount>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.View_BaseAccount model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.View_BaseAccount();					
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
																																				model.emp_dept= dt.Rows[n]["emp_dept"].ToString();
																												if(dt.Rows[n]["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(dt.Rows[n]["emp_id"].ToString());
				}
																																				model.emp_cnname= dt.Rows[n]["emp_cnname"].ToString();
																																model.role_name= dt.Rows[n]["role_name"].ToString();
																																model.role_code= dt.Rows[n]["role_code"].ToString();
																						
				
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