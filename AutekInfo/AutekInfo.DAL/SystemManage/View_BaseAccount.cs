using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//View_BaseAccount
		public partial class View_BaseAccount
	{
   		     
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from View_BaseAccount");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(AutekInfo.Model.View_BaseAccount model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into View_BaseAccount(");			
            strSql.Append("loginid,pwd,status,lastloginip,lastlogindate,sysstatus,updater,updatedata,emp_dept,emp_id,emp_cnname,role_name,role_code");
			strSql.Append(") values (");
            strSql.Append("@loginid,@pwd,@status,@lastloginip,@lastlogindate,@sysstatus,@updater,@updatedata,@emp_dept,@emp_id,@emp_cnname,@role_name,@role_code");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@loginid", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@pwd", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@status", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@lastloginip", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@lastlogindate", SqlDbType.DateTime) ,            
                        new SqlParameter("@sysstatus", SqlDbType.Int,4) ,            
                        new SqlParameter("@updater", SqlDbType.Int,4) ,            
                        new SqlParameter("@updatedata", SqlDbType.DateTime) ,            
                        new SqlParameter("@emp_dept", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@emp_cnname", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@role_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@role_code", SqlDbType.VarChar,50)             
              
            };
			            
            parameters[0].Value = model.loginid;                        
            parameters[1].Value = model.pwd;                        
            parameters[2].Value = model.status;                        
            parameters[3].Value = model.lastloginip;                        
            parameters[4].Value = model.lastlogindate;                        
            parameters[5].Value = model.sysstatus;                        
            parameters[6].Value = model.updater;                        
            parameters[7].Value = model.updatedata;                        
            parameters[8].Value = model.emp_dept;                        
            parameters[9].Value = model.emp_id;                        
            parameters[10].Value = model.emp_cnname;                        
            parameters[11].Value = model.role_name;                        
            parameters[12].Value = model.role_code;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.View_BaseAccount model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update View_BaseAccount set ");
			                        
            strSql.Append(" loginid = @loginid , ");                                    
            strSql.Append(" pwd = @pwd , ");                                    
            strSql.Append(" status = @status , ");                                    
            strSql.Append(" lastloginip = @lastloginip , ");                                    
            strSql.Append(" lastlogindate = @lastlogindate , ");                                    
            strSql.Append(" sysstatus = @sysstatus , ");                                    
            strSql.Append(" updater = @updater , ");                                    
            strSql.Append(" updatedata = @updatedata , ");                                    
            strSql.Append(" emp_dept = @emp_dept , ");                                    
            strSql.Append(" emp_id = @emp_id , ");                                    
            strSql.Append(" emp_cnname = @emp_cnname , ");                                    
            strSql.Append(" role_name = @role_name , ");                                    
            strSql.Append(" role_code = @role_code  ");            			
			strSql.Append(" where  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@loginid", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@pwd", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@status", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@lastloginip", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@lastlogindate", SqlDbType.DateTime) ,            
                        new SqlParameter("@sysstatus", SqlDbType.Int,4) ,            
                        new SqlParameter("@updater", SqlDbType.Int,4) ,            
                        new SqlParameter("@updatedata", SqlDbType.DateTime) ,            
                        new SqlParameter("@emp_dept", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@emp_cnname", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@role_name", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@role_code", SqlDbType.VarChar,50)             
              
            };
						            
            parameters[0].Value = model.loginid;                        
            parameters[1].Value = model.pwd;                        
            parameters[2].Value = model.status;                        
            parameters[3].Value = model.lastloginip;                        
            parameters[4].Value = model.lastlogindate;                        
            parameters[5].Value = model.sysstatus;                        
            parameters[6].Value = model.updater;                        
            parameters[7].Value = model.updatedata;                        
            parameters[8].Value = model.emp_dept;                        
            parameters[9].Value = model.emp_id;                        
            parameters[10].Value = model.emp_cnname;                        
            parameters[11].Value = model.role_name;                        
            parameters[12].Value = model.role_code;                        
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
			strSql.Append("delete from View_BaseAccount ");
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
		public AutekInfo.Model.View_BaseAccount GetModel()
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select loginid, pwd, status, lastloginip, lastlogindate, sysstatus, updater, updatedata, emp_dept, emp_id, emp_cnname, role_name, role_code  ");			
			strSql.Append("  from View_BaseAccount ");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};

			
			AutekInfo.Model.View_BaseAccount model=new AutekInfo.Model.View_BaseAccount();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.loginid= ds.Tables[0].Rows[0]["loginid"].ToString();
																																model.pwd= ds.Tables[0].Rows[0]["pwd"].ToString();
																																model.status= ds.Tables[0].Rows[0]["status"].ToString();
																																model.lastloginip= ds.Tables[0].Rows[0]["lastloginip"].ToString();
																												if(ds.Tables[0].Rows[0]["lastlogindate"].ToString()!="")
				{
					model.lastlogindate=DateTime.Parse(ds.Tables[0].Rows[0]["lastlogindate"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["sysstatus"].ToString()!="")
				{
					model.sysstatus=int.Parse(ds.Tables[0].Rows[0]["sysstatus"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["updater"].ToString()!="")
				{
					model.updater=int.Parse(ds.Tables[0].Rows[0]["updater"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["updatedata"].ToString()!="")
				{
					model.updatedata=DateTime.Parse(ds.Tables[0].Rows[0]["updatedata"].ToString());
				}
																																				model.emp_dept= ds.Tables[0].Rows[0]["emp_dept"].ToString();
																												if(ds.Tables[0].Rows[0]["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(ds.Tables[0].Rows[0]["emp_id"].ToString());
				}
																																				model.emp_cnname= ds.Tables[0].Rows[0]["emp_cnname"].ToString();
																																model.role_name= ds.Tables[0].Rows[0]["role_name"].ToString();
																																model.role_code= ds.Tables[0].Rows[0]["role_code"].ToString();
																										
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
			strSql.Append(" FROM View_BaseAccount ");
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
			strSql.Append(" FROM View_BaseAccount ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

