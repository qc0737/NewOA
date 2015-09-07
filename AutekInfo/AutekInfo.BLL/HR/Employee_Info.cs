using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.Common;
using AutekInfo.Model;
namespace AutekInfo.BLL {
	 	//Employee_Info
		public partial class Employee_Info
	{
   		     
		private readonly AutekInfo.DAL.Employee_Info dal=new AutekInfo.DAL.Employee_Info();
		public Employee_Info()
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
		public int  Add(AutekInfo.Model.Employee_Info model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.Employee_Info model)
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
		public AutekInfo.Model.Employee_Info GetModel(int emp_id)
		{
			
			return dal.GetModel(emp_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AutekInfo.Model.Employee_Info GetModelByCache(int emp_id)
		{
			
			string CacheKey = "Employee_InfoModel-" + emp_id;
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
			return (AutekInfo.Model.Employee_Info)objModel;
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
		public List<AutekInfo.Model.Employee_Info> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AutekInfo.Model.Employee_Info> DataTableToList(DataTable dt)
		{
			List<AutekInfo.Model.Employee_Info> modelList = new List<AutekInfo.Model.Employee_Info>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AutekInfo.Model.Employee_Info model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new AutekInfo.Model.Employee_Info();					
													if(dt.Rows[n]["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(dt.Rows[n]["emp_id"].ToString());
				}
																																				model.loginid= dt.Rows[n]["loginid"].ToString();
																																model.emp_dept= dt.Rows[n]["emp_dept"].ToString();
																																model.emp_insti= dt.Rows[n]["emp_insti"].ToString();
																																model.emp_comp= dt.Rows[n]["emp_comp"].ToString();
																																model.emp_worknum= dt.Rows[n]["emp_worknum"].ToString();
																																model.emp_cnname= dt.Rows[n]["emp_cnname"].ToString();
																																model.emp_cardnum= dt.Rows[n]["emp_cardnum"].ToString();
																												if(dt.Rows[n]["emp_birthdate"].ToString()!="")
				{
					model.emp_birthdate=DateTime.Parse(dt.Rows[n]["emp_birthdate"].ToString());
				}
																																if(dt.Rows[n]["emp_entrydate"].ToString()!="")
				{
					model.emp_entrydate=DateTime.Parse(dt.Rows[n]["emp_entrydate"].ToString());
				}
																																				model.emp_entrytitle= dt.Rows[n]["emp_entrytitle"].ToString();
																												if(dt.Rows[n]["emp_practicedate"].ToString()!="")
				{
					model.emp_practicedate=DateTime.Parse(dt.Rows[n]["emp_practicedate"].ToString());
				}
																																if(dt.Rows[n]["emp_lastdate"].ToString()!="")
				{
					model.emp_lastdate=DateTime.Parse(dt.Rows[n]["emp_lastdate"].ToString());
				}
																																				model.emp_sex= dt.Rows[n]["emp_sex"].ToString();
																																model.emp_title= dt.Rows[n]["emp_title"].ToString();
																																model.emp_type= dt.Rows[n]["emp_type"].ToString();
																																model.emp_workarea= dt.Rows[n]["emp_workarea"].ToString();
																																model.emp_luyongfangshi= dt.Rows[n]["emp_luyongfangshi"].ToString();
																																model.emp_luyongqudao= dt.Rows[n]["emp_luyongqudao"].ToString();
																												if(dt.Rows[n]["emp_cometruedate"].ToString()!="")
				{
					model.emp_cometruedate=DateTime.Parse(dt.Rows[n]["emp_cometruedate"].ToString());
				}
																																if(dt.Rows[n]["emp_yjcometruedate"].ToString()!="")
				{
					model.emp_yjcometruedate=DateTime.Parse(dt.Rows[n]["emp_yjcometruedate"].ToString());
				}
																																if(dt.Rows[n]["emp_beginworkdate"].ToString()!="")
				{
					model.emp_beginworkdate=DateTime.Parse(dt.Rows[n]["emp_beginworkdate"].ToString());
				}
																																				model.emp_workcertificate= dt.Rows[n]["emp_workcertificate"].ToString();
																																model.emp_zhicheng= dt.Rows[n]["emp_zhicheng"].ToString();
																																model.emp_identity= dt.Rows[n]["emp_identity"].ToString();
																																model.emp_age= dt.Rows[n]["emp_age"].ToString();
																																model.emp_photolink= dt.Rows[n]["emp_photolink"].ToString();
																																model.emp_minzhu= dt.Rows[n]["emp_minzhu"].ToString();
																																model.emp_zzmm= dt.Rows[n]["emp_zzmm"].ToString();
																																model.emp_marital= dt.Rows[n]["emp_marital"].ToString();
																																model.emp_healthstatus= dt.Rows[n]["emp_healthstatus"].ToString();
																																model.emp_paiban= dt.Rows[n]["emp_paiban"].ToString();
																																model.emp_hklx= dt.Rows[n]["emp_hklx"].ToString();
																																model.emp_jiguan= dt.Rows[n]["emp_jiguan"].ToString();
																																model.emp_hujiaddr= dt.Rows[n]["emp_hujiaddr"].ToString();
																																model.emp_juzhuaddr= dt.Rows[n]["emp_juzhuaddr"].ToString();
																																model.emp_tel= dt.Rows[n]["emp_tel"].ToString();
																																model.emp_phone= dt.Rows[n]["emp_phone"].ToString();
																																model.emp_lxr= dt.Rows[n]["emp_lxr"].ToString();
																																model.emp_lxrphone= dt.Rows[n]["emp_lxrphone"].ToString();
																																model.emp_zhideng= dt.Rows[n]["emp_zhideng"].ToString();
																																model.emp_QQ= dt.Rows[n]["emp_QQ"].ToString();
																																model.emp_email= dt.Rows[n]["emp_email"].ToString();
																												if(dt.Rows[n]["emp_dimissdate"].ToString()!="")
				{
					model.emp_dimissdate=DateTime.Parse(dt.Rows[n]["emp_dimissdate"].ToString());
				}
																																				model.emp_dimisstype= dt.Rows[n]["emp_dimisstype"].ToString();
																																model.emp_dismissremark= dt.Rows[n]["emp_dismissremark"].ToString();
																																model.emp_isonworking= dt.Rows[n]["emp_isonworking"].ToString();
																																model.emp_iszda= dt.Rows[n]["emp_iszda"].ToString();
																																model.emp_isjthk= dt.Rows[n]["emp_isjthk"].ToString();
																																model.emp_sblx= dt.Rows[n]["emp_sblx"].ToString();
																																model.emp_sbnum= dt.Rows[n]["emp_sbnum"].ToString();
																																model.emp_isblacklist= dt.Rows[n]["emp_isblacklist"].ToString();
																																model.emp_balcklistremark= dt.Rows[n]["emp_balcklistremark"].ToString();
																																model.emp_lastcomp= dt.Rows[n]["emp_lastcomp"].ToString();
																																model.emp_remrak= dt.Rows[n]["emp_remrak"].ToString();
																																model.emp_birthtype= dt.Rows[n]["emp_birthtype"].ToString();
																												if(dt.Rows[n]["emp_real_brithdate"].ToString()!="")
				{
					model.emp_real_brithdate=DateTime.Parse(dt.Rows[n]["emp_real_brithdate"].ToString());
				}
																																				model.emp_jobtype= dt.Rows[n]["emp_jobtype"].ToString();
																																model.emp_banknum= dt.Rows[n]["emp_banknum"].ToString();
																																model.emp_bank= dt.Rows[n]["emp_bank"].ToString();
																												if(dt.Rows[n]["emp_createdate"].ToString()!="")
				{
					model.emp_createdate=DateTime.Parse(dt.Rows[n]["emp_createdate"].ToString());
				}
																																				model.emp_creater= dt.Rows[n]["emp_creater"].ToString();
																						
				
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