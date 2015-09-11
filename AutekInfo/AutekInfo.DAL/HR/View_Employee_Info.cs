using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL  
{
	 	//View_Employee_Info
		public partial class View_Employee_Info
	{
   		     
		public bool Exists(int emp_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from View_Employee_Info");
			strSql.Append(" where ");
			                            			SqlParameter[] parameters = {
					new SqlParameter("@emp_id", SqlDbType.Int,4)
			};
			parameters[0].Value = emp_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutekInfo.Model.View_Employee_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into View_Employee_Info(");			
            strSql.Append("emp_dept,emp_insti,emp_comp,emp_worknum,emp_cnname,emp_entrydate,emp_email,emp_age,emp_identity,emp_workarea,emp_phone,emp_title,emp_sex");
			strSql.Append(") values (");
            strSql.Append("@emp_dept,@emp_insti,@emp_comp,@emp_worknum,@emp_cnname,@emp_entrydate,@emp_email,@emp_age,@emp_identity,@emp_workarea,@emp_phone,@emp_title,@emp_sex");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@emp_dept", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_insti", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_comp", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_worknum", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_cnname", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_entrydate", SqlDbType.DateTime) ,            
                        new SqlParameter("@emp_email", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_age", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_identity", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_workarea", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_phone", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_title", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_sex", SqlDbType.NVarChar,100)             
              
            };
			            
            parameters[0].Value = model.emp_dept;                        
            parameters[1].Value = model.emp_insti;                        
            parameters[2].Value = model.emp_comp;                        
            parameters[3].Value = model.emp_worknum;                        
            parameters[4].Value = model.emp_cnname;                        
            parameters[5].Value = model.emp_entrydate;                        
            parameters[6].Value = model.emp_email;                        
            parameters[7].Value = model.emp_age;                        
            parameters[8].Value = model.emp_identity;                        
            parameters[9].Value = model.emp_workarea;                        
            parameters[10].Value = model.emp_phone;                        
            parameters[11].Value = model.emp_title;                        
            parameters[12].Value = model.emp_sex;                        
			   
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
		public bool Update(AutekInfo.Model.View_Employee_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update View_Employee_Info set ");
			                                                
            strSql.Append(" emp_dept = @emp_dept , ");                                    
            strSql.Append(" emp_insti = @emp_insti , ");                                    
            strSql.Append(" emp_comp = @emp_comp , ");                                    
            strSql.Append(" emp_worknum = @emp_worknum , ");                                    
            strSql.Append(" emp_cnname = @emp_cnname , ");                                    
            strSql.Append(" emp_entrydate = @emp_entrydate , ");                                    
            strSql.Append(" emp_email = @emp_email , ");                                    
            strSql.Append(" emp_age = @emp_age , ");                                    
            strSql.Append(" emp_identity = @emp_identity , ");                                    
            strSql.Append(" emp_workarea = @emp_workarea , ");                                    
            strSql.Append(" emp_phone = @emp_phone , ");                                    
            strSql.Append(" emp_title = @emp_title , ");                                    
            strSql.Append(" emp_sex = @emp_sex  ");            			
			strSql.Append(" where emp_id=@emp_id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@emp_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@emp_dept", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_insti", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_comp", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_worknum", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_cnname", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_entrydate", SqlDbType.DateTime) ,            
                        new SqlParameter("@emp_email", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_age", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_identity", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_workarea", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_phone", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_title", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@emp_sex", SqlDbType.NVarChar,100)             
              
            };
						            
            parameters[0].Value = model.emp_id;                        
            parameters[1].Value = model.emp_dept;                        
            parameters[2].Value = model.emp_insti;                        
            parameters[3].Value = model.emp_comp;                        
            parameters[4].Value = model.emp_worknum;                        
            parameters[5].Value = model.emp_cnname;                        
            parameters[6].Value = model.emp_entrydate;                        
            parameters[7].Value = model.emp_email;                        
            parameters[8].Value = model.emp_age;                        
            parameters[9].Value = model.emp_identity;                        
            parameters[10].Value = model.emp_workarea;                        
            parameters[11].Value = model.emp_phone;                        
            parameters[12].Value = model.emp_title;                        
            parameters[13].Value = model.emp_sex;                        
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
		public bool Delete(int emp_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from View_Employee_Info ");
			strSql.Append(" where emp_id=@emp_id");
						SqlParameter[] parameters = {
					new SqlParameter("@emp_id", SqlDbType.Int,4)
			};
			parameters[0].Value = emp_id;


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
		public bool DeleteList(string emp_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from View_Employee_Info ");
			strSql.Append(" where ID in ("+emp_idlist + ")  ");
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
		public AutekInfo.Model.View_Employee_Info GetModel(int emp_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select emp_id, emp_dept, emp_insti, emp_comp, emp_worknum, emp_cnname, emp_entrydate, emp_email, emp_age, emp_identity, emp_workarea, emp_phone, emp_title, emp_sex  ");			
			strSql.Append("  from View_Employee_Info ");
			strSql.Append(" where emp_id=@emp_id");
						SqlParameter[] parameters = {
					new SqlParameter("@emp_id", SqlDbType.Int,4)
			};
			parameters[0].Value = emp_id;

			
			AutekInfo.Model.View_Employee_Info model=new AutekInfo.Model.View_Employee_Info();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(ds.Tables[0].Rows[0]["emp_id"].ToString());
				}
																																				model.emp_dept= ds.Tables[0].Rows[0]["emp_dept"].ToString();
																																model.emp_insti= ds.Tables[0].Rows[0]["emp_insti"].ToString();
																																model.emp_comp= ds.Tables[0].Rows[0]["emp_comp"].ToString();
																																model.emp_worknum= ds.Tables[0].Rows[0]["emp_worknum"].ToString();
																																model.emp_cnname= ds.Tables[0].Rows[0]["emp_cnname"].ToString();
																												if(ds.Tables[0].Rows[0]["emp_entrydate"].ToString()!="")
				{
					model.emp_entrydate=DateTime.Parse(ds.Tables[0].Rows[0]["emp_entrydate"].ToString());
				}
																																				model.emp_email= ds.Tables[0].Rows[0]["emp_email"].ToString();
																																model.emp_age= ds.Tables[0].Rows[0]["emp_age"].ToString();
																																model.emp_identity= ds.Tables[0].Rows[0]["emp_identity"].ToString();
																																model.emp_workarea= ds.Tables[0].Rows[0]["emp_workarea"].ToString();
																																model.emp_phone= ds.Tables[0].Rows[0]["emp_phone"].ToString();
																																model.emp_title= ds.Tables[0].Rows[0]["emp_title"].ToString();
																																model.emp_sex= ds.Tables[0].Rows[0]["emp_sex"].ToString();
																										
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
			strSql.Append(" FROM View_Employee_Info ");
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
			strSql.Append(" FROM View_Employee_Info ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}


        #region extend
        public DataSet GetModelListByPages(string fields,string id,string sort,int pagesize, int page,  string strWhere,bool sorttype,out int tcount)
        {
            return DbHelperSQL.GetRecordByPage("View_Employee_Info",id, fields, sort, pagesize, page, strWhere, sorttype, out tcount);
        }
        #endregion
    }
}

