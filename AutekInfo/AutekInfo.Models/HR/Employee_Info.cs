using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//Employee_Info
		public class Employee_Info
	{
   		     
      	/// <summary>
		/// emp_id
        /// </summary>		
		private int _emp_id;
        public int emp_id
        {
            get{ return _emp_id; }
            set{ _emp_id = value; }
        }        
		/// <summary>
		/// loginid
        /// </summary>		
		private string _loginid;
        public string loginid
        {
            get{ return _loginid; }
            set{ _loginid = value; }
        }        
		/// <summary>
		/// emp_dept
        /// </summary>		
		private string _emp_dept;
        public string emp_dept
        {
            get{ return _emp_dept; }
            set{ _emp_dept = value; }
        }        
		/// <summary>
		/// emp_insti
        /// </summary>		
		private string _emp_insti;
        public string emp_insti
        {
            get{ return _emp_insti; }
            set{ _emp_insti = value; }
        }        
		/// <summary>
		/// emp_comp
        /// </summary>		
		private string _emp_comp;
        public string emp_comp
        {
            get{ return _emp_comp; }
            set{ _emp_comp = value; }
        }        
		/// <summary>
		/// emp_worknum
        /// </summary>		
		private string _emp_worknum;
        public string emp_worknum
        {
            get{ return _emp_worknum; }
            set{ _emp_worknum = value; }
        }        
		/// <summary>
		/// emp_cnname
        /// </summary>		
		private string _emp_cnname;
        public string emp_cnname
        {
            get{ return _emp_cnname; }
            set{ _emp_cnname = value; }
        }        
		/// <summary>
		/// emp_cardnum
        /// </summary>		
		private string _emp_cardnum;
        public string emp_cardnum
        {
            get{ return _emp_cardnum; }
            set{ _emp_cardnum = value; }
        }        
		/// <summary>
		/// emp_birthdate
        /// </summary>		
		private DateTime _emp_birthdate;
        public DateTime emp_birthdate
        {
            get{ return _emp_birthdate; }
            set{ _emp_birthdate = value; }
        }        
		/// <summary>
		/// emp_entrydate
        /// </summary>		
		private DateTime _emp_entrydate;
        public DateTime emp_entrydate
        {
            get{ return _emp_entrydate; }
            set{ _emp_entrydate = value; }
        }        
		/// <summary>
		/// emp_entrytitle
        /// </summary>		
		private string _emp_entrytitle;
        public string emp_entrytitle
        {
            get{ return _emp_entrytitle; }
            set{ _emp_entrytitle = value; }
        }        
		/// <summary>
		/// emp_practicedate
        /// </summary>		
		private DateTime _emp_practicedate;
        public DateTime emp_practicedate
        {
            get{ return _emp_practicedate; }
            set{ _emp_practicedate = value; }
        }        
		/// <summary>
		/// emp_lastdate
        /// </summary>		
		private DateTime _emp_lastdate;
        public DateTime emp_lastdate
        {
            get{ return _emp_lastdate; }
            set{ _emp_lastdate = value; }
        }        
		/// <summary>
		/// emp_sex
        /// </summary>		
		private string _emp_sex;
        public string emp_sex
        {
            get{ return _emp_sex; }
            set{ _emp_sex = value; }
        }        
		/// <summary>
		/// emp_title
        /// </summary>		
		private string _emp_title;
        public string emp_title
        {
            get{ return _emp_title; }
            set{ _emp_title = value; }
        }        
		/// <summary>
		/// emp_type
        /// </summary>		
		private string _emp_type;
        public string emp_type
        {
            get{ return _emp_type; }
            set{ _emp_type = value; }
        }        
		/// <summary>
		/// emp_workarea
        /// </summary>		
		private string _emp_workarea;
        public string emp_workarea
        {
            get{ return _emp_workarea; }
            set{ _emp_workarea = value; }
        }        
		/// <summary>
		/// emp_luyongfangshi
        /// </summary>		
		private string _emp_luyongfangshi;
        public string emp_luyongfangshi
        {
            get{ return _emp_luyongfangshi; }
            set{ _emp_luyongfangshi = value; }
        }        
		/// <summary>
		/// emp_luyongqudao
        /// </summary>		
		private string _emp_luyongqudao;
        public string emp_luyongqudao
        {
            get{ return _emp_luyongqudao; }
            set{ _emp_luyongqudao = value; }
        }        
		/// <summary>
		/// emp_cometruedate
        /// </summary>		
		private DateTime _emp_cometruedate;
        public DateTime emp_cometruedate
        {
            get{ return _emp_cometruedate; }
            set{ _emp_cometruedate = value; }
        }        
		/// <summary>
		/// emp_yjcometruedate
        /// </summary>		
		private DateTime _emp_yjcometruedate;
        public DateTime emp_yjcometruedate
        {
            get{ return _emp_yjcometruedate; }
            set{ _emp_yjcometruedate = value; }
        }        
		/// <summary>
		/// emp_beginworkdate
        /// </summary>		
		private DateTime _emp_beginworkdate;
        public DateTime emp_beginworkdate
        {
            get{ return _emp_beginworkdate; }
            set{ _emp_beginworkdate = value; }
        }        
		/// <summary>
		/// emp_workcertificate
        /// </summary>		
		private string _emp_workcertificate;
        public string emp_workcertificate
        {
            get{ return _emp_workcertificate; }
            set{ _emp_workcertificate = value; }
        }        
		/// <summary>
		/// emp_zhicheng
        /// </summary>		
		private string _emp_zhicheng;
        public string emp_zhicheng
        {
            get{ return _emp_zhicheng; }
            set{ _emp_zhicheng = value; }
        }        
		/// <summary>
		/// emp_identity
        /// </summary>		
		private string _emp_identity;
        public string emp_identity
        {
            get{ return _emp_identity; }
            set{ _emp_identity = value; }
        }        
		/// <summary>
		/// emp_age
        /// </summary>		
		private string _emp_age;
        public string emp_age
        {
            get{ return _emp_age; }
            set{ _emp_age = value; }
        }        
		/// <summary>
		/// emp_photolink
        /// </summary>		
		private string _emp_photolink;
        public string emp_photolink
        {
            get{ return _emp_photolink; }
            set{ _emp_photolink = value; }
        }        
		/// <summary>
		/// emp_minzhu
        /// </summary>		
		private string _emp_minzhu;
        public string emp_minzhu
        {
            get{ return _emp_minzhu; }
            set{ _emp_minzhu = value; }
        }        
		/// <summary>
		/// emp_zzmm
        /// </summary>		
		private string _emp_zzmm;
        public string emp_zzmm
        {
            get{ return _emp_zzmm; }
            set{ _emp_zzmm = value; }
        }        
		/// <summary>
		/// emp_marital
        /// </summary>		
		private string _emp_marital;
        public string emp_marital
        {
            get{ return _emp_marital; }
            set{ _emp_marital = value; }
        }        
		/// <summary>
		/// emp_healthstatus
        /// </summary>		
		private string _emp_healthstatus;
        public string emp_healthstatus
        {
            get{ return _emp_healthstatus; }
            set{ _emp_healthstatus = value; }
        }        
		/// <summary>
		/// emp_paiban
        /// </summary>		
		private string _emp_paiban;
        public string emp_paiban
        {
            get{ return _emp_paiban; }
            set{ _emp_paiban = value; }
        }        
		/// <summary>
		/// emp_hklx
        /// </summary>		
		private string _emp_hklx;
        public string emp_hklx
        {
            get{ return _emp_hklx; }
            set{ _emp_hklx = value; }
        }        
		/// <summary>
		/// emp_jiguan
        /// </summary>		
		private string _emp_jiguan;
        public string emp_jiguan
        {
            get{ return _emp_jiguan; }
            set{ _emp_jiguan = value; }
        }        
		/// <summary>
		/// emp_hujiaddr
        /// </summary>		
		private string _emp_hujiaddr;
        public string emp_hujiaddr
        {
            get{ return _emp_hujiaddr; }
            set{ _emp_hujiaddr = value; }
        }        
		/// <summary>
		/// emp_juzhuaddr
        /// </summary>		
		private string _emp_juzhuaddr;
        public string emp_juzhuaddr
        {
            get{ return _emp_juzhuaddr; }
            set{ _emp_juzhuaddr = value; }
        }        
		/// <summary>
		/// emp_tel
        /// </summary>		
		private string _emp_tel;
        public string emp_tel
        {
            get{ return _emp_tel; }
            set{ _emp_tel = value; }
        }        
		/// <summary>
		/// emp_phone
        /// </summary>		
		private string _emp_phone;
        public string emp_phone
        {
            get{ return _emp_phone; }
            set{ _emp_phone = value; }
        }        
		/// <summary>
		/// emp_lxr
        /// </summary>		
		private string _emp_lxr;
        public string emp_lxr
        {
            get{ return _emp_lxr; }
            set{ _emp_lxr = value; }
        }        
		/// <summary>
		/// emp_lxrphone
        /// </summary>		
		private string _emp_lxrphone;
        public string emp_lxrphone
        {
            get{ return _emp_lxrphone; }
            set{ _emp_lxrphone = value; }
        }        
		/// <summary>
		/// emp_zhideng
        /// </summary>		
		private string _emp_zhideng;
        public string emp_zhideng
        {
            get{ return _emp_zhideng; }
            set{ _emp_zhideng = value; }
        }        
		/// <summary>
		/// emp_QQ
        /// </summary>		
		private string _emp_qq;
        public string emp_QQ
        {
            get{ return _emp_qq; }
            set{ _emp_qq = value; }
        }        
		/// <summary>
		/// emp_email
        /// </summary>		
		private string _emp_email;
        public string emp_email
        {
            get{ return _emp_email; }
            set{ _emp_email = value; }
        }        
		/// <summary>
		/// emp_dimissdate
        /// </summary>		
		private DateTime _emp_dimissdate;
        public DateTime emp_dimissdate
        {
            get{ return _emp_dimissdate; }
            set{ _emp_dimissdate = value; }
        }        
		/// <summary>
		/// emp_dimisstype
        /// </summary>		
		private string _emp_dimisstype;
        public string emp_dimisstype
        {
            get{ return _emp_dimisstype; }
            set{ _emp_dimisstype = value; }
        }        
		/// <summary>
		/// emp_dismissremark
        /// </summary>		
		private string _emp_dismissremark;
        public string emp_dismissremark
        {
            get{ return _emp_dismissremark; }
            set{ _emp_dismissremark = value; }
        }        
		/// <summary>
		/// emp_isonworking
        /// </summary>		
		private string _emp_isonworking;
        public string emp_isonworking
        {
            get{ return _emp_isonworking; }
            set{ _emp_isonworking = value; }
        }        
		/// <summary>
		/// emp_iszda
        /// </summary>		
		private string _emp_iszda;
        public string emp_iszda
        {
            get{ return _emp_iszda; }
            set{ _emp_iszda = value; }
        }        
		/// <summary>
		/// emp_isjthk
        /// </summary>		
		private string _emp_isjthk;
        public string emp_isjthk
        {
            get{ return _emp_isjthk; }
            set{ _emp_isjthk = value; }
        }        
		/// <summary>
		/// emp_sblx
        /// </summary>		
		private string _emp_sblx;
        public string emp_sblx
        {
            get{ return _emp_sblx; }
            set{ _emp_sblx = value; }
        }        
		/// <summary>
		/// emp_sbnum
        /// </summary>		
		private string _emp_sbnum;
        public string emp_sbnum
        {
            get{ return _emp_sbnum; }
            set{ _emp_sbnum = value; }
        }        
		/// <summary>
		/// emp_isblacklist
        /// </summary>		
		private string _emp_isblacklist;
        public string emp_isblacklist
        {
            get{ return _emp_isblacklist; }
            set{ _emp_isblacklist = value; }
        }        
		/// <summary>
		/// emp_balcklistremark
        /// </summary>		
		private string _emp_balcklistremark;
        public string emp_balcklistremark
        {
            get{ return _emp_balcklistremark; }
            set{ _emp_balcklistremark = value; }
        }        
		/// <summary>
		/// emp_lastcomp
        /// </summary>		
		private string _emp_lastcomp;
        public string emp_lastcomp
        {
            get{ return _emp_lastcomp; }
            set{ _emp_lastcomp = value; }
        }        
		/// <summary>
		/// emp_remrak
        /// </summary>		
		private string _emp_remrak;
        public string emp_remrak
        {
            get{ return _emp_remrak; }
            set{ _emp_remrak = value; }
        }        
		/// <summary>
		/// emp_birthtype
        /// </summary>		
		private string _emp_birthtype;
        public string emp_birthtype
        {
            get{ return _emp_birthtype; }
            set{ _emp_birthtype = value; }
        }        
		/// <summary>
		/// emp_real_brithdate
        /// </summary>		
		private DateTime _emp_real_brithdate;
        public DateTime emp_real_brithdate
        {
            get{ return _emp_real_brithdate; }
            set{ _emp_real_brithdate = value; }
        }        
		/// <summary>
		/// emp_jobtype
        /// </summary>		
		private string _emp_jobtype;
        public string emp_jobtype
        {
            get{ return _emp_jobtype; }
            set{ _emp_jobtype = value; }
        }        
		/// <summary>
		/// emp_banknum
        /// </summary>		
		private string _emp_banknum;
        public string emp_banknum
        {
            get{ return _emp_banknum; }
            set{ _emp_banknum = value; }
        }        
		/// <summary>
		/// emp_bank
        /// </summary>		
		private string _emp_bank;
        public string emp_bank
        {
            get{ return _emp_bank; }
            set{ _emp_bank = value; }
        }        
		/// <summary>
		/// emp_createdate
        /// </summary>		
		private DateTime _emp_createdate;
        public DateTime emp_createdate
        {
            get{ return _emp_createdate; }
            set{ _emp_createdate = value; }
        }        
		/// <summary>
		/// emp_creater
        /// </summary>		
		private string _emp_creater;
        public string emp_creater
        {
            get{ return _emp_creater; }
            set{ _emp_creater = value; }
        }        
		   
	}
}

