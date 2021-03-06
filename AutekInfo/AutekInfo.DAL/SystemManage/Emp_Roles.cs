﻿using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//Emp_Roles
		public partial class Emp_Roles
	{
   		     
		public bool Exists(int role_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Emp_Roles");
			strSql.Append(" where ");
			                                       strSql.Append(" role_id = @role_id  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@role_id", SqlDbType.Int,4)
			};
			parameters[0].Value = role_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutekInfo.Model.Emp_Roles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Emp_Roles(");			
            strSql.Append("role_code,role_name,role_describe");
			strSql.Append(") values (");
            strSql.Append("@role_code,@role_name,@role_describe");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@role_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@role_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@role_describe", SqlDbType.NVarChar,500)             
              
            };
			            
            parameters[0].Value = model.role_code;                        
            parameters[1].Value = model.role_name;                        
            parameters[2].Value = model.role_describe;                        
			   
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
		public bool Update(AutekInfo.Model.Emp_Roles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Emp_Roles set ");
			                                                
            strSql.Append(" role_code = @role_code , ");                                    
            strSql.Append(" role_name = @role_name , ");                                    
            strSql.Append(" role_describe = @role_describe  ");            			
			strSql.Append(" where role_id=@role_id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@role_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@role_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@role_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@role_describe", SqlDbType.NVarChar,500)             
              
            };
						            
            parameters[0].Value = model.role_id;                        
            parameters[1].Value = model.role_code;                        
            parameters[2].Value = model.role_name;                        
            parameters[3].Value = model.role_describe;                        
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
			strSql.Append("delete from Emp_Roles ");
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
			strSql.Append("delete from Emp_Roles ");
			strSql.Append(" where role_id in ("+role_idlist + ")  ");
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
		public AutekInfo.Model.Emp_Roles GetModel(int role_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select role_id, role_code, role_name, role_describe  ");			
			strSql.Append("  from Emp_Roles ");
			strSql.Append(" where role_id=@role_id");
						SqlParameter[] parameters = {
					new SqlParameter("@role_id", SqlDbType.Int,4)
			};
			parameters[0].Value = role_id;

			
			AutekInfo.Model.Emp_Roles model=new AutekInfo.Model.Emp_Roles();
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
			strSql.Append(" FROM Emp_Roles ");
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
			strSql.Append(" FROM Emp_Roles ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

