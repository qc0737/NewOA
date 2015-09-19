using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//View_Role_Auths
		public partial class View_Role_Auths
	{
   		     
		
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutekInfo.Model.View_Role_Auths model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into View_Role_Auths(");			
            strSql.Append("role_code,role_name,role_describe,authids,authnames");
			strSql.Append(") values (");
            strSql.Append("@role_code,@role_name,@role_describe,@authids,@authnames");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@role_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@role_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@role_describe", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@authids", SqlDbType.VarChar,4000) ,            
                        new SqlParameter("@authnames", SqlDbType.VarChar,4000)             
              
            };
			            
            parameters[0].Value = model.role_code;                        
            parameters[1].Value = model.role_name;                        
            parameters[2].Value = model.role_describe;                        
            parameters[3].Value = model.authids;                        
            parameters[4].Value = model.authnames;                        
			   
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
		public bool Update(AutekInfo.Model.View_Role_Auths model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update View_Role_Auths set ");
			                                                
            strSql.Append(" role_code = @role_code , ");                                    
            strSql.Append(" role_name = @role_name , ");                                    
            strSql.Append(" role_describe = @role_describe , ");                                    
            strSql.Append(" authids = @authids , ");                                    
            strSql.Append(" authnames = @authnames  ");            			
			strSql.Append(" where role_id=@role_id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@role_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@role_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@role_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@role_describe", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@authids", SqlDbType.VarChar,4000) ,            
                        new SqlParameter("@authnames", SqlDbType.VarChar,4000)             
              
            };
						            
            parameters[0].Value = model.role_id;                        
            parameters[1].Value = model.role_code;                        
            parameters[2].Value = model.role_name;                        
            parameters[3].Value = model.role_describe;                        
            parameters[4].Value = model.authids;                        
            parameters[5].Value = model.authnames;                        
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
		public bool Delete(int role_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from View_Role_Auths ");
			strSql.Append(" where role_id=@role_id");
						SqlParameter[] parameters = {
					new SqlParameter("@role_id", SqlDbType.Int,4)
			};
			parameters[0].Value = role_id;


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
		public bool DeleteList(string role_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from View_Role_Auths ");
			strSql.Append(" where ID in ("+role_idlist + ")  ");
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
		public AutekInfo.Model.View_Role_Auths GetModel(int role_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select role_id, role_code, role_name, role_describe, authids, authnames  ");			
			strSql.Append("  from View_Role_Auths ");
			strSql.Append(" where role_id=@role_id");
						SqlParameter[] parameters = {
					new SqlParameter("@role_id", SqlDbType.Int,4)
			};
			parameters[0].Value = role_id;

			
			AutekInfo.Model.View_Role_Auths model=new AutekInfo.Model.View_Role_Auths();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(ds.Tables[0].Rows[0]["role_id"].ToString());
				}
																																				model.role_code= ds.Tables[0].Rows[0]["role_code"].ToString();
																																model.role_name= ds.Tables[0].Rows[0]["role_name"].ToString();
																																model.role_describe= ds.Tables[0].Rows[0]["role_describe"].ToString();
																																model.authids= ds.Tables[0].Rows[0]["authids"].ToString();
																																model.authnames= ds.Tables[0].Rows[0]["authnames"].ToString();
																										
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
			strSql.Append(" FROM View_Role_Auths ");
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
			strSql.Append(" FROM View_Role_Auths ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

