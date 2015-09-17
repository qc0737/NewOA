using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//View_Menu_Option
		public partial class View_Menu_Option
	{
   		     
		
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutekInfo.Model.View_Menu_Option model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into View_Menu_Option(");			
            strSql.Append("menu_name,menu_isshow,menu_option_name,menu_option_code,menu_pid,menu_sort");
			strSql.Append(") values (");
            strSql.Append("@menu_name,@menu_isshow,@menu_option_name,@menu_option_code,@menu_pid,@menu_sort");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@menu_name", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@menu_isshow", SqlDbType.Bit,1) ,            
                        new SqlParameter("@menu_option_name", SqlDbType.VarChar,4000) ,            
                        new SqlParameter("@menu_option_code", SqlDbType.VarChar,4000) ,            
                        new SqlParameter("@menu_pid", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_sort", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.menu_name;                        
            parameters[1].Value = model.menu_isshow;                        
            parameters[2].Value = model.menu_option_name;                        
            parameters[3].Value = model.menu_option_code;                        
            parameters[4].Value = model.menu_pid;                        
            parameters[5].Value = model.menu_sort;                        
			   
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
		public bool Update(AutekInfo.Model.View_Menu_Option model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update View_Menu_Option set ");
			                                                
            strSql.Append(" menu_name = @menu_name , ");                                    
            strSql.Append(" menu_isshow = @menu_isshow , ");                                    
            strSql.Append(" menu_option_name = @menu_option_name , ");                                    
            strSql.Append(" menu_option_code = @menu_option_code , ");                                    
            strSql.Append(" menu_pid = @menu_pid , ");                                    
            strSql.Append(" menu_sort = @menu_sort  ");            			
			strSql.Append(" where menu_id=@menu_id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@menu_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_name", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@menu_isshow", SqlDbType.Bit,1) ,            
                        new SqlParameter("@menu_option_name", SqlDbType.VarChar,4000) ,            
                        new SqlParameter("@menu_option_code", SqlDbType.VarChar,4000) ,            
                        new SqlParameter("@menu_pid", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_sort", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.menu_id;                        
            parameters[1].Value = model.menu_name;                        
            parameters[2].Value = model.menu_isshow;                        
            parameters[3].Value = model.menu_option_name;                        
            parameters[4].Value = model.menu_option_code;                        
            parameters[5].Value = model.menu_pid;                        
            parameters[6].Value = model.menu_sort;                        
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
		public bool Delete(int menu_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from View_Menu_Option ");
			strSql.Append(" where menu_id=@menu_id");
						SqlParameter[] parameters = {
					new SqlParameter("@menu_id", SqlDbType.Int,4)
			};
			parameters[0].Value = menu_id;


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
		public bool DeleteList(string menu_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from View_Menu_Option ");
			strSql.Append(" where ID in ("+menu_idlist + ")  ");
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
		public AutekInfo.Model.View_Menu_Option GetModel(int menu_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select menu_id, menu_name, menu_isshow, menu_option_name, menu_option_code, menu_pid, menu_sort  ");			
			strSql.Append("  from View_Menu_Option ");
			strSql.Append(" where menu_id=@menu_id");
						SqlParameter[] parameters = {
					new SqlParameter("@menu_id", SqlDbType.Int,4)
			};
			parameters[0].Value = menu_id;

			
			AutekInfo.Model.View_Menu_Option model=new AutekInfo.Model.View_Menu_Option();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["menu_id"].ToString()!="")
				{
					model.menu_id=int.Parse(ds.Tables[0].Rows[0]["menu_id"].ToString());
				}
																																				model.menu_name= ds.Tables[0].Rows[0]["menu_name"].ToString();
																																												if(ds.Tables[0].Rows[0]["menu_isshow"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["menu_isshow"].ToString()=="1")||(ds.Tables[0].Rows[0]["menu_isshow"].ToString().ToLower()=="true"))
					{
					model.menu_isshow= true;
					}
					else
					{
					model.menu_isshow= false;
					}
				}
																				model.menu_option_name= ds.Tables[0].Rows[0]["menu_option_name"].ToString();
																																model.menu_option_code= ds.Tables[0].Rows[0]["menu_option_code"].ToString();
																												if(ds.Tables[0].Rows[0]["menu_pid"].ToString()!="")
				{
					model.menu_pid=int.Parse(ds.Tables[0].Rows[0]["menu_pid"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["menu_sort"].ToString()!="")
				{
					model.menu_sort=int.Parse(ds.Tables[0].Rows[0]["menu_sort"].ToString());
				}
																														
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
			strSql.Append(" FROM View_Menu_Option ");
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
			strSql.Append(" FROM View_Menu_Option ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

