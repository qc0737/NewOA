using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//Emp_Authority
		public partial class Emp_Authority
	{
   		     
		public bool Exists(int auth_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Emp_Authority");
			strSql.Append(" where ");
			                                       strSql.Append(" auth_id = @auth_id  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@auth_id", SqlDbType.Int,4)
			};
			parameters[0].Value = auth_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutekInfo.Model.Emp_Authority model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Emp_Authority(");			
            strSql.Append("auth_code,auth_name,auth_remark");
			strSql.Append(") values (");
            strSql.Append("@auth_code,@auth_name,@auth_remark");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@auth_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@auth_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@auth_remark", SqlDbType.NVarChar,50)             
              
            };
			            
            parameters[0].Value = model.auth_code;                        
            parameters[1].Value = model.auth_name;                        
            parameters[2].Value = model.auth_remark;                        
			   
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
		public bool Update(AutekInfo.Model.Emp_Authority model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Emp_Authority set ");
			                                                
            strSql.Append(" auth_code = @auth_code , ");                                    
            strSql.Append(" auth_name = @auth_name , ");                                    
            strSql.Append(" auth_remark = @auth_remark  ");            			
			strSql.Append(" where auth_id=@auth_id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@auth_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@auth_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@auth_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@auth_remark", SqlDbType.NVarChar,50)             
              
            };
						            
            parameters[0].Value = model.auth_id;                        
            parameters[1].Value = model.auth_code;                        
            parameters[2].Value = model.auth_name;                        
            parameters[3].Value = model.auth_remark;                        
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
		public bool Delete(int auth_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Emp_Authority ");
			strSql.Append(" where auth_id=@auth_id");
						SqlParameter[] parameters = {
					new SqlParameter("@auth_id", SqlDbType.Int,4)
			};
			parameters[0].Value = auth_id;


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
		public bool DeleteList(string auth_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Emp_Authority ");
			strSql.Append(" where ID in ("+auth_idlist + ")  ");
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
		public AutekInfo.Model.Emp_Authority GetModel(int auth_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select auth_id, auth_code, auth_name, auth_remark  ");			
			strSql.Append("  from Emp_Authority ");
			strSql.Append(" where auth_id=@auth_id");
						SqlParameter[] parameters = {
					new SqlParameter("@auth_id", SqlDbType.Int,4)
			};
			parameters[0].Value = auth_id;

			
			AutekInfo.Model.Emp_Authority model=new AutekInfo.Model.Emp_Authority();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["auth_id"].ToString()!="")
				{
					model.auth_id=int.Parse(ds.Tables[0].Rows[0]["auth_id"].ToString());
				}
																																				model.auth_code= ds.Tables[0].Rows[0]["auth_code"].ToString();
																																model.auth_name= ds.Tables[0].Rows[0]["auth_name"].ToString();
																																model.auth_remark= ds.Tables[0].Rows[0]["auth_remark"].ToString();
																										
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
			strSql.Append(" FROM Emp_Authority ");
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
			strSql.Append(" FROM Emp_Authority ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

