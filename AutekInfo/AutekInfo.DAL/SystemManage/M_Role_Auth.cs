using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//M_Role_Auth
		public partial class M_Role_Auth
	{
   		     
		public bool Exists(int m_role_auth_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from M_Role_Auth");
			strSql.Append(" where ");
			                                       strSql.Append(" m_role_auth_id = @m_role_auth_id  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@m_role_auth_id", SqlDbType.Int,4)
			};
			parameters[0].Value = m_role_auth_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutekInfo.Model.M_Role_Auth model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into M_Role_Auth(");			
            strSql.Append("role_id,auth_id");
			strSql.Append(") values (");
            strSql.Append("@role_id,@auth_id");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@role_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@auth_id", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.role_id;                        
            parameters[1].Value = model.auth_id;                        
			   
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
		public bool Update(AutekInfo.Model.M_Role_Auth model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update M_Role_Auth set ");
			                                                
            strSql.Append(" role_id = @role_id , ");                                    
            strSql.Append(" auth_id = @auth_id  ");            			
			strSql.Append(" where m_role_auth_id=@m_role_auth_id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@m_role_auth_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@role_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@auth_id", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.m_role_auth_id;                        
            parameters[1].Value = model.role_id;                        
            parameters[2].Value = model.auth_id;                        
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
		public bool Delete(int m_role_auth_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from M_Role_Auth ");
			strSql.Append(" where m_role_auth_id=@m_role_auth_id");
						SqlParameter[] parameters = {
					new SqlParameter("@m_role_auth_id", SqlDbType.Int,4)
			};
			parameters[0].Value = m_role_auth_id;


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
		public bool DeleteList(string m_role_auth_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from M_Role_Auth ");
			strSql.Append(" where ID in ("+m_role_auth_idlist + ")  ");
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
		public AutekInfo.Model.M_Role_Auth GetModel(int m_role_auth_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select m_role_auth_id, role_id, auth_id  ");			
			strSql.Append("  from M_Role_Auth ");
			strSql.Append(" where m_role_auth_id=@m_role_auth_id");
						SqlParameter[] parameters = {
					new SqlParameter("@m_role_auth_id", SqlDbType.Int,4)
			};
			parameters[0].Value = m_role_auth_id;

			
			AutekInfo.Model.M_Role_Auth model=new AutekInfo.Model.M_Role_Auth();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["m_role_auth_id"].ToString()!="")
				{
					model.m_role_auth_id=int.Parse(ds.Tables[0].Rows[0]["m_role_auth_id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(ds.Tables[0].Rows[0]["role_id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["auth_id"].ToString()!="")
				{
					model.auth_id=int.Parse(ds.Tables[0].Rows[0]["auth_id"].ToString());
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
			strSql.Append(" FROM M_Role_Auth ");
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
			strSql.Append(" FROM M_Role_Auth ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}



        public int DelAddModelList(List<Model.M_Role_Auth> list)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(String.Format("delete from M_Role_Auth where role_id={0};", list[0].role_id));
            foreach (Model.M_Role_Auth m in list)
            {
                strSql.Append(String.Format("insert into M_Role_Auth( role_id,auth_id) values ({0},'{1}') ", m.role_id, m.auth_id));
            }
            strSql.Append(";select @@IDENTITY");


            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {

                return Convert.ToInt32(obj);

            }
        }
		
    }
}

