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
   		     
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from View_Menu_Option");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(AutekInfo.Model.View_Menu_Option model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into View_Menu_Option(");			
            strSql.Append("menu_name,option_code,option_name,option_desc,option_id,menu_id,menu_isshow,menu_pid,menu_sort");
			strSql.Append(") values (");
            strSql.Append("@menu_name,@option_code,@option_name,@option_desc,@option_id,@menu_id,@menu_isshow,@menu_pid,@menu_sort");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@menu_name", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@option_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@option_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@option_desc", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@option_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_isshow", SqlDbType.Bit,1) ,            
                        new SqlParameter("@menu_pid", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_sort", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.menu_name;                        
            parameters[1].Value = model.option_code;                        
            parameters[2].Value = model.option_name;                        
            parameters[3].Value = model.option_desc;                        
            parameters[4].Value = model.option_id;                        
            parameters[5].Value = model.menu_id;                        
            parameters[6].Value = model.menu_isshow;                        
            parameters[7].Value = model.menu_pid;                        
            parameters[8].Value = model.menu_sort;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.View_Menu_Option model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update View_Menu_Option set ");
			                        
            strSql.Append(" menu_name = @menu_name , ");                                    
            strSql.Append(" option_code = @option_code , ");                                    
            strSql.Append(" option_name = @option_name , ");                                    
            strSql.Append(" option_desc = @option_desc , ");                                    
            strSql.Append(" option_id = @option_id , ");                                    
            strSql.Append(" menu_id = @menu_id , ");                                    
            strSql.Append(" menu_isshow = @menu_isshow , ");                                    
            strSql.Append(" menu_pid = @menu_pid , ");                                    
            strSql.Append(" menu_sort = @menu_sort  ");            			
			strSql.Append(" where  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@menu_name", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@option_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@option_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@option_desc", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@option_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_isshow", SqlDbType.Bit,1) ,            
                        new SqlParameter("@menu_pid", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_sort", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.menu_name;                        
            parameters[1].Value = model.option_code;                        
            parameters[2].Value = model.option_name;                        
            parameters[3].Value = model.option_desc;                        
            parameters[4].Value = model.option_id;                        
            parameters[5].Value = model.menu_id;                        
            parameters[6].Value = model.menu_isshow;                        
            parameters[7].Value = model.menu_pid;                        
            parameters[8].Value = model.menu_sort;                        
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
		public bool Delete()
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from View_Menu_Option ");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};


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
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.View_Menu_Option GetModel()
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select menu_name, option_code, option_name, option_desc, option_id, menu_id, menu_isshow, menu_pid, menu_sort  ");			
			strSql.Append("  from View_Menu_Option ");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};

			
			AutekInfo.Model.View_Menu_Option model=new AutekInfo.Model.View_Menu_Option();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.menu_name= ds.Tables[0].Rows[0]["menu_name"].ToString();
																																model.option_code= ds.Tables[0].Rows[0]["option_code"].ToString();
																																model.option_name= ds.Tables[0].Rows[0]["option_name"].ToString();
																																model.option_desc= ds.Tables[0].Rows[0]["option_desc"].ToString();
																												if(ds.Tables[0].Rows[0]["option_id"].ToString()!="")
				{
					model.option_id=int.Parse(ds.Tables[0].Rows[0]["option_id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["menu_id"].ToString()!="")
				{
					model.menu_id=int.Parse(ds.Tables[0].Rows[0]["menu_id"].ToString());
				}
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

