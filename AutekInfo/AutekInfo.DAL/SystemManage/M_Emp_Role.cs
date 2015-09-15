using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//M_Emp_Role
		public partial class M_Emp_Role
	{
   		     
        //public bool Exists()
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select count(1) from M_Emp_Role");
        //    strSql.Append(" where ");
        //                                            SqlParameter[] parameters = {
        //            new SqlParameter("@m_emp_role_id", SqlDbType.Int,4)
        //    };
        //    parameters[0].Value = m_emp_role_id;

        //    return DbHelperSQL.Exists(strSql.ToString(),parameters);
        //}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutekInfo.Model.M_Emp_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into M_Emp_Role(");			
            strSql.Append("emp_id,role_id");
			strSql.Append(") values (");
            strSql.Append("@emp_id,@role_id");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@emp_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@role_id", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.emp_id;                        
            parameters[1].Value = model.role_id;                        
			   
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
		public bool Update(AutekInfo.Model.M_Emp_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update M_Emp_Role set ");
			                                                
            strSql.Append(" emp_id = @emp_id , ");                                    
            strSql.Append(" role_id = @role_id  ");            			
			strSql.Append(" where m_emp_role_id=@m_emp_role_id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@m_emp_role_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@emp_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@role_id", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.m_emp_role_id;                        
            parameters[1].Value = model.emp_id;                        
            parameters[2].Value = model.role_id;                        
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
		public bool Delete(int m_emp_role_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from M_Emp_Role ");
			strSql.Append(" where m_emp_role_id=@m_emp_role_id");
						SqlParameter[] parameters = {
					new SqlParameter("@m_emp_role_id", SqlDbType.Int,4)
			};
			parameters[0].Value = m_emp_role_id;


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
		public bool DeleteList(string m_emp_role_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from M_Emp_Role ");
            strSql.Append(" where m_emp_role_id in (" + m_emp_role_idlist + ")  ");
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
		public AutekInfo.Model.M_Emp_Role GetModel(int m_emp_role_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select m_emp_role_id, emp_id, role_id  ");			
			strSql.Append("  from M_Emp_Role ");
			strSql.Append(" where m_emp_role_id=@m_emp_role_id");
						SqlParameter[] parameters = {
					new SqlParameter("@m_emp_role_id", SqlDbType.Int,4)
			};
			parameters[0].Value = m_emp_role_id;

			
			AutekInfo.Model.M_Emp_Role model=new AutekInfo.Model.M_Emp_Role();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["m_emp_role_id"].ToString()!="")
				{
					model.m_emp_role_id=int.Parse(ds.Tables[0].Rows[0]["m_emp_role_id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(ds.Tables[0].Rows[0]["emp_id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(ds.Tables[0].Rows[0]["role_id"].ToString());
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
			strSql.Append(" FROM M_Emp_Role ");
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
			strSql.Append(" FROM M_Emp_Role ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

