using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//View_BaseAccount
		public class View_BaseAccount
	{
   		     
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
		/// pwd
        /// </summary>		
		private string _pwd;
        public string pwd
        {
            get{ return _pwd; }
            set{ _pwd = value; }
        }        
		/// <summary>
		/// status
        /// </summary>		
		private string _status;
        public string status
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// lastloginip
        /// </summary>		
		private string _lastloginip;
        public string lastloginip
        {
            get{ return _lastloginip; }
            set{ _lastloginip = value; }
        }        
		/// <summary>
		/// lastlogindate
        /// </summary>		
		private DateTime _lastlogindate;
        public DateTime lastlogindate
        {
            get{ return _lastlogindate; }
            set{ _lastlogindate = value; }
        }        
		/// <summary>
		/// sysstatus
        /// </summary>		
		private int _sysstatus;
        public int sysstatus
        {
            get{ return _sysstatus; }
            set{ _sysstatus = value; }
        }        
		/// <summary>
		/// updater
        /// </summary>		
		private int _updater;
        public int updater
        {
            get{ return _updater; }
            set{ _updater = value; }
        }        
		/// <summary>
		/// updatedata
        /// </summary>		
		private DateTime _updatedata;
        public DateTime updatedata
        {
            get{ return _updatedata; }
            set{ _updatedata = value; }
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
		/// emp_id
        /// </summary>		
		private int _emp_id;
        public int emp_id
        {
            get{ return _emp_id; }
            set{ _emp_id = value; }
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
		/// role_name
        /// </summary>		
		private string _role_name;
        public string role_name
        {
            get{ return _role_name; }
            set{ _role_name = value; }
        }        
		/// <summary>
		/// role_code
        /// </summary>		
		private string _role_code;
        public string role_code
        {
            get{ return _role_code; }
            set{ _role_code = value; }
        }        
		   
	}
}

