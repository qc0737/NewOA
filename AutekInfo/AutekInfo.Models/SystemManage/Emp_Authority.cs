using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//Emp_Authority
		public class Emp_Authority
	{
   		     
      	/// <summary>
		/// auth_id
        /// </summary>		
		private int _auth_id;
        public int auth_id
        {
            get{ return _auth_id; }
            set{ _auth_id = value; }
        }        
		/// <summary>
		/// auth_code
        /// </summary>		
		private string _auth_code;
        public string auth_code
        {
            get{ return _auth_code; }
            set{ _auth_code = value; }
        }        
		/// <summary>
		/// auth_name
        /// </summary>		
		private string _auth_name;
        public string auth_name
        {
            get{ return _auth_name; }
            set{ _auth_name = value; }
        }        
		/// <summary>
		/// auth_remark
        /// </summary>		
		private string _auth_remark;
        public string auth_remark
        {
            get{ return _auth_remark; }
            set{ _auth_remark = value; }
        }        
		   
	}
}

