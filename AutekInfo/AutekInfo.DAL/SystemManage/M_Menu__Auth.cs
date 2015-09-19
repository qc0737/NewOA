using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL
{
    //M_Menu_Auth
    public partial class M_Menu_Auth
    {

        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from M_Menu_Auth");
            strSql.Append(" where ");
            strSql.Append(" id = @id  ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(AutekInfo.Model.M_Menu_Auth model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into M_Menu_Auth(");
            strSql.Append("auth_id,menu_options");
            strSql.Append(") values (");
            strSql.Append("@auth_id,@menu_options");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@auth_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_options", SqlDbType.VarChar,500)             
              
            };

            parameters[0].Value = model.auth_id;
            parameters[1].Value = model.menu_options;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(AutekInfo.Model.M_Menu_Auth model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update M_Menu_Auth set ");

            strSql.Append(" auth_id = @auth_id , ");
            strSql.Append(" menu_options = @menu_options  ");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@auth_id", SqlDbType.Int,4) ,            
                        new SqlParameter("@menu_options", SqlDbType.VarChar,500)             
              
            };

            parameters[0].Value = model.id;
            parameters[1].Value = model.auth_id;
            parameters[2].Value = model.menu_options;
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


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from M_Menu_Auth ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;


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

        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from M_Menu_Auth ");
            strSql.Append(" where ID in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public AutekInfo.Model.M_Menu_Auth GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id, auth_id, menu_options  ");
            strSql.Append("  from M_Menu_Auth ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;


            AutekInfo.Model.M_Menu_Auth model = new AutekInfo.Model.M_Menu_Auth();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["auth_id"].ToString() != "")
                {
                    model.auth_id = int.Parse(ds.Tables[0].Rows[0]["auth_id"].ToString());
                }
                model.menu_options = ds.Tables[0].Rows[0]["menu_options"].ToString();

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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM M_Menu_Auth ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM M_Menu_Auth ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #region extend
        public int AddModelList(List<Model.M_Menu_Auth> list)
        {
            StringBuilder strSql = new StringBuilder();
            foreach (Model.M_Menu_Auth m in list)
            {
                strSql.Append(String.Format("insert into M_Menu_Auth( auth_id,menu_options) values ({0},'{1}') ", m.auth_id, m.menu_options));
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
        #endregion
    }
}

