using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//Menu_Options
		public partial class Menu_Options
	{
   		     
		public bool Exists(int option_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Menu_Options");
			strSql.Append(" where ");
			                                       strSql.Append(" option_id = @option_id  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@option_id", SqlDbType.Int,4)
			};
			parameters[0].Value = option_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutekInfo.Model.Menu_Options model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Menu_Options(");			
            strSql.Append("menu_id,option_code,option_name,option_desc");
			strSql.Append(") values (");
            strSql.Append("@menu_id,@option_code,@option_name,@option_desc");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@menu_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@option_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@option_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@option_desc", SqlDbType.NVarChar,100)             
              
            };
			            
            parameters[0].Value = model.menu_id;                        
            parameters[1].Value = model.option_code;                        
            parameters[2].Value = model.option_name;                        
            parameters[3].Value = model.option_desc;                        
			   
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);			
			if (obj == null)
			{
				return 0;
			}
			else
			{
				                    
            	return Convert.ToInt32(obj);
                                                                  
			}			   
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.Menu_Options model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Menu_Options set ");
			                                                
            strSql.Append(" menu_id = @menu_id , ");                                    
            strSql.Append(" option_code = @option_code , ");                                    
            strSql.Append(" option_name = @option_name , ");                                    
            strSql.Append(" option_desc = @option_desc  ");            			
			strSql.Append(" where option_id=@option_id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@option_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@option_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@option_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@option_desc", SqlDbType.NVarChar,100)             
              
            };
						            
            parameters[0].Value = model.option_id;                        
            parameters[1].Value = model.menu_id;                        
            parameters[2].Value = model.option_code;                        
            parameters[3].Value = model.option_name;                        
            parameters[4].Value = model.option_desc;                        
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int option_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Menu_Options ");
			strSql.Append(" where option_id=@option_id");
						SqlParameter[] parameters = {
					new SqlParameter("@option_id", SqlDbType.Int,4)
			};
			parameters[0].Value = option_id;


			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string option_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Menu_Options ");
			strSql.Append(" where ID in ("+option_idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
				
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.Menu_Options GetModel(int option_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select option_id, menu_id, option_code, option_name, option_desc  ");			
			strSql.Append("  from Menu_Options ");
			strSql.Append(" where option_id=@option_id");
						SqlParameter[] parameters = {
					new SqlParameter("@option_id", SqlDbType.Int,4)
			};
			parameters[0].Value = option_id;

			
			AutekInfo.Model.Menu_Options model=new AutekInfo.Model.Menu_Options();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["option_id"].ToString()!="")
				{
					model.option_id=int.Parse(ds.Tables[0].Rows[0]["option_id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["menu_id"].ToString()!="")
				{
					model.menu_id=int.Parse(ds.Tables[0].Rows[0]["menu_id"].ToString());
				}
																																				model.option_code= ds.Tables[0].Rows[0]["option_code"].ToString();
																																model.option_name= ds.Tables[0].Rows[0]["option_name"].ToString();
																																model.option_desc= ds.Tables[0].Rows[0]["option_desc"].ToString();
																										
				return model;
			}
			else
			{
				return null;
			}
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM Menu_Options ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM Menu_Options ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}


        #region extend
        public bool Remove(int menu_id)
        {
           StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Menu_Options ");
            strSql.Append(" where menu_id =" + menu_id + " ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}        
        #endregion
    }
}

