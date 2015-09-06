using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//Menu
		public partial class Menu
	{
   		     
		public bool Exists(int menu_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Menu");
			strSql.Append(" where ");
			                                       strSql.Append(" menu_id = @menu_id  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@menu_id", SqlDbType.Int,4)			};
			parameters[0].Value = menu_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(AutekInfo.Model.Menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Menu(");			
            strSql.Append("menu_id,menu_icon,menu_name,menu_pid,menu_link,menu_sort,menu_isshow");
			strSql.Append(") values (");
            strSql.Append("@menu_id,@menu_icon,@menu_name,@menu_pid,@menu_link,@menu_sort,@menu_isshow");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@menu_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_icon", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@menu_name", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@menu_pid", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_link", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@menu_sort", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_isshow", SqlDbType.Bit,1)             
              
            };
			            
            parameters[0].Value = model.menu_id;                        
            parameters[1].Value = model.menu_icon;                        
            parameters[2].Value = model.menu_name;                        
            parameters[3].Value = model.menu_pid;                        
            parameters[4].Value = model.menu_link;                        
            parameters[5].Value = model.menu_sort;                        
            parameters[6].Value = model.menu_isshow;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.Menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Menu set ");
			                        
            strSql.Append(" menu_id = @menu_id , ");                                    
            strSql.Append(" menu_icon = @menu_icon , ");                                    
            strSql.Append(" menu_name = @menu_name , ");                                    
            strSql.Append(" menu_pid = @menu_pid , ");                                    
            strSql.Append(" menu_link = @menu_link , ");                                    
            strSql.Append(" menu_sort = @menu_sort , ");                                    
            strSql.Append(" menu_isshow = @menu_isshow  ");            			
			strSql.Append(" where menu_id=@menu_id  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@menu_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_icon", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@menu_name", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@menu_pid", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_link", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@menu_sort", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_isshow", SqlDbType.Bit,1)             
              
            };
						            
            parameters[0].Value = model.menu_id;                        
            parameters[1].Value = model.menu_icon;                        
            parameters[2].Value = model.menu_name;                        
            parameters[3].Value = model.menu_pid;                        
            parameters[4].Value = model.menu_link;                        
            parameters[5].Value = model.menu_sort;                        
            parameters[6].Value = model.menu_isshow;                        
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
			strSql.Append("delete from Menu ");
			strSql.Append(" where menu_id=@menu_id ");
						SqlParameter[] parameters = {
					new SqlParameter("@menu_id", SqlDbType.Int,4)			};
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
		/// 得到一个对象实体
		/// </summary>
		public AutekInfo.Model.Menu GetModel(int menu_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select menu_id, menu_icon, menu_name, menu_pid, menu_link, menu_sort, menu_isshow  ");			
			strSql.Append("  from Menu ");
			strSql.Append(" where menu_id=@menu_id ");
						SqlParameter[] parameters = {
					new SqlParameter("@menu_id", SqlDbType.Int,4)			};
			parameters[0].Value = menu_id;

			
			AutekInfo.Model.Menu model=new AutekInfo.Model.Menu();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["menu_id"].ToString()!="")
				{
					model.menu_id=int.Parse(ds.Tables[0].Rows[0]["menu_id"].ToString());
				}
																																				model.menu_icon= ds.Tables[0].Rows[0]["menu_icon"].ToString();
																																model.menu_name= ds.Tables[0].Rows[0]["menu_name"].ToString();
																												if(ds.Tables[0].Rows[0]["menu_pid"].ToString()!="")
				{
					model.menu_pid=int.Parse(ds.Tables[0].Rows[0]["menu_pid"].ToString());
				}
																																				model.menu_link= ds.Tables[0].Rows[0]["menu_link"].ToString();
																												if(ds.Tables[0].Rows[0]["menu_sort"].ToString()!="")
				{
					model.menu_sort=int.Parse(ds.Tables[0].Rows[0]["menu_sort"].ToString());
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
			strSql.Append(" FROM Menu ");
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
			strSql.Append(" FROM Menu ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

