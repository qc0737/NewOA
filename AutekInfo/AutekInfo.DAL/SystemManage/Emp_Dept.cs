using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//Emp_Dept
		public partial class Emp_Dept
	{
   		     
		public bool Exists(int dept_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Emp_Dept");
			strSql.Append(" where ");
			                            			SqlParameter[] parameters = {
					new SqlParameter("@dept_id", SqlDbType.Int,4)
			};
			parameters[0].Value = dept_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutekInfo.Model.Emp_Dept model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Emp_Dept(");			
            strSql.Append("dept_name,dept_code,dept_pid,dept_order");
			strSql.Append(") values (");
            strSql.Append("@dept_name,@dept_code,@dept_pid,@dept_order");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@dept_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@dept_code", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@dept_pid", SqlDbType.Int,4) ,            
                        new SqlParameter("@dept_order", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.dept_name;                        
            parameters[1].Value = model.dept_code;                        
            parameters[2].Value = model.dept_pid;                        
            parameters[3].Value = model.dept_order;                        
			   
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
		public bool Update(AutekInfo.Model.Emp_Dept model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Emp_Dept set ");
			                                                
            strSql.Append(" dept_name = @dept_name , ");                                    
            strSql.Append(" dept_code = @dept_code , ");                                    
            strSql.Append(" dept_pid = @dept_pid , ");                                    
            strSql.Append(" dept_order = @dept_order  ");            			
			strSql.Append(" where dept_id=@dept_id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@dept_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@dept_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@dept_code", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@dept_pid", SqlDbType.Int,4) ,            
                        new SqlParameter("@dept_order", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.dept_id;                        
            parameters[1].Value = model.dept_name;                        
            parameters[2].Value = model.dept_code;                        
            parameters[3].Value = model.dept_pid;                        
            parameters[4].Value = model.dept_order;                        
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
		public bool Delete(int dept_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Emp_Dept ");
			strSql.Append(" where dept_id=@dept_id");
						SqlParameter[] parameters = {
					new SqlParameter("@dept_id", SqlDbType.Int,4)
			};
			parameters[0].Value = dept_id;


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
		public bool DeleteList(string dept_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Emp_Dept ");
			strSql.Append(" where ID in ("+dept_idlist + ")  ");
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
		public AutekInfo.Model.Emp_Dept GetModel(int dept_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select dept_id, dept_name, dept_code, dept_pid, dept_order  ");			
			strSql.Append("  from Emp_Dept ");
			strSql.Append(" where dept_id=@dept_id");
						SqlParameter[] parameters = {
					new SqlParameter("@dept_id", SqlDbType.Int,4)
			};
			parameters[0].Value = dept_id;

			
			AutekInfo.Model.Emp_Dept model=new AutekInfo.Model.Emp_Dept();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["dept_id"].ToString()!="")
				{
					model.dept_id=int.Parse(ds.Tables[0].Rows[0]["dept_id"].ToString());
				}
																																				model.dept_name= ds.Tables[0].Rows[0]["dept_name"].ToString();
																																model.dept_code= ds.Tables[0].Rows[0]["dept_code"].ToString();
																												if(ds.Tables[0].Rows[0]["dept_pid"].ToString()!="")
				{
					model.dept_pid=int.Parse(ds.Tables[0].Rows[0]["dept_pid"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["dept_order"].ToString()!="")
				{
					model.dept_order=int.Parse(ds.Tables[0].Rows[0]["dept_order"].ToString());
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
			strSql.Append(" FROM Emp_Dept ");
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
			strSql.Append(" FROM Emp_Dept ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}


        #region extend
        public bool Update(Model.Emp_Dept m_dept, Model.Emp_Dept m_dept_target)
        {
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(" update Emp_Dept set ");

                strSql.Append(" dept_name = @dept_name , ");
                strSql.Append(" dept_code = @dept_code , ");
                strSql.Append(" dept_pid = @dept_pid , ");
                strSql.Append(" dept_order = @dept_order  ");
                strSql.Append(" where dept_id=@dept_id ");

                strSql.Append("; update Emp_Dept set ");

                strSql.Append(" dept_name = @dept_name2 , ");
                strSql.Append(" dept_code = @dept_code2 , ");
                strSql.Append(" dept_pid = @dept_pid2 , ");
                strSql.Append(" dept_order = @dept_order2  ");
                strSql.Append(" where dept_id=@dept_id2 ");

                SqlParameter[] parameters = {
			            new SqlParameter("@dept_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@dept_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@dept_code", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@dept_pid", SqlDbType.Int,4) ,            
                        new SqlParameter("@dept_order", SqlDbType.Int,4)  ,
           
                        new SqlParameter("@dept_id2", SqlDbType.Int,4) ,            
                        new SqlParameter("@dept_name2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@dept_code2", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@dept_pid2", SqlDbType.Int,4) ,            
                        new SqlParameter("@dept_order2", SqlDbType.Int,4)  
              
            };

                parameters[0].Value = m_dept.dept_id;
                parameters[1].Value = m_dept.dept_name;
                parameters[2].Value = m_dept.dept_code;
                parameters[3].Value = m_dept.dept_pid;
                parameters[4].Value = m_dept.dept_order;

                parameters[5].Value = m_dept_target.dept_id;
                parameters[6].Value = m_dept_target.dept_name;
                parameters[7].Value = m_dept_target.dept_code;
                parameters[8].Value = m_dept_target.dept_pid;
                parameters[9].Value = m_dept_target.dept_order;
                int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Model.Emp_Dept GetModel(string dept_name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 dept_id, dept_name, dept_code, dept_pid, dept_order  ");
            strSql.Append("  from Emp_Dept ");
            strSql.Append(" where dept_name like @dept_name ");
            SqlParameter[] parameters = {
					new SqlParameter("@dept_name", SqlDbType.VarChar,50)
			};
            parameters[0].Value = "%"+dept_name+"%";


            AutekInfo.Model.Emp_Dept model = new AutekInfo.Model.Emp_Dept();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["dept_id"].ToString() != "")
                {
                    model.dept_id = int.Parse(ds.Tables[0].Rows[0]["dept_id"].ToString());
                }
                model.dept_name = ds.Tables[0].Rows[0]["dept_name"].ToString();
                model.dept_code = ds.Tables[0].Rows[0]["dept_code"].ToString();
                if (ds.Tables[0].Rows[0]["dept_pid"].ToString() != "")
                {
                    model.dept_pid = int.Parse(ds.Tables[0].Rows[0]["dept_pid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dept_order"].ToString() != "")
                {
                    model.dept_order = int.Parse(ds.Tables[0].Rows[0]["dept_order"].ToString());
                }

                return model;
            }
            else
            {
                return null;
            }
        }
        #endregion

        
    }
}

