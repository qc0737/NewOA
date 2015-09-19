using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//Emp_Account
		public class Emp_Account
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
		   
	}
}

