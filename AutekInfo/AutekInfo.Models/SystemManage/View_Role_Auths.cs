using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//View_Role_Auths
		public class View_Role_Auths
	{
   		     
      	/// <summary>
		/// role_id
        /// </summary>		
		private int _role_id;
        public int role_id
        {
            get{ return _role_id; }
            set{ _role_id = value; }
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
		/// role_describe
        /// </summary>		
		private string _role_describe;
        public string role_describe
        {
            get{ return _role_describe; }
            set{ _role_describe = value; }
        }        
		/// <summary>
		/// authids
        /// </summary>		
		private string _authids;
        public string authids
        {
            get{ return _authids; }
            set{ _authids = value; }
        }        
		/// <summary>
		/// authnames
        /// </summary>		
		private string _authnames;
        public string authnames
        {
            get{ return _authnames; }
            set{ _authnames = value; }
        }        
		   
	}
}

