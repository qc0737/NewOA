using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using AutekInfo.DBUtility;
namespace AutekInfo.DAL
{
    //Employee_Info
    public partial class Employee_Info
    {

        public bool Exists(int emp_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Employee_Info");
            strSql.Append(" where ");
            strSql.Append(" emp_id = @emp_id  ");
            SqlParameter[] parameters = {
new SqlParameter("@emp_id", SqlDbType.Int,4)
};
            parameters[0].Value = emp_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(AutekInfo.Model.Employee_Info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Employee_Info(");
            strSql.Append("loginid,emp_dept,emp_insti,emp_comp,emp_worknum,emp_cnname,emp_cardnum,emp_birthdate,emp_entrydate,emp_entrytitle,emp_practicedate,emp_lastdate,emp_sex,emp_title,emp_type,emp_workarea,emp_luyongfangshi,emp_luyongqudao,emp_cometruedate,emp_yjcometruedate,emp_beginworkdate,emp_workcertificate,emp_zhicheng,emp_identity,emp_age,emp_photolink,emp_minzhu,emp_zzmm,emp_marital,emp_healthstatus,emp_paiban,emp_hklx,emp_jiguan,emp_hujiaddr,emp_juzhuaddr,emp_tel,emp_phone,emp_lxr,emp_lxrphone,emp_zhideng,emp_QQ,emp_email,emp_dimissdate,emp_dimisstype,emp_dismissremark,emp_isonworking,emp_iszda,emp_isjthk,emp_sblx,emp_sbnum,emp_isblacklist,emp_balcklistremark,emp_lastcomp,emp_remrak,emp_birthtype,emp_real_brithdate,emp_jobtype,emp_banknum,emp_bank,emp_createdate,emp_creater");
            strSql.Append(") values (");
            strSql.Append("@loginid,@emp_dept,@emp_insti,@emp_comp,@emp_worknum,@emp_cnname,@emp_cardnum,@emp_birthdate,@emp_entrydate,@emp_entrytitle,@emp_practicedate,@emp_lastdate,@emp_sex,@emp_title,@emp_type,@emp_workarea,@emp_luyongfangshi,@emp_luyongqudao,@emp_cometruedate,@emp_yjcometruedate,@emp_beginworkdate,@emp_workcertificate,@emp_zhicheng,@emp_identity,@emp_age,@emp_photolink,@emp_minzhu,@emp_zzmm,@emp_marital,@emp_healthstatus,@emp_paiban,@emp_hklx,@emp_jiguan,@emp_hujiaddr,@emp_juzhuaddr,@emp_tel,@emp_phone,@emp_lxr,@emp_lxrphone,@emp_zhideng,@emp_QQ,@emp_email,@emp_dimissdate,@emp_dimisstype,@emp_dismissremark,@emp_isonworking,@emp_iszda,@emp_isjthk,@emp_sblx,@emp_sbnum,@emp_isblacklist,@emp_balcklistremark,@emp_lastcomp,@emp_remrak,@emp_birthtype,@emp_real_brithdate,@emp_jobtype,@emp_banknum,@emp_bank,@emp_createdate,@emp_creater");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
new SqlParameter("@loginid", SqlDbType.NVarChar,50) ,            
new SqlParameter("@emp_dept", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_insti", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_comp", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_worknum", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_cnname", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_cardnum", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_birthdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_entrydate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_entrytitle", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_practicedate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_lastdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_sex", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_title", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_type", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_workarea", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_luyongfangshi", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_luyongqudao", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_cometruedate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_yjcometruedate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_beginworkdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_workcertificate", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_zhicheng", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_identity", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_age", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_photolink", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_minzhu", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_zzmm", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_marital", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_healthstatus", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_paiban", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_hklx", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_jiguan", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_hujiaddr", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_juzhuaddr", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_tel", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_phone", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_lxr", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_lxrphone", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_zhideng", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_QQ", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_email", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_dimissdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_dimisstype", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_dismissremark", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_isonworking", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_iszda", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_isjthk", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_sblx", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_sbnum", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_isblacklist", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_balcklistremark", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_lastcomp", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_remrak", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_birthtype", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_real_brithdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_jobtype", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_banknum", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_bank", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_createdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_creater", SqlDbType.NVarChar,100)             
              
};

            parameters[0].Value = model.loginid;
            parameters[1].Value = model.emp_dept;
            parameters[2].Value = model.emp_insti;
            parameters[3].Value = model.emp_comp;
            parameters[4].Value = model.emp_worknum;
            parameters[5].Value = model.emp_cnname;
            parameters[6].Value = model.emp_cardnum;
            parameters[7].Value = model.emp_birthdate;
            parameters[8].Value = model.emp_entrydate;
            parameters[9].Value = model.emp_entrytitle;
            parameters[10].Value = model.emp_practicedate;
            parameters[11].Value = model.emp_lastdate;
            parameters[12].Value = model.emp_sex;
            parameters[13].Value = model.emp_title;
            parameters[14].Value = model.emp_type;
            parameters[15].Value = model.emp_workarea;
            parameters[16].Value = model.emp_luyongfangshi;
            parameters[17].Value = model.emp_luyongqudao;
            parameters[18].Value = model.emp_cometruedate;
            parameters[19].Value = model.emp_yjcometruedate;
            parameters[20].Value = model.emp_beginworkdate;
            parameters[21].Value = model.emp_workcertificate;
            parameters[22].Value = model.emp_zhicheng;
            parameters[23].Value = model.emp_identity;
            parameters[24].Value = model.emp_age;
            parameters[25].Value = model.emp_photolink;
            parameters[26].Value = model.emp_minzhu;
            parameters[27].Value = model.emp_zzmm;
            parameters[28].Value = model.emp_marital;
            parameters[29].Value = model.emp_healthstatus;
            parameters[30].Value = model.emp_paiban;
            parameters[31].Value = model.emp_hklx;
            parameters[32].Value = model.emp_jiguan;
            parameters[33].Value = model.emp_hujiaddr;
            parameters[34].Value = model.emp_juzhuaddr;
            parameters[35].Value = model.emp_tel;
            parameters[36].Value = model.emp_phone;
            parameters[37].Value = model.emp_lxr;
            parameters[38].Value = model.emp_lxrphone;
            parameters[39].Value = model.emp_zhideng;
            parameters[40].Value = model.emp_QQ;
            parameters[41].Value = model.emp_email;
            parameters[42].Value = model.emp_dimissdate;
            parameters[43].Value = model.emp_dimisstype;
            parameters[44].Value = model.emp_dismissremark;
            parameters[45].Value = model.emp_isonworking;
            parameters[46].Value = model.emp_iszda;
            parameters[47].Value = model.emp_isjthk;
            parameters[48].Value = model.emp_sblx;
            parameters[49].Value = model.emp_sbnum;
            parameters[50].Value = model.emp_isblacklist;
            parameters[51].Value = model.emp_balcklistremark;
            parameters[52].Value = model.emp_lastcomp;
            parameters[53].Value = model.emp_remrak;
            parameters[54].Value = model.emp_birthtype;
            parameters[55].Value = model.emp_real_brithdate;
            parameters[56].Value = model.emp_jobtype;
            parameters[57].Value = model.emp_banknum;
            parameters[58].Value = model.emp_bank;
            parameters[59].Value = model.emp_createdate;
            parameters[60].Value = model.emp_creater;

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
        public bool Update(AutekInfo.Model.Employee_Info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Employee_Info set ");

            strSql.Append(" loginid = @loginid , ");
            strSql.Append(" emp_dept = @emp_dept , ");
            strSql.Append(" emp_insti = @emp_insti , ");
            strSql.Append(" emp_comp = @emp_comp , ");
            strSql.Append(" emp_worknum = @emp_worknum , ");
            strSql.Append(" emp_cnname = @emp_cnname , ");
            strSql.Append(" emp_cardnum = @emp_cardnum , ");
            strSql.Append(" emp_birthdate = @emp_birthdate , ");
            strSql.Append(" emp_entrydate = @emp_entrydate , ");
            strSql.Append(" emp_entrytitle = @emp_entrytitle , ");
            strSql.Append(" emp_practicedate = @emp_practicedate , ");
            strSql.Append(" emp_lastdate = @emp_lastdate , ");
            strSql.Append(" emp_sex = @emp_sex , ");
            strSql.Append(" emp_title = @emp_title , ");
            strSql.Append(" emp_type = @emp_type , ");
            strSql.Append(" emp_workarea = @emp_workarea , ");
            strSql.Append(" emp_luyongfangshi = @emp_luyongfangshi , ");
            strSql.Append(" emp_luyongqudao = @emp_luyongqudao , ");
            strSql.Append(" emp_cometruedate = @emp_cometruedate , ");
            strSql.Append(" emp_yjcometruedate = @emp_yjcometruedate , ");
            strSql.Append(" emp_beginworkdate = @emp_beginworkdate , ");
            strSql.Append(" emp_workcertificate = @emp_workcertificate , ");
            strSql.Append(" emp_zhicheng = @emp_zhicheng , ");
            strSql.Append(" emp_identity = @emp_identity , ");
            strSql.Append(" emp_age = @emp_age , ");
            strSql.Append(" emp_photolink = @emp_photolink , ");
            strSql.Append(" emp_minzhu = @emp_minzhu , ");
            strSql.Append(" emp_zzmm = @emp_zzmm , ");
            strSql.Append(" emp_marital = @emp_marital , ");
            strSql.Append(" emp_healthstatus = @emp_healthstatus , ");
            strSql.Append(" emp_paiban = @emp_paiban , ");
            strSql.Append(" emp_hklx = @emp_hklx , ");
            strSql.Append(" emp_jiguan = @emp_jiguan , ");
            strSql.Append(" emp_hujiaddr = @emp_hujiaddr , ");
            strSql.Append(" emp_juzhuaddr = @emp_juzhuaddr , ");
            strSql.Append(" emp_tel = @emp_tel , ");
            strSql.Append(" emp_phone = @emp_phone , ");
            strSql.Append(" emp_lxr = @emp_lxr , ");
            strSql.Append(" emp_lxrphone = @emp_lxrphone , ");
            strSql.Append(" emp_zhideng = @emp_zhideng , ");
            strSql.Append(" emp_QQ = @emp_QQ , ");
            strSql.Append(" emp_email = @emp_email , ");
            strSql.Append(" emp_dimissdate = @emp_dimissdate , ");
            strSql.Append(" emp_dimisstype = @emp_dimisstype , ");
            strSql.Append(" emp_dismissremark = @emp_dismissremark , ");
            strSql.Append(" emp_isonworking = @emp_isonworking , ");
            strSql.Append(" emp_iszda = @emp_iszda , ");
            strSql.Append(" emp_isjthk = @emp_isjthk , ");
            strSql.Append(" emp_sblx = @emp_sblx , ");
            strSql.Append(" emp_sbnum = @emp_sbnum , ");
            strSql.Append(" emp_isblacklist = @emp_isblacklist , ");
            strSql.Append(" emp_balcklistremark = @emp_balcklistremark , ");
            strSql.Append(" emp_lastcomp = @emp_lastcomp , ");
            strSql.Append(" emp_remrak = @emp_remrak , ");
            strSql.Append(" emp_birthtype = @emp_birthtype , ");
            strSql.Append(" emp_real_brithdate = @emp_real_brithdate , ");
            strSql.Append(" emp_jobtype = @emp_jobtype , ");
            strSql.Append(" emp_banknum = @emp_banknum , ");
            strSql.Append(" emp_bank = @emp_bank , ");
            strSql.Append(" emp_createdate = @emp_createdate , ");
            strSql.Append(" emp_creater = @emp_creater  ");
            strSql.Append(" where emp_id=@emp_id ");

            SqlParameter[] parameters = {
new SqlParameter("@emp_id", SqlDbType.Int,4) ,            
new SqlParameter("@loginid", SqlDbType.NVarChar,50) ,            
new SqlParameter("@emp_dept", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_insti", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_comp", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_worknum", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_cnname", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_cardnum", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_birthdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_entrydate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_entrytitle", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_practicedate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_lastdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_sex", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_title", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_type", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_workarea", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_luyongfangshi", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_luyongqudao", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_cometruedate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_yjcometruedate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_beginworkdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_workcertificate", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_zhicheng", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_identity", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_age", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_photolink", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_minzhu", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_zzmm", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_marital", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_healthstatus", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_paiban", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_hklx", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_jiguan", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_hujiaddr", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_juzhuaddr", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_tel", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_phone", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_lxr", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_lxrphone", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_zhideng", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_QQ", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_email", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_dimissdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_dimisstype", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_dismissremark", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_isonworking", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_iszda", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_isjthk", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_sblx", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_sbnum", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_isblacklist", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_balcklistremark", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_lastcomp", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_remrak", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_birthtype", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_real_brithdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_jobtype", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_banknum", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_bank", SqlDbType.NVarChar,100) ,            
new SqlParameter("@emp_createdate", SqlDbType.DateTime) ,            
new SqlParameter("@emp_creater", SqlDbType.NVarChar,100)             
              
};

            parameters[0].Value = model.emp_id;
            parameters[1].Value = model.loginid;
            parameters[2].Value = model.emp_dept;
            parameters[3].Value = model.emp_insti;
            parameters[4].Value = model.emp_comp;
            parameters[5].Value = model.emp_worknum;
            parameters[6].Value = model.emp_cnname;
            parameters[7].Value = model.emp_cardnum;
            parameters[8].Value = model.emp_birthdate;
            parameters[9].Value = model.emp_entrydate;
            parameters[10].Value = model.emp_entrytitle;
            parameters[11].Value = model.emp_practicedate;
            parameters[12].Value = model.emp_lastdate;
            parameters[13].Value = model.emp_sex;
            parameters[14].Value = model.emp_title;
            parameters[15].Value = model.emp_type;
            parameters[16].Value = model.emp_workarea;
            parameters[17].Value = model.emp_luyongfangshi;
            parameters[18].Value = model.emp_luyongqudao;
            parameters[19].Value = model.emp_cometruedate;
            parameters[20].Value = model.emp_yjcometruedate;
            parameters[21].Value = model.emp_beginworkdate;
            parameters[22].Value = model.emp_workcertificate;
            parameters[23].Value = model.emp_zhicheng;
            parameters[24].Value = model.emp_identity;
            parameters[25].Value = model.emp_age;
            parameters[26].Value = model.emp_photolink;
            parameters[27].Value = model.emp_minzhu;
            parameters[28].Value = model.emp_zzmm;
            parameters[29].Value = model.emp_marital;
            parameters[30].Value = model.emp_healthstatus;
            parameters[31].Value = model.emp_paiban;
            parameters[32].Value = model.emp_hklx;
            parameters[33].Value = model.emp_jiguan;
            parameters[34].Value = model.emp_hujiaddr;
            parameters[35].Value = model.emp_juzhuaddr;
            parameters[36].Value = model.emp_tel;
            parameters[37].Value = model.emp_phone;
            parameters[38].Value = model.emp_lxr;
            parameters[39].Value = model.emp_lxrphone;
            parameters[40].Value = model.emp_zhideng;
            parameters[41].Value = model.emp_QQ;
            parameters[42].Value = model.emp_email;
            parameters[43].Value = model.emp_dimissdate;
            parameters[44].Value = model.emp_dimisstype;
            parameters[45].Value = model.emp_dismissremark;
            parameters[46].Value = model.emp_isonworking;
            parameters[47].Value = model.emp_iszda;
            parameters[48].Value = model.emp_isjthk;
            parameters[49].Value = model.emp_sblx;
            parameters[50].Value = model.emp_sbnum;
            parameters[51].Value = model.emp_isblacklist;
            parameters[52].Value = model.emp_balcklistremark;
            parameters[53].Value = model.emp_lastcomp;
            parameters[54].Value = model.emp_remrak;
            parameters[55].Value = model.emp_birthtype;
            parameters[56].Value = model.emp_real_brithdate;
            parameters[57].Value = model.emp_jobtype;
            parameters[58].Value = model.emp_banknum;
            parameters[59].Value = model.emp_bank;
            parameters[60].Value = model.emp_createdate;
            parameters[61].Value = model.emp_creater;
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
        public bool Delete(int emp_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Employee_Info ");
            strSql.Append(" where emp_id=@emp_id");
            SqlParameter[] parameters = {
new SqlParameter("@emp_id", SqlDbType.Int,4)
};
            parameters[0].Value = emp_id;


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
        public bool DeleteList(string emp_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Employee_Info ");
            strSql.Append(" where ID in (" + emp_idlist + ")  ");
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
        public AutekInfo.Model.Employee_Info GetModel(int emp_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select emp_id, loginid, emp_dept, emp_insti, emp_comp, emp_worknum, emp_cnname, emp_cardnum, emp_birthdate, emp_entrydate, emp_entrytitle, emp_practicedate, emp_lastdate, emp_sex, emp_title, emp_type, emp_workarea, emp_luyongfangshi, emp_luyongqudao, emp_cometruedate, emp_yjcometruedate, emp_beginworkdate, emp_workcertificate, emp_zhicheng, emp_identity, emp_age, emp_photolink, emp_minzhu, emp_zzmm, emp_marital, emp_healthstatus, emp_paiban, emp_hklx, emp_jiguan, emp_hujiaddr, emp_juzhuaddr, emp_tel, emp_phone, emp_lxr, emp_lxrphone, emp_zhideng, emp_QQ, emp_email, emp_dimissdate, emp_dimisstype, emp_dismissremark, emp_isonworking, emp_iszda, emp_isjthk, emp_sblx, emp_sbnum, emp_isblacklist, emp_balcklistremark, emp_lastcomp, emp_remrak, emp_birthtype, emp_real_brithdate, emp_jobtype, emp_banknum, emp_bank, emp_createdate, emp_creater  ");
            strSql.Append("  from Employee_Info ");
            strSql.Append(" where emp_id=@emp_id");
            SqlParameter[] parameters = {
new SqlParameter("@emp_id", SqlDbType.Int,4)
};
            parameters[0].Value = emp_id;


            AutekInfo.Model.Employee_Info model = new AutekInfo.Model.Employee_Info();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["emp_id"].ToString() != "")
                {
                    model.emp_id = int.Parse(ds.Tables[0].Rows[0]["emp_id"].ToString());
                }
                model.loginid = ds.Tables[0].Rows[0]["loginid"].ToString();
                model.emp_dept = ds.Tables[0].Rows[0]["emp_dept"].ToString();
                model.emp_insti = ds.Tables[0].Rows[0]["emp_insti"].ToString();
                model.emp_comp = ds.Tables[0].Rows[0]["emp_comp"].ToString();
                model.emp_worknum = ds.Tables[0].Rows[0]["emp_worknum"].ToString();
                model.emp_cnname = ds.Tables[0].Rows[0]["emp_cnname"].ToString();
                model.emp_cardnum = ds.Tables[0].Rows[0]["emp_cardnum"].ToString();
                if (ds.Tables[0].Rows[0]["emp_birthdate"].ToString() != "")
                {
                    model.emp_birthdate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_birthdate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["emp_entrydate"].ToString() != "")
                {
                    model.emp_entrydate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_entrydate"].ToString());
                }
                model.emp_entrytitle = ds.Tables[0].Rows[0]["emp_entrytitle"].ToString();
                if (ds.Tables[0].Rows[0]["emp_practicedate"].ToString() != "")
                {
                    model.emp_practicedate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_practicedate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["emp_lastdate"].ToString() != "")
                {
                    model.emp_lastdate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_lastdate"].ToString());
                }
                model.emp_sex = ds.Tables[0].Rows[0]["emp_sex"].ToString();
                model.emp_title = ds.Tables[0].Rows[0]["emp_title"].ToString();
                model.emp_type = ds.Tables[0].Rows[0]["emp_type"].ToString();
                model.emp_workarea = ds.Tables[0].Rows[0]["emp_workarea"].ToString();
                model.emp_luyongfangshi = ds.Tables[0].Rows[0]["emp_luyongfangshi"].ToString();
                model.emp_luyongqudao = ds.Tables[0].Rows[0]["emp_luyongqudao"].ToString();
                if (ds.Tables[0].Rows[0]["emp_cometruedate"].ToString() != "")
                {
                    model.emp_cometruedate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_cometruedate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["emp_yjcometruedate"].ToString() != "")
                {
                    model.emp_yjcometruedate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_yjcometruedate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["emp_beginworkdate"].ToString() != "")
                {
                    model.emp_beginworkdate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_beginworkdate"].ToString());
                }
                model.emp_workcertificate = ds.Tables[0].Rows[0]["emp_workcertificate"].ToString();
                model.emp_zhicheng = ds.Tables[0].Rows[0]["emp_zhicheng"].ToString();
                model.emp_identity = ds.Tables[0].Rows[0]["emp_identity"].ToString();
                model.emp_age = ds.Tables[0].Rows[0]["emp_age"].ToString();
                model.emp_photolink = ds.Tables[0].Rows[0]["emp_photolink"].ToString();
                model.emp_minzhu = ds.Tables[0].Rows[0]["emp_minzhu"].ToString();
                model.emp_zzmm = ds.Tables[0].Rows[0]["emp_zzmm"].ToString();
                model.emp_marital = ds.Tables[0].Rows[0]["emp_marital"].ToString();
                model.emp_healthstatus = ds.Tables[0].Rows[0]["emp_healthstatus"].ToString();
                model.emp_paiban = ds.Tables[0].Rows[0]["emp_paiban"].ToString();
                model.emp_hklx = ds.Tables[0].Rows[0]["emp_hklx"].ToString();
                model.emp_jiguan = ds.Tables[0].Rows[0]["emp_jiguan"].ToString();
                model.emp_hujiaddr = ds.Tables[0].Rows[0]["emp_hujiaddr"].ToString();
                model.emp_juzhuaddr = ds.Tables[0].Rows[0]["emp_juzhuaddr"].ToString();
                model.emp_tel = ds.Tables[0].Rows[0]["emp_tel"].ToString();
                model.emp_phone = ds.Tables[0].Rows[0]["emp_phone"].ToString();
                model.emp_lxr = ds.Tables[0].Rows[0]["emp_lxr"].ToString();
                model.emp_lxrphone = ds.Tables[0].Rows[0]["emp_lxrphone"].ToString();
                model.emp_zhideng = ds.Tables[0].Rows[0]["emp_zhideng"].ToString();
                model.emp_QQ = ds.Tables[0].Rows[0]["emp_QQ"].ToString();
                model.emp_email = ds.Tables[0].Rows[0]["emp_email"].ToString();
                if (ds.Tables[0].Rows[0]["emp_dimissdate"].ToString() != "")
                {
                    model.emp_dimissdate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_dimissdate"].ToString());
                }
                model.emp_dimisstype = ds.Tables[0].Rows[0]["emp_dimisstype"].ToString();
                model.emp_dismissremark = ds.Tables[0].Rows[0]["emp_dismissremark"].ToString();
                model.emp_isonworking = ds.Tables[0].Rows[0]["emp_isonworking"].ToString();
                model.emp_iszda = ds.Tables[0].Rows[0]["emp_iszda"].ToString();
                model.emp_isjthk = ds.Tables[0].Rows[0]["emp_isjthk"].ToString();
                model.emp_sblx = ds.Tables[0].Rows[0]["emp_sblx"].ToString();
                model.emp_sbnum = ds.Tables[0].Rows[0]["emp_sbnum"].ToString();
                model.emp_isblacklist = ds.Tables[0].Rows[0]["emp_isblacklist"].ToString();
                model.emp_balcklistremark = ds.Tables[0].Rows[0]["emp_balcklistremark"].ToString();
                model.emp_lastcomp = ds.Tables[0].Rows[0]["emp_lastcomp"].ToString();
                model.emp_remrak = ds.Tables[0].Rows[0]["emp_remrak"].ToString();
                model.emp_birthtype = ds.Tables[0].Rows[0]["emp_birthtype"].ToString();
                if (ds.Tables[0].Rows[0]["emp_real_brithdate"].ToString() != "")
                {
                    model.emp_real_brithdate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_real_brithdate"].ToString());
                }
                model.emp_jobtype = ds.Tables[0].Rows[0]["emp_jobtype"].ToString();
                model.emp_banknum = ds.Tables[0].Rows[0]["emp_banknum"].ToString();
                model.emp_bank = ds.Tables[0].Rows[0]["emp_bank"].ToString();
                if (ds.Tables[0].Rows[0]["emp_createdate"].ToString() != "")
                {
                    model.emp_createdate = DateTime.Parse(ds.Tables[0].Rows[0]["emp_createdate"].ToString());
                }
                model.emp_creater = ds.Tables[0].Rows[0]["emp_creater"].ToString();

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
            strSql.Append(" FROM Employee_Info ");
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
            strSql.Append(" FROM Employee_Info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

