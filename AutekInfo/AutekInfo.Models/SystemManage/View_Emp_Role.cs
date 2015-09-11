using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//View_Emp_Role
		public class View_Emp_Role
	{
   		     
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
		   
	}
}

