using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//View_Emp_Role
		public partial class View_Emp_Role
	{
   		     
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from View_Emp_Role");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(AutekInfo.Model.View_Emp_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into View_Emp_Role(");			
            strSql.Append("role_code,role_name,role_describe,emp_id,emp_cnname");
			strSql.Append(") values (");
            strSql.Append("@role_code,@role_name,@role_describe,@emp_id,@emp_cnname");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@role_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@role_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@role_describe", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@emp_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@emp_cnname", SqlDbType.NVarChar,100)             
              
            };
			            
            parameters[0].Value = model.role_code;                        
            parameters[1].Value = model.role_name;                        
            parameters[2].Value = model.role_describe;                        
            parameters[3].Value = model.emp_id;                        
            parameters[4].Value = model.emp_cnname;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.View_Emp_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update View_Emp_Role set ");
			                        
            strSql.Append(" role_code = @role_code , ");                                    
            strSql.Append(" role_name = @role_name , ");                                    
            strSql.Append(" role_describe = @role_describe , ");                                    
            strSql.Append(" emp_id = @emp_id , ");                                    
            strSql.Append(" emp_cnname = @emp_cnname  ");            			
			strSql.Append(" where  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@role_code", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@role_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@role_describe", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@emp_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@emp_cnname", SqlDbType.NVarChar,100)             
              
            };
						            
            parameters[0].Value = model.role_code;                        
            parameters[1].Value = model.role_name;                        
            parameters[2].Value = model.role_describe;                        
            parameters[3].Value = model.emp_id;                        
            parameters[4].Value = model.emp_cnname;                        
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
			strSql.Append("delete from View_Emp_Role ");
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
		public AutekInfo.Model.View_Emp_Role GetModel()
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select role_code, role_name, role_describe, emp_id, emp_cnname  ");			
			strSql.Append("  from View_Emp_Role ");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};

			
			AutekInfo.Model.View_Emp_Role model=new AutekInfo.Model.View_Emp_Role();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.role_code= ds.Tables[0].Rows[0]["role_code"].ToString();
																																model.role_name= ds.Tables[0].Rows[0]["role_name"].ToString();
																																model.role_describe= ds.Tables[0].Rows[0]["role_describe"].ToString();
																												if(ds.Tables[0].Rows[0]["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(ds.Tables[0].Rows[0]["emp_id"].ToString());
				}
																																				model.emp_cnname= ds.Tables[0].Rows[0]["emp_cnname"].ToString();
																										
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
			strSql.Append(" FROM View_Emp_Role ");
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
			strSql.Append(" FROM View_Emp_Role ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

