using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//M_Emp_Role
		public class M_Emp_Role
	{
   		     
      	/// <summary>
		/// m_emp_role_id
        /// </summary>		
		private int _m_emp_role_id;
        public int m_emp_role_id
        {
            get{ return _m_emp_role_id; }
            set{ _m_emp_role_id = value; }
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
		/// role_id
        /// </summary>		
		private int _role_id;
        public int role_id
        {
            get{ return _role_id; }
            set{ _role_id = value; }
        }        
		   
	}
}

