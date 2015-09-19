using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//Emp_Account
		public partial class Emp_Account
	{
   		     
		public bool Exists(string loginid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Emp_Account");
			strSql.Append(" where ");
			                                       strSql.Append(" loginid = @loginid  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@loginid", SqlDbType.NVarChar,50)			};
			parameters[0].Value = loginid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(AutekInfo.Model.Emp_Account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Emp_Account(");			
            strSql.Append("loginid,pwd,status,lastloginip,lastlogindate,sysstatus,updater,updatedata");
			strSql.Append(") values (");
            strSql.Append("@loginid,@pwd,@status,@lastloginip,@lastlogindate,@sysstatus,@updater,@updatedata");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@loginid", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@pwd", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@status", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@lastloginip", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@lastlogindate", SqlDbType.DateTime) ,            
                        new SqlParameter("@sysstatus", SqlDbType.Int,4) ,            
                        new SqlParameter("@updater", SqlDbType.Int,4) ,            
                        new SqlParameter("@updatedata", SqlDbType.DateTime)             
              
            };
			            
            parameters[0].Value = model.loginid;                        
            parameters[1].Value = model.pwd;                        
            parameters[2].Value = model.status;                        
            parameters[3].Value = model.lastloginip;                        
            parameters[4].Value = model.lastlogindate;                        
            parameters[5].Value = model.sysstatus;                        
            parameters[6].Value = model.updater;                        
            parameters[7].Value = model.updatedata;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AutekInfo.Model.Emp_Account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Emp_Account set ");
			                        
            strSql.Append(" loginid = @loginid , ");                                    
            strSql.Append(" pwd = @pwd , ");                                    
            strSql.Append(" status = @status , ");                                    
            strSql.Append(" lastloginip = @lastloginip , ");                                    
            strSql.Append(" lastlogindate = @lastlogindate , ");                                    
            strSql.Append(" sysstatus = @sysstatus , ");                                    
            strSql.Append(" updater = @updater , ");                                    
            strSql.Append(" updatedata = @updatedata  ");            			
			strSql.Append(" where loginid=@loginid  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@loginid", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@pwd", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@status", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@lastloginip", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@lastlogindate", SqlDbType.DateTime) ,            
                        new SqlParameter("@sysstatus", SqlDbType.Int,4) ,            
                        new SqlParameter("@updater", SqlDbType.Int,4) ,            
                        new SqlParameter("@updatedata", SqlDbType.DateTime)             
              
            };
						            
            parameters[0].Value = model.loginid;                        
            parameters[1].Value = model.pwd;                        
            parameters[2].Value = model.status;                        
            parameters[3].Value = model.lastloginip;                        
            parameters[4].Value = model.lastlogindate;                        
            parameters[5].Value = model.sysstatus;                        
            parameters[6].Value = model.updater;                        
            parameters[7].Value = model.updatedata;                        
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
		public bool Delete(string loginid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Emp_Account ");
			strSql.Append(" where loginid=@loginid ");
						SqlParameter[] parameters = {
					new SqlParameter("@loginid", SqlDbType.NVarChar,50)			};
			parameters[0].Value = loginid;


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
		public AutekInfo.Model.Emp_Account GetModel(string loginid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select loginid, pwd, status, lastloginip, lastlogindate, sysstatus, updater, updatedata  ");			
			strSql.Append("  from Emp_Account ");
			strSql.Append(" where loginid=@loginid ");
						SqlParameter[] parameters = {
					new SqlParameter("@loginid", SqlDbType.NVarChar,50)			};
			parameters[0].Value = loginid;

			
			AutekInfo.Model.Emp_Account model=new AutekInfo.Model.Emp_Account();
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
			strSql.Append(" FROM Emp_Account ");
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
			strSql.Append(" FROM Emp_Account ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

